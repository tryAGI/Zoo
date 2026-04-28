
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Feet &lt;https://en.wikipedia.org/wiki/Foot_(unit)&gt;
    /// </summary>
    public enum UnitLengthVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Ft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitLengthVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitLengthVariant2 value)
        {
            return value switch
            {
                UnitLengthVariant2.Ft => "ft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitLengthVariant2? ToEnum(string value)
        {
            return value switch
            {
                "ft" => UnitLengthVariant2.Ft,
                _ => null,
            };
        }
    }
}