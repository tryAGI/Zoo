
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Parasolid part format.
    /// </summary>
    public enum FileImportFormatVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        Parasolid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileImportFormatVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileImportFormatVariant9 value)
        {
            return value switch
            {
                FileImportFormatVariant9.Parasolid => "parasolid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileImportFormatVariant9? ToEnum(string value)
        {
            return value switch
            {
                "parasolid" => FileImportFormatVariant9.Parasolid,
                _ => null,
            };
        }
    }
}