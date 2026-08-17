
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Mesh of 2D geometry
    /// </summary>
    public enum StepImportTargetRepresentationVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Mesh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepImportTargetRepresentationVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepImportTargetRepresentationVariant1 value)
        {
            return value switch
            {
                StepImportTargetRepresentationVariant1.Mesh => "mesh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepImportTargetRepresentationVariant1? ToEnum(string value)
        {
            return value switch
            {
                "mesh" => StepImportTargetRepresentationVariant1.Mesh,
                _ => null,
            };
        }
    }
}