
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFormat3dVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Fbx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormat3dVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormat3dVariant1Type value)
        {
            return value switch
            {
                OutputFormat3dVariant1Type.Fbx => "fbx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormat3dVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "fbx" => OutputFormat3dVariant1Type.Fbx,
                _ => null,
            };
        }
    }
}