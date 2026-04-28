
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum SelectionVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        SceneByName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SelectionVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SelectionVariant3Type value)
        {
            return value switch
            {
                SelectionVariant3Type.SceneByName => "scene_by_name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SelectionVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "scene_by_name" => SelectionVariant3Type.SceneByName,
                _ => null,
            };
        }
    }
}