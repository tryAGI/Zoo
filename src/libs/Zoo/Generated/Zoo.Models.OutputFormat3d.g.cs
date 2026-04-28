#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Output 3D format specifier.
    /// </summary>
    public readonly partial struct OutputFormat3d : global::System.IEquatable<OutputFormat3d>
    {
        /// <summary>
        /// Autodesk Filmbox (FBX) format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.OutputFormat3dVariant1? OutputFormat3dVariant1 { get; init; }
#else
        public global::Zoo.OutputFormat3dVariant1? OutputFormat3dVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFormat3dVariant1))]
#endif
        public bool IsOutputFormat3dVariant1 => OutputFormat3dVariant1 != null;

        /// <summary>
        /// glTF 2.0. We refer to this as glTF since that is how our customers refer to it, although by default it will be in binary format and thus technically (glb). If you prefer ASCII output, you can set that option for the export.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.OutputFormat3dVariant2? OutputFormat3dVariant2 { get; init; }
#else
        public global::Zoo.OutputFormat3dVariant2? OutputFormat3dVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFormat3dVariant2))]
#endif
        public bool IsOutputFormat3dVariant2 => OutputFormat3dVariant2 != null;

        /// <summary>
        /// Wavefront OBJ format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.OutputFormat3dVariant3? OutputFormat3dVariant3 { get; init; }
#else
        public global::Zoo.OutputFormat3dVariant3? OutputFormat3dVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFormat3dVariant3))]
#endif
        public bool IsOutputFormat3dVariant3 => OutputFormat3dVariant3 != null;

        /// <summary>
        /// The PLY Polygon File Format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.OutputFormat3dVariant4? OutputFormat3dVariant4 { get; init; }
#else
        public global::Zoo.OutputFormat3dVariant4? OutputFormat3dVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFormat3dVariant4))]
#endif
        public bool IsOutputFormat3dVariant4 => OutputFormat3dVariant4 != null;

        /// <summary>
        /// ISO 10303-21 (STEP) format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.OutputFormat3dVariant5? OutputFormat3dVariant5 { get; init; }
#else
        public global::Zoo.OutputFormat3dVariant5? OutputFormat3dVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFormat3dVariant5))]
#endif
        public bool IsOutputFormat3dVariant5 => OutputFormat3dVariant5 != null;

        /// <summary>
        /// *ST**ereo**L**ithography format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.OutputFormat3dVariant6? OutputFormat3dVariant6 { get; init; }
#else
        public global::Zoo.OutputFormat3dVariant6? OutputFormat3dVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFormat3dVariant6))]
