
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Increasing numbers.
    /// </summary>
    public enum DirectionVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Positive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectionVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectionVariant1 value)
        {
            return value switch
            {
                DirectionVariant1.Positive => "positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectionVariant1? ToEnum(string value)
        {
            return value switch
            {
                "positive" => DirectionVariant1.Positive,
                _ => null,
            };
        }
    }
}