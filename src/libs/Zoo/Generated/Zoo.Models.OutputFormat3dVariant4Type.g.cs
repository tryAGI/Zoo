
#nullable enable

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFormat3dVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Ply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormat3dVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormat3dVariant4Type value)
        {
            return value switch
            {
                OutputFormat3dVariant4Type.Ply => "ply",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormat3dVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "ply" => OutputFormat3dVariant4Type.Ply,
                _ => null,
            };
        }
    }
}