#endif
        public bool IsOutputFormat3dVariant6 => OutputFormat3dVariant6 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFormat3d(global::Zoo.OutputFormat3dVariant1 value) => new OutputFormat3d((global::Zoo.OutputFormat3dVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.OutputFormat3dVariant1?(OutputFormat3d @this) => @this.OutputFormat3dVariant1;

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat3d(global::Zoo.OutputFormat3dVariant1? value)
        {
            OutputFormat3dVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFormat3d(global::Zoo.OutputFormat3dVariant2 value) => new OutputFormat3d((global::Zoo.OutputFormat3dVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.OutputFormat3dVariant2?(OutputFormat3d @this) => @this.OutputFormat3dVariant2;

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat3d(global::Zoo.OutputFormat3dVariant2? value)
        {
            OutputFormat3dVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFormat3d(global::Zoo.OutputFormat3dVariant3 value) => new OutputFormat3d((global::Zoo.OutputFormat3dVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.OutputFormat3dVariant3?(OutputFormat3d @this) => @this.OutputFormat3dVariant3;

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat3d(global::Zoo.OutputFormat3dVariant3? value)
        {
            OutputFormat3dVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFormat3d(global::Zoo.OutputFormat3dVariant4 value) => new OutputFormat3d((global::Zoo.OutputFormat3dVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.OutputFormat3dVariant4?(OutputFormat3d @this) => @this.OutputFormat3dVariant4;

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat3d(global::Zoo.OutputFormat3dVariant4? value)
        {
            OutputFormat3dVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFormat3d(global::Zoo.OutputFormat3dVariant5 value) => new OutputFormat3d((global::Zoo.OutputFormat3dVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.OutputFormat3dVariant5?(OutputFormat3d @this) => @this.OutputFormat3dVariant5;

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat3d(global::Zoo.OutputFormat3dVariant5? value)
        {
            OutputFormat3dVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFormat3d(global::Zoo.OutputFormat3dVariant6 value) => new OutputFormat3d((global::Zoo.OutputFormat3dVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.OutputFormat3dVariant6?(OutputFormat3d @this) => @this.OutputFormat3dVariant6;

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat3d(global::Zoo.OutputFormat3dVariant6? value)
        {
            OutputFormat3dVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat3d(
            global::Zoo.OutputFormat3dVariant1? outputFormat3dVariant1,
            global::Zoo.OutputFormat3dVariant2? outputFormat3dVariant2,
            global::Zoo.OutputFormat3dVariant3? outputFormat3dVariant3,
            global::Zoo.OutputFormat3dVariant4? outputFormat3dVariant4,
            global::Zoo.OutputFormat3dVariant5? outputFormat3dVariant5,
            global::Zoo.OutputFormat3dVariant6? outputFormat3dVariant6
            )
        {
            OutputFormat3dVariant1 = outputFormat3dVariant1;
            OutputFormat3dVariant2 = outputFormat3dVariant2;
            OutputFormat3dVariant3 = outputFormat3dVariant3;
            OutputFormat3dVariant4 = outputFormat3dVariant4;
            OutputFormat3dVariant5 = outputFormat3dVariant5;
            OutputFormat3dVariant6 = outputFormat3dVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputFormat3dVariant6 as object ??
            OutputFormat3dVariant5 as object ??
            OutputFormat3dVariant4 as object ??
            OutputFormat3dVariant3 as object ??
            OutputFormat3dVariant2 as object ??
            OutputFormat3dVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputFormat3dVariant1?.ToString() ??
            OutputFormat3dVariant2?.ToString() ??
            OutputFormat3dVariant3?.ToString() ??
            OutputFormat3dVariant4?.ToString() ??
            OutputFormat3dVariant5?.ToString() ??
            OutputFormat3dVariant6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputFormat3dVariant1 && !IsOutputFormat3dVariant2 && !IsOutputFormat3dVariant3 && !IsOutputFormat3dVariant4 && !IsOutputFormat3dVariant5 && !IsOutputFormat3dVariant6 || !IsOutputFormat3dVariant1 && IsOutputFormat3dVariant2 && !IsOutputFormat3dVariant3 && !IsOutputFormat3dVariant4 && !IsOutputFormat3dVariant5 && !IsOutputFormat3dVariant6 || !IsOutputFormat3dVariant1 && !IsOutputFormat3dVariant2 && IsOutputFormat3dVariant3 && !IsOutputFormat3dVariant4 && !IsOutputFormat3dVariant5 && !IsOutputFormat3dVariant6 || !IsOutputFormat3dVariant1 && !IsOutputFormat3dVariant2 && !IsOutputFormat3dVariant3 && IsOutputFormat3dVariant4 && !IsOutputFormat3dVariant5 && !IsOutputFormat3dVariant6 || !IsOutputFormat3dVariant1 && !IsOutputFormat3dVariant2 && !IsOutputFormat3dVariant3 && !IsOutputFormat3dVariant4 && IsOutputFormat3dVariant5 && !IsOutputFormat3dVariant6 || !IsOutputFormat3dVariant1 && !IsOutputFormat3dVariant2 && !IsOutputFormat3dVariant3 && !IsOutputFormat3dVariant4 && !IsOutputFormat3dVariant5 && IsOutputFormat3dVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.OutputFormat3dVariant1?, TResult>? outputFormat3dVariant1 = null,
            global::System.Func<global::Zoo.OutputFormat3dVariant2?, TResult>? outputFormat3dVariant2 = null,
            global::System.Func<global::Zoo.OutputFormat3dVariant3?, TResult>? outputFormat3dVariant3 = null,
            global::System.Func<global::Zoo.OutputFormat3dVariant4?, TResult>? outputFormat3dVariant4 = null,
            global::System.Func<global::Zoo.OutputFormat3dVariant5?, TResult>? outputFormat3dVariant5 = null,
            global::System.Func<global::Zoo.OutputFormat3dVariant6?, TResult>? outputFormat3dVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputFormat3dVariant1 && outputFormat3dVariant1 != null)
            {
                return outputFormat3dVariant1(OutputFormat3dVariant1!);
            }
            else if (IsOutputFormat3dVariant2 && outputFormat3dVariant2 != null)
            {
                return outputFormat3dVariant2(OutputFormat3dVariant2!);
            }
            else if (IsOutputFormat3dVariant3 && outputFormat3dVariant3 != null)
            {
                return outputFormat3dVariant3(OutputFormat3dVariant3!);
            }
            else if (IsOutputFormat3dVariant4 && outputFormat3dVariant4 != null)
            {
                return outputFormat3dVariant4(OutputFormat3dVariant4!);
            }
            else if (IsOutputFormat3dVariant5 && outputFormat3dVariant5 != null)
            {
                return outputFormat3dVariant5(OutputFormat3dVariant5!);
            }
            else if (IsOutputFormat3dVariant6 && outputFormat3dVariant6 != null)
            {
                return outputFormat3dVariant6(OutputFormat3dVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.OutputFormat3dVariant1?>? outputFormat3dVariant1 = null,
            global::System.Action<global::Zoo.OutputFormat3dVariant2?>? outputFormat3dVariant2 = null,
            global::System.Action<global::Zoo.OutputFormat3dVariant3?>? outputFormat3dVariant3 = null,
            global::System.Action<global::Zoo.OutputFormat3dVariant4?>? outputFormat3dVariant4 = null,
            global::System.Action<global::Zoo.OutputFormat3dVariant5?>? outputFormat3dVariant5 = null,
            global::System.Action<global::Zoo.OutputFormat3dVariant6?>? outputFormat3dVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputFormat3dVariant1)
            {
                outputFormat3dVariant1?.Invoke(OutputFormat3dVariant1!);
            }
            else if (IsOutputFormat3dVariant2)
            {
                outputFormat3dVariant2?.Invoke(OutputFormat3dVariant2!);
            }
            else if (IsOutputFormat3dVariant3)
            {
                outputFormat3dVariant3?.Invoke(OutputFormat3dVariant3!);
            }
            else if (IsOutputFormat3dVariant4)
            {
                outputFormat3dVariant4?.Invoke(OutputFormat3dVariant4!);
            }
            else if (IsOutputFormat3dVariant5)
            {
                outputFormat3dVariant5?.Invoke(OutputFormat3dVariant5!);
            }
            else if (IsOutputFormat3dVariant6)
            {
                outputFormat3dVariant6?.Invoke(OutputFormat3dVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputFormat3dVariant1,
                typeof(global::Zoo.OutputFormat3dVariant1),
                OutputFormat3dVariant2,
                typeof(global::Zoo.OutputFormat3dVariant2),
                OutputFormat3dVariant3,
                typeof(global::Zoo.OutputFormat3dVariant3),
                OutputFormat3dVariant4,
                typeof(global::Zoo.OutputFormat3dVariant4),
                OutputFormat3dVariant5,
                typeof(global::Zoo.OutputFormat3dVariant5),
                OutputFormat3dVariant6,
                typeof(global::Zoo.OutputFormat3dVariant6),
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
        public bool Equals(OutputFormat3d other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.OutputFormat3dVariant1?>.Default.Equals(OutputFormat3dVariant1, other.OutputFormat3dVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.OutputFormat3dVariant2?>.Default.Equals(OutputFormat3dVariant2, other.OutputFormat3dVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.OutputFormat3dVariant3?>.Default.Equals(OutputFormat3dVariant3, other.OutputFormat3dVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.OutputFormat3dVariant4?>.Default.Equals(OutputFormat3dVariant4, other.OutputFormat3dVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.OutputFormat3dVariant5?>.Default.Equals(OutputFormat3dVariant5, other.OutputFormat3dVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.OutputFormat3dVariant6?>.Default.Equals(OutputFormat3dVariant6, other.OutputFormat3dVariant6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputFormat3d obj1, OutputFormat3d obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputFormat3d>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputFormat3d obj1, OutputFormat3d obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputFormat3d o && Equals(o);
        }
    }
}
