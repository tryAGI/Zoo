#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Input format specifier.
    /// </summary>
    public readonly partial struct InputFormat3d : global::System.IEquatable<InputFormat3d>
    {
        /// <summary>
        /// Autodesk Filmbox (FBX) format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.InputFormat3dVariant1? InputFormat3dVariant1 { get; init; }
#else
        public global::Zoo.InputFormat3dVariant1? InputFormat3dVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFormat3dVariant1))]
#endif
        public bool IsInputFormat3dVariant1 => InputFormat3dVariant1 != null;

        /// <summary>
        /// Binary glTF 2.0. We refer to this as glTF since that is how our customers refer to it, but this can also import binary glTF (glb).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.InputFormat3dVariant2? InputFormat3dVariant2 { get; init; }
#else
        public global::Zoo.InputFormat3dVariant2? InputFormat3dVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFormat3dVariant2))]
#endif
        public bool IsInputFormat3dVariant2 => InputFormat3dVariant2 != null;

        /// <summary>
        /// Wavefront OBJ format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.InputFormat3dVariant3? InputFormat3dVariant3 { get; init; }
#else
        public global::Zoo.InputFormat3dVariant3? InputFormat3dVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFormat3dVariant3))]
#endif
        public bool IsInputFormat3dVariant3 => InputFormat3dVariant3 != null;

        /// <summary>
        /// The PLY Polygon File Format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.InputFormat3dVariant4? InputFormat3dVariant4 { get; init; }
#else
        public global::Zoo.InputFormat3dVariant4? InputFormat3dVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFormat3dVariant4))]
#endif
        public bool IsInputFormat3dVariant4 => InputFormat3dVariant4 != null;

        /// <summary>
        /// SolidWorks part (SLDPRT) format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.InputFormat3dVariant5? InputFormat3dVariant5 { get; init; }
#else
        public global::Zoo.InputFormat3dVariant5? InputFormat3dVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFormat3dVariant5))]
#endif
        public bool IsInputFormat3dVariant5 => InputFormat3dVariant5 != null;

        /// <summary>
        /// ISO 10303-21 (STEP) format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.InputFormat3dVariant6? InputFormat3dVariant6 { get; init; }
#else
        public global::Zoo.InputFormat3dVariant6? InputFormat3dVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFormat3dVariant6))]
#endif
        public bool IsInputFormat3dVariant6 => InputFormat3dVariant6 != null;

        /// <summary>
        /// *ST**ereo**L**ithography format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.InputFormat3dVariant7? InputFormat3dVariant7 { get; init; }
#else
        public global::Zoo.InputFormat3dVariant7? InputFormat3dVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFormat3dVariant7))]
