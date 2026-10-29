
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The entity is visible.
    /// </summary>
    public enum VisibilityVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Show,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VisibilityVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisibilityVariant1 value)
        {
            return value switch
            {
                VisibilityVariant1.Show => "show",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisibilityVariant1? ToEnum(string value)
        {
            return value switch
            {
                "show" => VisibilityVariant1.Show,
                _ => null,
            };
        }
    }
}