
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Condense the JSON into the smallest possible size.
    /// </summary>
    public enum GltfPresentationVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Compact,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GltfPresentationVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GltfPresentationVariant1 value)
        {
            return value switch
            {
                GltfPresentationVariant1.Compact => "compact",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GltfPresentationVariant1? ToEnum(string value)
        {
            return value switch
            {
                "compact" => GltfPresentationVariant1.Compact,
                _ => null,
            };
        }
    }
}