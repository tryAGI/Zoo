#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Describes the storage format of a glTF 2.0 scene.
    /// </summary>
    public readonly partial struct GltfStorage : global::System.IEquatable<GltfStorage>
    {
        /// <summary>
        /// Binary glTF 2.0.<br/>
        /// This is a single binary with .glb extension.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.GltfStorageVariant1? GltfStorageVariant1 { get; init; }
#else
        public global::Zoo.GltfStorageVariant1? GltfStorageVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GltfStorageVariant1))]
#endif
        public bool IsGltfStorageVariant1 => GltfStorageVariant1 != null;

        /// <summary>
        /// Standard glTF 2.0.<br/>
        /// This is a JSON file with .gltf extension paired with a separate binary blob file with .bin extension.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.GltfStorageVariant2? GltfStorageVariant2 { get; init; }
#else
        public global::Zoo.GltfStorageVariant2? GltfStorageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GltfStorageVariant2))]
#endif
        public bool IsGltfStorageVariant2 => GltfStorageVariant2 != null;

        /// <summary>
        /// Embedded glTF 2.0.<br/>
        /// Single JSON file with .gltf extension binary data encoded as base64 data URIs.<br/>
        /// This is the default setting.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.GltfStorageVariant3? GltfStorageVariant3 { get; init; }
#else
        public global::Zoo.GltfStorageVariant3? GltfStorageVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GltfStorageVariant3))]
#endif
        public bool IsGltfStorageVariant3 => GltfStorageVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GltfStorage(global::Zoo.GltfStorageVariant1 value) => new GltfStorage((global::Zoo.GltfStorageVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.GltfStorageVariant1?(GltfStorage @this) => @this.GltfStorageVariant1;

        /// <summary>
        /// 
        /// </summary>
        public GltfStorage(global::Zoo.GltfStorageVariant1? value)
        {
            GltfStorageVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GltfStorage(global::Zoo.GltfStorageVariant2 value) => new GltfStorage((global::Zoo.GltfStorageVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.GltfStorageVariant2?(GltfStorage @this) => @this.GltfStorageVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GltfStorage(global::Zoo.GltfStorageVariant2? value)
        {
            GltfStorageVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GltfStorage(global::Zoo.GltfStorageVariant3 value) => new GltfStorage((global::Zoo.GltfStorageVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.GltfStorageVariant3?(GltfStorage @this) => @this.GltfStorageVariant3;

        /// <summary>
        /// 
        /// </summary>
        public GltfStorage(global::Zoo.GltfStorageVariant3? value)
        {
            GltfStorageVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GltfStorage(
            global::Zoo.GltfStorageVariant1? gltfStorageVariant1,
            global::Zoo.GltfStorageVariant2? gltfStorageVariant2,
            global::Zoo.GltfStorageVariant3? gltfStorageVariant3
            )
        {
            GltfStorageVariant1 = gltfStorageVariant1;
            GltfStorageVariant2 = gltfStorageVariant2;
            GltfStorageVariant3 = gltfStorageVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GltfStorageVariant3 as object ??
            GltfStorageVariant2 as object ??
            GltfStorageVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GltfStorageVariant1?.ToValueString() ??
            GltfStorageVariant2?.ToValueString() ??
            GltfStorageVariant3?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGltfStorageVariant1 && !IsGltfStorageVariant2 && !IsGltfStorageVariant3 || !IsGltfStorageVariant1 && IsGltfStorageVariant2 && !IsGltfStorageVariant3 || !IsGltfStorageVariant1 && !IsGltfStorageVariant2 && IsGltfStorageVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.GltfStorageVariant1?, TResult>? gltfStorageVariant1 = null,
            global::System.Func<global::Zoo.GltfStorageVariant2?, TResult>? gltfStorageVariant2 = null,
            global::System.Func<global::Zoo.GltfStorageVariant3?, TResult>? gltfStorageVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGltfStorageVariant1 && gltfStorageVariant1 != null)
            {
                return gltfStorageVariant1(GltfStorageVariant1!);
            }
            else if (IsGltfStorageVariant2 && gltfStorageVariant2 != null)
            {
                return gltfStorageVariant2(GltfStorageVariant2!);
            }
            else if (IsGltfStorageVariant3 && gltfStorageVariant3 != null)
            {
                return gltfStorageVariant3(GltfStorageVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.GltfStorageVariant1?>? gltfStorageVariant1 = null,
            global::System.Action<global::Zoo.GltfStorageVariant2?>? gltfStorageVariant2 = null,
            global::System.Action<global::Zoo.GltfStorageVariant3?>? gltfStorageVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGltfStorageVariant1)
            {
                gltfStorageVariant1?.Invoke(GltfStorageVariant1!);
            }
            else if (IsGltfStorageVariant2)
            {
                gltfStorageVariant2?.Invoke(GltfStorageVariant2!);
            }
            else if (IsGltfStorageVariant3)
            {
                gltfStorageVariant3?.Invoke(GltfStorageVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GltfStorageVariant1,
                typeof(global::Zoo.GltfStorageVariant1),
                GltfStorageVariant2,
                typeof(global::Zoo.GltfStorageVariant2),
                GltfStorageVariant3,
                typeof(global::Zoo.GltfStorageVariant3),
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
        public bool Equals(GltfStorage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.GltfStorageVariant1?>.Default.Equals(GltfStorageVariant1, other.GltfStorageVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.GltfStorageVariant2?>.Default.Equals(GltfStorageVariant2, other.GltfStorageVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.GltfStorageVariant3?>.Default.Equals(GltfStorageVariant3, other.GltfStorageVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GltfStorage obj1, GltfStorage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GltfStorage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GltfStorage obj1, GltfStorage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GltfStorage o && Equals(o);
        }
    }
}
