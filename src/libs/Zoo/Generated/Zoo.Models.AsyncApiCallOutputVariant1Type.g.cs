
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum AsyncApiCallOutputVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        FileConversion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncApiCallOutputVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncApiCallOutputVariant1Type value)
        {
            return value switch
            {
                AsyncApiCallOutputVariant1Type.FileConversion => "file_conversion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncApiCallOutputVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "file_conversion" => AsyncApiCallOutputVariant1Type.FileConversion,
                _ => null,
            };
        }
    }
}