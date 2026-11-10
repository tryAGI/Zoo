
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Original imported files.
    /// </summary>
    public enum GltfExportExtraVariant3
    {
        /// <summary>
        ///
        /// </summary>
        ImportedFiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GltfExportExtraVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GltfExportExtraVariant3 value)
        {
            return value switch
            {
                GltfExportExtraVariant3.ImportedFiles => "imported_files",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GltfExportExtraVariant3? ToEnum(string value)
        {
            return value switch
            {
                "imported_files" => GltfExportExtraVariant3.ImportedFiles,
                _ => null,
            };
        }
    }
}