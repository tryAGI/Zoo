
#nullable enable

namespace Zoo
{
    /// <summary>
    /// UUIDs and source UUIDs on boundary-representation solids, edges, faces, and surfaces.
    /// </summary>
    public enum GltfExportExtraVariant5
    {
        /// <summary>
        ///
        /// </summary>
        GeometryUuids,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GltfExportExtraVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GltfExportExtraVariant5 value)
        {
            return value switch
            {
                GltfExportExtraVariant5.GeometryUuids => "geometry_uuids",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GltfExportExtraVariant5? ToEnum(string value)
        {
            return value switch
            {
                "geometry_uuids" => GltfExportExtraVariant5.GeometryUuids,
                _ => null,
            };
        }
    }
}