#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Zoo.JsonConverters
{
    /// <inheritdoc />
    public class SelectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zoo.Selection>
    {
        /// <inheritdoc />
        public override global::Zoo.Selection Read(
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
            if (__jsonProps.Contains("index")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("index")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Zoo.SelectionVariant1? selectionVariant1 = default;
            global::Zoo.SelectionVariant2? selectionVariant2 = default;
            global::Zoo.SelectionVariant3? selectionVariant3 = default;
            global::Zoo.SelectionVariant4? selectionVariant4 = default;
            global::Zoo.SelectionVariant5? selectionVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant1).Name}");
                        selectionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant2).Name}");
                        selectionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant3).Name}");
                        selectionVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant4).Name}");
                        selectionVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant5).Name}");
                        selectionVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (selectionVariant1 == null && selectionVariant2 == null && selectionVariant3 == null && selectionVariant4 == null && selectionVariant5 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant1).Name}");
                    selectionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant2).Name}");
                    selectionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant3).Name}");
                    selectionVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant4).Name}");
                    selectionVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant5).Name}");
                    selectionVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Zoo.Selection(
                selectionVariant1,

                selectionVariant2,

                selectionVariant3,

                selectionVariant4,

                selectionVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zoo.Selection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSelectionVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SelectionVariant1!, typeInfo);
            }
            else if (value.IsSelectionVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SelectionVariant2!, typeInfo);
            }
            else if (value.IsSelectionVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SelectionVariant3!, typeInfo);
            }
            else if (value.IsSelectionVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SelectionVariant4!, typeInfo);
            }
            else if (value.IsSelectionVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.SelectionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.SelectionVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.SelectionVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SelectionVariant5!, typeInfo);
            }
        }
    }
}