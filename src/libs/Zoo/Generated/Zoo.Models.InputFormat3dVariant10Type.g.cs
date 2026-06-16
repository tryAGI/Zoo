
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputFormat3dVariant10Type
    {
        /// <summary>
        /// 
        /// </summary>
        Ply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFormat3dVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFormat3dVariant10Type value)
        {
            return value switch
            {
                InputFormat3dVariant10Type.Ply => "ply",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFormat3dVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "ply" => InputFormat3dVariant10Type.Ply,
                _ => null,
            };
        }
    }
}