
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The entity is hidden.
    /// </summary>
    public enum VisibilityVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Hide,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VisibilityVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisibilityVariant2 value)
        {
            return value switch
            {
                VisibilityVariant2.Hide => "hide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisibilityVariant2? ToEnum(string value)
        {
            return value switch
            {
                "hide" => VisibilityVariant2.Hide,
                _ => null,
            };
        }
    }
}