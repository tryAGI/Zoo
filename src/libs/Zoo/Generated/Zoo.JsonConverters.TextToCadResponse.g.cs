#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Zoo.JsonConverters
{
    /// <inheritdoc />
    public class TextToCadResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zoo.TextToCadResponse>
    {
        /// <inheritdoc />
        public override global::Zoo.TextToCadResponse Read(
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
            if (__jsonProps.Contains("code")) __score0++;
            if (__jsonProps.Contains("completed_at")) __score0++;
            if (__jsonProps.Contains("conversation_id")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("error")) __score0++;
            if (__jsonProps.Contains("feedback")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("kcl_version")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("model_version")) __score0++;
            if (__jsonProps.Contains("output_format")) __score0++;
            if (__jsonProps.Contains("outputs")) __score0++;
            if (__jsonProps.Contains("prompt")) __score0++;
            if (__jsonProps.Contains("started_at")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("updated_at")) __score0++;
            if (__jsonProps.Contains("user_id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("code")) __score1++;
            if (__jsonProps.Contains("completed_at")) __score1++;
            if (__jsonProps.Contains("conversation_id")) __score1++;
            if (__jsonProps.Contains("created_at")) __score1++;
            if (__jsonProps.Contains("error")) __score1++;
            if (__jsonProps.Contains("feedback")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("model_version")) __score1++;
            if (__jsonProps.Contains("original_source_code")) __score1++;
            if (__jsonProps.Contains("prompt")) __score1++;
            if (__jsonProps.Contains("source_ranges")) __score1++;
            if (__jsonProps.Contains("started_at")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("updated_at")) __score1++;
            if (__jsonProps.Contains("user_id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("completed_at")) __score2++;
            if (__jsonProps.Contains("conversation_id")) __score2++;
            if (__jsonProps.Contains("created_at")) __score2++;
            if (__jsonProps.Contains("error")) __score2++;
            if (__jsonProps.Contains("feedback")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("kcl_version")) __score2++;
            if (__jsonProps.Contains("model")) __score2++;
            if (__jsonProps.Contains("model_version")) __score2++;
            if (__jsonProps.Contains("outputs")) __score2++;
            if (__jsonProps.Contains("project_name")) __score2++;
            if (__jsonProps.Contains("prompt")) __score2++;
            if (__jsonProps.Contains("source_ranges")) __score2++;
            if (__jsonProps.Contains("started_at")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("updated_at")) __score2++;
            if (__jsonProps.Contains("user_id")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Zoo.TextToCadResponseVariant1? textToCadResponseVariant1 = default;
            global::Zoo.TextToCadResponseVariant2? textToCadResponseVariant2 = default;
            global::Zoo.TextToCadResponseVariant3? textToCadResponseVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.TextToCadResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.TextToCadResponseVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.TextToCadResponseVariant1).Name}");
                        textToCadResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.TextToCadResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.TextToCadResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.TextToCadResponseVariant2).Name}");
                        textToCadResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.TextToCadResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.TextToCadResponseVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.TextToCadResponseVariant3).Name}");
                        textToCadResponseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (textToCadResponseVariant1 == null && textToCadResponseVariant2 == null && textToCadResponseVariant3 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.TextToCadResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.TextToCadResponseVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.TextToCadResponseVariant1).Name}");
                    textToCadResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.TextToCadResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.TextToCadResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.TextToCadResponseVariant2).Name}");
                    textToCadResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.TextToCadResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.TextToCadResponseVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.TextToCadResponseVariant3).Name}");
                    textToCadResponseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Zoo.TextToCadResponse(
                textToCadResponseVariant1,

                textToCadResponseVariant2,

                textToCadResponseVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zoo.TextToCadResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextToCadResponseVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.TextToCadResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.TextToCadResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.TextToCadResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToCadResponseVariant1!, typeInfo);
            }
            else if (value.IsTextToCadResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.TextToCadResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.TextToCadResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.TextToCadResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToCadResponseVariant2!, typeInfo);
            }
            else if (value.IsTextToCadResponseVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.TextToCadResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.TextToCadResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.TextToCadResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToCadResponseVariant3!, typeInfo);
            }
        }
    }
}