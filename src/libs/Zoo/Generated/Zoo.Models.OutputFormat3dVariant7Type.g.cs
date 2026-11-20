
#nullable enable

namespace Zoo
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputFormat3dVariant7Type
    {
        /// <summary>
        ///
        /// </summary>
        Rhino,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormat3dVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormat3dVariant7Type value)
        {
            return value switch
            {
                OutputFormat3dVariant7Type.Rhino => "rhino",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormat3dVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "rhino" => OutputFormat3dVariant7Type.Rhino,
                _ => null,
            };
        }
    }
}