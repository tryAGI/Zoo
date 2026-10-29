#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Identifies the visibility of entities.
    /// </summary>
    public readonly partial struct Visibility : global::System.IEquatable<Visibility>
    {
        /// <summary>
        /// The entity is visible.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.VisibilityVariant1? VisibilityVariant1 { get; init; }
#else
        public global::Zoo.VisibilityVariant1? VisibilityVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VisibilityVariant1))]
#endif
        public bool IsVisibilityVariant1 => VisibilityVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVisibilityVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.VisibilityVariant1? value)
        {
            value = VisibilityVariant1;
            return IsVisibilityVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.VisibilityVariant1 PickVisibilityVariant1() => VisibilityVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VisibilityVariant1' but the value was {ToString()}.");

        /// <summary>
        /// The entity is hidden.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.VisibilityVariant2? VisibilityVariant2 { get; init; }
#else
        public global::Zoo.VisibilityVariant2? VisibilityVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VisibilityVariant2))]
#endif
        public bool IsVisibilityVariant2 => VisibilityVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVisibilityVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.VisibilityVariant2? value)
        {
            value = VisibilityVariant2;
            return IsVisibilityVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.VisibilityVariant2 PickVisibilityVariant2() => VisibilityVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VisibilityVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Visibility(global::Zoo.VisibilityVariant1 value) => new Visibility((global::Zoo.VisibilityVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Zoo.VisibilityVariant1?(Visibility @this) => @this.VisibilityVariant1;

        /// <summary>
        ///
        /// </summary>
        public Visibility(global::Zoo.VisibilityVariant1? value)
        {
            VisibilityVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Visibility FromVisibilityVariant1(global::Zoo.VisibilityVariant1? value) => new Visibility(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Visibility(global::Zoo.VisibilityVariant2 value) => new Visibility((global::Zoo.VisibilityVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Zoo.VisibilityVariant2?(Visibility @this) => @this.VisibilityVariant2;

        /// <summary>
        ///
        /// </summary>
        public Visibility(global::Zoo.VisibilityVariant2? value)
        {
            VisibilityVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Visibility FromVisibilityVariant2(global::Zoo.VisibilityVariant2? value) => new Visibility(value);

        /// <summary>
        ///
        /// </summary>
        public Visibility(
            global::Zoo.VisibilityVariant1? visibilityVariant1,
            global::Zoo.VisibilityVariant2? visibilityVariant2
            )
        {
            VisibilityVariant1 = visibilityVariant1;
            VisibilityVariant2 = visibilityVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            VisibilityVariant2 as object ??
            VisibilityVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            VisibilityVariant1?.ToValueString() ??
            VisibilityVariant2?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsVisibilityVariant1 && !IsVisibilityVariant2 || !IsVisibilityVariant1 && IsVisibilityVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.VisibilityVariant1?, TResult>? visibilityVariant1 = null,
            global::System.Func<global::Zoo.VisibilityVariant2?, TResult>? visibilityVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (VisibilityVariant1 is { } __value0 && visibilityVariant1 != null)
            {
                return visibilityVariant1(__value0);
            }
            else if (VisibilityVariant2 is { } __value1 && visibilityVariant2 != null)
            {
                return visibilityVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.VisibilityVariant1?>? visibilityVariant1 = null,

            global::System.Action<global::Zoo.VisibilityVariant2?>? visibilityVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (VisibilityVariant1 is { } __value0)
            {
                visibilityVariant1?.Invoke(__value0);
            }
            else if (VisibilityVariant2 is { } __value1)
            {
                visibilityVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Zoo.VisibilityVariant1?>? visibilityVariant1 = null,
            global::System.Action<global::Zoo.VisibilityVariant2?>? visibilityVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (VisibilityVariant1 is { } __value0)
            {
                visibilityVariant1?.Invoke(__value0);
            }
            else if (VisibilityVariant2 is { } __value1)
            {
                visibilityVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VisibilityVariant1,
                typeof(global::Zoo.VisibilityVariant1),
                VisibilityVariant2,
                typeof(global::Zoo.VisibilityVariant2),
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
        public bool Equals(Visibility other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.VisibilityVariant1?>.Default.Equals(VisibilityVariant1, other.VisibilityVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.VisibilityVariant2?>.Default.Equals(VisibilityVariant2, other.VisibilityVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Visibility obj1, Visibility obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Visibility>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Visibility obj1, Visibility obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Visibility o && Equals(o);
        }
    }
}
