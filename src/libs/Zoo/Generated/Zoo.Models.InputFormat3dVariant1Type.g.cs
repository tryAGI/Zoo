
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputFormat3dVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Fbx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFormat3dVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFormat3dVariant1Type value)
        {
            return value switch
            {
                InputFormat3dVariant1Type.Fbx => "fbx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFormat3dVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "fbx" => InputFormat3dVariant1Type.Fbx,
                _ => null,
            };
        }
    }
}