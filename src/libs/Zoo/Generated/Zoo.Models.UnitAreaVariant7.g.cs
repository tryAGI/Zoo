
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Square millimeters &lt;https://en.wikipedia.org/wiki/Square_millimeter&gt;
    /// </summary>
    public enum UnitAreaVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        Mm2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitAreaVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitAreaVariant7 value)
        {
            return value switch
            {
                UnitAreaVariant7.Mm2 => "mm2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitAreaVariant7? ToEnum(string value)
        {
            return value switch
            {
                "mm2" => UnitAreaVariant7.Mm2,
                _ => null,
            };
        }
    }
}