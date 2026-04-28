
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum AsyncApiCallOutputVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        FileCenterOfMass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncApiCallOutputVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncApiCallOutputVariant2Type value)
        {
            return value switch
            {
                AsyncApiCallOutputVariant2Type.FileCenterOfMass => "file_center_of_mass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncApiCallOutputVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "file_center_of_mass" => AsyncApiCallOutputVariant2Type.FileCenterOfMass,
                _ => null,
            };
        }
    }
}