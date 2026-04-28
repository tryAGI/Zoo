
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum AsyncApiCallOutputVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        TextToCad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncApiCallOutputVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncApiCallOutputVariant7Type value)
        {
            return value switch
            {
                AsyncApiCallOutputVariant7Type.TextToCad => "text_to_cad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncApiCallOutputVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "text_to_cad" => AsyncApiCallOutputVariant7Type.TextToCad,
                _ => null,
            };
        }
    }
}