
#nullable enable

namespace Zoo
{
    /// <summary>
    /// KCL.
    /// </summary>
    public enum TextToCadModelVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Kcl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToCadModelVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToCadModelVariant2 value)
        {
            return value switch
            {
                TextToCadModelVariant2.Kcl => "kcl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToCadModelVariant2? ToEnum(string value)
        {
            return value switch
            {
                "kcl" => TextToCadModelVariant2.Kcl,
                _ => null,
            };
        }
    }
}