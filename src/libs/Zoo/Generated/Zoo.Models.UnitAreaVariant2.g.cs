
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Square decimeters &lt;https://en.wikipedia.org/wiki/Square_decimeter&gt;
    /// </summary>
    public enum UnitAreaVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Dm2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitAreaVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitAreaVariant2 value)
        {
            return value switch
            {
                UnitAreaVariant2.Dm2 => "dm2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitAreaVariant2? ToEnum(string value)
        {
            return value switch
            {
                "dm2" => UnitAreaVariant2.Dm2,
                _ => null,
            };
        }
    }
}