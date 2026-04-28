
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Encode payload as binary using big endian.
    /// </summary>
    public enum PlyStorageVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        BinaryBigEndian,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlyStorageVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlyStorageVariant3 value)
        {
            return value switch
            {
                PlyStorageVariant3.BinaryBigEndian => "binary_big_endian",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlyStorageVariant3? ToEnum(string value)
        {
            return value switch
            {
                "binary_big_endian" => PlyStorageVariant3.BinaryBigEndian,
                _ => null,
            };
        }
    }
}