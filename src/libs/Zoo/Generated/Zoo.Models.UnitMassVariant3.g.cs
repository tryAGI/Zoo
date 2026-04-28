
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Pounds &lt;https://en.wikipedia.org/wiki/Pound_(mass)&gt;
    /// </summary>
    public enum UnitMassVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Lb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitMassVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitMassVariant3 value)
        {
            return value switch
            {
                UnitMassVariant3.Lb => "lb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitMassVariant3? ToEnum(string value)
        {
            return value switch
            {
                "lb" => UnitMassVariant3.Lb,
                _ => null,
            };
        }
    }
}