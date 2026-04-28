#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Specifies the sign of a co-ordinate axis.
    /// </summary>
    public readonly partial struct Direction : global::System.IEquatable<Direction>
    {
        /// <summary>
        /// Increasing numbers.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.DirectionVariant1? DirectionVariant1 { get; init; }
#else
        public global::Zoo.DirectionVariant1? DirectionVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DirectionVariant1))]
#endif
        public bool IsDirectionVariant1 => DirectionVariant1 != null;

        /// <summary>
        /// Decreasing numbers.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.DirectionVariant2? DirectionVariant2 { get; init; }
#else
        public global::Zoo.DirectionVariant2? DirectionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DirectionVariant2))]
#endif
        public bool IsDirectionVariant2 => DirectionVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Direction(global::Zoo.DirectionVariant1 value) => new Direction((global::Zoo.DirectionVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.DirectionVariant1?(Direction @this) => @this.DirectionVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Direction(global::Zoo.DirectionVariant1? value)
        {
            DirectionVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Direction(global::Zoo.DirectionVariant2 value) => new Direction((global::Zoo.DirectionVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.DirectionVariant2?(Direction @this) => @this.DirectionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Direction(global::Zoo.DirectionVariant2? value)
        {
            DirectionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Direction(
            global::Zoo.DirectionVariant1? directionVariant1,
            global::Zoo.DirectionVariant2? directionVariant2
            )
        {
            DirectionVariant1 = directionVariant1;
            DirectionVariant2 = directionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DirectionVariant2 as object ??
            DirectionVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DirectionVariant1?.ToValueString() ??
            DirectionVariant2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDirectionVariant1 && !IsDirectionVariant2 || !IsDirectionVariant1 && IsDirectionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.DirectionVariant1?, TResult>? directionVariant1 = null,
            global::System.Func<global::Zoo.DirectionVariant2?, TResult>? directionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDirectionVariant1 && directionVariant1 != null)
            {
                return directionVariant1(DirectionVariant1!);
            }
            else if (IsDirectionVariant2 && directionVariant2 != null)
            {
                return directionVariant2(DirectionVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.DirectionVariant1?>? directionVariant1 = null,
            global::System.Action<global::Zoo.DirectionVariant2?>? directionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDirectionVariant1)
            {
                directionVariant1?.Invoke(DirectionVariant1!);
            }
            else if (IsDirectionVariant2)
            {
                directionVariant2?.Invoke(DirectionVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DirectionVariant1,
                typeof(global::Zoo.DirectionVariant1),
                DirectionVariant2,
                typeof(global::Zoo.DirectionVariant2),
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
        public bool Equals(Direction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.DirectionVariant1?>.Default.Equals(DirectionVariant1, other.DirectionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.DirectionVariant2?>.Default.Equals(DirectionVariant2, other.DirectionVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Direction obj1, Direction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Direction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Direction obj1, Direction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Direction o && Equals(o);
        }
    }
}
