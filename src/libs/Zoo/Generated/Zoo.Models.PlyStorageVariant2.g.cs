
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Encode payload as binary using little endian.
    /// </summary>
    public enum PlyStorageVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        BinaryLittleEndian,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlyStorageVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlyStorageVariant2 value)
        {
            return value switch
            {
                PlyStorageVariant2.BinaryLittleEndian => "binary_little_endian",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlyStorageVariant2? ToEnum(string value)
        {
            return value switch
            {
                "binary_little_endian" => PlyStorageVariant2.BinaryLittleEndian,
                _ => null,
            };
        }
    }
}