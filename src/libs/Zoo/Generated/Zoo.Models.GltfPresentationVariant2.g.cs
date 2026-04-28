
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Expand the JSON into a more human readable format.<br/>
    /// This is the default setting.
    /// </summary>
    public enum GltfPresentationVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Pretty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GltfPresentationVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GltfPresentationVariant2 value)
        {
            return value switch
            {
                GltfPresentationVariant2.Pretty => "pretty",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GltfPresentationVariant2? ToEnum(string value)
        {
            return value switch
            {
                "pretty" => GltfPresentationVariant2.Pretty,
                _ => null,
            };
        }
    }
}