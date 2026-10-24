
#nullable enable

namespace Zoo
{
    /// <summary>
    /// AP203 edition 2.
    /// </summary>
    public enum StepSchemaVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Ap203,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepSchemaVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepSchemaVariant1 value)
        {
            return value switch
            {
                StepSchemaVariant1.Ap203 => "ap203",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepSchemaVariant1? ToEnum(string value)
        {
            return value switch
            {
                "ap203" => StepSchemaVariant1.Ap203,
                _ => null,
            };
        }
    }
}