
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The async API call has completed.
    /// </summary>
    public enum ApiCallStatusVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiCallStatusVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiCallStatusVariant4 value)
        {
            return value switch
            {
                ApiCallStatusVariant4.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiCallStatusVariant4? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ApiCallStatusVariant4.Completed,
                _ => null,
            };
        }
    }
}