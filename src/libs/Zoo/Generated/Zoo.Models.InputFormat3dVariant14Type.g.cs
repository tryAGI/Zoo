
#nullable enable

namespace Zoo
{
    /// <summary>
    ///
    /// </summary>
    public enum InputFormat3dVariant14Type
    {
        /// <summary>
        ///
        /// </summary>
        Rhino,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFormat3dVariant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFormat3dVariant14Type value)
        {
            return value switch
            {
                InputFormat3dVariant14Type.Rhino => "rhino",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFormat3dVariant14Type? ToEnum(string value)
        {
            return value switch
            {
                "rhino" => InputFormat3dVariant14Type.Rhino,
                _ => null,
            };
        }
    }
}