
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFormat3dVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        Step,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormat3dVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormat3dVariant5Type value)
        {
            return value switch
            {
                OutputFormat3dVariant5Type.Step => "step",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormat3dVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "step" => OutputFormat3dVariant5Type.Step,
                _ => null,
            };
        }
    }
}