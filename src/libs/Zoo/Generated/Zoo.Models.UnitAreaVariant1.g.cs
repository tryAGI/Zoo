
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Square centimeters &lt;https://en.wikipedia.org/wiki/Square_centimeter&gt;
    /// </summary>
    public enum UnitAreaVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Cm2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitAreaVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitAreaVariant1 value)
        {
            return value switch
            {
                UnitAreaVariant1.Cm2 => "cm2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitAreaVariant1? ToEnum(string value)
        {
            return value switch
            {
                "cm2" => UnitAreaVariant1.Cm2,
                _ => null,
            };
        }
    }
}