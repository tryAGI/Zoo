
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Rejected.
    /// </summary>
    public enum MlFeedbackVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MlFeedbackVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MlFeedbackVariant4 value)
        {
            return value switch
            {
                MlFeedbackVariant4.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MlFeedbackVariant4? ToEnum(string value)
        {
            return value switch
            {
                "rejected" => MlFeedbackVariant4.Rejected,
                _ => null,
            };
        }
    }
}