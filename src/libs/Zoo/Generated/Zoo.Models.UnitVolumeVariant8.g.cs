
#nullable enable

namespace Zoo
{
    /// <summary>
    /// US Gallons (gal US) &lt;https://en.wikipedia.org/wiki/Gallon&gt;
    /// </summary>
    public enum UnitVolumeVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        Usgal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitVolumeVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitVolumeVariant8 value)
        {
            return value switch
            {
                UnitVolumeVariant8.Usgal => "usgal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitVolumeVariant8? ToEnum(string value)
        {
            return value switch
            {
                "usgal" => UnitVolumeVariant8.Usgal,
                _ => null,
            };
        }
    }
}