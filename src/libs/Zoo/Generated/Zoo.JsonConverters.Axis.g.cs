#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Zoo.JsonConverters
{
    /// <inheritdoc />
    public class AxisJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zoo.Axis>
    {
        /// <inheritdoc />
        public override global::Zoo.Axis Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AxisVariant1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AxisVariant2), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Zoo.AxisVariant1? axisVariant1 = default;
            global::Zoo.AxisVariant2? axisVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AxisVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AxisVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AxisVariant1).Name}");
                        axisVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AxisVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AxisVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AxisVariant2).Name}");
                        axisVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (axisVariant1 == null && axisVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AxisVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AxisVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AxisVariant1).Name}");
                    axisVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AxisVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AxisVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AxisVariant2).Name}");
                    axisVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Zoo.Axis(
                axisVariant1,

                axisVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zoo.Axis value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAxisVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AxisVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AxisVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AxisVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AxisVariant1!.Value, typeInfo);
            }
            else if (value.IsAxisVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Zoo.AxisVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Zoo.AxisVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Zoo.AxisVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AxisVariant2!.Value, typeInfo);
            }
        }
    }
}