
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Add extra spaces to make the text more easily readable.<br/>
    /// This is the default setting.
    /// </summary>
    public enum StepPresentationVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Pretty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepPresentationVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepPresentationVariant2 value)
        {
            return value switch
            {
                StepPresentationVariant2.Pretty => "pretty",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepPresentationVariant2? ToEnum(string value)
        {
            return value switch
            {
                "pretty" => StepPresentationVariant2.Pretty,
                _ => null,
            };
        }
    }
}