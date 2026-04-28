#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// The status of an async API call.
    /// </summary>
    public readonly partial struct ApiCallStatus : global::System.IEquatable<ApiCallStatus>
    {
        /// <summary>
        /// The async API call is queued.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.ApiCallStatusVariant1? ApiCallStatusVariant1 { get; init; }
#else
        public global::Zoo.ApiCallStatusVariant1? ApiCallStatusVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiCallStatusVariant1))]
#endif
        public bool IsApiCallStatusVariant1 => ApiCallStatusVariant1 != null;

        /// <summary>
        /// The async API call was uploaded to be converted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.ApiCallStatusVariant2? ApiCallStatusVariant2 { get; init; }
#else
        public global::Zoo.ApiCallStatusVariant2? ApiCallStatusVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiCallStatusVariant2))]
#endif
        public bool IsApiCallStatusVariant2 => ApiCallStatusVariant2 != null;

        /// <summary>
        /// The async API call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.ApiCallStatusVariant3? ApiCallStatusVariant3 { get; init; }
#else
        public global::Zoo.ApiCallStatusVariant3? ApiCallStatusVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiCallStatusVariant3))]
#endif
        public bool IsApiCallStatusVariant3 => ApiCallStatusVariant3 != null;

        /// <summary>
        /// The async API call has completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.ApiCallStatusVariant4? ApiCallStatusVariant4 { get; init; }
#else
        public global::Zoo.ApiCallStatusVariant4? ApiCallStatusVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiCallStatusVariant4))]
#endif
        public bool IsApiCallStatusVariant4 => ApiCallStatusVariant4 != null;

        /// <summary>
        /// The async API call has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.ApiCallStatusVariant5? ApiCallStatusVariant5 { get; init; }
#else
        public global::Zoo.ApiCallStatusVariant5? ApiCallStatusVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiCallStatusVariant5))]
