
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Plaintext encoding.
    /// </summary>
    public enum StlStorageVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Ascii,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StlStorageVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StlStorageVariant1 value)
        {
            return value switch
            {
                StlStorageVariant1.Ascii => "ascii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StlStorageVariant1? ToEnum(string value)
        {
            return value switch
            {
                "ascii" => StlStorageVariant1.Ascii,
                _ => null,
            };
        }
    }
}