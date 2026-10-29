#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Data item selection.
    /// </summary>
    public readonly partial struct Projection : global::System.IEquatable<Projection>
    {
        /// <summary>
        /// Orthographic (parallel) projection.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.ProjectionVariant1? ProjectionVariant1 { get; init; }
#else
        public global::Zoo.ProjectionVariant1? ProjectionVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProjectionVariant1))]
#endif
        public bool IsProjectionVariant1 => ProjectionVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProjectionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.ProjectionVariant1? value)
        {
            value = ProjectionVariant1;
            return IsProjectionVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.ProjectionVariant1 PickProjectionVariant1() => ProjectionVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProjectionVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Perspective projection.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.ProjectionVariant2? ProjectionVariant2 { get; init; }
#else
        public global::Zoo.ProjectionVariant2? ProjectionVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProjectionVariant2))]
#endif
        public bool IsProjectionVariant2 => ProjectionVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProjectionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.ProjectionVariant2? value)
        {
            value = ProjectionVariant2;
            return IsProjectionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.ProjectionVariant2 PickProjectionVariant2() => ProjectionVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProjectionVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Projection(global::Zoo.ProjectionVariant1 value) => new Projection((global::Zoo.ProjectionVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Zoo.ProjectionVariant1?(Projection @this) => @this.ProjectionVariant1;

        /// <summary>
        ///
        /// </summary>
        public Projection(global::Zoo.ProjectionVariant1? value)
        {
            ProjectionVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Projection FromProjectionVariant1(global::Zoo.ProjectionVariant1? value) => new Projection(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Projection(global::Zoo.ProjectionVariant2 value) => new Projection((global::Zoo.ProjectionVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Zoo.ProjectionVariant2?(Projection @this) => @this.ProjectionVariant2;

        /// <summary>
        ///
        /// </summary>
        public Projection(global::Zoo.ProjectionVariant2? value)
        {
            ProjectionVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Projection FromProjectionVariant2(global::Zoo.ProjectionVariant2? value) => new Projection(value);

        /// <summary>
        ///
        /// </summary>
        public Projection(
            global::Zoo.ProjectionVariant1? projectionVariant1,
            global::Zoo.ProjectionVariant2? projectionVariant2
            )
        {
            ProjectionVariant1 = projectionVariant1;
            ProjectionVariant2 = projectionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ProjectionVariant2 as object ??
            ProjectionVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ProjectionVariant1?.ToString() ??
            ProjectionVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsProjectionVariant1 && !IsProjectionVariant2 || !IsProjectionVariant1 && IsProjectionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.ProjectionVariant1, TResult>? projectionVariant1 = null,
            global::System.Func<global::Zoo.ProjectionVariant2, TResult>? projectionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ProjectionVariant1 is { } __value0 && projectionVariant1 != null)
            {
                return projectionVariant1(__value0);
            }
            else if (ProjectionVariant2 is { } __value1 && projectionVariant2 != null)
            {
                return projectionVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.ProjectionVariant1>? projectionVariant1 = null,

            global::System.Action<global::Zoo.ProjectionVariant2>? projectionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ProjectionVariant1 is { } __value0)
            {
                projectionVariant1?.Invoke(__value0);
            }
            else if (ProjectionVariant2 is { } __value1)
            {
                projectionVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Zoo.ProjectionVariant1>? projectionVariant1 = null,
            global::System.Action<global::Zoo.ProjectionVariant2>? projectionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ProjectionVariant1 is { } __value0)
            {
                projectionVariant1?.Invoke(__value0);
            }
            else if (ProjectionVariant2 is { } __value1)
            {
                projectionVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ProjectionVariant1,
                typeof(global::Zoo.ProjectionVariant1),
                ProjectionVariant2,
                typeof(global::Zoo.ProjectionVariant2),
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
        public bool Equals(Projection other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.ProjectionVariant1?>.Default.Equals(ProjectionVariant1, other.ProjectionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.ProjectionVariant2?>.Default.Equals(ProjectionVariant2, other.ProjectionVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Projection obj1, Projection obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Projection>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Projection obj1, Projection obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Projection o && Equals(o);
        }
    }
}