#endif
        public bool IsApiCallStatusVariant5 => ApiCallStatusVariant5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApiCallStatus(global::Zoo.ApiCallStatusVariant1 value) => new ApiCallStatus((global::Zoo.ApiCallStatusVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.ApiCallStatusVariant1?(ApiCallStatus @this) => @this.ApiCallStatusVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ApiCallStatus(global::Zoo.ApiCallStatusVariant1? value)
        {
            ApiCallStatusVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApiCallStatus(global::Zoo.ApiCallStatusVariant2 value) => new ApiCallStatus((global::Zoo.ApiCallStatusVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.ApiCallStatusVariant2?(ApiCallStatus @this) => @this.ApiCallStatusVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ApiCallStatus(global::Zoo.ApiCallStatusVariant2? value)
        {
            ApiCallStatusVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApiCallStatus(global::Zoo.ApiCallStatusVariant3 value) => new ApiCallStatus((global::Zoo.ApiCallStatusVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.ApiCallStatusVariant3?(ApiCallStatus @this) => @this.ApiCallStatusVariant3;

        /// <summary>
        /// 
        /// </summary>
        public ApiCallStatus(global::Zoo.ApiCallStatusVariant3? value)
        {
            ApiCallStatusVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApiCallStatus(global::Zoo.ApiCallStatusVariant4 value) => new ApiCallStatus((global::Zoo.ApiCallStatusVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.ApiCallStatusVariant4?(ApiCallStatus @this) => @this.ApiCallStatusVariant4;

        /// <summary>
        /// 
        /// </summary>
        public ApiCallStatus(global::Zoo.ApiCallStatusVariant4? value)
        {
            ApiCallStatusVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApiCallStatus(global::Zoo.ApiCallStatusVariant5 value) => new ApiCallStatus((global::Zoo.ApiCallStatusVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.ApiCallStatusVariant5?(ApiCallStatus @this) => @this.ApiCallStatusVariant5;

        /// <summary>
        /// 
        /// </summary>
        public ApiCallStatus(global::Zoo.ApiCallStatusVariant5? value)
        {
            ApiCallStatusVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ApiCallStatus(
            global::Zoo.ApiCallStatusVariant1? apiCallStatusVariant1,
            global::Zoo.ApiCallStatusVariant2? apiCallStatusVariant2,
            global::Zoo.ApiCallStatusVariant3? apiCallStatusVariant3,
            global::Zoo.ApiCallStatusVariant4? apiCallStatusVariant4,
            global::Zoo.ApiCallStatusVariant5? apiCallStatusVariant5
            )
        {
            ApiCallStatusVariant1 = apiCallStatusVariant1;
            ApiCallStatusVariant2 = apiCallStatusVariant2;
            ApiCallStatusVariant3 = apiCallStatusVariant3;
            ApiCallStatusVariant4 = apiCallStatusVariant4;
            ApiCallStatusVariant5 = apiCallStatusVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApiCallStatusVariant5 as object ??
            ApiCallStatusVariant4 as object ??
            ApiCallStatusVariant3 as object ??
            ApiCallStatusVariant2 as object ??
            ApiCallStatusVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApiCallStatusVariant1?.ToValueString() ??
            ApiCallStatusVariant2?.ToValueString() ??
            ApiCallStatusVariant3?.ToValueString() ??
            ApiCallStatusVariant4?.ToValueString() ??
            ApiCallStatusVariant5?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApiCallStatusVariant1 && !IsApiCallStatusVariant2 && !IsApiCallStatusVariant3 && !IsApiCallStatusVariant4 && !IsApiCallStatusVariant5 || !IsApiCallStatusVariant1 && IsApiCallStatusVariant2 && !IsApiCallStatusVariant3 && !IsApiCallStatusVariant4 && !IsApiCallStatusVariant5 || !IsApiCallStatusVariant1 && !IsApiCallStatusVariant2 && IsApiCallStatusVariant3 && !IsApiCallStatusVariant4 && !IsApiCallStatusVariant5 || !IsApiCallStatusVariant1 && !IsApiCallStatusVariant2 && !IsApiCallStatusVariant3 && IsApiCallStatusVariant4 && !IsApiCallStatusVariant5 || !IsApiCallStatusVariant1 && !IsApiCallStatusVariant2 && !IsApiCallStatusVariant3 && !IsApiCallStatusVariant4 && IsApiCallStatusVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.ApiCallStatusVariant1?, TResult>? apiCallStatusVariant1 = null,
            global::System.Func<global::Zoo.ApiCallStatusVariant2?, TResult>? apiCallStatusVariant2 = null,
            global::System.Func<global::Zoo.ApiCallStatusVariant3?, TResult>? apiCallStatusVariant3 = null,
            global::System.Func<global::Zoo.ApiCallStatusVariant4?, TResult>? apiCallStatusVariant4 = null,
            global::System.Func<global::Zoo.ApiCallStatusVariant5?, TResult>? apiCallStatusVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiCallStatusVariant1 && apiCallStatusVariant1 != null)
            {
                return apiCallStatusVariant1(ApiCallStatusVariant1!);
            }
            else if (IsApiCallStatusVariant2 && apiCallStatusVariant2 != null)
            {
                return apiCallStatusVariant2(ApiCallStatusVariant2!);
            }
            else if (IsApiCallStatusVariant3 && apiCallStatusVariant3 != null)
            {
                return apiCallStatusVariant3(ApiCallStatusVariant3!);
            }
            else if (IsApiCallStatusVariant4 && apiCallStatusVariant4 != null)
            {
                return apiCallStatusVariant4(ApiCallStatusVariant4!);
            }
            else if (IsApiCallStatusVariant5 && apiCallStatusVariant5 != null)
            {
                return apiCallStatusVariant5(ApiCallStatusVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.ApiCallStatusVariant1?>? apiCallStatusVariant1 = null,
            global::System.Action<global::Zoo.ApiCallStatusVariant2?>? apiCallStatusVariant2 = null,
            global::System.Action<global::Zoo.ApiCallStatusVariant3?>? apiCallStatusVariant3 = null,
            global::System.Action<global::Zoo.ApiCallStatusVariant4?>? apiCallStatusVariant4 = null,
            global::System.Action<global::Zoo.ApiCallStatusVariant5?>? apiCallStatusVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiCallStatusVariant1)
            {
                apiCallStatusVariant1?.Invoke(ApiCallStatusVariant1!);
            }
            else if (IsApiCallStatusVariant2)
            {
                apiCallStatusVariant2?.Invoke(ApiCallStatusVariant2!);
            }
            else if (IsApiCallStatusVariant3)
            {
                apiCallStatusVariant3?.Invoke(ApiCallStatusVariant3!);
            }
            else if (IsApiCallStatusVariant4)
            {
                apiCallStatusVariant4?.Invoke(ApiCallStatusVariant4!);
            }
            else if (IsApiCallStatusVariant5)
            {
                apiCallStatusVariant5?.Invoke(ApiCallStatusVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApiCallStatusVariant1,
                typeof(global::Zoo.ApiCallStatusVariant1),
                ApiCallStatusVariant2,
                typeof(global::Zoo.ApiCallStatusVariant2),
                ApiCallStatusVariant3,
                typeof(global::Zoo.ApiCallStatusVariant3),
                ApiCallStatusVariant4,
                typeof(global::Zoo.ApiCallStatusVariant4),
                ApiCallStatusVariant5,
                typeof(global::Zoo.ApiCallStatusVariant5),
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
        public bool Equals(ApiCallStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.ApiCallStatusVariant1?>.Default.Equals(ApiCallStatusVariant1, other.ApiCallStatusVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.ApiCallStatusVariant2?>.Default.Equals(ApiCallStatusVariant2, other.ApiCallStatusVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.ApiCallStatusVariant3?>.Default.Equals(ApiCallStatusVariant3, other.ApiCallStatusVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.ApiCallStatusVariant4?>.Default.Equals(ApiCallStatusVariant4, other.ApiCallStatusVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.ApiCallStatusVariant5?>.Default.Equals(ApiCallStatusVariant5, other.ApiCallStatusVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ApiCallStatus obj1, ApiCallStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ApiCallStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ApiCallStatus obj1, ApiCallStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApiCallStatus o && Equals(o);
        }
    }
}
