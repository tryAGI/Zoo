
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum AsyncApiCallOutputVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        TextToCadMultiFileIteration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncApiCallOutputVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncApiCallOutputVariant9Type value)
        {
            return value switch
            {
                AsyncApiCallOutputVariant9Type.TextToCadMultiFileIteration => "text_to_cad_multi_file_iteration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncApiCallOutputVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "text_to_cad_multi_file_iteration" => AsyncApiCallOutputVariant9Type.TextToCadMultiFileIteration,
                _ => null,
            };
        }
    }
}