
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum SelectionVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        MeshByIndex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SelectionVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SelectionVariant4Type value)
        {
            return value switch
            {
                SelectionVariant4Type.MeshByIndex => "mesh_by_index",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SelectionVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "mesh_by_index" => SelectionVariant4Type.MeshByIndex,
                _ => null,
            };
        }
    }
}