
#nullable enable

namespace Zoo
{
    /// <summary>
    /// CAD.
    /// </summary>
    public enum TextToCadModelVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Cad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToCadModelVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToCadModelVariant1 value)
        {
            return value switch
            {
                TextToCadModelVariant1.Cad => "cad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToCadModelVariant1? ToEnum(string value)
        {
            return value switch
            {
                "cad" => TextToCadModelVariant1.Cad,
                _ => null,
            };
        }
    }
}