
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The async API call is queued.
    /// </summary>
    public enum ApiCallStatusVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiCallStatusVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiCallStatusVariant1 value)
        {
            return value switch
            {
                ApiCallStatusVariant1.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiCallStatusVariant1? ToEnum(string value)
        {
            return value switch
            {
                "queued" => ApiCallStatusVariant1.Queued,
                _ => null,
            };
        }
    }
}