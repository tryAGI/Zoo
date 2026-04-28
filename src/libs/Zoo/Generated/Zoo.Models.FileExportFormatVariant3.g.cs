
#nullable enable

namespace Zoo
{
    /// <summary>
    /// glTF 2.0. Embedded glTF 2.0 (pretty printed).<br/>
    /// Single JSON file with .gltf extension binary data encoded as base64 data URIs.<br/>
    /// The JSON contents are pretty printed.<br/>
    /// It is human readable, single file, and you can view the diff easily in a git commit.
    /// </summary>
    public enum FileExportFormatVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Gltf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileExportFormatVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileExportFormatVariant3 value)
        {
            return value switch
            {
                FileExportFormatVariant3.Gltf => "gltf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileExportFormatVariant3? ToEnum(string value)
        {
            return value switch
            {
                "gltf" => FileExportFormatVariant3.Gltf,
                _ => null,
            };
        }
    }
}