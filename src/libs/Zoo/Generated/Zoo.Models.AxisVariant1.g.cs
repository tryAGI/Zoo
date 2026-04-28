
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 'Y' axis.
    /// </summary>
    public enum AxisVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Y,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AxisVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AxisVariant1 value)
        {
            return value switch
            {
                AxisVariant1.Y => "y",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AxisVariant1? ToEnum(string value)
        {
            return value switch
            {
                "y" => AxisVariant1.Y,
                _ => null,
            };
        }
    }
}