
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The STL file format. &lt;https://en.wikipedia.org/wiki/STL_(file_format)&gt;
    /// </summary>
    public enum FileImportFormatVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        Stl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileImportFormatVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileImportFormatVariant7 value)
        {
            return value switch
            {
                FileImportFormatVariant7.Stl => "stl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileImportFormatVariant7? ToEnum(string value)
        {
            return value switch
            {
                "stl" => FileImportFormatVariant7.Stl,
                _ => null,
            };
        }
    }
}