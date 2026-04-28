
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Square yards &lt;https://en.wikipedia.org/wiki/Square_mile&gt;
    /// </summary>
    public enum UnitAreaVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        Yd2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitAreaVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitAreaVariant8 value)
        {
            return value switch
            {
                UnitAreaVariant8.Yd2 => "yd2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitAreaVariant8? ToEnum(string value)
        {
            return value switch
            {
                "yd2" => UnitAreaVariant8.Yd2,
                _ => null,
            };
        }
    }
}