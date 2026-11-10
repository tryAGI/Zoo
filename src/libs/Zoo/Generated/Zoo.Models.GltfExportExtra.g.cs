#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Additional data that can be included in a glTF 2.0 export.
    /// </summary>
    public readonly partial struct GltfExportExtra : global::System.IEquatable<GltfExportExtra>
    {
        /// <summary>
        /// Sketch geometry and metadata.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.GltfExportExtraVariant1? GltfExportExtraVariant1 { get; init; }
#else
        public global::Zoo.GltfExportExtraVariant1? GltfExportExtraVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GltfExportExtraVariant1))]
#endif
        public bool IsGltfExportExtraVariant1 => GltfExportExtraVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGltfExportExtraVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.GltfExportExtraVariant1? value)
        {
            value = GltfExportExtraVariant1;
            return IsGltfExportExtraVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.GltfExportExtraVariant1 PickGltfExportExtraVariant1() => GltfExportExtraVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GltfExportExtraVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Sketch regions and their resolver metadata.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.GltfExportExtraVariant2? GltfExportExtraVariant2 { get; init; }
#else
        public global::Zoo.GltfExportExtraVariant2? GltfExportExtraVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GltfExportExtraVariant2))]
#endif
        public bool IsGltfExportExtraVariant2 => GltfExportExtraVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGltfExportExtraVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.GltfExportExtraVariant2? value)
        {
            value = GltfExportExtraVariant2;
            return IsGltfExportExtraVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.GltfExportExtraVariant2 PickGltfExportExtraVariant2() => GltfExportExtraVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GltfExportExtraVariant2' but the value was {ToString()}.");

        /// <summary>
        /// Original imported files.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.GltfExportExtraVariant3? GltfExportExtraVariant3 { get; init; }
#else
        public global::Zoo.GltfExportExtraVariant3? GltfExportExtraVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GltfExportExtraVariant3))]
#endif
        public bool IsGltfExportExtraVariant3 => GltfExportExtraVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGltfExportExtraVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.GltfExportExtraVariant3? value)
        {
            value = GltfExportExtraVariant3;
            return IsGltfExportExtraVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.GltfExportExtraVariant3 PickGltfExportExtraVariant3() => GltfExportExtraVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GltfExportExtraVariant3' but the value was {ToString()}.");

        /// <summary>
        /// Model-based definition (MBD) annotations.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.GltfExportExtraVariant4? GltfExportExtraVariant4 { get; init; }
#else
        public global::Zoo.GltfExportExtraVariant4? GltfExportExtraVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GltfExportExtraVariant4))]
#endif
        public bool IsGltfExportExtraVariant4 => GltfExportExtraVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGltfExportExtraVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.GltfExportExtraVariant4? value)
        {
            value = GltfExportExtraVariant4;
            return IsGltfExportExtraVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.GltfExportExtraVariant4 PickGltfExportExtraVariant4() => GltfExportExtraVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GltfExportExtraVariant4' but the value was {ToString()}.");

        /// <summary>
        /// UUIDs and source UUIDs on boundary-representation solids, edges, faces, and surfaces.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.GltfExportExtraVariant5? GltfExportExtraVariant5 { get; init; }
#else
        public global::Zoo.GltfExportExtraVariant5? GltfExportExtraVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GltfExportExtraVariant5))]
