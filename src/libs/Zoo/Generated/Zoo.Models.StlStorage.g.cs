#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Export storage.
    /// </summary>
    public readonly partial struct StlStorage : global::System.IEquatable<StlStorage>
    {
        /// <summary>
        /// Plaintext encoding.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.StlStorageVariant1? StlStorageVariant1 { get; init; }
#else
        public global::Zoo.StlStorageVariant1? StlStorageVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StlStorageVariant1))]
#endif
        public bool IsStlStorageVariant1 => StlStorageVariant1 != null;

        /// <summary>
        /// Binary STL encoding.<br/>
        /// This is the default setting.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.StlStorageVariant2? StlStorageVariant2 { get; init; }
#else
        public global::Zoo.StlStorageVariant2? StlStorageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StlStorageVariant2))]
#endif
        public bool IsStlStorageVariant2 => StlStorageVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StlStorage(global::Zoo.StlStorageVariant1 value) => new StlStorage((global::Zoo.StlStorageVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.StlStorageVariant1?(StlStorage @this) => @this.StlStorageVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StlStorage(global::Zoo.StlStorageVariant1? value)
        {
            StlStorageVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StlStorage(global::Zoo.StlStorageVariant2 value) => new StlStorage((global::Zoo.StlStorageVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.StlStorageVariant2?(StlStorage @this) => @this.StlStorageVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StlStorage(global::Zoo.StlStorageVariant2? value)
        {
            StlStorageVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StlStorage(
            global::Zoo.StlStorageVariant1? stlStorageVariant1,
            global::Zoo.StlStorageVariant2? stlStorageVariant2
            )
        {
            StlStorageVariant1 = stlStorageVariant1;
            StlStorageVariant2 = stlStorageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StlStorageVariant2 as object ??
            StlStorageVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StlStorageVariant1?.ToValueString() ??
            StlStorageVariant2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStlStorageVariant1 && !IsStlStorageVariant2 || !IsStlStorageVariant1 && IsStlStorageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.StlStorageVariant1?, TResult>? stlStorageVariant1 = null,
            global::System.Func<global::Zoo.StlStorageVariant2?, TResult>? stlStorageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStlStorageVariant1 && stlStorageVariant1 != null)
            {
                return stlStorageVariant1(StlStorageVariant1!);
            }
            else if (IsStlStorageVariant2 && stlStorageVariant2 != null)
            {
                return stlStorageVariant2(StlStorageVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.StlStorageVariant1?>? stlStorageVariant1 = null,
            global::System.Action<global::Zoo.StlStorageVariant2?>? stlStorageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStlStorageVariant1)
            {
                stlStorageVariant1?.Invoke(StlStorageVariant1!);
            }
            else if (IsStlStorageVariant2)
            {
                stlStorageVariant2?.Invoke(StlStorageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StlStorageVariant1,
                typeof(global::Zoo.StlStorageVariant1),
                StlStorageVariant2,
                typeof(global::Zoo.StlStorageVariant2),
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
        public bool Equals(StlStorage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.StlStorageVariant1?>.Default.Equals(StlStorageVariant1, other.StlStorageVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.StlStorageVariant2?>.Default.Equals(StlStorageVariant2, other.StlStorageVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StlStorage obj1, StlStorage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StlStorage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StlStorage obj1, StlStorage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StlStorage o && Equals(o);
        }
    }
}
