
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Autodesk Filmbox (FBX) format. &lt;https://en.wikipedia.org/wiki/FBX&gt;
    /// </summary>
    public enum FileImportFormatVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Fbx,
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
                FileImportFormatVariant1.Fbx => "fbx",
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
                "fbx" => FileImportFormatVariant1.Fbx,
                _ => null,
            };
        }
    }
}