#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Describes the storage format of an FBX file.
    /// </summary>
    public readonly partial struct FbxStorage : global::System.IEquatable<FbxStorage>
    {
        /// <summary>
        /// ASCII FBX encoding.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FbxStorageVariant1? FbxStorageVariant1 { get; init; }
#else
        public global::Zoo.FbxStorageVariant1? FbxStorageVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FbxStorageVariant1))]
#endif
        public bool IsFbxStorageVariant1 => FbxStorageVariant1 != null;

        /// <summary>
        /// Binary FBX encoding.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FbxStorageVariant2? FbxStorageVariant2 { get; init; }
#else
        public global::Zoo.FbxStorageVariant2? FbxStorageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FbxStorageVariant2))]
#endif
        public bool IsFbxStorageVariant2 => FbxStorageVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FbxStorage(global::Zoo.FbxStorageVariant1 value) => new FbxStorage((global::Zoo.FbxStorageVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FbxStorageVariant1?(FbxStorage @this) => @this.FbxStorageVariant1;

        /// <summary>
        /// 
        /// </summary>
        public FbxStorage(global::Zoo.FbxStorageVariant1? value)
        {
            FbxStorageVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FbxStorage(global::Zoo.FbxStorageVariant2 value) => new FbxStorage((global::Zoo.FbxStorageVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FbxStorageVariant2?(FbxStorage @this) => @this.FbxStorageVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FbxStorage(global::Zoo.FbxStorageVariant2? value)
        {
            FbxStorageVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FbxStorage(
            global::Zoo.FbxStorageVariant1? fbxStorageVariant1,
            global::Zoo.FbxStorageVariant2? fbxStorageVariant2
            )
        {
            FbxStorageVariant1 = fbxStorageVariant1;
            FbxStorageVariant2 = fbxStorageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FbxStorageVariant2 as object ??
            FbxStorageVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FbxStorageVariant1?.ToValueString() ??
            FbxStorageVariant2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFbxStorageVariant1 && !IsFbxStorageVariant2 || !IsFbxStorageVariant1 && IsFbxStorageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.FbxStorageVariant1?, TResult>? fbxStorageVariant1 = null,
            global::System.Func<global::Zoo.FbxStorageVariant2?, TResult>? fbxStorageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFbxStorageVariant1 && fbxStorageVariant1 != null)
            {
                return fbxStorageVariant1(FbxStorageVariant1!);
            }
            else if (IsFbxStorageVariant2 && fbxStorageVariant2 != null)
            {
                return fbxStorageVariant2(FbxStorageVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.FbxStorageVariant1?>? fbxStorageVariant1 = null,
            global::System.Action<global::Zoo.FbxStorageVariant2?>? fbxStorageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFbxStorageVariant1)
            {
                fbxStorageVariant1?.Invoke(FbxStorageVariant1!);
            }
            else if (IsFbxStorageVariant2)
            {
                fbxStorageVariant2?.Invoke(FbxStorageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FbxStorageVariant1,
                typeof(global::Zoo.FbxStorageVariant1),
                FbxStorageVariant2,
                typeof(global::Zoo.FbxStorageVariant2),
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
        public bool Equals(FbxStorage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FbxStorageVariant1?>.Default.Equals(FbxStorageVariant1, other.FbxStorageVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FbxStorageVariant2?>.Default.Equals(FbxStorageVariant2, other.FbxStorageVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FbxStorage obj1, FbxStorage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FbxStorage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FbxStorage obj1, FbxStorage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FbxStorage o && Equals(o);
        }
    }
}
