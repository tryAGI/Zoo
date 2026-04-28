
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum SelectionVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        DefaultScene,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SelectionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SelectionVariant1Type value)
        {
            return value switch
            {
                SelectionVariant1Type.DefaultScene => "default_scene",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SelectionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "default_scene" => SelectionVariant1Type.DefaultScene,
                _ => null,
            };
        }
    }
}