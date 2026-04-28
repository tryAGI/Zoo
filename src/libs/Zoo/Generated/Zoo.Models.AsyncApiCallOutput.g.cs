#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// The output from the async API call.
    /// </summary>
    public readonly partial struct AsyncApiCallOutput : global::System.IEquatable<AsyncApiCallOutput>
    {
        /// <summary>
        /// A file conversion.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.AsyncApiCallOutputVariant1? AsyncApiCallOutputVariant1 { get; init; }
#else
        public global::Zoo.AsyncApiCallOutputVariant1? AsyncApiCallOutputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsyncApiCallOutputVariant1))]
#endif
        public bool IsAsyncApiCallOutputVariant1 => AsyncApiCallOutputVariant1 != null;

        /// <summary>
        /// File center of mass.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.AsyncApiCallOutputVariant2? AsyncApiCallOutputVariant2 { get; init; }
#else
        public global::Zoo.AsyncApiCallOutputVariant2? AsyncApiCallOutputVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsyncApiCallOutputVariant2))]
#endif
        public bool IsAsyncApiCallOutputVariant2 => AsyncApiCallOutputVariant2 != null;

        /// <summary>
        /// A file mass.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.AsyncApiCallOutputVariant3? AsyncApiCallOutputVariant3 { get; init; }
#else
        public global::Zoo.AsyncApiCallOutputVariant3? AsyncApiCallOutputVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsyncApiCallOutputVariant3))]
#endif
        public bool IsAsyncApiCallOutputVariant3 => AsyncApiCallOutputVariant3 != null;

        /// <summary>
        /// A file volume.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.AsyncApiCallOutputVariant4? AsyncApiCallOutputVariant4 { get; init; }
#else
        public global::Zoo.AsyncApiCallOutputVariant4? AsyncApiCallOutputVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsyncApiCallOutputVariant4))]
#endif
        public bool IsAsyncApiCallOutputVariant4 => AsyncApiCallOutputVariant4 != null;

        /// <summary>
        /// A file density.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.AsyncApiCallOutputVariant5? AsyncApiCallOutputVariant5 { get; init; }
#else
        public global::Zoo.AsyncApiCallOutputVariant5? AsyncApiCallOutputVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsyncApiCallOutputVariant5))]
#endif
        public bool IsAsyncApiCallOutputVariant5 => AsyncApiCallOutputVariant5 != null;

        /// <summary>
        /// A file surface area.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.AsyncApiCallOutputVariant6? AsyncApiCallOutputVariant6 { get; init; }
#else
        public global::Zoo.AsyncApiCallOutputVariant6? AsyncApiCallOutputVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsyncApiCallOutputVariant6))]
#endif
        public bool IsAsyncApiCallOutputVariant6 => AsyncApiCallOutputVariant6 != null;

        /// <summary>
        /// Text to CAD.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.AsyncApiCallOutputVariant7? AsyncApiCallOutputVariant7 { get; init; }
#else
        public global::Zoo.AsyncApiCallOutputVariant7? AsyncApiCallOutputVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsyncApiCallOutputVariant7))]
#endif
        public bool IsAsyncApiCallOutputVariant7 => AsyncApiCallOutputVariant7 != null;

        /// <summary>
        /// Text to CAD iteration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.AsyncApiCallOutputVariant8? AsyncApiCallOutputVariant8 { get; init; }
#else
        public global::Zoo.AsyncApiCallOutputVariant8? AsyncApiCallOutputVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsyncApiCallOutputVariant8))]
#endif
        public bool IsAsyncApiCallOutputVariant8 => AsyncApiCallOutputVariant8 != null;

        /// <summary>
        /// Text to CAD multi-file iteration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.AsyncApiCallOutputVariant9? AsyncApiCallOutputVariant9 { get; init; }
#else
        public global::Zoo.AsyncApiCallOutputVariant9? AsyncApiCallOutputVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsyncApiCallOutputVariant9))]
