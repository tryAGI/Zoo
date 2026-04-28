
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Sort in decreasing order of "created_at".
    /// </summary>
    public enum CreatedAtSortModeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAtDescending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatedAtSortModeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatedAtSortModeVariant2 value)
        {
            return value switch
            {
                CreatedAtSortModeVariant2.CreatedAtDescending => "created_at_descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatedAtSortModeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "created_at_descending" => CreatedAtSortModeVariant2.CreatedAtDescending,
                _ => null,
            };
        }
    }
}