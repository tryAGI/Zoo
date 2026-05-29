
#nullable enable

namespace Zoo
{
    /// <summary>
    /// PTC Creo part format.
    /// </summary>
    public enum FileImportFormatVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Creo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileImportFormatVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileImportFormatVariant3 value)
        {
            return value switch
            {
                FileImportFormatVariant3.Creo => "creo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileImportFormatVariant3? ToEnum(string value)
        {
            return value switch
            {
                "creo" => FileImportFormatVariant3.Creo,
                _ => null,
            };
        }
    }
}