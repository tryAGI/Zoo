
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFormat3dVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gltf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormat3dVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormat3dVariant2Type value)
        {
            return value switch
            {
                OutputFormat3dVariant2Type.Gltf => "gltf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormat3dVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "gltf" => OutputFormat3dVariant2Type.Gltf,
                _ => null,
            };
        }
    }
}