
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Binary glTF 2.0.<br/>
    /// This is a single binary with .glb extension.<br/>
    /// This is better if you want a compressed format as opposed to the human readable glTF that lacks compression.
    /// </summary>
    public enum FileExportFormatVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Glb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileExportFormatVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileExportFormatVariant2 value)
        {
            return value switch
            {
                FileExportFormatVariant2.Glb => "glb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileExportFormatVariant2? ToEnum(string value)
        {
            return value switch
            {
                "glb" => FileExportFormatVariant2.Glb,
                _ => null,
            };
        }
    }
}