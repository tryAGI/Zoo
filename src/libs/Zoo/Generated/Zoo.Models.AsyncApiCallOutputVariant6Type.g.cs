
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum AsyncApiCallOutputVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        FileSurfaceArea,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncApiCallOutputVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncApiCallOutputVariant6Type value)
        {
            return value switch
            {
                AsyncApiCallOutputVariant6Type.FileSurfaceArea => "file_surface_area",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncApiCallOutputVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "file_surface_area" => AsyncApiCallOutputVariant6Type.FileSurfaceArea,
                _ => null,
            };
        }
    }
}