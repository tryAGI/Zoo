
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Millimeters &lt;https://en.wikipedia.org/wiki/Millimeter&gt;
    /// </summary>
    public enum UnitLengthVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        Mm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitLengthVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitLengthVariant5 value)
        {
            return value switch
            {
                UnitLengthVariant5.Mm => "mm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitLengthVariant5? ToEnum(string value)
        {
            return value switch
            {
                "mm" => UnitLengthVariant5.Mm,
                _ => null,
            };
        }
    }
}