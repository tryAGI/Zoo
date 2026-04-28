
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Cubic centimeters (cc or cm³) &lt;https://en.wikipedia.org/wiki/Cubic_centimeter&gt;
    /// </summary>
    public enum UnitVolumeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Cm3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitVolumeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitVolumeVariant1 value)
        {
            return value switch
            {
                UnitVolumeVariant1.Cm3 => "cm3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitVolumeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "cm3" => UnitVolumeVariant1.Cm3,
                _ => null,
            };
        }
    }
}