
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The STL file format. &lt;https://en.wikipedia.org/wiki/STL_(file_format)&gt;
    /// </summary>
    public enum FileImportFormatVariant13
    {
        /// <summary>
        /// 
        /// </summary>
        Stl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileImportFormatVariant13Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileImportFormatVariant13 value)
        {
            return value switch
            {
                FileImportFormatVariant13.Stl => "stl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileImportFormatVariant13? ToEnum(string value)
        {
            return value switch
            {
                "stl" => FileImportFormatVariant13.Stl,
                _ => null,
            };
        }
    }
}