
#nullable enable

namespace Zoo
{
    /// <summary>
    /// glTF 2.0.
    /// </summary>
    public enum FileImportFormatVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Gltf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileImportFormatVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileImportFormatVariant2 value)
        {
            return value switch
            {
                FileImportFormatVariant2.Gltf => "gltf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileImportFormatVariant2? ToEnum(string value)
        {
            return value switch
            {
                "gltf" => FileImportFormatVariant2.Gltf,
                _ => null,
            };
        }
    }
}