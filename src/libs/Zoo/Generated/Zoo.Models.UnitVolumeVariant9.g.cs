
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Milliliters (ml) &lt;https://en.wikipedia.org/wiki/Litre&gt;
    /// </summary>
    public enum UnitVolumeVariant9
    {
        /// <summary>
        /// //en.wikipedia.org/wiki/Litre&gt;
        /// </summary>
        Ml,
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
                UnitVolumeVariant9.Ml => "ml",
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
                "ml" => UnitVolumeVariant9.Ml,
                _ => null,
            };
        }
    }
}