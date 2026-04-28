
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Binary FBX encoding.
    /// </summary>
    public enum FbxStorageVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Binary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FbxStorageVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FbxStorageVariant2 value)
        {
            return value switch
            {
                FbxStorageVariant2.Binary => "binary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FbxStorageVariant2? ToEnum(string value)
        {
            return value switch
            {
                "binary" => FbxStorageVariant2.Binary,
                _ => null,
            };
        }
    }
}