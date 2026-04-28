
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Decreasing numbers.
    /// </summary>
    public enum DirectionVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Negative,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectionVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectionVariant2 value)
        {
            return value switch
            {
                DirectionVariant2.Negative => "negative",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectionVariant2? ToEnum(string value)
        {
            return value switch
            {
                "negative" => DirectionVariant2.Negative,
                _ => null,
            };
        }
    }
}