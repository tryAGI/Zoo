
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Embedded glTF 2.0.<br/>
    /// Single JSON file with .gltf extension binary data encoded as base64 data URIs.<br/>
    /// This is the default setting.
    /// </summary>
    public enum GltfStorageVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Embedded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GltfStorageVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GltfStorageVariant3 value)
        {
            return value switch
            {
                GltfStorageVariant3.Embedded => "embedded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GltfStorageVariant3? ToEnum(string value)
        {
            return value switch
            {
                "embedded" => GltfStorageVariant3.Embedded,
                _ => null,
            };
        }
    }
}