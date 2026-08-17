#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// After importing, how should this model's data be represented?
    /// </summary>
    public readonly partial struct StepImportTargetRepresentation : global::System.IEquatable<StepImportTargetRepresentation>
    {
        /// <summary>
        /// Mesh of 2D geometry
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.StepImportTargetRepresentationVariant1? StepImportTargetRepresentationVariant1 { get; init; }
#else
        public global::Zoo.StepImportTargetRepresentationVariant1? StepImportTargetRepresentationVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepImportTargetRepresentationVariant1))]
#endif
        public bool IsStepImportTargetRepresentationVariant1 => StepImportTargetRepresentationVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStepImportTargetRepresentationVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.StepImportTargetRepresentationVariant1? value)
        {
            value = StepImportTargetRepresentationVariant1;
            return IsStepImportTargetRepresentationVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.StepImportTargetRepresentationVariant1 PickStepImportTargetRepresentationVariant1() => IsStepImportTargetRepresentationVariant1
            ? StepImportTargetRepresentationVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepImportTargetRepresentationVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Boundary representation
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.StepImportTargetRepresentationVariant2? StepImportTargetRepresentationVariant2 { get; init; }
#else
        public global::Zoo.StepImportTargetRepresentationVariant2? StepImportTargetRepresentationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepImportTargetRepresentationVariant2))]
#endif
        public bool IsStepImportTargetRepresentationVariant2 => StepImportTargetRepresentationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStepImportTargetRepresentationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.StepImportTargetRepresentationVariant2? value)
        {
            value = StepImportTargetRepresentationVariant2;
            return IsStepImportTargetRepresentationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.StepImportTargetRepresentationVariant2 PickStepImportTargetRepresentationVariant2() => IsStepImportTargetRepresentationVariant2
            ? StepImportTargetRepresentationVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepImportTargetRepresentationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepImportTargetRepresentation(global::Zoo.StepImportTargetRepresentationVariant1 value) => new StepImportTargetRepresentation((global::Zoo.StepImportTargetRepresentationVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.StepImportTargetRepresentationVariant1?(StepImportTargetRepresentation @this) => @this.StepImportTargetRepresentationVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StepImportTargetRepresentation(global::Zoo.StepImportTargetRepresentationVariant1? value)
        {
            StepImportTargetRepresentationVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StepImportTargetRepresentation FromStepImportTargetRepresentationVariant1(global::Zoo.StepImportTargetRepresentationVariant1? value) => new StepImportTargetRepresentation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepImportTargetRepresentation(global::Zoo.StepImportTargetRepresentationVariant2 value) => new StepImportTargetRepresentation((global::Zoo.StepImportTargetRepresentationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.StepImportTargetRepresentationVariant2?(StepImportTargetRepresentation @this) => @this.StepImportTargetRepresentationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StepImportTargetRepresentation(global::Zoo.StepImportTargetRepresentationVariant2? value)
        {
            StepImportTargetRepresentationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StepImportTargetRepresentation FromStepImportTargetRepresentationVariant2(global::Zoo.StepImportTargetRepresentationVariant2? value) => new StepImportTargetRepresentation(value);

        /// <summary>
        /// 
        /// </summary>
        public StepImportTargetRepresentation(
            global::Zoo.StepImportTargetRepresentationVariant1? stepImportTargetRepresentationVariant1,
            global::Zoo.StepImportTargetRepresentationVariant2? stepImportTargetRepresentationVariant2
            )
        {
            StepImportTargetRepresentationVariant1 = stepImportTargetRepresentationVariant1;
            StepImportTargetRepresentationVariant2 = stepImportTargetRepresentationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StepImportTargetRepresentationVariant2 as object ??
            StepImportTargetRepresentationVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StepImportTargetRepresentationVariant1?.ToValueString() ??
            StepImportTargetRepresentationVariant2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStepImportTargetRepresentationVariant1 && !IsStepImportTargetRepresentationVariant2 || !IsStepImportTargetRepresentationVariant1 && IsStepImportTargetRepresentationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.StepImportTargetRepresentationVariant1?, TResult>? stepImportTargetRepresentationVariant1 = null,
            global::System.Func<global::Zoo.StepImportTargetRepresentationVariant2?, TResult>? stepImportTargetRepresentationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStepImportTargetRepresentationVariant1 && stepImportTargetRepresentationVariant1 != null)
            {
                return stepImportTargetRepresentationVariant1(StepImportTargetRepresentationVariant1!);
            }
            else if (IsStepImportTargetRepresentationVariant2 && stepImportTargetRepresentationVariant2 != null)
            {
                return stepImportTargetRepresentationVariant2(StepImportTargetRepresentationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.StepImportTargetRepresentationVariant1?>? stepImportTargetRepresentationVariant1 = null,

            global::System.Action<global::Zoo.StepImportTargetRepresentationVariant2?>? stepImportTargetRepresentationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStepImportTargetRepresentationVariant1)
            {
                stepImportTargetRepresentationVariant1?.Invoke(StepImportTargetRepresentationVariant1!);
            }
            else if (IsStepImportTargetRepresentationVariant2)
            {
                stepImportTargetRepresentationVariant2?.Invoke(StepImportTargetRepresentationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Zoo.StepImportTargetRepresentationVariant1?>? stepImportTargetRepresentationVariant1 = null,
            global::System.Action<global::Zoo.StepImportTargetRepresentationVariant2?>? stepImportTargetRepresentationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStepImportTargetRepresentationVariant1)
            {
                stepImportTargetRepresentationVariant1?.Invoke(StepImportTargetRepresentationVariant1!);
            }
            else if (IsStepImportTargetRepresentationVariant2)
            {
                stepImportTargetRepresentationVariant2?.Invoke(StepImportTargetRepresentationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StepImportTargetRepresentationVariant1,
                typeof(global::Zoo.StepImportTargetRepresentationVariant1),
                StepImportTargetRepresentationVariant2,
                typeof(global::Zoo.StepImportTargetRepresentationVariant2),
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
        public bool Equals(StepImportTargetRepresentation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.StepImportTargetRepresentationVariant1?>.Default.Equals(StepImportTargetRepresentationVariant1, other.StepImportTargetRepresentationVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.StepImportTargetRepresentationVariant2?>.Default.Equals(StepImportTargetRepresentationVariant2, other.StepImportTargetRepresentationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StepImportTargetRepresentation obj1, StepImportTargetRepresentation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepImportTargetRepresentation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StepImportTargetRepresentation obj1, StepImportTargetRepresentation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepImportTargetRepresentation o && Equals(o);
        }
    }
}
