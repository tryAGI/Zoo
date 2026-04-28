
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Cubic feet (ft³) &lt;https://en.wikipedia.org/wiki/Cubic_foot&gt;
    /// </summary>
    public enum UnitVolumeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Ft3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitVolumeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitVolumeVariant2 value)
        {
            return value switch
            {
                UnitVolumeVariant2.Ft3 => "ft3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitVolumeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "ft3" => UnitVolumeVariant2.Ft3,
                _ => null,
            };
        }
    }
}