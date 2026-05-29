#nullable enable

namespace Zoo.JsonConverters
{
    /// <inheritdoc />
    public sealed class FileImportFormatVariant9JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zoo.FileImportFormatVariant9>
    {
        /// <inheritdoc />
        public override global::Zoo.FileImportFormatVariant9 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Zoo.FileImportFormatVariant9Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Zoo.FileImportFormatVariant9)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Zoo.FileImportFormatVariant9);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zoo.FileImportFormatVariant9 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Zoo.FileImportFormatVariant9Extensions.ToValueString(value));
        }
    }
}
