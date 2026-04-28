#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// The valid types for density units.
    /// </summary>
    public readonly partial struct UnitDensity : global::System.IEquatable<UnitDensity>
    {
        /// <summary>
        /// Pounds per cubic feet.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitDensityVariant1? UnitDensityVariant1 { get; init; }
#else
        public global::Zoo.UnitDensityVariant1? UnitDensityVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitDensityVariant1))]
#endif
        public bool IsUnitDensityVariant1 => UnitDensityVariant1 != null;

        /// <summary>
        /// Kilograms per cubic meter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitDensityVariant2? UnitDensityVariant2 { get; init; }
#else
        public global::Zoo.UnitDensityVariant2? UnitDensityVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitDensityVariant2))]
#endif
        public bool IsUnitDensityVariant2 => UnitDensityVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitDensity(global::Zoo.UnitDensityVariant1 value) => new UnitDensity((global::Zoo.UnitDensityVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitDensityVariant1?(UnitDensity @this) => @this.UnitDensityVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UnitDensity(global::Zoo.UnitDensityVariant1? value)
        {
            UnitDensityVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitDensity(global::Zoo.UnitDensityVariant2 value) => new UnitDensity((global::Zoo.UnitDensityVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitDensityVariant2?(UnitDensity @this) => @this.UnitDensityVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UnitDensity(global::Zoo.UnitDensityVariant2? value)
        {
            UnitDensityVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UnitDensity(
            global::Zoo.UnitDensityVariant1? unitDensityVariant1,
            global::Zoo.UnitDensityVariant2? unitDensityVariant2
            )
        {
            UnitDensityVariant1 = unitDensityVariant1;
            UnitDensityVariant2 = unitDensityVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UnitDensityVariant2 as object ??
            UnitDensityVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UnitDensityVariant1?.ToValueString() ??
            UnitDensityVariant2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnitDensityVariant1 && !IsUnitDensityVariant2 || !IsUnitDensityVariant1 && IsUnitDensityVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.UnitDensityVariant1?, TResult>? unitDensityVariant1 = null,
            global::System.Func<global::Zoo.UnitDensityVariant2?, TResult>? unitDensityVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnitDensityVariant1 && unitDensityVariant1 != null)
            {
                return unitDensityVariant1(UnitDensityVariant1!);
            }
            else if (IsUnitDensityVariant2 && unitDensityVariant2 != null)
            {
                return unitDensityVariant2(UnitDensityVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.UnitDensityVariant1?>? unitDensityVariant1 = null,
            global::System.Action<global::Zoo.UnitDensityVariant2?>? unitDensityVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnitDensityVariant1)
            {
                unitDensityVariant1?.Invoke(UnitDensityVariant1!);
            }
            else if (IsUnitDensityVariant2)
            {
                unitDensityVariant2?.Invoke(UnitDensityVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnitDensityVariant1,
                typeof(global::Zoo.UnitDensityVariant1),
                UnitDensityVariant2,
                typeof(global::Zoo.UnitDensityVariant2),
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
        public bool Equals(UnitDensity other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitDensityVariant1?>.Default.Equals(UnitDensityVariant1, other.UnitDensityVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitDensityVariant2?>.Default.Equals(UnitDensityVariant2, other.UnitDensityVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UnitDensity obj1, UnitDensity obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnitDensity>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UnitDensity obj1, UnitDensity obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnitDensity o && Equals(o);
        }
    }
}
