
#nullable enable

namespace Zoo
{
    /// <summary>
    /// KCL iteration.
    /// </summary>
    public enum TextToCadModelVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        KclIteration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToCadModelVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToCadModelVariant3 value)
        {
            return value switch
            {
                TextToCadModelVariant3.KclIteration => "kcl_iteration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToCadModelVariant3? ToEnum(string value)
        {
            return value switch
            {
                "kcl_iteration" => TextToCadModelVariant3.KclIteration,
                _ => null,
            };
        }
    }
}