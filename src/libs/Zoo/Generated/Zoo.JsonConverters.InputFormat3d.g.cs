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
            if (__jsonProps.Contains("coords")) __score0++;
            if (__jsonProps.Contains("split_closed_faces")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("coords")) __score1++;
            if (__jsonProps.Contains("split_closed_faces")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("coords")) __score2++;
            if (__jsonProps.Contains("split_closed_faces")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("coords")) __score5++;
            if (__jsonProps.Contains("split_closed_faces")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("coords")) __score6++;
            if (__jsonProps.Contains("split_closed_faces")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("coords")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("units")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("coords")) __score8++;
            if (__jsonProps.Contains("split_closed_faces")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("coords")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            if (__jsonProps.Contains("units")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("coords")) __score10++;
            if (__jsonProps.Contains("split_closed_faces")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("coords")) __score11++;
            if (__jsonProps.Contains("split_closed_faces")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("coords")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            if (__jsonProps.Contains("units")) __score12++;
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
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }

            global::Zoo.InputFormat3dVariant1? inputFormat3dVariant1 = default;
            global::Zoo.InputFormat3dVariant2? inputFormat3dVariant2 = default;
            global::Zoo.InputFormat3dVariant3? inputFormat3dVariant3 = default;
            global::Zoo.InputFormat3dVariant4? inputFormat3dVariant4 = default;
            global::Zoo.InputFormat3dVariant5? inputFormat3dVariant5 = default;
            global::Zoo.InputFormat3dVariant6? inputFormat3dVariant6 = default;
            global::Zoo.InputFormat3dVariant7? inputFormat3dVariant7 = default;
            global::Zoo.InputFormat3dVariant8? inputFormat3dVariant8 = default;
            global::Zoo.InputFormat3dVariant9? inputFormat3dVariant9 = default;
            global::Zoo.InputFormat3dVariant10? inputFormat3dVariant10 = default;
            global::Zoo.InputFormat3dVariant11? inputFormat3dVariant11 = default;
            global::Zoo.InputFormat3dVariant12? inputFormat3dVariant12 = default;
            global::Zoo.InputFormat3dVariant13? inputFormat3dVariant13 = default;
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
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant8).Name}");
                        inputFormat3dVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant9).Name}");
                        inputFormat3dVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant10).Name}");
                        inputFormat3dVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant11).Name}");
                        inputFormat3dVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant12).Name}");
                        inputFormat3dVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant13> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant13).Name}");
                        inputFormat3dVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null && inputFormat3dVariant8 == null && inputFormat3dVariant9 == null && inputFormat3dVariant10 == null && inputFormat3dVariant11 == null && inputFormat3dVariant12 == null && inputFormat3dVariant13 == null)
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

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null && inputFormat3dVariant8 == null && inputFormat3dVariant9 == null && inputFormat3dVariant10 == null && inputFormat3dVariant11 == null && inputFormat3dVariant12 == null && inputFormat3dVariant13 == null)
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

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null && inputFormat3dVariant8 == null && inputFormat3dVariant9 == null && inputFormat3dVariant10 == null && inputFormat3dVariant11 == null && inputFormat3dVariant12 == null && inputFormat3dVariant13 == null)
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

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null && inputFormat3dVariant8 == null && inputFormat3dVariant9 == null && inputFormat3dVariant10 == null && inputFormat3dVariant11 == null && inputFormat3dVariant12 == null && inputFormat3dVariant13 == null)
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

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null && inputFormat3dVariant8 == null && inputFormat3dVariant9 == null && inputFormat3dVariant10 == null && inputFormat3dVariant11 == null && inputFormat3dVariant12 == null && inputFormat3dVariant13 == null)
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

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null && inputFormat3dVariant8 == null && inputFormat3dVariant9 == null && inputFormat3dVariant10 == null && inputFormat3dVariant11 == null && inputFormat3dVariant12 == null && inputFormat3dVariant13 == null)
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

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null && inputFormat3dVariant8 == null && inputFormat3dVariant9 == null && inputFormat3dVariant10 == null && inputFormat3dVariant11 == null && inputFormat3dVariant12 == null && inputFormat3dVariant13 == null)
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

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null && inputFormat3dVariant8 == null && inputFormat3dVariant9 == null && inputFormat3dVariant10 == null && inputFormat3dVariant11 == null && inputFormat3dVariant12 == null && inputFormat3dVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant8).Name}");
                    inputFormat3dVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null && inputFormat3dVariant8 == null && inputFormat3dVariant9 == null && inputFormat3dVariant10 == null && inputFormat3dVariant11 == null && inputFormat3dVariant12 == null && inputFormat3dVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant9).Name}");
                    inputFormat3dVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null && inputFormat3dVariant8 == null && inputFormat3dVariant9 == null && inputFormat3dVariant10 == null && inputFormat3dVariant11 == null && inputFormat3dVariant12 == null && inputFormat3dVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant10).Name}");
                    inputFormat3dVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null && inputFormat3dVariant8 == null && inputFormat3dVariant9 == null && inputFormat3dVariant10 == null && inputFormat3dVariant11 == null && inputFormat3dVariant12 == null && inputFormat3dVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant11).Name}");
                    inputFormat3dVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null && inputFormat3dVariant8 == null && inputFormat3dVariant9 == null && inputFormat3dVariant10 == null && inputFormat3dVariant11 == null && inputFormat3dVariant12 == null && inputFormat3dVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant12).Name}");
                    inputFormat3dVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (inputFormat3dVariant1 == null && inputFormat3dVariant2 == null && inputFormat3dVariant3 == null && inputFormat3dVariant4 == null && inputFormat3dVariant5 == null && inputFormat3dVariant6 == null && inputFormat3dVariant7 == null && inputFormat3dVariant8 == null && inputFormat3dVariant9 == null && inputFormat3dVariant10 == null && inputFormat3dVariant11 == null && inputFormat3dVariant12 == null && inputFormat3dVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant13> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant13).Name}");
                    inputFormat3dVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                inputFormat3dVariant7,

                inputFormat3dVariant8,

                inputFormat3dVariant9,

                inputFormat3dVariant10,

                inputFormat3dVariant11,

                inputFormat3dVariant12,

                inputFormat3dVariant13
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
            else if (value.IsInputFormat3dVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFormat3dVariant8!, typeInfo);
            }
            else if (value.IsInputFormat3dVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFormat3dVariant9!, typeInfo);
            }
            else if (value.IsInputFormat3dVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFormat3dVariant10!, typeInfo);
            }
            else if (value.IsInputFormat3dVariant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFormat3dVariant11!, typeInfo);
            }
            else if (value.IsInputFormat3dVariant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFormat3dVariant12!, typeInfo);
            }
            else if (value.IsInputFormat3dVariant13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.InputFormat3dVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.InputFormat3dVariant13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.InputFormat3dVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFormat3dVariant13!, typeInfo);
            }
        }
    }
}