#endif
        public bool IsAsyncApiCallOutputVariant9 => AsyncApiCallOutputVariant9 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant1 value) => new AsyncApiCallOutput((global::Zoo.AsyncApiCallOutputVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.AsyncApiCallOutputVariant1?(AsyncApiCallOutput @this) => @this.AsyncApiCallOutputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant1? value)
        {
            AsyncApiCallOutputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant2 value) => new AsyncApiCallOutput((global::Zoo.AsyncApiCallOutputVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.AsyncApiCallOutputVariant2?(AsyncApiCallOutput @this) => @this.AsyncApiCallOutputVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant2? value)
        {
            AsyncApiCallOutputVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant3 value) => new AsyncApiCallOutput((global::Zoo.AsyncApiCallOutputVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.AsyncApiCallOutputVariant3?(AsyncApiCallOutput @this) => @this.AsyncApiCallOutputVariant3;

        /// <summary>
        /// 
        /// </summary>
        public AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant3? value)
        {
            AsyncApiCallOutputVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant4 value) => new AsyncApiCallOutput((global::Zoo.AsyncApiCallOutputVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.AsyncApiCallOutputVariant4?(AsyncApiCallOutput @this) => @this.AsyncApiCallOutputVariant4;

        /// <summary>
        /// 
        /// </summary>
        public AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant4? value)
        {
            AsyncApiCallOutputVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant5 value) => new AsyncApiCallOutput((global::Zoo.AsyncApiCallOutputVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.AsyncApiCallOutputVariant5?(AsyncApiCallOutput @this) => @this.AsyncApiCallOutputVariant5;

        /// <summary>
        /// 
        /// </summary>
        public AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant5? value)
        {
            AsyncApiCallOutputVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant6 value) => new AsyncApiCallOutput((global::Zoo.AsyncApiCallOutputVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.AsyncApiCallOutputVariant6?(AsyncApiCallOutput @this) => @this.AsyncApiCallOutputVariant6;

        /// <summary>
        /// 
        /// </summary>
        public AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant6? value)
        {
            AsyncApiCallOutputVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant7 value) => new AsyncApiCallOutput((global::Zoo.AsyncApiCallOutputVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.AsyncApiCallOutputVariant7?(AsyncApiCallOutput @this) => @this.AsyncApiCallOutputVariant7;

        /// <summary>
        /// 
        /// </summary>
        public AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant7? value)
        {
            AsyncApiCallOutputVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant8 value) => new AsyncApiCallOutput((global::Zoo.AsyncApiCallOutputVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.AsyncApiCallOutputVariant8?(AsyncApiCallOutput @this) => @this.AsyncApiCallOutputVariant8;

        /// <summary>
        /// 
        /// </summary>
        public AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant8? value)
        {
            AsyncApiCallOutputVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant9 value) => new AsyncApiCallOutput((global::Zoo.AsyncApiCallOutputVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.AsyncApiCallOutputVariant9?(AsyncApiCallOutput @this) => @this.AsyncApiCallOutputVariant9;

        /// <summary>
        /// 
        /// </summary>
        public AsyncApiCallOutput(global::Zoo.AsyncApiCallOutputVariant9? value)
        {
            AsyncApiCallOutputVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AsyncApiCallOutput(
            global::Zoo.AsyncApiCallOutputVariant1? asyncApiCallOutputVariant1,
            global::Zoo.AsyncApiCallOutputVariant2? asyncApiCallOutputVariant2,
            global::Zoo.AsyncApiCallOutputVariant3? asyncApiCallOutputVariant3,
            global::Zoo.AsyncApiCallOutputVariant4? asyncApiCallOutputVariant4,
            global::Zoo.AsyncApiCallOutputVariant5? asyncApiCallOutputVariant5,
            global::Zoo.AsyncApiCallOutputVariant6? asyncApiCallOutputVariant6,
            global::Zoo.AsyncApiCallOutputVariant7? asyncApiCallOutputVariant7,
            global::Zoo.AsyncApiCallOutputVariant8? asyncApiCallOutputVariant8,
            global::Zoo.AsyncApiCallOutputVariant9? asyncApiCallOutputVariant9
            )
        {
            AsyncApiCallOutputVariant1 = asyncApiCallOutputVariant1;
            AsyncApiCallOutputVariant2 = asyncApiCallOutputVariant2;
            AsyncApiCallOutputVariant3 = asyncApiCallOutputVariant3;
            AsyncApiCallOutputVariant4 = asyncApiCallOutputVariant4;
            AsyncApiCallOutputVariant5 = asyncApiCallOutputVariant5;
            AsyncApiCallOutputVariant6 = asyncApiCallOutputVariant6;
            AsyncApiCallOutputVariant7 = asyncApiCallOutputVariant7;
            AsyncApiCallOutputVariant8 = asyncApiCallOutputVariant8;
            AsyncApiCallOutputVariant9 = asyncApiCallOutputVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AsyncApiCallOutputVariant9 as object ??
            AsyncApiCallOutputVariant8 as object ??
            AsyncApiCallOutputVariant7 as object ??
            AsyncApiCallOutputVariant6 as object ??
            AsyncApiCallOutputVariant5 as object ??
            AsyncApiCallOutputVariant4 as object ??
            AsyncApiCallOutputVariant3 as object ??
            AsyncApiCallOutputVariant2 as object ??
            AsyncApiCallOutputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AsyncApiCallOutputVariant1?.ToString() ??
            AsyncApiCallOutputVariant2?.ToString() ??
            AsyncApiCallOutputVariant3?.ToString() ??
            AsyncApiCallOutputVariant4?.ToString() ??
            AsyncApiCallOutputVariant5?.ToString() ??
            AsyncApiCallOutputVariant6?.ToString() ??
            AsyncApiCallOutputVariant7?.ToString() ??
            AsyncApiCallOutputVariant8?.ToString() ??
            AsyncApiCallOutputVariant9?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAsyncApiCallOutputVariant1 && !IsAsyncApiCallOutputVariant2 && !IsAsyncApiCallOutputVariant3 && !IsAsyncApiCallOutputVariant4 && !IsAsyncApiCallOutputVariant5 && !IsAsyncApiCallOutputVariant6 && !IsAsyncApiCallOutputVariant7 && !IsAsyncApiCallOutputVariant8 && !IsAsyncApiCallOutputVariant9 || !IsAsyncApiCallOutputVariant1 && IsAsyncApiCallOutputVariant2 && !IsAsyncApiCallOutputVariant3 && !IsAsyncApiCallOutputVariant4 && !IsAsyncApiCallOutputVariant5 && !IsAsyncApiCallOutputVariant6 && !IsAsyncApiCallOutputVariant7 && !IsAsyncApiCallOutputVariant8 && !IsAsyncApiCallOutputVariant9 || !IsAsyncApiCallOutputVariant1 && !IsAsyncApiCallOutputVariant2 && IsAsyncApiCallOutputVariant3 && !IsAsyncApiCallOutputVariant4 && !IsAsyncApiCallOutputVariant5 && !IsAsyncApiCallOutputVariant6 && !IsAsyncApiCallOutputVariant7 && !IsAsyncApiCallOutputVariant8 && !IsAsyncApiCallOutputVariant9 || !IsAsyncApiCallOutputVariant1 && !IsAsyncApiCallOutputVariant2 && !IsAsyncApiCallOutputVariant3 && IsAsyncApiCallOutputVariant4 && !IsAsyncApiCallOutputVariant5 && !IsAsyncApiCallOutputVariant6 && !IsAsyncApiCallOutputVariant7 && !IsAsyncApiCallOutputVariant8 && !IsAsyncApiCallOutputVariant9 || !IsAsyncApiCallOutputVariant1 && !IsAsyncApiCallOutputVariant2 && !IsAsyncApiCallOutputVariant3 && !IsAsyncApiCallOutputVariant4 && IsAsyncApiCallOutputVariant5 && !IsAsyncApiCallOutputVariant6 && !IsAsyncApiCallOutputVariant7 && !IsAsyncApiCallOutputVariant8 && !IsAsyncApiCallOutputVariant9 || !IsAsyncApiCallOutputVariant1 && !IsAsyncApiCallOutputVariant2 && !IsAsyncApiCallOutputVariant3 && !IsAsyncApiCallOutputVariant4 && !IsAsyncApiCallOutputVariant5 && IsAsyncApiCallOutputVariant6 && !IsAsyncApiCallOutputVariant7 && !IsAsyncApiCallOutputVariant8 && !IsAsyncApiCallOutputVariant9 || !IsAsyncApiCallOutputVariant1 && !IsAsyncApiCallOutputVariant2 && !IsAsyncApiCallOutputVariant3 && !IsAsyncApiCallOutputVariant4 && !IsAsyncApiCallOutputVariant5 && !IsAsyncApiCallOutputVariant6 && IsAsyncApiCallOutputVariant7 && !IsAsyncApiCallOutputVariant8 && !IsAsyncApiCallOutputVariant9 || !IsAsyncApiCallOutputVariant1 && !IsAsyncApiCallOutputVariant2 && !IsAsyncApiCallOutputVariant3 && !IsAsyncApiCallOutputVariant4 && !IsAsyncApiCallOutputVariant5 && !IsAsyncApiCallOutputVariant6 && !IsAsyncApiCallOutputVariant7 && IsAsyncApiCallOutputVariant8 && !IsAsyncApiCallOutputVariant9 || !IsAsyncApiCallOutputVariant1 && !IsAsyncApiCallOutputVariant2 && !IsAsyncApiCallOutputVariant3 && !IsAsyncApiCallOutputVariant4 && !IsAsyncApiCallOutputVariant5 && !IsAsyncApiCallOutputVariant6 && !IsAsyncApiCallOutputVariant7 && !IsAsyncApiCallOutputVariant8 && IsAsyncApiCallOutputVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.AsyncApiCallOutputVariant1?, TResult>? asyncApiCallOutputVariant1 = null,
            global::System.Func<global::Zoo.AsyncApiCallOutputVariant2?, TResult>? asyncApiCallOutputVariant2 = null,
            global::System.Func<global::Zoo.AsyncApiCallOutputVariant3?, TResult>? asyncApiCallOutputVariant3 = null,
            global::System.Func<global::Zoo.AsyncApiCallOutputVariant4?, TResult>? asyncApiCallOutputVariant4 = null,
            global::System.Func<global::Zoo.AsyncApiCallOutputVariant5?, TResult>? asyncApiCallOutputVariant5 = null,
            global::System.Func<global::Zoo.AsyncApiCallOutputVariant6?, TResult>? asyncApiCallOutputVariant6 = null,
            global::System.Func<global::Zoo.AsyncApiCallOutputVariant7?, TResult>? asyncApiCallOutputVariant7 = null,
            global::System.Func<global::Zoo.AsyncApiCallOutputVariant8?, TResult>? asyncApiCallOutputVariant8 = null,
            global::System.Func<global::Zoo.AsyncApiCallOutputVariant9?, TResult>? asyncApiCallOutputVariant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAsyncApiCallOutputVariant1 && asyncApiCallOutputVariant1 != null)
            {
                return asyncApiCallOutputVariant1(AsyncApiCallOutputVariant1!);
            }
            else if (IsAsyncApiCallOutputVariant2 && asyncApiCallOutputVariant2 != null)
            {
                return asyncApiCallOutputVariant2(AsyncApiCallOutputVariant2!);
            }
            else if (IsAsyncApiCallOutputVariant3 && asyncApiCallOutputVariant3 != null)
            {
                return asyncApiCallOutputVariant3(AsyncApiCallOutputVariant3!);
            }
            else if (IsAsyncApiCallOutputVariant4 && asyncApiCallOutputVariant4 != null)
            {
                return asyncApiCallOutputVariant4(AsyncApiCallOutputVariant4!);
            }
            else if (IsAsyncApiCallOutputVariant5 && asyncApiCallOutputVariant5 != null)
            {
                return asyncApiCallOutputVariant5(AsyncApiCallOutputVariant5!);
            }
            else if (IsAsyncApiCallOutputVariant6 && asyncApiCallOutputVariant6 != null)
            {
                return asyncApiCallOutputVariant6(AsyncApiCallOutputVariant6!);
            }
            else if (IsAsyncApiCallOutputVariant7 && asyncApiCallOutputVariant7 != null)
            {
                return asyncApiCallOutputVariant7(AsyncApiCallOutputVariant7!);
            }
            else if (IsAsyncApiCallOutputVariant8 && asyncApiCallOutputVariant8 != null)
            {
                return asyncApiCallOutputVariant8(AsyncApiCallOutputVariant8!);
            }
            else if (IsAsyncApiCallOutputVariant9 && asyncApiCallOutputVariant9 != null)
            {
                return asyncApiCallOutputVariant9(AsyncApiCallOutputVariant9!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.AsyncApiCallOutputVariant1?>? asyncApiCallOutputVariant1 = null,
            global::System.Action<global::Zoo.AsyncApiCallOutputVariant2?>? asyncApiCallOutputVariant2 = null,
            global::System.Action<global::Zoo.AsyncApiCallOutputVariant3?>? asyncApiCallOutputVariant3 = null,
            global::System.Action<global::Zoo.AsyncApiCallOutputVariant4?>? asyncApiCallOutputVariant4 = null,
            global::System.Action<global::Zoo.AsyncApiCallOutputVariant5?>? asyncApiCallOutputVariant5 = null,
            global::System.Action<global::Zoo.AsyncApiCallOutputVariant6?>? asyncApiCallOutputVariant6 = null,
            global::System.Action<global::Zoo.AsyncApiCallOutputVariant7?>? asyncApiCallOutputVariant7 = null,
            global::System.Action<global::Zoo.AsyncApiCallOutputVariant8?>? asyncApiCallOutputVariant8 = null,
            global::System.Action<global::Zoo.AsyncApiCallOutputVariant9?>? asyncApiCallOutputVariant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAsyncApiCallOutputVariant1)
            {
                asyncApiCallOutputVariant1?.Invoke(AsyncApiCallOutputVariant1!);
            }
            else if (IsAsyncApiCallOutputVariant2)
            {
                asyncApiCallOutputVariant2?.Invoke(AsyncApiCallOutputVariant2!);
            }
            else if (IsAsyncApiCallOutputVariant3)
            {
                asyncApiCallOutputVariant3?.Invoke(AsyncApiCallOutputVariant3!);
            }
            else if (IsAsyncApiCallOutputVariant4)
            {
                asyncApiCallOutputVariant4?.Invoke(AsyncApiCallOutputVariant4!);
            }
            else if (IsAsyncApiCallOutputVariant5)
            {
                asyncApiCallOutputVariant5?.Invoke(AsyncApiCallOutputVariant5!);
            }
            else if (IsAsyncApiCallOutputVariant6)
            {
                asyncApiCallOutputVariant6?.Invoke(AsyncApiCallOutputVariant6!);
            }
            else if (IsAsyncApiCallOutputVariant7)
            {
                asyncApiCallOutputVariant7?.Invoke(AsyncApiCallOutputVariant7!);
            }
            else if (IsAsyncApiCallOutputVariant8)
            {
                asyncApiCallOutputVariant8?.Invoke(AsyncApiCallOutputVariant8!);
            }
            else if (IsAsyncApiCallOutputVariant9)
            {
                asyncApiCallOutputVariant9?.Invoke(AsyncApiCallOutputVariant9!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AsyncApiCallOutputVariant1,
                typeof(global::Zoo.AsyncApiCallOutputVariant1),
                AsyncApiCallOutputVariant2,
                typeof(global::Zoo.AsyncApiCallOutputVariant2),
                AsyncApiCallOutputVariant3,
                typeof(global::Zoo.AsyncApiCallOutputVariant3),
                AsyncApiCallOutputVariant4,
                typeof(global::Zoo.AsyncApiCallOutputVariant4),
                AsyncApiCallOutputVariant5,
                typeof(global::Zoo.AsyncApiCallOutputVariant5),
                AsyncApiCallOutputVariant6,
                typeof(global::Zoo.AsyncApiCallOutputVariant6),
                AsyncApiCallOutputVariant7,
                typeof(global::Zoo.AsyncApiCallOutputVariant7),
                AsyncApiCallOutputVariant8,
                typeof(global::Zoo.AsyncApiCallOutputVariant8),
                AsyncApiCallOutputVariant9,
                typeof(global::Zoo.AsyncApiCallOutputVariant9),
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
        public bool Equals(AsyncApiCallOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.AsyncApiCallOutputVariant1?>.Default.Equals(AsyncApiCallOutputVariant1, other.AsyncApiCallOutputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.AsyncApiCallOutputVariant2?>.Default.Equals(AsyncApiCallOutputVariant2, other.AsyncApiCallOutputVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.AsyncApiCallOutputVariant3?>.Default.Equals(AsyncApiCallOutputVariant3, other.AsyncApiCallOutputVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.AsyncApiCallOutputVariant4?>.Default.Equals(AsyncApiCallOutputVariant4, other.AsyncApiCallOutputVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.AsyncApiCallOutputVariant5?>.Default.Equals(AsyncApiCallOutputVariant5, other.AsyncApiCallOutputVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.AsyncApiCallOutputVariant6?>.Default.Equals(AsyncApiCallOutputVariant6, other.AsyncApiCallOutputVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.AsyncApiCallOutputVariant7?>.Default.Equals(AsyncApiCallOutputVariant7, other.AsyncApiCallOutputVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.AsyncApiCallOutputVariant8?>.Default.Equals(AsyncApiCallOutputVariant8, other.AsyncApiCallOutputVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.AsyncApiCallOutputVariant9?>.Default.Equals(AsyncApiCallOutputVariant9, other.AsyncApiCallOutputVariant9) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AsyncApiCallOutput obj1, AsyncApiCallOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AsyncApiCallOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AsyncApiCallOutput obj1, AsyncApiCallOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AsyncApiCallOutput o && Equals(o);
        }
    }
}
