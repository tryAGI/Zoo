
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The 3DM file format. &lt;https://deepwiki.com/mcneel/rhino3dm/6.1-3dm-file-format&gt;
    /// </summary>
    public enum FileImportFormatVariant14
    {
        /// <summary>
        /// //deepwiki.com/mcneel/rhino3dm/6.1-3dm-file-format&gt;
        /// </summary>
        Rhino,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileImportFormatVariant14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileImportFormatVariant14 value)
        {
            return value switch
            {
                FileImportFormatVariant14.Rhino => "rhino",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileImportFormatVariant14? ToEnum(string value)
        {
            return value switch
            {
                "rhino" => FileImportFormatVariant14.Rhino,
                _ => null,
            };
        }
    }
}