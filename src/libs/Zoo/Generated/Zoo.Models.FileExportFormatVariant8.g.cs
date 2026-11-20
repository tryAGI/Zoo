
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The 3DM file format. &lt;https://deepwiki.com/mcneel/rhino3dm/6.1-3dm-file-format&gt;
    /// </summary>
    public enum FileExportFormatVariant8
    {
        /// <summary>
        /// //deepwiki.com/mcneel/rhino3dm/6.1-3dm-file-format&gt;
        /// </summary>
        Rhino,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileExportFormatVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileExportFormatVariant8 value)
        {
            return value switch
            {
                FileExportFormatVariant8.Rhino => "rhino",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileExportFormatVariant8? ToEnum(string value)
        {
            return value switch
            {
                "rhino" => FileExportFormatVariant8.Rhino,
                _ => null,
            };
        }
    }
}