
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Cubic millimeters (mm³)
    /// </summary>
    public enum UnitVolumeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Mm3,
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
                UnitVolumeVariant1.Mm3 => "mm3",
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
                "mm3" => UnitVolumeVariant1.Mm3,
                _ => null,
            };
        }
    }
}