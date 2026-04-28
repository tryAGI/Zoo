
#nullable enable

namespace Zoo
{
    /// <summary>
    /// US Gallons (gal US) &lt;https://en.wikipedia.org/wiki/Gallon&gt;
    /// </summary>
    public enum UnitVolumeVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        Usgal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitVolumeVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitVolumeVariant7 value)
        {
            return value switch
            {
                UnitVolumeVariant7.Usgal => "usgal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitVolumeVariant7? ToEnum(string value)
        {
            return value switch
            {
                "usgal" => UnitVolumeVariant7.Usgal,
                _ => null,
            };
        }
    }
}