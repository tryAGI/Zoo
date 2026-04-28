
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Yards &lt;https://en.wikipedia.org/wiki/Yard&gt;
    /// </summary>
    public enum UnitLengthVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        Yd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitLengthVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitLengthVariant6 value)
        {
            return value switch
            {
                UnitLengthVariant6.Yd => "yd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitLengthVariant6? ToEnum(string value)
        {
            return value switch
            {
                "yd" => UnitLengthVariant6.Yd,
                _ => null,
            };
        }
    }
}