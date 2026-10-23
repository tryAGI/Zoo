
#nullable enable

namespace Zoo
{
    /// <summary>
    /// AP214.
    /// </summary>
    public enum StepSchemaVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Ap214,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepSchemaVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepSchemaVariant2 value)
        {
            return value switch
            {
                StepSchemaVariant2.Ap214 => "ap214",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepSchemaVariant2? ToEnum(string value)
        {
            return value switch
            {
                "ap214" => StepSchemaVariant2.Ap214,
                _ => null,
            };
        }
    }
}