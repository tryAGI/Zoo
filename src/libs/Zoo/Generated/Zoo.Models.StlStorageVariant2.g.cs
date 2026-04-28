
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Binary STL encoding.<br/>
    /// This is the default setting.
    /// </summary>
    public enum StlStorageVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Binary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StlStorageVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StlStorageVariant2 value)
        {
            return value switch
            {
                StlStorageVariant2.Binary => "binary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StlStorageVariant2? ToEnum(string value)
        {
            return value switch
            {
                "binary" => StlStorageVariant2.Binary,
                _ => null,
            };
        }
    }
}