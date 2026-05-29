#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Zoo.JsonConverters
{
    /// <inheritdoc />
    public class FileImportFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zoo.FileImportFormat>
    {
        /// <inheritdoc />
        public override global::Zoo.FileImportFormat Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant4), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant5), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant6), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant7), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant8), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant9), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score8++;
                    }
                }
            }
            var __score9 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant10), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score9++;
                    }
                }
            }
            var __score10 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant11), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score10++;
                    }
                }
            }
            var __score11 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant12), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score11++;
                    }
                }
            }
            var __score12 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant13), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score12++;
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
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }

            global::Zoo.FileImportFormatVariant1? fileImportFormatVariant1 = default;
            global::Zoo.FileImportFormatVariant2? fileImportFormatVariant2 = default;
            global::Zoo.FileImportFormatVariant3? fileImportFormatVariant3 = default;
            global::Zoo.FileImportFormatVariant4? fileImportFormatVariant4 = default;
            global::Zoo.FileImportFormatVariant5? fileImportFormatVariant5 = default;
            global::Zoo.FileImportFormatVariant6? fileImportFormatVariant6 = default;
            global::Zoo.FileImportFormatVariant7? fileImportFormatVariant7 = default;
            global::Zoo.FileImportFormatVariant8? fileImportFormatVariant8 = default;
            global::Zoo.FileImportFormatVariant9? fileImportFormatVariant9 = default;
            global::Zoo.FileImportFormatVariant10? fileImportFormatVariant10 = default;
            global::Zoo.FileImportFormatVariant11? fileImportFormatVariant11 = default;
            global::Zoo.FileImportFormatVariant12? fileImportFormatVariant12 = default;
            global::Zoo.FileImportFormatVariant13? fileImportFormatVariant13 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant1).Name}");
                        fileImportFormatVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant2).Name}");
                        fileImportFormatVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant3).Name}");
                        fileImportFormatVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant4).Name}");
                        fileImportFormatVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant5).Name}");
                        fileImportFormatVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant6).Name}");
                        fileImportFormatVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant7).Name}");
                        fileImportFormatVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant8).Name}");
                        fileImportFormatVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant9).Name}");
                        fileImportFormatVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant10).Name}");
                        fileImportFormatVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant11).Name}");
                        fileImportFormatVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant12).Name}");
                        fileImportFormatVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant13> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant13).Name}");
                        fileImportFormatVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (fileImportFormatVariant1 == null && fileImportFormatVariant2 == null && fileImportFormatVariant3 == null && fileImportFormatVariant4 == null && fileImportFormatVariant5 == null && fileImportFormatVariant6 == null && fileImportFormatVariant7 == null && fileImportFormatVariant8 == null && fileImportFormatVariant9 == null && fileImportFormatVariant10 == null && fileImportFormatVariant11 == null && fileImportFormatVariant12 == null && fileImportFormatVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant1).Name}");
                    fileImportFormatVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (fileImportFormatVariant1 == null && fileImportFormatVariant2 == null && fileImportFormatVariant3 == null && fileImportFormatVariant4 == null && fileImportFormatVariant5 == null && fileImportFormatVariant6 == null && fileImportFormatVariant7 == null && fileImportFormatVariant8 == null && fileImportFormatVariant9 == null && fileImportFormatVariant10 == null && fileImportFormatVariant11 == null && fileImportFormatVariant12 == null && fileImportFormatVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant2).Name}");
                    fileImportFormatVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (fileImportFormatVariant1 == null && fileImportFormatVariant2 == null && fileImportFormatVariant3 == null && fileImportFormatVariant4 == null && fileImportFormatVariant5 == null && fileImportFormatVariant6 == null && fileImportFormatVariant7 == null && fileImportFormatVariant8 == null && fileImportFormatVariant9 == null && fileImportFormatVariant10 == null && fileImportFormatVariant11 == null && fileImportFormatVariant12 == null && fileImportFormatVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant3).Name}");
                    fileImportFormatVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (fileImportFormatVariant1 == null && fileImportFormatVariant2 == null && fileImportFormatVariant3 == null && fileImportFormatVariant4 == null && fileImportFormatVariant5 == null && fileImportFormatVariant6 == null && fileImportFormatVariant7 == null && fileImportFormatVariant8 == null && fileImportFormatVariant9 == null && fileImportFormatVariant10 == null && fileImportFormatVariant11 == null && fileImportFormatVariant12 == null && fileImportFormatVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant4).Name}");
                    fileImportFormatVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (fileImportFormatVariant1 == null && fileImportFormatVariant2 == null && fileImportFormatVariant3 == null && fileImportFormatVariant4 == null && fileImportFormatVariant5 == null && fileImportFormatVariant6 == null && fileImportFormatVariant7 == null && fileImportFormatVariant8 == null && fileImportFormatVariant9 == null && fileImportFormatVariant10 == null && fileImportFormatVariant11 == null && fileImportFormatVariant12 == null && fileImportFormatVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant5).Name}");
                    fileImportFormatVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (fileImportFormatVariant1 == null && fileImportFormatVariant2 == null && fileImportFormatVariant3 == null && fileImportFormatVariant4 == null && fileImportFormatVariant5 == null && fileImportFormatVariant6 == null && fileImportFormatVariant7 == null && fileImportFormatVariant8 == null && fileImportFormatVariant9 == null && fileImportFormatVariant10 == null && fileImportFormatVariant11 == null && fileImportFormatVariant12 == null && fileImportFormatVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant6).Name}");
                    fileImportFormatVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (fileImportFormatVariant1 == null && fileImportFormatVariant2 == null && fileImportFormatVariant3 == null && fileImportFormatVariant4 == null && fileImportFormatVariant5 == null && fileImportFormatVariant6 == null && fileImportFormatVariant7 == null && fileImportFormatVariant8 == null && fileImportFormatVariant9 == null && fileImportFormatVariant10 == null && fileImportFormatVariant11 == null && fileImportFormatVariant12 == null && fileImportFormatVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant7).Name}");
                    fileImportFormatVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (fileImportFormatVariant1 == null && fileImportFormatVariant2 == null && fileImportFormatVariant3 == null && fileImportFormatVariant4 == null && fileImportFormatVariant5 == null && fileImportFormatVariant6 == null && fileImportFormatVariant7 == null && fileImportFormatVariant8 == null && fileImportFormatVariant9 == null && fileImportFormatVariant10 == null && fileImportFormatVariant11 == null && fileImportFormatVariant12 == null && fileImportFormatVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant8).Name}");
                    fileImportFormatVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (fileImportFormatVariant1 == null && fileImportFormatVariant2 == null && fileImportFormatVariant3 == null && fileImportFormatVariant4 == null && fileImportFormatVariant5 == null && fileImportFormatVariant6 == null && fileImportFormatVariant7 == null && fileImportFormatVariant8 == null && fileImportFormatVariant9 == null && fileImportFormatVariant10 == null && fileImportFormatVariant11 == null && fileImportFormatVariant12 == null && fileImportFormatVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant9).Name}");
                    fileImportFormatVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (fileImportFormatVariant1 == null && fileImportFormatVariant2 == null && fileImportFormatVariant3 == null && fileImportFormatVariant4 == null && fileImportFormatVariant5 == null && fileImportFormatVariant6 == null && fileImportFormatVariant7 == null && fileImportFormatVariant8 == null && fileImportFormatVariant9 == null && fileImportFormatVariant10 == null && fileImportFormatVariant11 == null && fileImportFormatVariant12 == null && fileImportFormatVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant10).Name}");
                    fileImportFormatVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (fileImportFormatVariant1 == null && fileImportFormatVariant2 == null && fileImportFormatVariant3 == null && fileImportFormatVariant4 == null && fileImportFormatVariant5 == null && fileImportFormatVariant6 == null && fileImportFormatVariant7 == null && fileImportFormatVariant8 == null && fileImportFormatVariant9 == null && fileImportFormatVariant10 == null && fileImportFormatVariant11 == null && fileImportFormatVariant12 == null && fileImportFormatVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant11).Name}");
                    fileImportFormatVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (fileImportFormatVariant1 == null && fileImportFormatVariant2 == null && fileImportFormatVariant3 == null && fileImportFormatVariant4 == null && fileImportFormatVariant5 == null && fileImportFormatVariant6 == null && fileImportFormatVariant7 == null && fileImportFormatVariant8 == null && fileImportFormatVariant9 == null && fileImportFormatVariant10 == null && fileImportFormatVariant11 == null && fileImportFormatVariant12 == null && fileImportFormatVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant12).Name}");
                    fileImportFormatVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (fileImportFormatVariant1 == null && fileImportFormatVariant2 == null && fileImportFormatVariant3 == null && fileImportFormatVariant4 == null && fileImportFormatVariant5 == null && fileImportFormatVariant6 == null && fileImportFormatVariant7 == null && fileImportFormatVariant8 == null && fileImportFormatVariant9 == null && fileImportFormatVariant10 == null && fileImportFormatVariant11 == null && fileImportFormatVariant12 == null && fileImportFormatVariant13 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant13> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant13).Name}");
                    fileImportFormatVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Zoo.FileImportFormat(
                fileImportFormatVariant1,

                fileImportFormatVariant2,

                fileImportFormatVariant3,

                fileImportFormatVariant4,

                fileImportFormatVariant5,

                fileImportFormatVariant6,

                fileImportFormatVariant7,

                fileImportFormatVariant8,

                fileImportFormatVariant9,

                fileImportFormatVariant10,

                fileImportFormatVariant11,

                fileImportFormatVariant12,

                fileImportFormatVariant13
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zoo.FileImportFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFileImportFormatVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileImportFormatVariant1!.Value, typeInfo);
            }
            else if (value.IsFileImportFormatVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileImportFormatVariant2!.Value, typeInfo);
            }
            else if (value.IsFileImportFormatVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileImportFormatVariant3!.Value, typeInfo);
            }
            else if (value.IsFileImportFormatVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileImportFormatVariant4!.Value, typeInfo);
            }
            else if (value.IsFileImportFormatVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileImportFormatVariant5!.Value, typeInfo);
            }
            else if (value.IsFileImportFormatVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileImportFormatVariant6!.Value, typeInfo);
            }
            else if (value.IsFileImportFormatVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileImportFormatVariant7!.Value, typeInfo);
            }
            else if (value.IsFileImportFormatVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileImportFormatVariant8!.Value, typeInfo);
            }
            else if (value.IsFileImportFormatVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileImportFormatVariant9!.Value, typeInfo);
            }
            else if (value.IsFileImportFormatVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileImportFormatVariant10!.Value, typeInfo);
            }
            else if (value.IsFileImportFormatVariant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileImportFormatVariant11!.Value, typeInfo);
            }
            else if (value.IsFileImportFormatVariant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileImportFormatVariant12!.Value, typeInfo);
            }
            else if (value.IsFileImportFormatVariant13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.FileImportFormatVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.FileImportFormatVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.FileImportFormatVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileImportFormatVariant13!.Value, typeInfo);
            }
        }
    }
}