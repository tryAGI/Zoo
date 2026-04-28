
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Square feet &lt;https://en.wikipedia.org/wiki/Square_foot&gt;
    /// </summary>
    public enum UnitAreaVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Ft2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitAreaVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitAreaVariant3 value)
        {
            return value switch
            {
                UnitAreaVariant3.Ft2 => "ft2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitAreaVariant3? ToEnum(string value)
        {
            return value switch
            {
                "ft2" => UnitAreaVariant3.Ft2,
                _ => null,
            };
        }
    }
}