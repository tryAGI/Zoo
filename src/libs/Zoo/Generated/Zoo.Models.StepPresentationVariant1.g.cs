
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Condenses the text to reduce the size of the file.
    /// </summary>
    public enum StepPresentationVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Compact,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepPresentationVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepPresentationVariant1 value)
        {
            return value switch
            {
                StepPresentationVariant1.Compact => "compact",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepPresentationVariant1? ToEnum(string value)
        {
            return value switch
            {
                "compact" => StepPresentationVariant1.Compact,
                _ => null,
            };
        }
    }
}