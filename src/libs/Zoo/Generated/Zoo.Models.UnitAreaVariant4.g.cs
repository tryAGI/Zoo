
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Square inches &lt;https://en.wikipedia.org/wiki/Square_inch&gt;
    /// </summary>
    public enum UnitAreaVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        In2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitAreaVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitAreaVariant4 value)
        {
            return value switch
            {
                UnitAreaVariant4.In2 => "in2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitAreaVariant4? ToEnum(string value)
        {
            return value switch
            {
                "in2" => UnitAreaVariant4.In2,
                _ => null,
            };
        }
    }
}