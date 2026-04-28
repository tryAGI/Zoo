
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Write numbers in their ascii representation (e.g. -13, 6.28, etc.). Properties are separated by spaces and elements are separated by line breaks.
    /// </summary>
    public enum PlyStorageVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Ascii,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlyStorageVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlyStorageVariant1 value)
        {
            return value switch
            {
                PlyStorageVariant1.Ascii => "ascii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlyStorageVariant1? ToEnum(string value)
        {
            return value switch
            {
                "ascii" => PlyStorageVariant1.Ascii,
                _ => null,
            };
        }
    }
}