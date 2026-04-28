
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The STEP file format. &lt;https://en.wikipedia.org/wiki/ISO_10303-21&gt;
    /// </summary>
    public enum FileExportFormatVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        Step,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileExportFormatVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileExportFormatVariant6 value)
        {
            return value switch
            {
                FileExportFormatVariant6.Step => "step",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileExportFormatVariant6? ToEnum(string value)
        {
            return value switch
            {
                "step" => FileExportFormatVariant6.Step,
                _ => null,
            };
        }
    }
}