#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// The valid types of mass units.
    /// </summary>
    public readonly partial struct UnitMass : global::System.IEquatable<UnitMass>
    {
        /// <summary>
        /// Grams &lt;https://en.wikipedia.org/wiki/Gram&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitMassVariant1? UnitMassVariant1 { get; init; }
#else
        public global::Zoo.UnitMassVariant1? UnitMassVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitMassVariant1))]
#endif
        public bool IsUnitMassVariant1 => UnitMassVariant1 != null;

        /// <summary>
        /// Kilograms &lt;https://en.wikipedia.org/wiki/Kilogram&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitMassVariant2? UnitMassVariant2 { get; init; }
#else
        public global::Zoo.UnitMassVariant2? UnitMassVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitMassVariant2))]
#endif
        public bool IsUnitMassVariant2 => UnitMassVariant2 != null;

        /// <summary>
        /// Pounds &lt;https://en.wikipedia.org/wiki/Pound_(mass)&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitMassVariant3? UnitMassVariant3 { get; init; }
#else
        public global::Zoo.UnitMassVariant3? UnitMassVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitMassVariant3))]
#endif
        public bool IsUnitMassVariant3 => UnitMassVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitMass(global::Zoo.UnitMassVariant1 value) => new UnitMass((global::Zoo.UnitMassVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitMassVariant1?(UnitMass @this) => @this.UnitMassVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UnitMass(global::Zoo.UnitMassVariant1? value)
        {
            UnitMassVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitMass(global::Zoo.UnitMassVariant2 value) => new UnitMass((global::Zoo.UnitMassVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitMassVariant2?(UnitMass @this) => @this.UnitMassVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UnitMass(global::Zoo.UnitMassVariant2? value)
        {
            UnitMassVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitMass(global::Zoo.UnitMassVariant3 value) => new UnitMass((global::Zoo.UnitMassVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitMassVariant3?(UnitMass @this) => @this.UnitMassVariant3;

        /// <summary>
        /// 
        /// </summary>
        public UnitMass(global::Zoo.UnitMassVariant3? value)
        {
            UnitMassVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UnitMass(
            global::Zoo.UnitMassVariant1? unitMassVariant1,
            global::Zoo.UnitMassVariant2? unitMassVariant2,
            global::Zoo.UnitMassVariant3? unitMassVariant3
            )
        {
            UnitMassVariant1 = unitMassVariant1;
            UnitMassVariant2 = unitMassVariant2;
            UnitMassVariant3 = unitMassVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UnitMassVariant3 as object ??
            UnitMassVariant2 as object ??
            UnitMassVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UnitMassVariant1?.ToValueString() ??
            UnitMassVariant2?.ToValueString() ??
            UnitMassVariant3?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnitMassVariant1 && !IsUnitMassVariant2 && !IsUnitMassVariant3 || !IsUnitMassVariant1 && IsUnitMassVariant2 && !IsUnitMassVariant3 || !IsUnitMassVariant1 && !IsUnitMassVariant2 && IsUnitMassVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.UnitMassVariant1?, TResult>? unitMassVariant1 = null,
            global::System.Func<global::Zoo.UnitMassVariant2?, TResult>? unitMassVariant2 = null,
            global::System.Func<global::Zoo.UnitMassVariant3?, TResult>? unitMassVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnitMassVariant1 && unitMassVariant1 != null)
            {
                return unitMassVariant1(UnitMassVariant1!);
            }
            else if (IsUnitMassVariant2 && unitMassVariant2 != null)
            {
                return unitMassVariant2(UnitMassVariant2!);
            }
            else if (IsUnitMassVariant3 && unitMassVariant3 != null)
            {
                return unitMassVariant3(UnitMassVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.UnitMassVariant1?>? unitMassVariant1 = null,
            global::System.Action<global::Zoo.UnitMassVariant2?>? unitMassVariant2 = null,
            global::System.Action<global::Zoo.UnitMassVariant3?>? unitMassVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnitMassVariant1)
            {
                unitMassVariant1?.Invoke(UnitMassVariant1!);
            }
            else if (IsUnitMassVariant2)
            {
                unitMassVariant2?.Invoke(UnitMassVariant2!);
            }
            else if (IsUnitMassVariant3)
            {
                unitMassVariant3?.Invoke(UnitMassVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnitMassVariant1,
                typeof(global::Zoo.UnitMassVariant1),
                UnitMassVariant2,
                typeof(global::Zoo.UnitMassVariant2),
                UnitMassVariant3,
                typeof(global::Zoo.UnitMassVariant3),
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
        public bool Equals(UnitMass other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitMassVariant1?>.Default.Equals(UnitMassVariant1, other.UnitMassVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitMassVariant2?>.Default.Equals(UnitMassVariant2, other.UnitMassVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitMassVariant3?>.Default.Equals(UnitMassVariant3, other.UnitMassVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UnitMass obj1, UnitMass obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnitMass>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UnitMass obj1, UnitMass obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnitMass o && Equals(o);
        }
    }
}
