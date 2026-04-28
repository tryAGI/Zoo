#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// The valid types of length units.
    /// </summary>
    public readonly partial struct UnitLength : global::System.IEquatable<UnitLength>
    {
        /// <summary>
        /// Centimeters &lt;https://en.wikipedia.org/wiki/Centimeter&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitLengthVariant1? UnitLengthVariant1 { get; init; }
#else
        public global::Zoo.UnitLengthVariant1? UnitLengthVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitLengthVariant1))]
#endif
        public bool IsUnitLengthVariant1 => UnitLengthVariant1 != null;

        /// <summary>
        /// Feet &lt;https://en.wikipedia.org/wiki/Foot_(unit)&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitLengthVariant2? UnitLengthVariant2 { get; init; }
#else
        public global::Zoo.UnitLengthVariant2? UnitLengthVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitLengthVariant2))]
#endif
        public bool IsUnitLengthVariant2 => UnitLengthVariant2 != null;

        /// <summary>
        /// Inches &lt;https://en.wikipedia.org/wiki/Inch&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitLengthVariant3? UnitLengthVariant3 { get; init; }
#else
        public global::Zoo.UnitLengthVariant3? UnitLengthVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitLengthVariant3))]
#endif
        public bool IsUnitLengthVariant3 => UnitLengthVariant3 != null;

        /// <summary>
        /// Meters &lt;https://en.wikipedia.org/wiki/Meter&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitLengthVariant4? UnitLengthVariant4 { get; init; }
#else
        public global::Zoo.UnitLengthVariant4? UnitLengthVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitLengthVariant4))]
#endif
        public bool IsUnitLengthVariant4 => UnitLengthVariant4 != null;

        /// <summary>
        /// Millimeters &lt;https://en.wikipedia.org/wiki/Millimeter&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitLengthVariant5? UnitLengthVariant5 { get; init; }
#else
        public global::Zoo.UnitLengthVariant5? UnitLengthVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitLengthVariant5))]
#endif
        public bool IsUnitLengthVariant5 => UnitLengthVariant5 != null;

        /// <summary>
        /// Yards &lt;https://en.wikipedia.org/wiki/Yard&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitLengthVariant6? UnitLengthVariant6 { get; init; }
#else
        public global::Zoo.UnitLengthVariant6? UnitLengthVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitLengthVariant6))]
