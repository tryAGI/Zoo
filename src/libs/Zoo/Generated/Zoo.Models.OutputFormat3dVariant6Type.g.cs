
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFormat3dVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        Stl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormat3dVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormat3dVariant6Type value)
        {
            return value switch
            {
                OutputFormat3dVariant6Type.Stl => "stl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormat3dVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "stl" => OutputFormat3dVariant6Type.Stl,
                _ => null,
            };
        }
    }
}