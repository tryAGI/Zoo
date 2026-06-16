
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Siemens NX part format.
    /// </summary>
    public enum FileImportFormatVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        Nx,
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
                FileImportFormatVariant7.Nx => "nx",
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
                "nx" => FileImportFormatVariant7.Nx,
                _ => null,
            };
        }
    }
}