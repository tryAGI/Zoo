
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Boundary representation
    /// </summary>
    public enum StepImportTargetRepresentationVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Brep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepImportTargetRepresentationVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepImportTargetRepresentationVariant2 value)
        {
            return value switch
            {
                StepImportTargetRepresentationVariant2.Brep => "brep",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepImportTargetRepresentationVariant2? ToEnum(string value)
        {
            return value switch
            {
                "brep" => StepImportTargetRepresentationVariant2.Brep,
                _ => null,
            };
        }
    }
}