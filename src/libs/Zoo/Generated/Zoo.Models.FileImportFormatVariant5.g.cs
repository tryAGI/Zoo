
#nullable enable

namespace Zoo
{
    /// <summary>
    /// SolidWorks part (SLDPRT) format.
    /// </summary>
    public enum FileImportFormatVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        Sldprt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileImportFormatVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileImportFormatVariant5 value)
        {
            return value switch
            {
                FileImportFormatVariant5.Sldprt => "sldprt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileImportFormatVariant5? ToEnum(string value)
        {
            return value switch
            {
                "sldprt" => FileImportFormatVariant5.Sldprt,
                _ => null,
            };
        }
    }
}