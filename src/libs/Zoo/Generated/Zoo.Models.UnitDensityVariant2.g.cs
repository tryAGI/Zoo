
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Kilograms per cubic meter.
    /// </summary>
    public enum UnitDensityVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Kg_m3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitDensityVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitDensityVariant2 value)
        {
            return value switch
            {
                UnitDensityVariant2.Kg_m3 => "kg:m3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitDensityVariant2? ToEnum(string value)
        {
            return value switch
            {
                "kg:m3" => UnitDensityVariant2.Kg_m3,
                _ => null,
            };
        }
    }
}