
#nullable enable

namespace Zoo
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncApiCallOutputVariant8Type
    {
        /// <summary>
        ///
        /// </summary>
        TextToCad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncApiCallOutputVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncApiCallOutputVariant8Type value)
        {
            return value switch
            {
                AsyncApiCallOutputVariant8Type.TextToCad => "text_to_cad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncApiCallOutputVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "text_to_cad" => AsyncApiCallOutputVariant8Type.TextToCad,
                _ => null,
            };
        }
    }
}