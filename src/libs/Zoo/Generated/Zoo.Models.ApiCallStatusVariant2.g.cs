
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The async API call was uploaded to be converted.
    /// </summary>
    public enum ApiCallStatusVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Uploaded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiCallStatusVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiCallStatusVariant2 value)
        {
            return value switch
            {
                ApiCallStatusVariant2.Uploaded => "uploaded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiCallStatusVariant2? ToEnum(string value)
        {
            return value switch
            {
                "uploaded" => ApiCallStatusVariant2.Uploaded,
                _ => null,
            };
        }
    }
}