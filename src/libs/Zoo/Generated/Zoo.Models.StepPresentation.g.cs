#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Describes the presentation style of the EXPRESS exchange format.
    /// </summary>
    public readonly partial struct StepPresentation : global::System.IEquatable<StepPresentation>
    {
        /// <summary>
        /// Condenses the text to reduce the size of the file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.StepPresentationVariant1? StepPresentationVariant1 { get; init; }
#else
        public global::Zoo.StepPresentationVariant1? StepPresentationVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepPresentationVariant1))]
#endif
        public bool IsStepPresentationVariant1 => StepPresentationVariant1 != null;

        /// <summary>
        /// Add extra spaces to make the text more easily readable.<br/>
        /// This is the default setting.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.StepPresentationVariant2? StepPresentationVariant2 { get; init; }
#else
        public global::Zoo.StepPresentationVariant2? StepPresentationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepPresentationVariant2))]
#endif
        public bool IsStepPresentationVariant2 => StepPresentationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepPresentation(global::Zoo.StepPresentationVariant1 value) => new StepPresentation((global::Zoo.StepPresentationVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.StepPresentationVariant1?(StepPresentation @this) => @this.StepPresentationVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StepPresentation(global::Zoo.StepPresentationVariant1? value)
        {
            StepPresentationVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepPresentation(global::Zoo.StepPresentationVariant2 value) => new StepPresentation((global::Zoo.StepPresentationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.StepPresentationVariant2?(StepPresentation @this) => @this.StepPresentationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StepPresentation(global::Zoo.StepPresentationVariant2? value)
        {
            StepPresentationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StepPresentation(
            global::Zoo.StepPresentationVariant1? stepPresentationVariant1,
            global::Zoo.StepPresentationVariant2? stepPresentationVariant2
            )
        {
            StepPresentationVariant1 = stepPresentationVariant1;
            StepPresentationVariant2 = stepPresentationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StepPresentationVariant2 as object ??
            StepPresentationVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StepPresentationVariant1?.ToValueString() ??
            StepPresentationVariant2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStepPresentationVariant1 && !IsStepPresentationVariant2 || !IsStepPresentationVariant1 && IsStepPresentationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.StepPresentationVariant1?, TResult>? stepPresentationVariant1 = null,
            global::System.Func<global::Zoo.StepPresentationVariant2?, TResult>? stepPresentationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStepPresentationVariant1 && stepPresentationVariant1 != null)
            {
                return stepPresentationVariant1(StepPresentationVariant1!);
            }
            else if (IsStepPresentationVariant2 && stepPresentationVariant2 != null)
            {
                return stepPresentationVariant2(StepPresentationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.StepPresentationVariant1?>? stepPresentationVariant1 = null,
            global::System.Action<global::Zoo.StepPresentationVariant2?>? stepPresentationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStepPresentationVariant1)
            {
                stepPresentationVariant1?.Invoke(StepPresentationVariant1!);
            }
            else if (IsStepPresentationVariant2)
            {
                stepPresentationVariant2?.Invoke(StepPresentationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StepPresentationVariant1,
                typeof(global::Zoo.StepPresentationVariant1),
                StepPresentationVariant2,
                typeof(global::Zoo.StepPresentationVariant2),
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
        public bool Equals(StepPresentation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.StepPresentationVariant1?>.Default.Equals(StepPresentationVariant1, other.StepPresentationVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.StepPresentationVariant2?>.Default.Equals(StepPresentationVariant2, other.StepPresentationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StepPresentation obj1, StepPresentation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepPresentation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StepPresentation obj1, StepPresentation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepPresentation o && Equals(o);
        }
    }
}
