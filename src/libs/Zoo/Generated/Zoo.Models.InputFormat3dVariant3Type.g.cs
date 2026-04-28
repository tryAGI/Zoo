
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputFormat3dVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Obj,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFormat3dVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFormat3dVariant3Type value)
        {
            return value switch
            {
                InputFormat3dVariant3Type.Obj => "obj",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFormat3dVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "obj" => InputFormat3dVariant3Type.Obj,
                _ => null,
            };
        }
    }
}