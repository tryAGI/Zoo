
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Thumbs down.
    /// </summary>
    public enum MlFeedbackVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        ThumbsDown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MlFeedbackVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MlFeedbackVariant2 value)
        {
            return value switch
            {
                MlFeedbackVariant2.ThumbsDown => "thumbs_down",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MlFeedbackVariant2? ToEnum(string value)
        {
            return value switch
            {
                "thumbs_down" => MlFeedbackVariant2.ThumbsDown,
                _ => null,
            };
        }
    }
}