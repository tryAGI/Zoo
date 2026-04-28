
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Binary glTF 2.0.<br/>
    /// This is a single binary with .glb extension.
    /// </summary>
    public enum GltfStorageVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Binary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GltfStorageVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GltfStorageVariant1 value)
        {
            return value switch
            {
                GltfStorageVariant1.Binary => "binary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GltfStorageVariant1? ToEnum(string value)
        {
            return value switch
            {
                "binary" => GltfStorageVariant1.Binary,
                _ => null,
            };
        }
    }
}