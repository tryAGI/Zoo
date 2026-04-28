
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Inches &lt;https://en.wikipedia.org/wiki/Inch&gt;
    /// </summary>
    public enum UnitLengthVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        In,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitLengthVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitLengthVariant3 value)
        {
            return value switch
            {
                UnitLengthVariant3.In => "in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitLengthVariant3? ToEnum(string value)
        {
            return value switch
            {
                "in" => UnitLengthVariant3.In,
                _ => null,
            };
        }
    }
}