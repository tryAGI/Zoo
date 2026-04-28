
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Thumbs up.
    /// </summary>
    public enum MlFeedbackVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        ThumbsUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MlFeedbackVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MlFeedbackVariant1 value)
        {
            return value switch
            {
                MlFeedbackVariant1.ThumbsUp => "thumbs_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MlFeedbackVariant1? ToEnum(string value)
        {
            return value switch
            {
                "thumbs_up" => MlFeedbackVariant1.ThumbsUp,
                _ => null,
            };
        }
    }
}