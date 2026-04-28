
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Pounds per cubic feet.
    /// </summary>
    public enum UnitDensityVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Lb_ft3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitDensityVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitDensityVariant1 value)
        {
            return value switch
            {
                UnitDensityVariant1.Lb_ft3 => "lb:ft3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitDensityVariant1? ToEnum(string value)
        {
            return value switch
            {
                "lb:ft3" => UnitDensityVariant1.Lb_ft3,
                _ => null,
            };
        }
    }
}