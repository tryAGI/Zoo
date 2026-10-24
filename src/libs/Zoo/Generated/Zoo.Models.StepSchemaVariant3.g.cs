
#nullable enable

namespace Zoo
{
    /// <summary>
    /// AP242.<br/>
    /// This is the default setting.
    /// </summary>
    public enum StepSchemaVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Ap242,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepSchemaVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepSchemaVariant3 value)
        {
            return value switch
            {
                StepSchemaVariant3.Ap242 => "ap242",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepSchemaVariant3? ToEnum(string value)
        {
            return value switch
            {
                "ap242" => StepSchemaVariant3.Ap242,
                _ => null,
            };
        }
    }
}