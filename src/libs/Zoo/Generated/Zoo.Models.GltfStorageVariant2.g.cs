
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Standard glTF 2.0.<br/>
    /// This is a JSON file with .gltf extension paired with a separate binary blob file with .bin extension.
    /// </summary>
    public enum GltfStorageVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GltfStorageVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GltfStorageVariant2 value)
        {
            return value switch
            {
                GltfStorageVariant2.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GltfStorageVariant2? ToEnum(string value)
        {
            return value switch
            {
                "standard" => GltfStorageVariant2.Standard,
                _ => null,
            };
        }
    }
}