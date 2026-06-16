
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Autodesk Filmbox (FBX) format. &lt;https://en.wikipedia.org/wiki/FBX&gt;
    /// </summary>
    public enum FileImportFormatVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Fbx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileImportFormatVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileImportFormatVariant4 value)
        {
            return value switch
            {
                FileImportFormatVariant4.Fbx => "fbx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileImportFormatVariant4? ToEnum(string value)
        {
            return value switch
            {
                "fbx" => FileImportFormatVariant4.Fbx,
                _ => null,
            };
        }
    }
}