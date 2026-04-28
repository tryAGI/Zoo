#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Zoo.JsonConverters
{
    /// <inheritdoc />
    public class UnitVolumeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zoo.UnitVolume>
    {
        /// <inheritdoc />
        public override global::Zoo.UnitVolume Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant4), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant5), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant6), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant7), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant8), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score7++;
                    }
                }
            }
            var __score8 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant9), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score8++;
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
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }

            global::Zoo.UnitVolumeVariant1? unitVolumeVariant1 = default;
            global::Zoo.UnitVolumeVariant2? unitVolumeVariant2 = default;
            global::Zoo.UnitVolumeVariant3? unitVolumeVariant3 = default;
            global::Zoo.UnitVolumeVariant4? unitVolumeVariant4 = default;
            global::Zoo.UnitVolumeVariant5? unitVolumeVariant5 = default;
            global::Zoo.UnitVolumeVariant6? unitVolumeVariant6 = default;
            global::Zoo.UnitVolumeVariant7? unitVolumeVariant7 = default;
            global::Zoo.UnitVolumeVariant8? unitVolumeVariant8 = default;
            global::Zoo.UnitVolumeVariant9? unitVolumeVariant9 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant1).Name}");
                        unitVolumeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant2).Name}");
                        unitVolumeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant3).Name}");
                        unitVolumeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant4).Name}");
                        unitVolumeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant5).Name}");
                        unitVolumeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant6).Name}");
                        unitVolumeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant7).Name}");
                        unitVolumeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant8).Name}");
                        unitVolumeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 8)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant9).Name}");
                        unitVolumeVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (unitVolumeVariant1 == null && unitVolumeVariant2 == null && unitVolumeVariant3 == null && unitVolumeVariant4 == null && unitVolumeVariant5 == null && unitVolumeVariant6 == null && unitVolumeVariant7 == null && unitVolumeVariant8 == null && unitVolumeVariant9 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant1).Name}");
                    unitVolumeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant2).Name}");
                    unitVolumeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant3).Name}");
                    unitVolumeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant4).Name}");
                    unitVolumeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant5).Name}");
                    unitVolumeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant6).Name}");
                    unitVolumeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant7).Name}");
                    unitVolumeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant8).Name}");
                    unitVolumeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant9).Name}");
                    unitVolumeVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Zoo.UnitVolume(
                unitVolumeVariant1,

                unitVolumeVariant2,

                unitVolumeVariant3,

                unitVolumeVariant4,

                unitVolumeVariant5,

                unitVolumeVariant6,

                unitVolumeVariant7,

                unitVolumeVariant8,

                unitVolumeVariant9
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zoo.UnitVolume value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnitVolumeVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitVolumeVariant1!.Value, typeInfo);
            }
            else if (value.IsUnitVolumeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitVolumeVariant2!.Value, typeInfo);
            }
            else if (value.IsUnitVolumeVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitVolumeVariant3!.Value, typeInfo);
            }
            else if (value.IsUnitVolumeVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitVolumeVariant4!.Value, typeInfo);
            }
            else if (value.IsUnitVolumeVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitVolumeVariant5!.Value, typeInfo);
            }
            else if (value.IsUnitVolumeVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitVolumeVariant6!.Value, typeInfo);
            }
            else if (value.IsUnitVolumeVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitVolumeVariant7!.Value, typeInfo);
            }
            else if (value.IsUnitVolumeVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitVolumeVariant8!.Value, typeInfo);
            }
            else if (value.IsUnitVolumeVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.UnitVolumeVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.UnitVolumeVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.UnitVolumeVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnitVolumeVariant9!.Value, typeInfo);
            }
        }
    }
}