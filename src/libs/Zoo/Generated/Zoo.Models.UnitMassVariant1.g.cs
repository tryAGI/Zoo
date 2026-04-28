
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Grams &lt;https://en.wikipedia.org/wiki/Gram&gt;
    /// </summary>
    public enum UnitMassVariant1
    {
        /// <summary>
        /// //en.wikipedia.org/wiki/Gram&gt;
        /// </summary>
        G,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitMassVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitMassVariant1 value)
        {
            return value switch
            {
                UnitMassVariant1.G => "g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitMassVariant1? ToEnum(string value)
        {
            return value switch
            {
                "g" => UnitMassVariant1.G,
                _ => null,
            };
        }
    }
}