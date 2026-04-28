
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The PLY file format. &lt;https://en.wikipedia.org/wiki/PLY_(file_format)&gt;
    /// </summary>
    public enum FileImportFormatVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Ply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileImportFormatVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileImportFormatVariant4 value)
        {
            return value switch
            {
                FileImportFormatVariant4.Ply => "ply",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileImportFormatVariant4? ToEnum(string value)
        {
            return value switch
            {
                "ply" => FileImportFormatVariant4.Ply,
                _ => null,
            };
        }
    }
}