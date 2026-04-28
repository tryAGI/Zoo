
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The OBJ file format. &lt;https://en.wikipedia.org/wiki/Wavefront_.obj_file&gt; It may or may not have an an attached material (mtl // mtllib) within the file, but we interact with it as if it does not.
    /// </summary>
    public enum FileExportFormatVariant4
    {
        /// <summary>
        /// //en.wikipedia.org/wiki/Wavefront_.obj_file&gt; It may or may not have an an attached material (mtl // mtllib) within the file, but we interact with it as if it does not.
        /// </summary>
        Obj,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileExportFormatVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileExportFormatVariant4 value)
        {
            return value switch
            {
                FileExportFormatVariant4.Obj => "obj",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileExportFormatVariant4? ToEnum(string value)
        {
            return value switch
            {
                "obj" => FileExportFormatVariant4.Obj,
                _ => null,
            };
        }
    }
}