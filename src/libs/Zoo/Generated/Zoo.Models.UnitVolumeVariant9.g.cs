
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Liters (l) &lt;https://en.wikipedia.org/wiki/Litre&gt;
    /// </summary>
    public enum UnitVolumeVariant9
    {
        /// <summary>
        /// //en.wikipedia.org/wiki/Litre&gt;
        /// </summary>
        L,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitVolumeVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitVolumeVariant9 value)
        {
            return value switch
            {
                UnitVolumeVariant9.L => "l",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitVolumeVariant9? ToEnum(string value)
        {
            return value switch
            {
                "l" => UnitVolumeVariant9.L,
                _ => null,
            };
        }
    }
}