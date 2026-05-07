
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Cubic inches (cu in or in³) &lt;https://en.wikipedia.org/wiki/Cubic_inch&gt;
    /// </summary>
    public enum UnitVolumeVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        In3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitVolumeVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitVolumeVariant4 value)
        {
            return value switch
            {
                UnitVolumeVariant4.In3 => "in3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitVolumeVariant4? ToEnum(string value)
        {
            return value switch
            {
                "in3" => UnitVolumeVariant4.In3,
                _ => null,
            };
        }
    }
}