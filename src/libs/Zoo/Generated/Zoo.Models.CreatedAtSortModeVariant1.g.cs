
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Sort in increasing order of "created_at".
    /// </summary>
    public enum CreatedAtSortModeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAtAscending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatedAtSortModeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatedAtSortModeVariant1 value)
        {
            return value switch
            {
                CreatedAtSortModeVariant1.CreatedAtAscending => "created_at_ascending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatedAtSortModeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "created_at_ascending" => CreatedAtSortModeVariant1.CreatedAtAscending,
                _ => null,
            };
        }
    }
}