#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// The storage for the output PLY file.
    /// </summary>
    public readonly partial struct PlyStorage : global::System.IEquatable<PlyStorage>
    {
        /// <summary>
        /// Write numbers in their ascii representation (e.g. -13, 6.28, etc.). Properties are separated by spaces and elements are separated by line breaks.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.PlyStorageVariant1? PlyStorageVariant1 { get; init; }
#else
        public global::Zoo.PlyStorageVariant1? PlyStorageVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlyStorageVariant1))]
#endif
        public bool IsPlyStorageVariant1 => PlyStorageVariant1 != null;

        /// <summary>
        /// Encode payload as binary using little endian.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.PlyStorageVariant2? PlyStorageVariant2 { get; init; }
#else
        public global::Zoo.PlyStorageVariant2? PlyStorageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlyStorageVariant2))]
#endif
        public bool IsPlyStorageVariant2 => PlyStorageVariant2 != null;

        /// <summary>
        /// Encode payload as binary using big endian.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.PlyStorageVariant3? PlyStorageVariant3 { get; init; }
#else
        public global::Zoo.PlyStorageVariant3? PlyStorageVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlyStorageVariant3))]
#endif
        public bool IsPlyStorageVariant3 => PlyStorageVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlyStorage(global::Zoo.PlyStorageVariant1 value) => new PlyStorage((global::Zoo.PlyStorageVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.PlyStorageVariant1?(PlyStorage @this) => @this.PlyStorageVariant1;

        /// <summary>
        /// 
        /// </summary>
        public PlyStorage(global::Zoo.PlyStorageVariant1? value)
        {
            PlyStorageVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlyStorage(global::Zoo.PlyStorageVariant2 value) => new PlyStorage((global::Zoo.PlyStorageVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.PlyStorageVariant2?(PlyStorage @this) => @this.PlyStorageVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PlyStorage(global::Zoo.PlyStorageVariant2? value)
        {
            PlyStorageVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlyStorage(global::Zoo.PlyStorageVariant3 value) => new PlyStorage((global::Zoo.PlyStorageVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.PlyStorageVariant3?(PlyStorage @this) => @this.PlyStorageVariant3;

        /// <summary>
        /// 
        /// </summary>
        public PlyStorage(global::Zoo.PlyStorageVariant3? value)
        {
            PlyStorageVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PlyStorage(
            global::Zoo.PlyStorageVariant1? plyStorageVariant1,
            global::Zoo.PlyStorageVariant2? plyStorageVariant2,
            global::Zoo.PlyStorageVariant3? plyStorageVariant3
            )
        {
            PlyStorageVariant1 = plyStorageVariant1;
            PlyStorageVariant2 = plyStorageVariant2;
            PlyStorageVariant3 = plyStorageVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PlyStorageVariant3 as object ??
            PlyStorageVariant2 as object ??
            PlyStorageVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PlyStorageVariant1?.ToValueString() ??
            PlyStorageVariant2?.ToValueString() ??
            PlyStorageVariant3?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPlyStorageVariant1 && !IsPlyStorageVariant2 && !IsPlyStorageVariant3 || !IsPlyStorageVariant1 && IsPlyStorageVariant2 && !IsPlyStorageVariant3 || !IsPlyStorageVariant1 && !IsPlyStorageVariant2 && IsPlyStorageVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.PlyStorageVariant1?, TResult>? plyStorageVariant1 = null,
            global::System.Func<global::Zoo.PlyStorageVariant2?, TResult>? plyStorageVariant2 = null,
            global::System.Func<global::Zoo.PlyStorageVariant3?, TResult>? plyStorageVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlyStorageVariant1 && plyStorageVariant1 != null)
            {
                return plyStorageVariant1(PlyStorageVariant1!);
            }
            else if (IsPlyStorageVariant2 && plyStorageVariant2 != null)
            {
                return plyStorageVariant2(PlyStorageVariant2!);
            }
            else if (IsPlyStorageVariant3 && plyStorageVariant3 != null)
            {
                return plyStorageVariant3(PlyStorageVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.PlyStorageVariant1?>? plyStorageVariant1 = null,
            global::System.Action<global::Zoo.PlyStorageVariant2?>? plyStorageVariant2 = null,
            global::System.Action<global::Zoo.PlyStorageVariant3?>? plyStorageVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlyStorageVariant1)
            {
                plyStorageVariant1?.Invoke(PlyStorageVariant1!);
            }
            else if (IsPlyStorageVariant2)
            {
                plyStorageVariant2?.Invoke(PlyStorageVariant2!);
            }
            else if (IsPlyStorageVariant3)
            {
                plyStorageVariant3?.Invoke(PlyStorageVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PlyStorageVariant1,
                typeof(global::Zoo.PlyStorageVariant1),
                PlyStorageVariant2,
                typeof(global::Zoo.PlyStorageVariant2),
                PlyStorageVariant3,
                typeof(global::Zoo.PlyStorageVariant3),
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
        public bool Equals(PlyStorage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.PlyStorageVariant1?>.Default.Equals(PlyStorageVariant1, other.PlyStorageVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.PlyStorageVariant2?>.Default.Equals(PlyStorageVariant2, other.PlyStorageVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.PlyStorageVariant3?>.Default.Equals(PlyStorageVariant3, other.PlyStorageVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PlyStorage obj1, PlyStorage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PlyStorage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PlyStorage obj1, PlyStorage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PlyStorage o && Equals(o);
        }
    }
}
