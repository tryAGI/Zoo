#nullable enable

namespace Zoo.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnitAreaVariant4NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zoo.UnitAreaVariant4?>
    {
        /// <inheritdoc />
        public override global::Zoo.UnitAreaVariant4? Read(
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
                        return global::Zoo.UnitAreaVariant4Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Zoo.UnitAreaVariant4)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Zoo.UnitAreaVariant4?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zoo.UnitAreaVariant4? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Zoo.UnitAreaVariant4Extensions.ToValueString(value.Value));
            }
        }
    }
}
