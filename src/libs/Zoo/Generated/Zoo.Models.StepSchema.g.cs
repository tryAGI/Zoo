#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Specifies the STEP application protocol schema for export.
    /// </summary>
    public readonly partial struct StepSchema : global::System.IEquatable<StepSchema>
    {
        /// <summary>
        /// AP203 edition 2.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.StepSchemaVariant1? StepSchemaVariant1 { get; init; }
#else
        public global::Zoo.StepSchemaVariant1? StepSchemaVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepSchemaVariant1))]
#endif
        public bool IsStepSchemaVariant1 => StepSchemaVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStepSchemaVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.StepSchemaVariant1? value)
        {
            value = StepSchemaVariant1;
            return IsStepSchemaVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.StepSchemaVariant1 PickStepSchemaVariant1() => StepSchemaVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepSchemaVariant1' but the value was {ToString()}.");

        /// <summary>
        /// AP214.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.StepSchemaVariant2? StepSchemaVariant2 { get; init; }
#else
        public global::Zoo.StepSchemaVariant2? StepSchemaVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepSchemaVariant2))]
#endif
        public bool IsStepSchemaVariant2 => StepSchemaVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStepSchemaVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.StepSchemaVariant2? value)
        {
            value = StepSchemaVariant2;
            return IsStepSchemaVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.StepSchemaVariant2 PickStepSchemaVariant2() => StepSchemaVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepSchemaVariant2' but the value was {ToString()}.");

        /// <summary>
        /// AP242.<br/>
        /// This is the default setting.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.StepSchemaVariant3? StepSchemaVariant3 { get; init; }
#else
        public global::Zoo.StepSchemaVariant3? StepSchemaVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepSchemaVariant3))]
#endif
        public bool IsStepSchemaVariant3 => StepSchemaVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStepSchemaVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.StepSchemaVariant3? value)
        {
            value = StepSchemaVariant3;
            return IsStepSchemaVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.StepSchemaVariant3 PickStepSchemaVariant3() => StepSchemaVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepSchemaVariant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepSchema(global::Zoo.StepSchemaVariant1 value) => new StepSchema((global::Zoo.StepSchemaVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Zoo.StepSchemaVariant1?(StepSchema @this) => @this.StepSchemaVariant1;

        /// <summary>
        ///
        /// </summary>
        public StepSchema(global::Zoo.StepSchemaVariant1? value)
        {
            StepSchemaVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepSchema FromStepSchemaVariant1(global::Zoo.StepSchemaVariant1? value) => new StepSchema(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepSchema(global::Zoo.StepSchemaVariant2 value) => new StepSchema((global::Zoo.StepSchemaVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Zoo.StepSchemaVariant2?(StepSchema @this) => @this.StepSchemaVariant2;

        /// <summary>
        ///
        /// </summary>
        public StepSchema(global::Zoo.StepSchemaVariant2? value)
        {
            StepSchemaVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepSchema FromStepSchemaVariant2(global::Zoo.StepSchemaVariant2? value) => new StepSchema(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepSchema(global::Zoo.StepSchemaVariant3 value) => new StepSchema((global::Zoo.StepSchemaVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Zoo.StepSchemaVariant3?(StepSchema @this) => @this.StepSchemaVariant3;

        /// <summary>
        ///
        /// </summary>
        public StepSchema(global::Zoo.StepSchemaVariant3? value)
        {
            StepSchemaVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepSchema FromStepSchemaVariant3(global::Zoo.StepSchemaVariant3? value) => new StepSchema(value);

        /// <summary>
        ///
        /// </summary>
        public StepSchema(
            global::Zoo.StepSchemaVariant1? stepSchemaVariant1,
            global::Zoo.StepSchemaVariant2? stepSchemaVariant2,
            global::Zoo.StepSchemaVariant3? stepSchemaVariant3
            )
        {
            StepSchemaVariant1 = stepSchemaVariant1;
            StepSchemaVariant2 = stepSchemaVariant2;
            StepSchemaVariant3 = stepSchemaVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StepSchemaVariant3 as object ??
            StepSchemaVariant2 as object ??
            StepSchemaVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StepSchemaVariant1?.ToValueString() ??
            StepSchemaVariant2?.ToValueString() ??
            StepSchemaVariant3?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStepSchemaVariant1 && !IsStepSchemaVariant2 && !IsStepSchemaVariant3 || !IsStepSchemaVariant1 && IsStepSchemaVariant2 && !IsStepSchemaVariant3 || !IsStepSchemaVariant1 && !IsStepSchemaVariant2 && IsStepSchemaVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.StepSchemaVariant1?, TResult>? stepSchemaVariant1 = null,
            global::System.Func<global::Zoo.StepSchemaVariant2?, TResult>? stepSchemaVariant2 = null,
            global::System.Func<global::Zoo.StepSchemaVariant3?, TResult>? stepSchemaVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StepSchemaVariant1 is { } __value0 && stepSchemaVariant1 != null)
            {
                return stepSchemaVariant1(__value0);
            }
            else if (StepSchemaVariant2 is { } __value1 && stepSchemaVariant2 != null)
            {
                return stepSchemaVariant2(__value1);
            }
            else if (StepSchemaVariant3 is { } __value2 && stepSchemaVariant3 != null)
            {
                return stepSchemaVariant3(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.StepSchemaVariant1?>? stepSchemaVariant1 = null,

            global::System.Action<global::Zoo.StepSchemaVariant2?>? stepSchemaVariant2 = null,

            global::System.Action<global::Zoo.StepSchemaVariant3?>? stepSchemaVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StepSchemaVariant1 is { } __value0)
            {
                stepSchemaVariant1?.Invoke(__value0);
            }
            else if (StepSchemaVariant2 is { } __value1)
            {
                stepSchemaVariant2?.Invoke(__value1);
            }
            else if (StepSchemaVariant3 is { } __value2)
            {
                stepSchemaVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Zoo.StepSchemaVariant1?>? stepSchemaVariant1 = null,
            global::System.Action<global::Zoo.StepSchemaVariant2?>? stepSchemaVariant2 = null,
            global::System.Action<global::Zoo.StepSchemaVariant3?>? stepSchemaVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StepSchemaVariant1 is { } __value0)
            {
                stepSchemaVariant1?.Invoke(__value0);
            }
            else if (StepSchemaVariant2 is { } __value1)
            {
                stepSchemaVariant2?.Invoke(__value1);
            }
            else if (StepSchemaVariant3 is { } __value2)
            {
                stepSchemaVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StepSchemaVariant1,
                typeof(global::Zoo.StepSchemaVariant1),
                StepSchemaVariant2,
                typeof(global::Zoo.StepSchemaVariant2),
                StepSchemaVariant3,
                typeof(global::Zoo.StepSchemaVariant3),
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
        public bool Equals(StepSchema other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.StepSchemaVariant1?>.Default.Equals(StepSchemaVariant1, other.StepSchemaVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.StepSchemaVariant2?>.Default.Equals(StepSchemaVariant2, other.StepSchemaVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.StepSchemaVariant3?>.Default.Equals(StepSchemaVariant3, other.StepSchemaVariant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StepSchema obj1, StepSchema obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepSchema>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StepSchema obj1, StepSchema obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepSchema o && Equals(o);
        }
    }
}
