#nullable enable

namespace Zoo.JsonConverters
{
    /// <inheritdoc />
    public sealed class AsyncApiCallOutputVariant8TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zoo.AsyncApiCallOutputVariant8Type>
    {
        /// <inheritdoc />
        public override global::Zoo.AsyncApiCallOutputVariant8Type Read(
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
                        return global::Zoo.AsyncApiCallOutputVariant8TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Zoo.AsyncApiCallOutputVariant8Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Zoo.AsyncApiCallOutputVariant8Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zoo.AsyncApiCallOutputVariant8Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Zoo.AsyncApiCallOutputVariant8TypeExtensions.ToValueString(value));
        }
    }
}
