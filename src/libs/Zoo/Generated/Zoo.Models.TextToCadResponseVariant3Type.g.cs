
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextToCadResponseVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        TextToCadMultiFileIteration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToCadResponseVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToCadResponseVariant3Type value)
        {
            return value switch
            {
                TextToCadResponseVariant3Type.TextToCadMultiFileIteration => "text_to_cad_multi_file_iteration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToCadResponseVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "text_to_cad_multi_file_iteration" => TextToCadResponseVariant3Type.TextToCadMultiFileIteration,
                _ => null,
            };
        }
    }
}