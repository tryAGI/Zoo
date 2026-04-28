
#nullable enable

namespace Zoo
{
    /// <summary>
    /// ASCII FBX encoding.
    /// </summary>
    public enum FbxStorageVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Ascii,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FbxStorageVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FbxStorageVariant1 value)
        {
            return value switch
            {
                FbxStorageVariant1.Ascii => "ascii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FbxStorageVariant1? ToEnum(string value)
        {
            return value switch
            {
                "ascii" => FbxStorageVariant1.Ascii,
                _ => null,
            };
        }
    }
}