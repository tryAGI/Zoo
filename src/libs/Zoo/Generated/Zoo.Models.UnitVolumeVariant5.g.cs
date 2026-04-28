
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Cubic yards (yd³) &lt;https://en.wikipedia.org/wiki/Cubic_yard&gt;
    /// </summary>
    public enum UnitVolumeVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        Yd3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitVolumeVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitVolumeVariant5 value)
        {
            return value switch
            {
                UnitVolumeVariant5.Yd3 => "yd3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitVolumeVariant5? ToEnum(string value)
        {
            return value switch
            {
                "yd3" => UnitVolumeVariant5.Yd3,
                _ => null,
            };
        }
    }
}