
#nullable enable

namespace Zoo
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectionVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Perspective,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectionVariant2Type value)
        {
            return value switch
            {
                ProjectionVariant2Type.Perspective => "perspective",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "perspective" => ProjectionVariant2Type.Perspective,
                _ => null,
            };
        }
    }
}