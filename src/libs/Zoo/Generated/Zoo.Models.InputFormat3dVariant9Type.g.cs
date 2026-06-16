
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputFormat3dVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        Parasolid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFormat3dVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFormat3dVariant9Type value)
        {
            return value switch
            {
                InputFormat3dVariant9Type.Parasolid => "parasolid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFormat3dVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "parasolid" => InputFormat3dVariant9Type.Parasolid,
                _ => null,
            };
        }
    }
}