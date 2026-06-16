
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputFormat3dVariant11Type
    {
        /// <summary>
        /// 
        /// </summary>
        Sldprt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFormat3dVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFormat3dVariant11Type value)
        {
            return value switch
            {
                InputFormat3dVariant11Type.Sldprt => "sldprt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFormat3dVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "sldprt" => InputFormat3dVariant11Type.Sldprt,
                _ => null,
            };
        }
    }
}