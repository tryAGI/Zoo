#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Supported set of sort modes for scanning by created_at only.<br/>
    /// Currently, we only support scanning in ascending order.
    /// </summary>
    public readonly partial struct CreatedAtSortMode : global::System.IEquatable<CreatedAtSortMode>
    {
        /// <summary>
        /// Sort in increasing order of "created_at".
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.CreatedAtSortModeVariant1? CreatedAtSortModeVariant1 { get; init; }
#else
        public global::Zoo.CreatedAtSortModeVariant1? CreatedAtSortModeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreatedAtSortModeVariant1))]
#endif
        public bool IsCreatedAtSortModeVariant1 => CreatedAtSortModeVariant1 != null;

        /// <summary>
        /// Sort in decreasing order of "created_at".
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.CreatedAtSortModeVariant2? CreatedAtSortModeVariant2 { get; init; }
#else
        public global::Zoo.CreatedAtSortModeVariant2? CreatedAtSortModeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreatedAtSortModeVariant2))]
#endif
        public bool IsCreatedAtSortModeVariant2 => CreatedAtSortModeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreatedAtSortMode(global::Zoo.CreatedAtSortModeVariant1 value) => new CreatedAtSortMode((global::Zoo.CreatedAtSortModeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.CreatedAtSortModeVariant1?(CreatedAtSortMode @this) => @this.CreatedAtSortModeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CreatedAtSortMode(global::Zoo.CreatedAtSortModeVariant1? value)
        {
            CreatedAtSortModeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreatedAtSortMode(global::Zoo.CreatedAtSortModeVariant2 value) => new CreatedAtSortMode((global::Zoo.CreatedAtSortModeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.CreatedAtSortModeVariant2?(CreatedAtSortMode @this) => @this.CreatedAtSortModeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreatedAtSortMode(global::Zoo.CreatedAtSortModeVariant2? value)
        {
            CreatedAtSortModeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreatedAtSortMode(
            global::Zoo.CreatedAtSortModeVariant1? createdAtSortModeVariant1,
            global::Zoo.CreatedAtSortModeVariant2? createdAtSortModeVariant2
            )
        {
            CreatedAtSortModeVariant1 = createdAtSortModeVariant1;
            CreatedAtSortModeVariant2 = createdAtSortModeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreatedAtSortModeVariant2 as object ??
            CreatedAtSortModeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreatedAtSortModeVariant1?.ToValueString() ??
            CreatedAtSortModeVariant2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreatedAtSortModeVariant1 && !IsCreatedAtSortModeVariant2 || !IsCreatedAtSortModeVariant1 && IsCreatedAtSortModeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.CreatedAtSortModeVariant1?, TResult>? createdAtSortModeVariant1 = null,
            global::System.Func<global::Zoo.CreatedAtSortModeVariant2?, TResult>? createdAtSortModeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreatedAtSortModeVariant1 && createdAtSortModeVariant1 != null)
            {
                return createdAtSortModeVariant1(CreatedAtSortModeVariant1!);
            }
            else if (IsCreatedAtSortModeVariant2 && createdAtSortModeVariant2 != null)
            {
                return createdAtSortModeVariant2(CreatedAtSortModeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.CreatedAtSortModeVariant1?>? createdAtSortModeVariant1 = null,
            global::System.Action<global::Zoo.CreatedAtSortModeVariant2?>? createdAtSortModeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreatedAtSortModeVariant1)
            {
                createdAtSortModeVariant1?.Invoke(CreatedAtSortModeVariant1!);
            }
            else if (IsCreatedAtSortModeVariant2)
            {
                createdAtSortModeVariant2?.Invoke(CreatedAtSortModeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreatedAtSortModeVariant1,
                typeof(global::Zoo.CreatedAtSortModeVariant1),
                CreatedAtSortModeVariant2,
                typeof(global::Zoo.CreatedAtSortModeVariant2),
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
        public bool Equals(CreatedAtSortMode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.CreatedAtSortModeVariant1?>.Default.Equals(CreatedAtSortModeVariant1, other.CreatedAtSortModeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.CreatedAtSortModeVariant2?>.Default.Equals(CreatedAtSortModeVariant2, other.CreatedAtSortModeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreatedAtSortMode obj1, CreatedAtSortMode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreatedAtSortMode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreatedAtSortMode obj1, CreatedAtSortMode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreatedAtSortMode o && Equals(o);
        }
    }
}
