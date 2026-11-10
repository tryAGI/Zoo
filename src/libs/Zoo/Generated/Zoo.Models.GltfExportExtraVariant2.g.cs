
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Sketch regions and their resolver metadata.
    /// </summary>
    public enum GltfExportExtraVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Regions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GltfExportExtraVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GltfExportExtraVariant2 value)
        {
            return value switch
            {
                GltfExportExtraVariant2.Regions => "regions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GltfExportExtraVariant2? ToEnum(string value)
        {
            return value switch
            {
                "regions" => GltfExportExtraVariant2.Regions,
                _ => null,
            };
        }
    }
}