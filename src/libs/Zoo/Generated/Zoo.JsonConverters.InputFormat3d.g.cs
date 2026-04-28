#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Zoo.JsonConverters
{
    /// <inheritdoc />
    public class InputFormat3dJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zoo.InputFormat3d>
    {
        /// <inheritdoc />
        public override global::Zoo.InputFormat3d Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("coords")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("units")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("coords")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("units")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("split_closed_faces")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("coords")) __score5++;
            if (__jsonProps.Contains("split_closed_faces")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("coords")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("units")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::Zoo.InputFormat3dVariant1? inputFormat3dVariant1 = default;
            global::Zoo.InputFormat3dVariant2? inputFormat3dVariant2 = default;
            global::Zoo.InputFormat3dVariant3? inputFormat3dVariant3 = default;
            global::Zoo.InputFormat3dVariant4? inputFormat3dVariant4 = default;
            global::Zoo.InputFormat3dVariant5? inputFormat3dVariant5 = default;
            global::Zoo.InputFormat3dVariant6? inputFormat3dVariant6 = default;
            global::Zoo.InputFormat3dVariant7? inputFormat3dVariant7 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant1).Name}");
                        inputFormat3dVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant2).Name}");
                        inputFormat3dVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant3).Name}");
                        inputFormat3dVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant4).Name}");
                        inputFormat3dVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant5).Name}");
                        inputFormat3dVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant6).Name}");
                        inputFormat3dVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant7).Name}");
                        inputFormat3dVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant1).Name}");
                    inputFormat3dVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant2).Name}");
                    inputFormat3dVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant3).Name}");
                    inputFormat3dVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant4).Name}");
                    inputFormat3dVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant5).Name}");
                    inputFormat3dVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant6).Name}");
                    inputFormat3dVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant7).Name}");
                    inputFormat3dVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Zoo.InputFormat3d(
                inputFormat3dVariant1,

                inputFormat3dVariant2,

                inputFormat3dVariant3,

                inputFormat3dVariant4,

                inputFormat3dVariant5,

                inputFormat3dVariant6,

                inputFormat3dVariant7
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zoo.InputFormat3d value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputFormat3dVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFormat3dVariant1!, typeInfo);
            }
            else if (value.IsInputFormat3dVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFormat3dVariant2!, typeInfo);
            }
            else if (value.IsInputFormat3dVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFormat3dVariant3!, typeInfo);
            }
            else if (value.IsInputFormat3dVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFormat3dVariant4!, typeInfo);
            }
            else if (value.IsInputFormat3dVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFormat3dVariant5!, typeInfo);
            }
            else if (value.IsInputFormat3dVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFormat3dVariant6!, typeInfo);
            }
            else if (value.IsInputFormat3dVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFormat3dVariant7!, typeInfo);
            }
        }
    }
}