
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputFormat3dVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        Stl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFormat3dVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFormat3dVariant7Type value)
        {
            return value switch
            {
                InputFormat3dVariant7Type.Stl => "stl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFormat3dVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "stl" => InputFormat3dVariant7Type.Stl,
                _ => null,
            };
        }
    }
}