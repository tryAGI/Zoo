
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The async API call is in progress.
    /// </summary>
    public enum ApiCallStatusVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiCallStatusVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiCallStatusVariant3 value)
        {
            return value switch
            {
                ApiCallStatusVariant3.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiCallStatusVariant3? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ApiCallStatusVariant3.InProgress,
                _ => null,
            };
        }
    }
}