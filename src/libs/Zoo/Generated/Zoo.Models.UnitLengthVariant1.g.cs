
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Centimeters &lt;https://en.wikipedia.org/wiki/Centimeter&gt;
    /// </summary>
    public enum UnitLengthVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Cm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitLengthVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitLengthVariant1 value)
        {
            return value switch
            {
                UnitLengthVariant1.Cm => "cm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitLengthVariant1? ToEnum(string value)
        {
            return value switch
            {
                "cm" => UnitLengthVariant1.Cm,
                _ => null,
            };
        }
    }
}