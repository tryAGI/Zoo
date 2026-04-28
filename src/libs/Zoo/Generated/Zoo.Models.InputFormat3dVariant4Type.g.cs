
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputFormat3dVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Ply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFormat3dVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFormat3dVariant4Type value)
        {
            return value switch
            {
                InputFormat3dVariant4Type.Ply => "ply",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFormat3dVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "ply" => InputFormat3dVariant4Type.Ply,
                _ => null,
            };
        }
    }
}