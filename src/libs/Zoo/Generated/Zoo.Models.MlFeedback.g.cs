#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Human feedback on an ML response.
    /// </summary>
    public readonly partial struct MlFeedback : global::System.IEquatable<MlFeedback>
    {
        /// <summary>
        /// Thumbs up.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.MlFeedbackVariant1? MlFeedbackVariant1 { get; init; }
#else
        public global::Zoo.MlFeedbackVariant1? MlFeedbackVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MlFeedbackVariant1))]
#endif
        public bool IsMlFeedbackVariant1 => MlFeedbackVariant1 != null;

        /// <summary>
        /// Thumbs down.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.MlFeedbackVariant2? MlFeedbackVariant2 { get; init; }
#else
        public global::Zoo.MlFeedbackVariant2? MlFeedbackVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MlFeedbackVariant2))]
#endif
        public bool IsMlFeedbackVariant2 => MlFeedbackVariant2 != null;

        /// <summary>
        /// Accepted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.MlFeedbackVariant3? MlFeedbackVariant3 { get; init; }
#else
        public global::Zoo.MlFeedbackVariant3? MlFeedbackVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MlFeedbackVariant3))]
#endif
        public bool IsMlFeedbackVariant3 => MlFeedbackVariant3 != null;

        /// <summary>
        /// Rejected.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.MlFeedbackVariant4? MlFeedbackVariant4 { get; init; }
#else
        public global::Zoo.MlFeedbackVariant4? MlFeedbackVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MlFeedbackVariant4))]
