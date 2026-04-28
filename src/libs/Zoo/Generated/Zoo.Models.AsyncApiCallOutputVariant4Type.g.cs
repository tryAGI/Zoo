
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum AsyncApiCallOutputVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        FileVolume,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncApiCallOutputVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncApiCallOutputVariant4Type value)
        {
            return value switch
            {
                AsyncApiCallOutputVariant4Type.FileVolume => "file_volume",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncApiCallOutputVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "file_volume" => AsyncApiCallOutputVariant4Type.FileVolume,
                _ => null,
            };
        }
    }
}