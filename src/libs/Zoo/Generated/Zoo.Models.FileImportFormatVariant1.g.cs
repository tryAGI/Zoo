
#nullable enable

namespace Zoo
{
    /// <summary>
    /// ACIS part format.
    /// </summary>
    public enum FileImportFormatVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Acis,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileImportFormatVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileImportFormatVariant1 value)
        {
            return value switch
            {
                FileImportFormatVariant1.Acis => "acis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileImportFormatVariant1? ToEnum(string value)
        {
            return value switch
            {
                "acis" => FileImportFormatVariant1.Acis,
                _ => null,
            };
        }
    }
}