#endif
        public bool IsMlFeedbackVariant4 => MlFeedbackVariant4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MlFeedback(global::Zoo.MlFeedbackVariant1 value) => new MlFeedback((global::Zoo.MlFeedbackVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.MlFeedbackVariant1?(MlFeedback @this) => @this.MlFeedbackVariant1;

        /// <summary>
        /// 
        /// </summary>
        public MlFeedback(global::Zoo.MlFeedbackVariant1? value)
        {
            MlFeedbackVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MlFeedback(global::Zoo.MlFeedbackVariant2 value) => new MlFeedback((global::Zoo.MlFeedbackVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.MlFeedbackVariant2?(MlFeedback @this) => @this.MlFeedbackVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MlFeedback(global::Zoo.MlFeedbackVariant2? value)
        {
            MlFeedbackVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MlFeedback(global::Zoo.MlFeedbackVariant3 value) => new MlFeedback((global::Zoo.MlFeedbackVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.MlFeedbackVariant3?(MlFeedback @this) => @this.MlFeedbackVariant3;

        /// <summary>
        /// 
        /// </summary>
        public MlFeedback(global::Zoo.MlFeedbackVariant3? value)
        {
            MlFeedbackVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MlFeedback(global::Zoo.MlFeedbackVariant4 value) => new MlFeedback((global::Zoo.MlFeedbackVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.MlFeedbackVariant4?(MlFeedback @this) => @this.MlFeedbackVariant4;

        /// <summary>
        /// 
        /// </summary>
        public MlFeedback(global::Zoo.MlFeedbackVariant4? value)
        {
            MlFeedbackVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MlFeedback(
            global::Zoo.MlFeedbackVariant1? mlFeedbackVariant1,
            global::Zoo.MlFeedbackVariant2? mlFeedbackVariant2,
            global::Zoo.MlFeedbackVariant3? mlFeedbackVariant3,
            global::Zoo.MlFeedbackVariant4? mlFeedbackVariant4
            )
        {
            MlFeedbackVariant1 = mlFeedbackVariant1;
            MlFeedbackVariant2 = mlFeedbackVariant2;
            MlFeedbackVariant3 = mlFeedbackVariant3;
            MlFeedbackVariant4 = mlFeedbackVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MlFeedbackVariant4 as object ??
            MlFeedbackVariant3 as object ??
            MlFeedbackVariant2 as object ??
            MlFeedbackVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MlFeedbackVariant1?.ToValueString() ??
            MlFeedbackVariant2?.ToValueString() ??
            MlFeedbackVariant3?.ToValueString() ??
            MlFeedbackVariant4?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMlFeedbackVariant1 && !IsMlFeedbackVariant2 && !IsMlFeedbackVariant3 && !IsMlFeedbackVariant4 || !IsMlFeedbackVariant1 && IsMlFeedbackVariant2 && !IsMlFeedbackVariant3 && !IsMlFeedbackVariant4 || !IsMlFeedbackVariant1 && !IsMlFeedbackVariant2 && IsMlFeedbackVariant3 && !IsMlFeedbackVariant4 || !IsMlFeedbackVariant1 && !IsMlFeedbackVariant2 && !IsMlFeedbackVariant3 && IsMlFeedbackVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.MlFeedbackVariant1?, TResult>? mlFeedbackVariant1 = null,
            global::System.Func<global::Zoo.MlFeedbackVariant2?, TResult>? mlFeedbackVariant2 = null,
            global::System.Func<global::Zoo.MlFeedbackVariant3?, TResult>? mlFeedbackVariant3 = null,
            global::System.Func<global::Zoo.MlFeedbackVariant4?, TResult>? mlFeedbackVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMlFeedbackVariant1 && mlFeedbackVariant1 != null)
            {
                return mlFeedbackVariant1(MlFeedbackVariant1!);
            }
            else if (IsMlFeedbackVariant2 && mlFeedbackVariant2 != null)
            {
                return mlFeedbackVariant2(MlFeedbackVariant2!);
            }
            else if (IsMlFeedbackVariant3 && mlFeedbackVariant3 != null)
            {
                return mlFeedbackVariant3(MlFeedbackVariant3!);
            }
            else if (IsMlFeedbackVariant4 && mlFeedbackVariant4 != null)
            {
                return mlFeedbackVariant4(MlFeedbackVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.MlFeedbackVariant1?>? mlFeedbackVariant1 = null,
            global::System.Action<global::Zoo.MlFeedbackVariant2?>? mlFeedbackVariant2 = null,
            global::System.Action<global::Zoo.MlFeedbackVariant3?>? mlFeedbackVariant3 = null,
            global::System.Action<global::Zoo.MlFeedbackVariant4?>? mlFeedbackVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMlFeedbackVariant1)
            {
                mlFeedbackVariant1?.Invoke(MlFeedbackVariant1!);
            }
            else if (IsMlFeedbackVariant2)
            {
                mlFeedbackVariant2?.Invoke(MlFeedbackVariant2!);
            }
            else if (IsMlFeedbackVariant3)
            {
                mlFeedbackVariant3?.Invoke(MlFeedbackVariant3!);
            }
            else if (IsMlFeedbackVariant4)
            {
                mlFeedbackVariant4?.Invoke(MlFeedbackVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MlFeedbackVariant1,
                typeof(global::Zoo.MlFeedbackVariant1),
                MlFeedbackVariant2,
                typeof(global::Zoo.MlFeedbackVariant2),
                MlFeedbackVariant3,
                typeof(global::Zoo.MlFeedbackVariant3),
                MlFeedbackVariant4,
                typeof(global::Zoo.MlFeedbackVariant4),
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
        public bool Equals(MlFeedback other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.MlFeedbackVariant1?>.Default.Equals(MlFeedbackVariant1, other.MlFeedbackVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.MlFeedbackVariant2?>.Default.Equals(MlFeedbackVariant2, other.MlFeedbackVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.MlFeedbackVariant3?>.Default.Equals(MlFeedbackVariant3, other.MlFeedbackVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.MlFeedbackVariant4?>.Default.Equals(MlFeedbackVariant4, other.MlFeedbackVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MlFeedback obj1, MlFeedback obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MlFeedback>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MlFeedback obj1, MlFeedback obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MlFeedback o && Equals(o);
        }
    }
}
