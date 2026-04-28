
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Square kilometers &lt;https://en.wikipedia.org/wiki/Square_kilometer&gt;
    /// </summary>
    public enum UnitAreaVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        Km2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitAreaVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitAreaVariant5 value)
        {
            return value switch
            {
                UnitAreaVariant5.Km2 => "km2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitAreaVariant5? ToEnum(string value)
        {
            return value switch
            {
                "km2" => UnitAreaVariant5.Km2,
                _ => null,
            };
        }
    }
}