#endif
        public bool IsInputFormat3dVariant7 => InputFormat3dVariant7 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputFormat3d(global::Zoo.InputFormat3dVariant1 value) => new InputFormat3d((global::Zoo.InputFormat3dVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.InputFormat3dVariant1?(InputFormat3d @this) => @this.InputFormat3dVariant1;

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(global::Zoo.InputFormat3dVariant1? value)
        {
            InputFormat3dVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputFormat3d(global::Zoo.InputFormat3dVariant2 value) => new InputFormat3d((global::Zoo.InputFormat3dVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.InputFormat3dVariant2?(InputFormat3d @this) => @this.InputFormat3dVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(global::Zoo.InputFormat3dVariant2? value)
        {
            InputFormat3dVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputFormat3d(global::Zoo.InputFormat3dVariant3 value) => new InputFormat3d((global::Zoo.InputFormat3dVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.InputFormat3dVariant3?(InputFormat3d @this) => @this.InputFormat3dVariant3;

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(global::Zoo.InputFormat3dVariant3? value)
        {
            InputFormat3dVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputFormat3d(global::Zoo.InputFormat3dVariant4 value) => new InputFormat3d((global::Zoo.InputFormat3dVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.InputFormat3dVariant4?(InputFormat3d @this) => @this.InputFormat3dVariant4;

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(global::Zoo.InputFormat3dVariant4? value)
        {
            InputFormat3dVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputFormat3d(global::Zoo.InputFormat3dVariant5 value) => new InputFormat3d((global::Zoo.InputFormat3dVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.InputFormat3dVariant5?(InputFormat3d @this) => @this.InputFormat3dVariant5;

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(global::Zoo.InputFormat3dVariant5? value)
        {
            InputFormat3dVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputFormat3d(global::Zoo.InputFormat3dVariant6 value) => new InputFormat3d((global::Zoo.InputFormat3dVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.InputFormat3dVariant6?(InputFormat3d @this) => @this.InputFormat3dVariant6;

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(global::Zoo.InputFormat3dVariant6? value)
        {
            InputFormat3dVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputFormat3d(global::Zoo.InputFormat3dVariant7 value) => new InputFormat3d((global::Zoo.InputFormat3dVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.InputFormat3dVariant7?(InputFormat3d @this) => @this.InputFormat3dVariant7;

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(global::Zoo.InputFormat3dVariant7? value)
        {
            InputFormat3dVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(
            global::Zoo.InputFormat3dVariant1? inputFormat3dVariant1,
            global::Zoo.InputFormat3dVariant2? inputFormat3dVariant2,
            global::Zoo.InputFormat3dVariant3? inputFormat3dVariant3,
            global::Zoo.InputFormat3dVariant4? inputFormat3dVariant4,
            global::Zoo.InputFormat3dVariant5? inputFormat3dVariant5,
            global::Zoo.InputFormat3dVariant6? inputFormat3dVariant6,
            global::Zoo.InputFormat3dVariant7? inputFormat3dVariant7
            )
        {
            InputFormat3dVariant1 = inputFormat3dVariant1;
            InputFormat3dVariant2 = inputFormat3dVariant2;
            InputFormat3dVariant3 = inputFormat3dVariant3;
            InputFormat3dVariant4 = inputFormat3dVariant4;
            InputFormat3dVariant5 = inputFormat3dVariant5;
            InputFormat3dVariant6 = inputFormat3dVariant6;
            InputFormat3dVariant7 = inputFormat3dVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputFormat3dVariant7 as object ??
            InputFormat3dVariant6 as object ??
            InputFormat3dVariant5 as object ??
            InputFormat3dVariant4 as object ??
            InputFormat3dVariant3 as object ??
            InputFormat3dVariant2 as object ??
            InputFormat3dVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputFormat3dVariant1?.ToString() ??
            InputFormat3dVariant2?.ToString() ??
            InputFormat3dVariant3?.ToString() ??
            InputFormat3dVariant4?.ToString() ??
            InputFormat3dVariant5?.ToString() ??
            InputFormat3dVariant6?.ToString() ??
            InputFormat3dVariant7?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 || !IsInputFormat3dVariant1 && IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && IsInputFormat3dVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.InputFormat3dVariant1?, TResult>? inputFormat3dVariant1 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant2?, TResult>? inputFormat3dVariant2 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant3?, TResult>? inputFormat3dVariant3 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant4?, TResult>? inputFormat3dVariant4 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant5?, TResult>? inputFormat3dVariant5 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant6?, TResult>? inputFormat3dVariant6 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant7?, TResult>? inputFormat3dVariant7 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputFormat3dVariant1 && inputFormat3dVariant1 != null)
            {
                return inputFormat3dVariant1(InputFormat3dVariant1!);
            }
            else if (IsInputFormat3dVariant2 && inputFormat3dVariant2 != null)
            {
                return inputFormat3dVariant2(InputFormat3dVariant2!);
            }
            else if (IsInputFormat3dVariant3 && inputFormat3dVariant3 != null)
            {
                return inputFormat3dVariant3(InputFormat3dVariant3!);
            }
            else if (IsInputFormat3dVariant4 && inputFormat3dVariant4 != null)
            {
                return inputFormat3dVariant4(InputFormat3dVariant4!);
            }
            else if (IsInputFormat3dVariant5 && inputFormat3dVariant5 != null)
            {
                return inputFormat3dVariant5(InputFormat3dVariant5!);
            }
            else if (IsInputFormat3dVariant6 && inputFormat3dVariant6 != null)
            {
                return inputFormat3dVariant6(InputFormat3dVariant6!);
            }
            else if (IsInputFormat3dVariant7 && inputFormat3dVariant7 != null)
            {
                return inputFormat3dVariant7(InputFormat3dVariant7!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.InputFormat3dVariant1?>? inputFormat3dVariant1 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant2?>? inputFormat3dVariant2 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant3?>? inputFormat3dVariant3 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant4?>? inputFormat3dVariant4 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant5?>? inputFormat3dVariant5 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant6?>? inputFormat3dVariant6 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant7?>? inputFormat3dVariant7 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputFormat3dVariant1)
            {
                inputFormat3dVariant1?.Invoke(InputFormat3dVariant1!);
            }
            else if (IsInputFormat3dVariant2)
            {
                inputFormat3dVariant2?.Invoke(InputFormat3dVariant2!);
            }
            else if (IsInputFormat3dVariant3)
            {
                inputFormat3dVariant3?.Invoke(InputFormat3dVariant3!);
            }
            else if (IsInputFormat3dVariant4)
            {
                inputFormat3dVariant4?.Invoke(InputFormat3dVariant4!);
            }
            else if (IsInputFormat3dVariant5)
            {
                inputFormat3dVariant5?.Invoke(InputFormat3dVariant5!);
            }
            else if (IsInputFormat3dVariant6)
            {
                inputFormat3dVariant6?.Invoke(InputFormat3dVariant6!);
            }
            else if (IsInputFormat3dVariant7)
            {
                inputFormat3dVariant7?.Invoke(InputFormat3dVariant7!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputFormat3dVariant1,
                typeof(global::Zoo.InputFormat3dVariant1),
                InputFormat3dVariant2,
                typeof(global::Zoo.InputFormat3dVariant2),
                InputFormat3dVariant3,
                typeof(global::Zoo.InputFormat3dVariant3),
                InputFormat3dVariant4,
                typeof(global::Zoo.InputFormat3dVariant4),
                InputFormat3dVariant5,
                typeof(global::Zoo.InputFormat3dVariant5),
                InputFormat3dVariant6,
                typeof(global::Zoo.InputFormat3dVariant6),
                InputFormat3dVariant7,
                typeof(global::Zoo.InputFormat3dVariant7),
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
        public bool Equals(InputFormat3d other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant1?>.Default.Equals(InputFormat3dVariant1, other.InputFormat3dVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant2?>.Default.Equals(InputFormat3dVariant2, other.InputFormat3dVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant3?>.Default.Equals(InputFormat3dVariant3, other.InputFormat3dVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant4?>.Default.Equals(InputFormat3dVariant4, other.InputFormat3dVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant5?>.Default.Equals(InputFormat3dVariant5, other.InputFormat3dVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant6?>.Default.Equals(InputFormat3dVariant6, other.InputFormat3dVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant7?>.Default.Equals(InputFormat3dVariant7, other.InputFormat3dVariant7) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputFormat3d obj1, InputFormat3d obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputFormat3d>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputFormat3d obj1, InputFormat3d obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputFormat3d o && Equals(o);
        }
    }
}
