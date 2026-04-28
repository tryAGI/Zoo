
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum AsyncApiCallOutputVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        FileMass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncApiCallOutputVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncApiCallOutputVariant3Type value)
        {
            return value switch
            {
                AsyncApiCallOutputVariant3Type.FileMass => "file_mass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncApiCallOutputVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "file_mass" => AsyncApiCallOutputVariant3Type.FileMass,
                _ => null,
            };
        }
    }
}