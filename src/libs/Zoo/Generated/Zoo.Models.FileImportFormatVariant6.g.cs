
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Autodesk Inventor part format.
    /// </summary>
    public enum FileImportFormatVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        Inventor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileImportFormatVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileImportFormatVariant6 value)
        {
            return value switch
            {
                FileImportFormatVariant6.Inventor => "inventor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileImportFormatVariant6? ToEnum(string value)
        {
            return value switch
            {
                "inventor" => FileImportFormatVariant6.Inventor,
                _ => null,
            };
        }
    }
}