#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Co-ordinate axis specifier.<br/>
    /// See [cglearn.eu] for background reading.<br/>
    /// [cglearn.eu]: https://cglearn.eu/pub/computer-graphics/introduction-to-geometry#material-coordinate-systems-1
    /// </summary>
    public readonly partial struct Axis : global::System.IEquatable<Axis>
    {
        /// <summary>
        /// 'Y' axis.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.AxisVariant1? AxisVariant1 { get; init; }
#else
        public global::Zoo.AxisVariant1? AxisVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AxisVariant1))]
#endif
        public bool IsAxisVariant1 => AxisVariant1 != null;

        /// <summary>
        /// 'Z' axis.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.AxisVariant2? AxisVariant2 { get; init; }
#else
        public global::Zoo.AxisVariant2? AxisVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AxisVariant2))]
#endif
        public bool IsAxisVariant2 => AxisVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Axis(global::Zoo.AxisVariant1 value) => new Axis((global::Zoo.AxisVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.AxisVariant1?(Axis @this) => @this.AxisVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Axis(global::Zoo.AxisVariant1? value)
        {
            AxisVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Axis(global::Zoo.AxisVariant2 value) => new Axis((global::Zoo.AxisVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.AxisVariant2?(Axis @this) => @this.AxisVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Axis(global::Zoo.AxisVariant2? value)
        {
            AxisVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Axis(
            global::Zoo.AxisVariant1? axisVariant1,
            global::Zoo.AxisVariant2? axisVariant2
            )
        {
            AxisVariant1 = axisVariant1;
            AxisVariant2 = axisVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AxisVariant2 as object ??
            AxisVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AxisVariant1?.ToValueString() ??
            AxisVariant2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAxisVariant1 && !IsAxisVariant2 || !IsAxisVariant1 && IsAxisVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.AxisVariant1?, TResult>? axisVariant1 = null,
            global::System.Func<global::Zoo.AxisVariant2?, TResult>? axisVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAxisVariant1 && axisVariant1 != null)
            {
                return axisVariant1(AxisVariant1!);
            }
            else if (IsAxisVariant2 && axisVariant2 != null)
            {
                return axisVariant2(AxisVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.AxisVariant1?>? axisVariant1 = null,
            global::System.Action<global::Zoo.AxisVariant2?>? axisVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAxisVariant1)
            {
                axisVariant1?.Invoke(AxisVariant1!);
            }
            else if (IsAxisVariant2)
            {
                axisVariant2?.Invoke(AxisVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AxisVariant1,
                typeof(global::Zoo.AxisVariant1),
                AxisVariant2,
                typeof(global::Zoo.AxisVariant2),
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
        public bool Equals(Axis other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.AxisVariant1?>.Default.Equals(AxisVariant1, other.AxisVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.AxisVariant2?>.Default.Equals(AxisVariant2, other.AxisVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Axis obj1, Axis obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Axis>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Axis obj1, Axis obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Axis o && Equals(o);
        }
    }
}
