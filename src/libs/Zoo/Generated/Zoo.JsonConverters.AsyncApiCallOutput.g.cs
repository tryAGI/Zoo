#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Zoo.JsonConverters
{
    /// <inheritdoc />
    public class AsyncApiCallOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zoo.AsyncApiCallOutput>
    {
        /// <inheritdoc />
        public override global::Zoo.AsyncApiCallOutput Read(
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
            if (__jsonProps.Contains("completed_at")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("error")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("output_format")) __score0++;
            if (__jsonProps.Contains("output_format_options")) __score0++;
            if (__jsonProps.Contains("outputs")) __score0++;
            if (__jsonProps.Contains("src_format")) __score0++;
            if (__jsonProps.Contains("src_format_options")) __score0++;
            if (__jsonProps.Contains("started_at")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("updated_at")) __score0++;
            if (__jsonProps.Contains("user_id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("center_of_mass")) __score1++;
            if (__jsonProps.Contains("completed_at")) __score1++;
            if (__jsonProps.Contains("created_at")) __score1++;
            if (__jsonProps.Contains("error")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("output_unit")) __score1++;
            if (__jsonProps.Contains("src_format")) __score1++;
            if (__jsonProps.Contains("started_at")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("updated_at")) __score1++;
            if (__jsonProps.Contains("user_id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("completed_at")) __score2++;
            if (__jsonProps.Contains("created_at")) __score2++;
            if (__jsonProps.Contains("error")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("mass")) __score2++;
            if (__jsonProps.Contains("material_density")) __score2++;
            if (__jsonProps.Contains("material_density_unit")) __score2++;
            if (__jsonProps.Contains("output_unit")) __score2++;
            if (__jsonProps.Contains("src_format")) __score2++;
            if (__jsonProps.Contains("started_at")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("updated_at")) __score2++;
            if (__jsonProps.Contains("user_id")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("completed_at")) __score3++;
            if (__jsonProps.Contains("created_at")) __score3++;
            if (__jsonProps.Contains("error")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("output_unit")) __score3++;
            if (__jsonProps.Contains("src_format")) __score3++;
            if (__jsonProps.Contains("started_at")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("updated_at")) __score3++;
            if (__jsonProps.Contains("user_id")) __score3++;
            if (__jsonProps.Contains("volume")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("completed_at")) __score4++;
            if (__jsonProps.Contains("created_at")) __score4++;
            if (__jsonProps.Contains("density")) __score4++;
            if (__jsonProps.Contains("error")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("material_mass")) __score4++;
            if (__jsonProps.Contains("material_mass_unit")) __score4++;
            if (__jsonProps.Contains("output_unit")) __score4++;
            if (__jsonProps.Contains("src_format")) __score4++;
            if (__jsonProps.Contains("started_at")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("updated_at")) __score4++;
            if (__jsonProps.Contains("user_id")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("completed_at")) __score5++;
            if (__jsonProps.Contains("created_at")) __score5++;
            if (__jsonProps.Contains("error")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("output_unit")) __score5++;
            if (__jsonProps.Contains("src_format")) __score5++;
            if (__jsonProps.Contains("started_at")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("surface_area")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("updated_at")) __score5++;
            if (__jsonProps.Contains("user_id")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("code")) __score6++;
            if (__jsonProps.Contains("completed_at")) __score6++;
            if (__jsonProps.Contains("conversation_id")) __score6++;
            if (__jsonProps.Contains("created_at")) __score6++;
            if (__jsonProps.Contains("error")) __score6++;
            if (__jsonProps.Contains("feedback")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("kcl_version")) __score6++;
            if (__jsonProps.Contains("model")) __score6++;
            if (__jsonProps.Contains("model_version")) __score6++;
            if (__jsonProps.Contains("output_format")) __score6++;
            if (__jsonProps.Contains("outputs")) __score6++;
            if (__jsonProps.Contains("prompt")) __score6++;
            if (__jsonProps.Contains("started_at")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("updated_at")) __score6++;
            if (__jsonProps.Contains("user_id")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("code")) __score7++;
            if (__jsonProps.Contains("completed_at")) __score7++;
            if (__jsonProps.Contains("conversation_id")) __score7++;
            if (__jsonProps.Contains("created_at")) __score7++;
            if (__jsonProps.Contains("error")) __score7++;
            if (__jsonProps.Contains("feedback")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("model")) __score7++;
            if (__jsonProps.Contains("model_version")) __score7++;
            if (__jsonProps.Contains("original_source_code")) __score7++;
            if (__jsonProps.Contains("prompt")) __score7++;
            if (__jsonProps.Contains("source_ranges")) __score7++;
            if (__jsonProps.Contains("started_at")) __score7++;
            if (__jsonProps.Contains("status")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("updated_at")) __score7++;
            if (__jsonProps.Contains("user_id")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("completed_at")) __score8++;
            if (__jsonProps.Contains("conversation_id")) __score8++;
            if (__jsonProps.Contains("created_at")) __score8++;
            if (__jsonProps.Contains("error")) __score8++;
            if (__jsonProps.Contains("feedback")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("kcl_version")) __score8++;
            if (__jsonProps.Contains("model")) __score8++;
            if (__jsonProps.Contains("model_version")) __score8++;
            if (__jsonProps.Contains("outputs")) __score8++;
            if (__jsonProps.Contains("project_name")) __score8++;
            if (__jsonProps.Contains("prompt")) __score8++;
            if (__jsonProps.Contains("source_ranges")) __score8++;
            if (__jsonProps.Contains("started_at")) __score8++;
            if (__jsonProps.Contains("status")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            if (__jsonProps.Contains("updated_at")) __score8++;
            if (__jsonProps.Contains("user_id")) __score8++;
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

            global::Zoo.AsyncApiCallOutputVariant1? asyncApiCallOutputVariant1 = default;
            global::Zoo.AsyncApiCallOutputVariant2? asyncApiCallOutputVariant2 = default;
            global::Zoo.AsyncApiCallOutputVariant3? asyncApiCallOutputVariant3 = default;
            global::Zoo.AsyncApiCallOutputVariant4? asyncApiCallOutputVariant4 = default;
            global::Zoo.AsyncApiCallOutputVariant5? asyncApiCallOutputVariant5 = default;
            global::Zoo.AsyncApiCallOutputVariant6? asyncApiCallOutputVariant6 = default;
            global::Zoo.AsyncApiCallOutputVariant7? asyncApiCallOutputVariant7 = default;
            global::Zoo.AsyncApiCallOutputVariant8? asyncApiCallOutputVariant8 = default;
            global::Zoo.AsyncApiCallOutputVariant9? asyncApiCallOutputVariant9 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant1).Name}");
                        asyncApiCallOutputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant2).Name}");
                        asyncApiCallOutputVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant3).Name}");
                        asyncApiCallOutputVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant4).Name}");
                        asyncApiCallOutputVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant5).Name}");
                        asyncApiCallOutputVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant6).Name}");
                        asyncApiCallOutputVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant7).Name}");
                        asyncApiCallOutputVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant8).Name}");
                        asyncApiCallOutputVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant9).Name}");
                        asyncApiCallOutputVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (asyncApiCallOutputVariant1 == null && asyncApiCallOutputVariant2 == null && asyncApiCallOutputVariant3 == null && asyncApiCallOutputVariant4 == null && asyncApiCallOutputVariant5 == null && asyncApiCallOutputVariant6 == null && asyncApiCallOutputVariant7 == null && asyncApiCallOutputVariant8 == null && asyncApiCallOutputVariant9 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant1).Name}");
                    asyncApiCallOutputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant2).Name}");
                    asyncApiCallOutputVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant3).Name}");
                    asyncApiCallOutputVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant4).Name}");
                    asyncApiCallOutputVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant5).Name}");
                    asyncApiCallOutputVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant6).Name}");
                    asyncApiCallOutputVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant7).Name}");
                    asyncApiCallOutputVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant8).Name}");
                    asyncApiCallOutputVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant9).Name}");
                    asyncApiCallOutputVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Zoo.AsyncApiCallOutput(
                asyncApiCallOutputVariant1,

                asyncApiCallOutputVariant2,

                asyncApiCallOutputVariant3,

                asyncApiCallOutputVariant4,

                asyncApiCallOutputVariant5,

                asyncApiCallOutputVariant6,

                asyncApiCallOutputVariant7,

                asyncApiCallOutputVariant8,

                asyncApiCallOutputVariant9
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zoo.AsyncApiCallOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAsyncApiCallOutputVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AsyncApiCallOutputVariant1!, typeInfo);
            }
            else if (value.IsAsyncApiCallOutputVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AsyncApiCallOutputVariant2!, typeInfo);
            }
            else if (value.IsAsyncApiCallOutputVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AsyncApiCallOutputVariant3!, typeInfo);
            }
            else if (value.IsAsyncApiCallOutputVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AsyncApiCallOutputVariant4!, typeInfo);
            }
            else if (value.IsAsyncApiCallOutputVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AsyncApiCallOutputVariant5!, typeInfo);
            }
            else if (value.IsAsyncApiCallOutputVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AsyncApiCallOutputVariant6!, typeInfo);
            }
            else if (value.IsAsyncApiCallOutputVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AsyncApiCallOutputVariant7!, typeInfo);
            }
            else if (value.IsAsyncApiCallOutputVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AsyncApiCallOutputVariant8!, typeInfo);
            }
            else if (value.IsAsyncApiCallOutputVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AsyncApiCallOutputVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AsyncApiCallOutputVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AsyncApiCallOutputVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AsyncApiCallOutputVariant9!, typeInfo);
            }
        }
    }
}