
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The async API call has failed.
    /// </summary>
    public enum ApiCallStatusVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiCallStatusVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiCallStatusVariant5 value)
        {
            return value switch
            {
                ApiCallStatusVariant5.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiCallStatusVariant5? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ApiCallStatusVariant5.Failed,
                _ => null,
            };
        }
    }
}