#endif
        public bool IsGltfExportExtraVariant5 => GltfExportExtraVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGltfExportExtraVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.GltfExportExtraVariant5? value)
        {
            value = GltfExportExtraVariant5;
            return IsGltfExportExtraVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Zoo.GltfExportExtraVariant5 PickGltfExportExtraVariant5() => GltfExportExtraVariant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GltfExportExtraVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GltfExportExtra(global::Zoo.GltfExportExtraVariant1 value) => new GltfExportExtra((global::Zoo.GltfExportExtraVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Zoo.GltfExportExtraVariant1?(GltfExportExtra @this) => @this.GltfExportExtraVariant1;

        /// <summary>
        ///
        /// </summary>
        public GltfExportExtra(global::Zoo.GltfExportExtraVariant1? value)
        {
            GltfExportExtraVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GltfExportExtra FromGltfExportExtraVariant1(global::Zoo.GltfExportExtraVariant1? value) => new GltfExportExtra(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GltfExportExtra(global::Zoo.GltfExportExtraVariant2 value) => new GltfExportExtra((global::Zoo.GltfExportExtraVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Zoo.GltfExportExtraVariant2?(GltfExportExtra @this) => @this.GltfExportExtraVariant2;

        /// <summary>
        ///
        /// </summary>
        public GltfExportExtra(global::Zoo.GltfExportExtraVariant2? value)
        {
            GltfExportExtraVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GltfExportExtra FromGltfExportExtraVariant2(global::Zoo.GltfExportExtraVariant2? value) => new GltfExportExtra(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GltfExportExtra(global::Zoo.GltfExportExtraVariant3 value) => new GltfExportExtra((global::Zoo.GltfExportExtraVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Zoo.GltfExportExtraVariant3?(GltfExportExtra @this) => @this.GltfExportExtraVariant3;

        /// <summary>
        ///
        /// </summary>
        public GltfExportExtra(global::Zoo.GltfExportExtraVariant3? value)
        {
            GltfExportExtraVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GltfExportExtra FromGltfExportExtraVariant3(global::Zoo.GltfExportExtraVariant3? value) => new GltfExportExtra(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GltfExportExtra(global::Zoo.GltfExportExtraVariant4 value) => new GltfExportExtra((global::Zoo.GltfExportExtraVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Zoo.GltfExportExtraVariant4?(GltfExportExtra @this) => @this.GltfExportExtraVariant4;

        /// <summary>
        ///
        /// </summary>
        public GltfExportExtra(global::Zoo.GltfExportExtraVariant4? value)
        {
            GltfExportExtraVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GltfExportExtra FromGltfExportExtraVariant4(global::Zoo.GltfExportExtraVariant4? value) => new GltfExportExtra(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GltfExportExtra(global::Zoo.GltfExportExtraVariant5 value) => new GltfExportExtra((global::Zoo.GltfExportExtraVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Zoo.GltfExportExtraVariant5?(GltfExportExtra @this) => @this.GltfExportExtraVariant5;

        /// <summary>
        ///
        /// </summary>
        public GltfExportExtra(global::Zoo.GltfExportExtraVariant5? value)
        {
            GltfExportExtraVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GltfExportExtra FromGltfExportExtraVariant5(global::Zoo.GltfExportExtraVariant5? value) => new GltfExportExtra(value);

        /// <summary>
        ///
        /// </summary>
        public GltfExportExtra(
            global::Zoo.GltfExportExtraVariant1? gltfExportExtraVariant1,
            global::Zoo.GltfExportExtraVariant2? gltfExportExtraVariant2,
            global::Zoo.GltfExportExtraVariant3? gltfExportExtraVariant3,
            global::Zoo.GltfExportExtraVariant4? gltfExportExtraVariant4,
            global::Zoo.GltfExportExtraVariant5? gltfExportExtraVariant5
            )
        {
            GltfExportExtraVariant1 = gltfExportExtraVariant1;
            GltfExportExtraVariant2 = gltfExportExtraVariant2;
            GltfExportExtraVariant3 = gltfExportExtraVariant3;
            GltfExportExtraVariant4 = gltfExportExtraVariant4;
            GltfExportExtraVariant5 = gltfExportExtraVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GltfExportExtraVariant5 as object ??
            GltfExportExtraVariant4 as object ??
            GltfExportExtraVariant3 as object ??
            GltfExportExtraVariant2 as object ??
            GltfExportExtraVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GltfExportExtraVariant1?.ToValueString() ??
            GltfExportExtraVariant2?.ToValueString() ??
            GltfExportExtraVariant3?.ToValueString() ??
            GltfExportExtraVariant4?.ToValueString() ??
            GltfExportExtraVariant5?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGltfExportExtraVariant1 && !IsGltfExportExtraVariant2 && !IsGltfExportExtraVariant3 && !IsGltfExportExtraVariant4 && !IsGltfExportExtraVariant5 || !IsGltfExportExtraVariant1 && IsGltfExportExtraVariant2 && !IsGltfExportExtraVariant3 && !IsGltfExportExtraVariant4 && !IsGltfExportExtraVariant5 || !IsGltfExportExtraVariant1 && !IsGltfExportExtraVariant2 && IsGltfExportExtraVariant3 && !IsGltfExportExtraVariant4 && !IsGltfExportExtraVariant5 || !IsGltfExportExtraVariant1 && !IsGltfExportExtraVariant2 && !IsGltfExportExtraVariant3 && IsGltfExportExtraVariant4 && !IsGltfExportExtraVariant5 || !IsGltfExportExtraVariant1 && !IsGltfExportExtraVariant2 && !IsGltfExportExtraVariant3 && !IsGltfExportExtraVariant4 && IsGltfExportExtraVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.GltfExportExtraVariant1?, TResult>? gltfExportExtraVariant1 = null,
            global::System.Func<global::Zoo.GltfExportExtraVariant2?, TResult>? gltfExportExtraVariant2 = null,
            global::System.Func<global::Zoo.GltfExportExtraVariant3?, TResult>? gltfExportExtraVariant3 = null,
            global::System.Func<global::Zoo.GltfExportExtraVariant4?, TResult>? gltfExportExtraVariant4 = null,
            global::System.Func<global::Zoo.GltfExportExtraVariant5?, TResult>? gltfExportExtraVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GltfExportExtraVariant1 is { } __value0 && gltfExportExtraVariant1 != null)
            {
                return gltfExportExtraVariant1(__value0);
            }
            else if (GltfExportExtraVariant2 is { } __value1 && gltfExportExtraVariant2 != null)
            {
                return gltfExportExtraVariant2(__value1);
            }
            else if (GltfExportExtraVariant3 is { } __value2 && gltfExportExtraVariant3 != null)
            {
                return gltfExportExtraVariant3(__value2);
            }
            else if (GltfExportExtraVariant4 is { } __value3 && gltfExportExtraVariant4 != null)
            {
                return gltfExportExtraVariant4(__value3);
            }
            else if (GltfExportExtraVariant5 is { } __value4 && gltfExportExtraVariant5 != null)
            {
                return gltfExportExtraVariant5(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.GltfExportExtraVariant1?>? gltfExportExtraVariant1 = null,

            global::System.Action<global::Zoo.GltfExportExtraVariant2?>? gltfExportExtraVariant2 = null,

            global::System.Action<global::Zoo.GltfExportExtraVariant3?>? gltfExportExtraVariant3 = null,

            global::System.Action<global::Zoo.GltfExportExtraVariant4?>? gltfExportExtraVariant4 = null,

            global::System.Action<global::Zoo.GltfExportExtraVariant5?>? gltfExportExtraVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GltfExportExtraVariant1 is { } __value0)
            {
                gltfExportExtraVariant1?.Invoke(__value0);
            }
            else if (GltfExportExtraVariant2 is { } __value1)
            {
                gltfExportExtraVariant2?.Invoke(__value1);
            }
            else if (GltfExportExtraVariant3 is { } __value2)
            {
                gltfExportExtraVariant3?.Invoke(__value2);
            }
            else if (GltfExportExtraVariant4 is { } __value3)
            {
                gltfExportExtraVariant4?.Invoke(__value3);
            }
            else if (GltfExportExtraVariant5 is { } __value4)
            {
                gltfExportExtraVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Zoo.GltfExportExtraVariant1?>? gltfExportExtraVariant1 = null,
            global::System.Action<global::Zoo.GltfExportExtraVariant2?>? gltfExportExtraVariant2 = null,
            global::System.Action<global::Zoo.GltfExportExtraVariant3?>? gltfExportExtraVariant3 = null,
            global::System.Action<global::Zoo.GltfExportExtraVariant4?>? gltfExportExtraVariant4 = null,
            global::System.Action<global::Zoo.GltfExportExtraVariant5?>? gltfExportExtraVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GltfExportExtraVariant1 is { } __value0)
            {
                gltfExportExtraVariant1?.Invoke(__value0);
            }
            else if (GltfExportExtraVariant2 is { } __value1)
            {
                gltfExportExtraVariant2?.Invoke(__value1);
            }
            else if (GltfExportExtraVariant3 is { } __value2)
            {
                gltfExportExtraVariant3?.Invoke(__value2);
            }
            else if (GltfExportExtraVariant4 is { } __value3)
            {
                gltfExportExtraVariant4?.Invoke(__value3);
            }
            else if (GltfExportExtraVariant5 is { } __value4)
            {
                gltfExportExtraVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GltfExportExtraVariant1,
                typeof(global::Zoo.GltfExportExtraVariant1),
                GltfExportExtraVariant2,
                typeof(global::Zoo.GltfExportExtraVariant2),
                GltfExportExtraVariant3,
                typeof(global::Zoo.GltfExportExtraVariant3),
                GltfExportExtraVariant4,
                typeof(global::Zoo.GltfExportExtraVariant4),
                GltfExportExtraVariant5,
                typeof(global::Zoo.GltfExportExtraVariant5),
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
        public bool Equals(GltfExportExtra other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.GltfExportExtraVariant1?>.Default.Equals(GltfExportExtraVariant1, other.GltfExportExtraVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.GltfExportExtraVariant2?>.Default.Equals(GltfExportExtraVariant2, other.GltfExportExtraVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.GltfExportExtraVariant3?>.Default.Equals(GltfExportExtraVariant3, other.GltfExportExtraVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.GltfExportExtraVariant4?>.Default.Equals(GltfExportExtraVariant4, other.GltfExportExtraVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.GltfExportExtraVariant5?>.Default.Equals(GltfExportExtraVariant5, other.GltfExportExtraVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GltfExportExtra obj1, GltfExportExtra obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GltfExportExtra>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GltfExportExtra obj1, GltfExportExtra obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GltfExportExtra o && Equals(o);
        }
    }
}
