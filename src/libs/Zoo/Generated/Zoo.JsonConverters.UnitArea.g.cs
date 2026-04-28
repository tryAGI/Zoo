#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Zoo.JsonConverters
{
    /// <inheritdoc />
    public class UnitAreaJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zoo.UnitArea>
    {
        /// <inheritdoc />
        public override global::Zoo.UnitArea Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant1), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant2), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant3), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant4), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __score4 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant5), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score4++;
                    }
                }
            }
            var __score5 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant6), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score5++;
                    }
                }
            }
            var __score6 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant7), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score6++;
                    }
                }
            }
            var __score7 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant8), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score7++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }

            global::Zoo.UnitAreaVariant1? unitAreaVariant1 = default;
            global::Zoo.UnitAreaVariant2? unitAreaVariant2 = default;
            global::Zoo.UnitAreaVariant3? unitAreaVariant3 = default;
            global::Zoo.UnitAreaVariant4? unitAreaVariant4 = default;
            global::Zoo.UnitAreaVariant5? unitAreaVariant5 = default;
            global::Zoo.UnitAreaVariant6? unitAreaVariant6 = default;
            global::Zoo.UnitAreaVariant7? unitAreaVariant7 = default;
            global::Zoo.UnitAreaVariant8? unitAreaVariant8 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant1).Name}");
                        unitAreaVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant2).Name}");
                        unitAreaVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant3).Name}");
                        unitAreaVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant4).Name}");
                        unitAreaVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant5).Name}");
                        unitAreaVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 5)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant6).Name}");
                        unitAreaVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 6)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant7).Name}");
                        unitAreaVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 7)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant8).Name}");
                        unitAreaVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (unitAreaVariant1 == null && unitAreaVariant2 == null && unitAreaVariant3 == null && unitAreaVariant4 == null && unitAreaVariant5 == null && unitAreaVariant6 == null && unitAreaVariant7 == null && unitAreaVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant1).Name}");
                    unitAreaVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant2).Name}");
                    unitAreaVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant3).Name}");
                    unitAreaVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant4).Name}");
                    unitAreaVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant5).Name}");
                    unitAreaVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant6).Name}");
                    unitAreaVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant7).Name}");
                    unitAreaVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant8).Name}");
                    unitAreaVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Zoo.UnitArea(
                unitAreaVariant1,

                unitAreaVariant2,

                unitAreaVariant3,

                unitAreaVariant4,

                unitAreaVariant5,

                unitAreaVariant6,

                unitAreaVariant7,

                unitAreaVariant8
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zoo.UnitArea value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnitAreaVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitAreaVariant1!.Value, typeInfo);
            }
            else if (value.IsUnitAreaVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitAreaVariant2!.Value, typeInfo);
            }
            else if (value.IsUnitAreaVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitAreaVariant3!.Value, typeInfo);
            }
            else if (value.IsUnitAreaVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitAreaVariant4!.Value, typeInfo);
            }
            else if (value.IsUnitAreaVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitAreaVariant5!.Value, typeInfo);
            }
            else if (value.IsUnitAreaVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitAreaVariant6!.Value, typeInfo);
            }
            else if (value.IsUnitAreaVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitAreaVariant7!.Value, typeInfo);
            }
            else if (value.IsUnitAreaVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitAreaVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitAreaVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitAreaVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitAreaVariant8!.Value, typeInfo);
            }
        }
    }
}