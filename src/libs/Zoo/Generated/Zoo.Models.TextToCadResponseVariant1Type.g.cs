
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextToCadResponseVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        TextToCad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToCadResponseVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToCadResponseVariant1Type value)
        {
            return value switch
            {
                TextToCadResponseVariant1Type.TextToCad => "text_to_cad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToCadResponseVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text_to_cad" => TextToCadResponseVariant1Type.TextToCad,
                _ => null,
            };
        }
    }
}