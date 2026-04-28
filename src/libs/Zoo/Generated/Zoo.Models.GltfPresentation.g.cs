#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Describes the presentation style of the glTF JSON.
    /// </summary>
    public readonly partial struct GltfPresentation : global::System.IEquatable<GltfPresentation>
    {
        /// <summary>
        /// Condense the JSON into the smallest possible size.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.GltfPresentationVariant1? GltfPresentationVariant1 { get; init; }
#else
        public global::Zoo.GltfPresentationVariant1? GltfPresentationVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GltfPresentationVariant1))]
#endif
        public bool IsGltfPresentationVariant1 => GltfPresentationVariant1 != null;

        /// <summary>
        /// Expand the JSON into a more human readable format.<br/>
        /// This is the default setting.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.GltfPresentationVariant2? GltfPresentationVariant2 { get; init; }
#else
        public global::Zoo.GltfPresentationVariant2? GltfPresentationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GltfPresentationVariant2))]
#endif
        public bool IsGltfPresentationVariant2 => GltfPresentationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GltfPresentation(global::Zoo.GltfPresentationVariant1 value) => new GltfPresentation((global::Zoo.GltfPresentationVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.GltfPresentationVariant1?(GltfPresentation @this) => @this.GltfPresentationVariant1;

        /// <summary>
        /// 
        /// </summary>
        public GltfPresentation(global::Zoo.GltfPresentationVariant1? value)
        {
            GltfPresentationVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GltfPresentation(global::Zoo.GltfPresentationVariant2 value) => new GltfPresentation((global::Zoo.GltfPresentationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.GltfPresentationVariant2?(GltfPresentation @this) => @this.GltfPresentationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GltfPresentation(global::Zoo.GltfPresentationVariant2? value)
        {
            GltfPresentationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GltfPresentation(
            global::Zoo.GltfPresentationVariant1? gltfPresentationVariant1,
            global::Zoo.GltfPresentationVariant2? gltfPresentationVariant2
            )
        {
            GltfPresentationVariant1 = gltfPresentationVariant1;
            GltfPresentationVariant2 = gltfPresentationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GltfPresentationVariant2 as object ??
            GltfPresentationVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GltfPresentationVariant1?.ToValueString() ??
            GltfPresentationVariant2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGltfPresentationVariant1 && !IsGltfPresentationVariant2 || !IsGltfPresentationVariant1 && IsGltfPresentationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.GltfPresentationVariant1?, TResult>? gltfPresentationVariant1 = null,
            global::System.Func<global::Zoo.GltfPresentationVariant2?, TResult>? gltfPresentationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGltfPresentationVariant1 && gltfPresentationVariant1 != null)
            {
                return gltfPresentationVariant1(GltfPresentationVariant1!);
            }
            else if (IsGltfPresentationVariant2 && gltfPresentationVariant2 != null)
            {
                return gltfPresentationVariant2(GltfPresentationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.GltfPresentationVariant1?>? gltfPresentationVariant1 = null,
            global::System.Action<global::Zoo.GltfPresentationVariant2?>? gltfPresentationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGltfPresentationVariant1)
            {
                gltfPresentationVariant1?.Invoke(GltfPresentationVariant1!);
            }
            else if (IsGltfPresentationVariant2)
            {
                gltfPresentationVariant2?.Invoke(GltfPresentationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GltfPresentationVariant1,
                typeof(global::Zoo.GltfPresentationVariant1),
                GltfPresentationVariant2,
                typeof(global::Zoo.GltfPresentationVariant2),
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
        public bool Equals(GltfPresentation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.GltfPresentationVariant1?>.Default.Equals(GltfPresentationVariant1, other.GltfPresentationVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.GltfPresentationVariant2?>.Default.Equals(GltfPresentationVariant2, other.GltfPresentationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GltfPresentation obj1, GltfPresentation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GltfPresentation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GltfPresentation obj1, GltfPresentation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GltfPresentation o && Equals(o);
        }
    }
}
