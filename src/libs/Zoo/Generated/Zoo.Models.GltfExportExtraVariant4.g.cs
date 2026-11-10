
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Model-based definition (MBD) annotations.
    /// </summary>
    public enum GltfExportExtraVariant4
    {
        /// <summary>
        ///
        /// </summary>
        Mbd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GltfExportExtraVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GltfExportExtraVariant4 value)
        {
            return value switch
            {
                GltfExportExtraVariant4.Mbd => "mbd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GltfExportExtraVariant4? ToEnum(string value)
        {
            return value switch
            {
                "mbd" => GltfExportExtraVariant4.Mbd,
                _ => null,
            };
        }
    }
}