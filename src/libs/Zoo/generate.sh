#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.zoo.dev/
python3 - <<'PY'
import json
import re
from pathlib import Path

path = Path("openapi.yaml")
data = json.loads(path.read_text(encoding="utf-8"))
schemas = data.get("components", {}).get("schemas", {})
if "System" in schemas:
    schemas["CoordinateSystem"] = schemas.pop("System")

def rewrite_refs(value):
    if isinstance(value, dict):
        if value.get("$ref") == "#/components/schemas/System":
            value["$ref"] = "#/components/schemas/CoordinateSystem"
        for child in value.values():
            rewrite_refs(child)
    elif isinstance(value, list):
        for child in value:
            rewrite_refs(child)

rewrite_refs(data)

selected_operations = {
    "/ai/text-to-cad/{output_format}": ["post"],
    "/ml/text-to-cad/iteration": ["post"],
    "/ml/text-to-cad/multi-file/iteration": ["post"],
    "/async/operations/{id}": ["get"],
    "/user/text-to-cad": ["get"],
    "/user/text-to-cad/{id}": ["get"],
}

reduced = {
    "openapi": data.get("openapi", "3.0.0"),
    "info": {
        **data.get("info", {}),
        "title": "Zoo Text-to-CAD API",
        "description": "Focused Zoo API surface for text-to-CAD generation and generated part retrieval.",
    },
    "servers": [{"url": "https://api.zoo.dev"}],
    "paths": {},
    "components": {"schemas": {}, "responses": {}},
    "tags": [
        tag for tag in data.get("tags", [])
        if tag.get("name") in {"ml", "api-calls"}
    ],
}

for path_name, methods in selected_operations.items():
    source_path = data["paths"][path_name]
    reduced["paths"][path_name] = {
        method: source_path[method]
        for method in methods
        if method in source_path
    }

ref_pattern = re.compile(r"^#/components/([^/]+)/(.+)$")
pending = []
seen = set()

def collect_refs(value):
    if isinstance(value, dict):
        ref = value.get("$ref")
        if isinstance(ref, str):
            match = ref_pattern.match(ref)
            if match:
                pending.append((match.group(1), match.group(2)))
        for child in value.values():
            collect_refs(child)
    elif isinstance(value, list):
        for child in value:
            collect_refs(child)

collect_refs(reduced["paths"])

source_components = data.get("components", {})
while pending:
    section, name = pending.pop()
    key = (section, name)
    if key in seen:
        continue
    seen.add(key)
    source_section = source_components.get(section, {})
    if name not in source_section:
        continue
    reduced.setdefault("components", {}).setdefault(section, {})[name] = source_section[name]
    collect_refs(source_section[name])

path.write_text(json.dumps(reduced, indent=2), encoding="utf-8")
PY
autosdk generate openapi.yaml \
  --namespace Zoo \
  --clientClassName ZooClient \
  --targetFramework net10.0 \
  --security-scheme Http:Header:Bearer \
  --output Generated \
  --exclude-deprecated-operations
