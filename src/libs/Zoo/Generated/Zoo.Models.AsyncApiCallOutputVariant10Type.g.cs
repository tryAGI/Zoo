
#nullable enable

namespace Zoo
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncApiCallOutputVariant10Type
    {
        /// <summary>
        ///
        /// </summary>
        TextToCadMultiFileIteration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncApiCallOutputVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncApiCallOutputVariant10Type value)
        {
            return value switch
            {
                AsyncApiCallOutputVariant10Type.TextToCadMultiFileIteration => "text_to_cad_multi_file_iteration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncApiCallOutputVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "text_to_cad_multi_file_iteration" => AsyncApiCallOutputVariant10Type.TextToCadMultiFileIteration,
                _ => null,
            };
        }
    }
}