
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Meters &lt;https://en.wikipedia.org/wiki/Meter&gt;
    /// </summary>
    public enum UnitLengthVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        M,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitLengthVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitLengthVariant4 value)
        {
            return value switch
            {
                UnitLengthVariant4.M => "m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitLengthVariant4? ToEnum(string value)
        {
            return value switch
            {
                "m" => UnitLengthVariant4.M,
                _ => null,
            };
        }
    }
}