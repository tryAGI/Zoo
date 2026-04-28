
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum AsyncApiCallOutputVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        FileDensity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncApiCallOutputVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncApiCallOutputVariant5Type value)
        {
            return value switch
            {
                AsyncApiCallOutputVariant5Type.FileDensity => "file_density",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncApiCallOutputVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "file_density" => AsyncApiCallOutputVariant5Type.FileDensity,
                _ => null,
            };
        }
    }
}