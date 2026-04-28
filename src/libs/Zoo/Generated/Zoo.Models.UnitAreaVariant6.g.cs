
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Square meters &lt;https://en.wikipedia.org/wiki/Square_meter&gt;
    /// </summary>
    public enum UnitAreaVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        M2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitAreaVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitAreaVariant6 value)
        {
            return value switch
            {
                UnitAreaVariant6.M2 => "m2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitAreaVariant6? ToEnum(string value)
        {
            return value switch
            {
                "m2" => UnitAreaVariant6.M2,
                _ => null,
            };
        }
    }
}