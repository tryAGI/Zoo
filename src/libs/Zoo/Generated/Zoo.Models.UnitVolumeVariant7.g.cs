
#nullable enable

namespace Zoo
{
    /// <summary>
    /// US Fluid Ounces (fl oz) &lt;https://en.wikipedia.org/wiki/Fluid_ounce&gt;
    /// </summary>
    public enum UnitVolumeVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        Usfloz,
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
                UnitVolumeVariant7.Usfloz => "usfloz",
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
                "usfloz" => UnitVolumeVariant7.Usfloz,
                _ => null,
            };
        }
    }
}