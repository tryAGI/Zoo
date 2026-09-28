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
        ///
        /// </summary>
        public bool TryPickCreatedAtSortModeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.CreatedAtSortModeVariant1? value)
        {
            value = CreatedAtSortModeVariant1;
            return IsCreatedAtSortModeVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.CreatedAtSortModeVariant1 PickCreatedAtSortModeVariant1() => CreatedAtSortModeVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreatedAtSortModeVariant1' but the value was {ToString()}.");

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
        public bool TryPickCreatedAtSortModeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.CreatedAtSortModeVariant2? value)
        {
            value = CreatedAtSortModeVariant2;
            return IsCreatedAtSortModeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.CreatedAtSortModeVariant2 PickCreatedAtSortModeVariant2() => CreatedAtSortModeVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreatedAtSortModeVariant2' but the value was {ToString()}.");
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
        public static CreatedAtSortMode FromCreatedAtSortModeVariant1(global::Zoo.CreatedAtSortModeVariant1? value) => new CreatedAtSortMode(value);

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
        public static CreatedAtSortMode FromCreatedAtSortModeVariant2(global::Zoo.CreatedAtSortModeVariant2? value) => new CreatedAtSortMode(value);

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

            if (CreatedAtSortModeVariant1 is { } __value0 && createdAtSortModeVariant1 != null)
            {
                return createdAtSortModeVariant1(__value0);
            }
            else if (CreatedAtSortModeVariant2 is { } __value1 && createdAtSortModeVariant2 != null)
            {
                return createdAtSortModeVariant2(__value1);
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

            if (CreatedAtSortModeVariant1 is { } __value0)
            {
                createdAtSortModeVariant1?.Invoke(__value0);
            }
            else if (CreatedAtSortModeVariant2 is { } __value1)
            {
                createdAtSortModeVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Zoo.CreatedAtSortModeVariant1?>? createdAtSortModeVariant1 = null,
            global::System.Action<global::Zoo.CreatedAtSortModeVariant2?>? createdAtSortModeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreatedAtSortModeVariant1 is { } __value0)
            {
                createdAtSortModeVariant1?.Invoke(__value0);
            }
            else if (CreatedAtSortModeVariant2 is { } __value1)
            {
                createdAtSortModeVariant2?.Invoke(__value1);
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
