#nullable enable

namespace Zoo.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiCallStatusVariant5NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zoo.ApiCallStatusVariant5?>
    {
        /// <inheritdoc />
        public override global::Zoo.ApiCallStatusVariant5? Read(
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
                        return global::Zoo.ApiCallStatusVariant5Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Zoo.ApiCallStatusVariant5)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Zoo.ApiCallStatusVariant5?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zoo.ApiCallStatusVariant5? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Zoo.ApiCallStatusVariant5Extensions.ToValueString(value.Value));
            }
        }
    }
}