#endif
        public bool IsUnitLengthVariant6 => UnitLengthVariant6 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitLength(global::Zoo.UnitLengthVariant1 value) => new UnitLength((global::Zoo.UnitLengthVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitLengthVariant1?(UnitLength @this) => @this.UnitLengthVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UnitLength(global::Zoo.UnitLengthVariant1? value)
        {
            UnitLengthVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitLength(global::Zoo.UnitLengthVariant2 value) => new UnitLength((global::Zoo.UnitLengthVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitLengthVariant2?(UnitLength @this) => @this.UnitLengthVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UnitLength(global::Zoo.UnitLengthVariant2? value)
        {
            UnitLengthVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitLength(global::Zoo.UnitLengthVariant3 value) => new UnitLength((global::Zoo.UnitLengthVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitLengthVariant3?(UnitLength @this) => @this.UnitLengthVariant3;

        /// <summary>
        /// 
        /// </summary>
        public UnitLength(global::Zoo.UnitLengthVariant3? value)
        {
            UnitLengthVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitLength(global::Zoo.UnitLengthVariant4 value) => new UnitLength((global::Zoo.UnitLengthVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitLengthVariant4?(UnitLength @this) => @this.UnitLengthVariant4;

        /// <summary>
        /// 
        /// </summary>
        public UnitLength(global::Zoo.UnitLengthVariant4? value)
        {
            UnitLengthVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitLength(global::Zoo.UnitLengthVariant5 value) => new UnitLength((global::Zoo.UnitLengthVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitLengthVariant5?(UnitLength @this) => @this.UnitLengthVariant5;

        /// <summary>
        /// 
        /// </summary>
        public UnitLength(global::Zoo.UnitLengthVariant5? value)
        {
            UnitLengthVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitLength(global::Zoo.UnitLengthVariant6 value) => new UnitLength((global::Zoo.UnitLengthVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitLengthVariant6?(UnitLength @this) => @this.UnitLengthVariant6;

        /// <summary>
        /// 
        /// </summary>
        public UnitLength(global::Zoo.UnitLengthVariant6? value)
        {
            UnitLengthVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UnitLength(
            global::Zoo.UnitLengthVariant1? unitLengthVariant1,
            global::Zoo.UnitLengthVariant2? unitLengthVariant2,
            global::Zoo.UnitLengthVariant3? unitLengthVariant3,
            global::Zoo.UnitLengthVariant4? unitLengthVariant4,
            global::Zoo.UnitLengthVariant5? unitLengthVariant5,
            global::Zoo.UnitLengthVariant6? unitLengthVariant6
            )
        {
            UnitLengthVariant1 = unitLengthVariant1;
            UnitLengthVariant2 = unitLengthVariant2;
            UnitLengthVariant3 = unitLengthVariant3;
            UnitLengthVariant4 = unitLengthVariant4;
            UnitLengthVariant5 = unitLengthVariant5;
            UnitLengthVariant6 = unitLengthVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UnitLengthVariant6 as object ??
            UnitLengthVariant5 as object ??
            UnitLengthVariant4 as object ??
            UnitLengthVariant3 as object ??
            UnitLengthVariant2 as object ??
            UnitLengthVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UnitLengthVariant1?.ToValueString() ??
            UnitLengthVariant2?.ToValueString() ??
            UnitLengthVariant3?.ToValueString() ??
            UnitLengthVariant4?.ToValueString() ??
            UnitLengthVariant5?.ToValueString() ??
            UnitLengthVariant6?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnitLengthVariant1 && !IsUnitLengthVariant2 && !IsUnitLengthVariant3 && !IsUnitLengthVariant4 && !IsUnitLengthVariant5 && !IsUnitLengthVariant6 || !IsUnitLengthVariant1 && IsUnitLengthVariant2 && !IsUnitLengthVariant3 && !IsUnitLengthVariant4 && !IsUnitLengthVariant5 && !IsUnitLengthVariant6 || !IsUnitLengthVariant1 && !IsUnitLengthVariant2 && IsUnitLengthVariant3 && !IsUnitLengthVariant4 && !IsUnitLengthVariant5 && !IsUnitLengthVariant6 || !IsUnitLengthVariant1 && !IsUnitLengthVariant2 && !IsUnitLengthVariant3 && IsUnitLengthVariant4 && !IsUnitLengthVariant5 && !IsUnitLengthVariant6 || !IsUnitLengthVariant1 && !IsUnitLengthVariant2 && !IsUnitLengthVariant3 && !IsUnitLengthVariant4 && IsUnitLengthVariant5 && !IsUnitLengthVariant6 || !IsUnitLengthVariant1 && !IsUnitLengthVariant2 && !IsUnitLengthVariant3 && !IsUnitLengthVariant4 && !IsUnitLengthVariant5 && IsUnitLengthVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.UnitLengthVariant1?, TResult>? unitLengthVariant1 = null,
            global::System.Func<global::Zoo.UnitLengthVariant2?, TResult>? unitLengthVariant2 = null,
            global::System.Func<global::Zoo.UnitLengthVariant3?, TResult>? unitLengthVariant3 = null,
            global::System.Func<global::Zoo.UnitLengthVariant4?, TResult>? unitLengthVariant4 = null,
            global::System.Func<global::Zoo.UnitLengthVariant5?, TResult>? unitLengthVariant5 = null,
            global::System.Func<global::Zoo.UnitLengthVariant6?, TResult>? unitLengthVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnitLengthVariant1 && unitLengthVariant1 != null)
            {
                return unitLengthVariant1(UnitLengthVariant1!);
            }
            else if (IsUnitLengthVariant2 && unitLengthVariant2 != null)
            {
                return unitLengthVariant2(UnitLengthVariant2!);
            }
            else if (IsUnitLengthVariant3 && unitLengthVariant3 != null)
            {
                return unitLengthVariant3(UnitLengthVariant3!);
            }
            else if (IsUnitLengthVariant4 && unitLengthVariant4 != null)
            {
                return unitLengthVariant4(UnitLengthVariant4!);
            }
            else if (IsUnitLengthVariant5 && unitLengthVariant5 != null)
            {
                return unitLengthVariant5(UnitLengthVariant5!);
            }
            else if (IsUnitLengthVariant6 && unitLengthVariant6 != null)
            {
                return unitLengthVariant6(UnitLengthVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.UnitLengthVariant1?>? unitLengthVariant1 = null,
            global::System.Action<global::Zoo.UnitLengthVariant2?>? unitLengthVariant2 = null,
            global::System.Action<global::Zoo.UnitLengthVariant3?>? unitLengthVariant3 = null,
            global::System.Action<global::Zoo.UnitLengthVariant4?>? unitLengthVariant4 = null,
            global::System.Action<global::Zoo.UnitLengthVariant5?>? unitLengthVariant5 = null,
            global::System.Action<global::Zoo.UnitLengthVariant6?>? unitLengthVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnitLengthVariant1)
            {
                unitLengthVariant1?.Invoke(UnitLengthVariant1!);
            }
            else if (IsUnitLengthVariant2)
            {
                unitLengthVariant2?.Invoke(UnitLengthVariant2!);
            }
            else if (IsUnitLengthVariant3)
            {
                unitLengthVariant3?.Invoke(UnitLengthVariant3!);
            }
            else if (IsUnitLengthVariant4)
            {
                unitLengthVariant4?.Invoke(UnitLengthVariant4!);
            }
            else if (IsUnitLengthVariant5)
            {
                unitLengthVariant5?.Invoke(UnitLengthVariant5!);
            }
            else if (IsUnitLengthVariant6)
            {
                unitLengthVariant6?.Invoke(UnitLengthVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnitLengthVariant1,
                typeof(global::Zoo.UnitLengthVariant1),
                UnitLengthVariant2,
                typeof(global::Zoo.UnitLengthVariant2),
                UnitLengthVariant3,
                typeof(global::Zoo.UnitLengthVariant3),
                UnitLengthVariant4,
                typeof(global::Zoo.UnitLengthVariant4),
                UnitLengthVariant5,
                typeof(global::Zoo.UnitLengthVariant5),
                UnitLengthVariant6,
                typeof(global::Zoo.UnitLengthVariant6),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(UnitLength other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitLengthVariant1?>.Default.Equals(UnitLengthVariant1, other.UnitLengthVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitLengthVariant2?>.Default.Equals(UnitLengthVariant2, other.UnitLengthVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitLengthVariant3?>.Default.Equals(UnitLengthVariant3, other.UnitLengthVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitLengthVariant4?>.Default.Equals(UnitLengthVariant4, other.UnitLengthVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitLengthVariant5?>.Default.Equals(UnitLengthVariant5, other.UnitLengthVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitLengthVariant6?>.Default.Equals(UnitLengthVariant6, other.UnitLengthVariant6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UnitLength obj1, UnitLength obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnitLength>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UnitLength obj1, UnitLength obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnitLength o && Equals(o);
        }
    }
}
