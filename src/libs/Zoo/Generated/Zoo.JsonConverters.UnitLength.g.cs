#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Zoo.JsonConverters
{
    /// <inheritdoc />
    public class UnitLengthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zoo.UnitLength>
    {
        /// <inheritdoc />
        public override global::Zoo.UnitLength Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant4), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant5), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant6), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score5++;
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

            global::Zoo.UnitLengthVariant1? unitLengthVariant1 = default;
            global::Zoo.UnitLengthVariant2? unitLengthVariant2 = default;
            global::Zoo.UnitLengthVariant3? unitLengthVariant3 = default;
            global::Zoo.UnitLengthVariant4? unitLengthVariant4 = default;
            global::Zoo.UnitLengthVariant5? unitLengthVariant5 = default;
            global::Zoo.UnitLengthVariant6? unitLengthVariant6 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant1).Name}");
                        unitLengthVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant2).Name}");
                        unitLengthVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant3).Name}");
                        unitLengthVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant4).Name}");
                        unitLengthVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant5).Name}");
                        unitLengthVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant6).Name}");
                        unitLengthVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (unitLengthVariant1 == null && unitLengthVariant2 == null && unitLengthVariant3 == null && unitLengthVariant4 == null && unitLengthVariant5 == null && unitLengthVariant6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant1).Name}");
                    unitLengthVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant2).Name}");
                    unitLengthVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant3).Name}");
                    unitLengthVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant4).Name}");
                    unitLengthVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant5).Name}");
                    unitLengthVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant6).Name}");
                    unitLengthVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Zoo.UnitLength(
                unitLengthVariant1,

                unitLengthVariant2,

                unitLengthVariant3,

                unitLengthVariant4,

                unitLengthVariant5,

                unitLengthVariant6
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zoo.UnitLength value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnitLengthVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitLengthVariant1!.Value, typeInfo);
            }
            else if (value.IsUnitLengthVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitLengthVariant2!.Value, typeInfo);
            }
            else if (value.IsUnitLengthVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitLengthVariant3!.Value, typeInfo);
            }
            else if (value.IsUnitLengthVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitLengthVariant4!.Value, typeInfo);
            }
            else if (value.IsUnitLengthVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitLengthVariant5!.Value, typeInfo);
            }
            else if (value.IsUnitLengthVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitLengthVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitLengthVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitLengthVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitLengthVariant6!.Value, typeInfo);
            }
        }
    }
}