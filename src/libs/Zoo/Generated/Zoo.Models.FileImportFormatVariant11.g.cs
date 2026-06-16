
#nullable enable

namespace Zoo
{
    /// <summary>
    /// SolidWorks part (SLDPRT) format.
    /// </summary>
    public enum FileImportFormatVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        Sldprt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileImportFormatVariant11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileImportFormatVariant11 value)
        {
            return value switch
            {
                FileImportFormatVariant11.Sldprt => "sldprt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileImportFormatVariant11? ToEnum(string value)
        {
            return value switch
            {
                "sldprt" => FileImportFormatVariant11.Sldprt,
                _ => null,
            };
        }
    }
}