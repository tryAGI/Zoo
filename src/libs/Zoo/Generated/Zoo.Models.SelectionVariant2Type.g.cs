
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum SelectionVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        SceneByIndex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SelectionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SelectionVariant2Type value)
        {
            return value switch
            {
                SelectionVariant2Type.SceneByIndex => "scene_by_index",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SelectionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "scene_by_index" => SelectionVariant2Type.SceneByIndex,
                _ => null,
            };
        }
    }
}