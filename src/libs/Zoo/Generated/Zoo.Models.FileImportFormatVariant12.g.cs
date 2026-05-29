
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The STEP file format. &lt;https://en.wikipedia.org/wiki/ISO_10303-21&gt;
    /// </summary>
    public enum FileImportFormatVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        Step,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileImportFormatVariant12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileImportFormatVariant12 value)
        {
            return value switch
            {
                FileImportFormatVariant12.Step => "step",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileImportFormatVariant12? ToEnum(string value)
        {
            return value switch
            {
                "step" => FileImportFormatVariant12.Step,
                _ => null,
            };
        }
    }
}