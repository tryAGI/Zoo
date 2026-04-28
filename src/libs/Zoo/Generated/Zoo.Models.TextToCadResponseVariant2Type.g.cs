
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextToCadResponseVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        TextToCadIteration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToCadResponseVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToCadResponseVariant2Type value)
        {
            return value switch
            {
                TextToCadResponseVariant2Type.TextToCadIteration => "text_to_cad_iteration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToCadResponseVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "text_to_cad_iteration" => TextToCadResponseVariant2Type.TextToCadIteration,
                _ => null,
            };
        }
    }
}