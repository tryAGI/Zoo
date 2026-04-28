
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputFormat3dVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        Step,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFormat3dVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFormat3dVariant6Type value)
        {
            return value switch
            {
                InputFormat3dVariant6Type.Step => "step",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFormat3dVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "step" => InputFormat3dVariant6Type.Step,
                _ => null,
            };
        }
    }
}