
#nullable enable

namespace Zoo
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectionVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Orthographic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectionVariant1Type value)
        {
            return value switch
            {
                ProjectionVariant1Type.Orthographic => "orthographic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "orthographic" => ProjectionVariant1Type.Orthographic,
                _ => null,
            };
        }
    }
}