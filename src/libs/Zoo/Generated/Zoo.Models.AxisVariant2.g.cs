
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 'Z' axis.
    /// </summary>
    public enum AxisVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Z,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AxisVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AxisVariant2 value)
        {
            return value switch
            {
                AxisVariant2.Z => "z",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AxisVariant2? ToEnum(string value)
        {
            return value switch
            {
                "z" => AxisVariant2.Z,
                _ => null,
            };
        }
    }
}