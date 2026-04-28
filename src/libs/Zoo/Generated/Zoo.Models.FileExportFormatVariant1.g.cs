
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Autodesk Filmbox (FBX) format. &lt;https://en.wikipedia.org/wiki/FBX&gt;
    /// </summary>
    public enum FileExportFormatVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Fbx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileExportFormatVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileExportFormatVariant1 value)
        {
            return value switch
            {
                FileExportFormatVariant1.Fbx => "fbx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileExportFormatVariant1? ToEnum(string value)
        {
            return value switch
            {
                "fbx" => FileExportFormatVariant1.Fbx,
                _ => null,
            };
        }
    }
}