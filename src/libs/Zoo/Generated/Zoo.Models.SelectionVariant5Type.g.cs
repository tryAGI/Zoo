
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum SelectionVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        MeshByName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SelectionVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SelectionVariant5Type value)
        {
            return value switch
            {
                SelectionVariant5Type.MeshByName => "mesh_by_name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SelectionVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "mesh_by_name" => SelectionVariant5Type.MeshByName,
                _ => null,
            };
        }
    }
}