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
        /// ACIS part format.
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
        /// 
        /// </summary>
        public bool TryPickInputFormat3dVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.InputFormat3dVariant1? value)
        {
            value = InputFormat3dVariant1;
            return IsInputFormat3dVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.InputFormat3dVariant1 PickInputFormat3dVariant1() => IsInputFormat3dVariant1
            ? InputFormat3dVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFormat3dVariant1' but the value was {ToString()}.");

        /// <summary>
        /// CATIA part format.
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
        /// 
        /// </summary>
        public bool TryPickInputFormat3dVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.InputFormat3dVariant2? value)
        {
            value = InputFormat3dVariant2;
            return IsInputFormat3dVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.InputFormat3dVariant2 PickInputFormat3dVariant2() => IsInputFormat3dVariant2
            ? InputFormat3dVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFormat3dVariant2' but the value was {ToString()}.");

        /// <summary>
        /// PTC Creo part format.
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
        /// 
        /// </summary>
        public bool TryPickInputFormat3dVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.InputFormat3dVariant3? value)
        {
            value = InputFormat3dVariant3;
            return IsInputFormat3dVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.InputFormat3dVariant3 PickInputFormat3dVariant3() => IsInputFormat3dVariant3
            ? InputFormat3dVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFormat3dVariant3' but the value was {ToString()}.");

        /// <summary>
        /// Autodesk Filmbox (FBX) format.
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
        /// 
        /// </summary>
        public bool TryPickInputFormat3dVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.InputFormat3dVariant4? value)
        {
            value = InputFormat3dVariant4;
            return IsInputFormat3dVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.InputFormat3dVariant4 PickInputFormat3dVariant4() => IsInputFormat3dVariant4
            ? InputFormat3dVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFormat3dVariant4' but the value was {ToString()}.");

        /// <summary>
        /// Binary glTF 2.0. We refer to this as glTF since that is how our customers refer to it, but this can also import binary glTF (glb).
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
        /// 
        /// </summary>
        public bool TryPickInputFormat3dVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.InputFormat3dVariant5? value)
        {
            value = InputFormat3dVariant5;
            return IsInputFormat3dVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.InputFormat3dVariant5 PickInputFormat3dVariant5() => IsInputFormat3dVariant5
            ? InputFormat3dVariant5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFormat3dVariant5' but the value was {ToString()}.");

        /// <summary>
        /// Autodesk Inventor part format.
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
        /// 
        /// </summary>
        public bool TryPickInputFormat3dVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.InputFormat3dVariant6? value)
        {
            value = InputFormat3dVariant6;
            return IsInputFormat3dVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.InputFormat3dVariant6 PickInputFormat3dVariant6() => IsInputFormat3dVariant6
            ? InputFormat3dVariant6!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFormat3dVariant6' but the value was {ToString()}.");

        /// <summary>
        /// Siemens NX part format.
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
        public bool TryPickInputFormat3dVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.InputFormat3dVariant7? value)
        {
            value = InputFormat3dVariant7;
            return IsInputFormat3dVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.InputFormat3dVariant7 PickInputFormat3dVariant7() => IsInputFormat3dVariant7
            ? InputFormat3dVariant7!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFormat3dVariant7' but the value was {ToString()}.");

        /// <summary>
        /// Wavefront OBJ format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.InputFormat3dVariant8? InputFormat3dVariant8 { get; init; }
#else
        public global::Zoo.InputFormat3dVariant8? InputFormat3dVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFormat3dVariant8))]
#endif
        public bool IsInputFormat3dVariant8 => InputFormat3dVariant8 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputFormat3dVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.InputFormat3dVariant8? value)
        {
            value = InputFormat3dVariant8;
            return IsInputFormat3dVariant8;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.InputFormat3dVariant8 PickInputFormat3dVariant8() => IsInputFormat3dVariant8
            ? InputFormat3dVariant8!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFormat3dVariant8' but the value was {ToString()}.");

        /// <summary>
        /// Parasolid part format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.InputFormat3dVariant9? InputFormat3dVariant9 { get; init; }
#else
        public global::Zoo.InputFormat3dVariant9? InputFormat3dVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFormat3dVariant9))]
#endif
        public bool IsInputFormat3dVariant9 => InputFormat3dVariant9 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputFormat3dVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.InputFormat3dVariant9? value)
        {
            value = InputFormat3dVariant9;
            return IsInputFormat3dVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.InputFormat3dVariant9 PickInputFormat3dVariant9() => IsInputFormat3dVariant9
            ? InputFormat3dVariant9!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFormat3dVariant9' but the value was {ToString()}.");

        /// <summary>
        /// The PLY Polygon File Format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.InputFormat3dVariant10? InputFormat3dVariant10 { get; init; }
#else
        public global::Zoo.InputFormat3dVariant10? InputFormat3dVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFormat3dVariant10))]
#endif
        public bool IsInputFormat3dVariant10 => InputFormat3dVariant10 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputFormat3dVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.InputFormat3dVariant10? value)
        {
            value = InputFormat3dVariant10;
            return IsInputFormat3dVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.InputFormat3dVariant10 PickInputFormat3dVariant10() => IsInputFormat3dVariant10
            ? InputFormat3dVariant10!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFormat3dVariant10' but the value was {ToString()}.");

        /// <summary>
        /// SolidWorks part (SLDPRT) format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.InputFormat3dVariant11? InputFormat3dVariant11 { get; init; }
#else
        public global::Zoo.InputFormat3dVariant11? InputFormat3dVariant11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFormat3dVariant11))]
#endif
        public bool IsInputFormat3dVariant11 => InputFormat3dVariant11 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputFormat3dVariant11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.InputFormat3dVariant11? value)
        {
            value = InputFormat3dVariant11;
            return IsInputFormat3dVariant11;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.InputFormat3dVariant11 PickInputFormat3dVariant11() => IsInputFormat3dVariant11
            ? InputFormat3dVariant11!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFormat3dVariant11' but the value was {ToString()}.");

        /// <summary>
        /// ISO 10303-21 (STEP) format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.InputFormat3dVariant12? InputFormat3dVariant12 { get; init; }
#else
        public global::Zoo.InputFormat3dVariant12? InputFormat3dVariant12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFormat3dVariant12))]
#endif
        public bool IsInputFormat3dVariant12 => InputFormat3dVariant12 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputFormat3dVariant12(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.InputFormat3dVariant12? value)
        {
            value = InputFormat3dVariant12;
            return IsInputFormat3dVariant12;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.InputFormat3dVariant12 PickInputFormat3dVariant12() => IsInputFormat3dVariant12
            ? InputFormat3dVariant12!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFormat3dVariant12' but the value was {ToString()}.");

        /// <summary>
        /// *ST**ereo**L**ithography format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.InputFormat3dVariant13? InputFormat3dVariant13 { get; init; }
#else
        public global::Zoo.InputFormat3dVariant13? InputFormat3dVariant13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFormat3dVariant13))]
#endif
        public bool IsInputFormat3dVariant13 => InputFormat3dVariant13 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputFormat3dVariant13(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.InputFormat3dVariant13? value)
        {
            value = InputFormat3dVariant13;
            return IsInputFormat3dVariant13;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.InputFormat3dVariant13 PickInputFormat3dVariant13() => IsInputFormat3dVariant13
            ? InputFormat3dVariant13!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFormat3dVariant13' but the value was {ToString()}.");
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
        public static InputFormat3d FromInputFormat3dVariant1(global::Zoo.InputFormat3dVariant1? value) => new InputFormat3d(value);

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
        public static InputFormat3d FromInputFormat3dVariant2(global::Zoo.InputFormat3dVariant2? value) => new InputFormat3d(value);

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
        public static InputFormat3d FromInputFormat3dVariant3(global::Zoo.InputFormat3dVariant3? value) => new InputFormat3d(value);

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
        public static InputFormat3d FromInputFormat3dVariant4(global::Zoo.InputFormat3dVariant4? value) => new InputFormat3d(value);

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
        public static InputFormat3d FromInputFormat3dVariant5(global::Zoo.InputFormat3dVariant5? value) => new InputFormat3d(value);

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
        public static InputFormat3d FromInputFormat3dVariant6(global::Zoo.InputFormat3dVariant6? value) => new InputFormat3d(value);

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
        public static InputFormat3d FromInputFormat3dVariant7(global::Zoo.InputFormat3dVariant7? value) => new InputFormat3d(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputFormat3d(global::Zoo.InputFormat3dVariant8 value) => new InputFormat3d((global::Zoo.InputFormat3dVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.InputFormat3dVariant8?(InputFormat3d @this) => @this.InputFormat3dVariant8;

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(global::Zoo.InputFormat3dVariant8? value)
        {
            InputFormat3dVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputFormat3d FromInputFormat3dVariant8(global::Zoo.InputFormat3dVariant8? value) => new InputFormat3d(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputFormat3d(global::Zoo.InputFormat3dVariant9 value) => new InputFormat3d((global::Zoo.InputFormat3dVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.InputFormat3dVariant9?(InputFormat3d @this) => @this.InputFormat3dVariant9;

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(global::Zoo.InputFormat3dVariant9? value)
        {
            InputFormat3dVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputFormat3d FromInputFormat3dVariant9(global::Zoo.InputFormat3dVariant9? value) => new InputFormat3d(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputFormat3d(global::Zoo.InputFormat3dVariant10 value) => new InputFormat3d((global::Zoo.InputFormat3dVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.InputFormat3dVariant10?(InputFormat3d @this) => @this.InputFormat3dVariant10;

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(global::Zoo.InputFormat3dVariant10? value)
        {
            InputFormat3dVariant10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputFormat3d FromInputFormat3dVariant10(global::Zoo.InputFormat3dVariant10? value) => new InputFormat3d(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputFormat3d(global::Zoo.InputFormat3dVariant11 value) => new InputFormat3d((global::Zoo.InputFormat3dVariant11?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.InputFormat3dVariant11?(InputFormat3d @this) => @this.InputFormat3dVariant11;

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(global::Zoo.InputFormat3dVariant11? value)
        {
            InputFormat3dVariant11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputFormat3d FromInputFormat3dVariant11(global::Zoo.InputFormat3dVariant11? value) => new InputFormat3d(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputFormat3d(global::Zoo.InputFormat3dVariant12 value) => new InputFormat3d((global::Zoo.InputFormat3dVariant12?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.InputFormat3dVariant12?(InputFormat3d @this) => @this.InputFormat3dVariant12;

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(global::Zoo.InputFormat3dVariant12? value)
        {
            InputFormat3dVariant12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputFormat3d FromInputFormat3dVariant12(global::Zoo.InputFormat3dVariant12? value) => new InputFormat3d(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputFormat3d(global::Zoo.InputFormat3dVariant13 value) => new InputFormat3d((global::Zoo.InputFormat3dVariant13?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.InputFormat3dVariant13?(InputFormat3d @this) => @this.InputFormat3dVariant13;

        /// <summary>
        /// 
        /// </summary>
        public InputFormat3d(global::Zoo.InputFormat3dVariant13? value)
        {
            InputFormat3dVariant13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputFormat3d FromInputFormat3dVariant13(global::Zoo.InputFormat3dVariant13? value) => new InputFormat3d(value);

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
            global::Zoo.InputFormat3dVariant7? inputFormat3dVariant7,
            global::Zoo.InputFormat3dVariant8? inputFormat3dVariant8,
            global::Zoo.InputFormat3dVariant9? inputFormat3dVariant9,
            global::Zoo.InputFormat3dVariant10? inputFormat3dVariant10,
            global::Zoo.InputFormat3dVariant11? inputFormat3dVariant11,
            global::Zoo.InputFormat3dVariant12? inputFormat3dVariant12,
            global::Zoo.InputFormat3dVariant13? inputFormat3dVariant13
            )
        {
            InputFormat3dVariant1 = inputFormat3dVariant1;
            InputFormat3dVariant2 = inputFormat3dVariant2;
            InputFormat3dVariant3 = inputFormat3dVariant3;
            InputFormat3dVariant4 = inputFormat3dVariant4;
            InputFormat3dVariant5 = inputFormat3dVariant5;
            InputFormat3dVariant6 = inputFormat3dVariant6;
            InputFormat3dVariant7 = inputFormat3dVariant7;
            InputFormat3dVariant8 = inputFormat3dVariant8;
            InputFormat3dVariant9 = inputFormat3dVariant9;
            InputFormat3dVariant10 = inputFormat3dVariant10;
            InputFormat3dVariant11 = inputFormat3dVariant11;
            InputFormat3dVariant12 = inputFormat3dVariant12;
            InputFormat3dVariant13 = inputFormat3dVariant13;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputFormat3dVariant13 as object ??
            InputFormat3dVariant12 as object ??
            InputFormat3dVariant11 as object ??
            InputFormat3dVariant10 as object ??
            InputFormat3dVariant9 as object ??
            InputFormat3dVariant8 as object ??
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
            InputFormat3dVariant7?.ToString() ??
            InputFormat3dVariant8?.ToString() ??
            InputFormat3dVariant9?.ToString() ??
            InputFormat3dVariant10?.ToString() ??
            InputFormat3dVariant11?.ToString() ??
            InputFormat3dVariant12?.ToString() ??
            InputFormat3dVariant13?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 && !IsInputFormat3dVariant8 && !IsInputFormat3dVariant9 && !IsInputFormat3dVariant10 && !IsInputFormat3dVariant11 && !IsInputFormat3dVariant12 && !IsInputFormat3dVariant13 || !IsInputFormat3dVariant1 && IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 && !IsInputFormat3dVariant8 && !IsInputFormat3dVariant9 && !IsInputFormat3dVariant10 && !IsInputFormat3dVariant11 && !IsInputFormat3dVariant12 && !IsInputFormat3dVariant13 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 && !IsInputFormat3dVariant8 && !IsInputFormat3dVariant9 && !IsInputFormat3dVariant10 && !IsInputFormat3dVariant11 && !IsInputFormat3dVariant12 && !IsInputFormat3dVariant13 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 && !IsInputFormat3dVariant8 && !IsInputFormat3dVariant9 && !IsInputFormat3dVariant10 && !IsInputFormat3dVariant11 && !IsInputFormat3dVariant12 && !IsInputFormat3dVariant13 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 && !IsInputFormat3dVariant8 && !IsInputFormat3dVariant9 && !IsInputFormat3dVariant10 && !IsInputFormat3dVariant11 && !IsInputFormat3dVariant12 && !IsInputFormat3dVariant13 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 && !IsInputFormat3dVariant8 && !IsInputFormat3dVariant9 && !IsInputFormat3dVariant10 && !IsInputFormat3dVariant11 && !IsInputFormat3dVariant12 && !IsInputFormat3dVariant13 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && IsInputFormat3dVariant7 && !IsInputFormat3dVariant8 && !IsInputFormat3dVariant9 && !IsInputFormat3dVariant10 && !IsInputFormat3dVariant11 && !IsInputFormat3dVariant12 && !IsInputFormat3dVariant13 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 && IsInputFormat3dVariant8 && !IsInputFormat3dVariant9 && !IsInputFormat3dVariant10 && !IsInputFormat3dVariant11 && !IsInputFormat3dVariant12 && !IsInputFormat3dVariant13 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 && !IsInputFormat3dVariant8 && IsInputFormat3dVariant9 && !IsInputFormat3dVariant10 && !IsInputFormat3dVariant11 && !IsInputFormat3dVariant12 && !IsInputFormat3dVariant13 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 && !IsInputFormat3dVariant8 && !IsInputFormat3dVariant9 && IsInputFormat3dVariant10 && !IsInputFormat3dVariant11 && !IsInputFormat3dVariant12 && !IsInputFormat3dVariant13 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 && !IsInputFormat3dVariant8 && !IsInputFormat3dVariant9 && !IsInputFormat3dVariant10 && IsInputFormat3dVariant11 && !IsInputFormat3dVariant12 && !IsInputFormat3dVariant13 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 && !IsInputFormat3dVariant8 && !IsInputFormat3dVariant9 && !IsInputFormat3dVariant10 && !IsInputFormat3dVariant11 && IsInputFormat3dVariant12 && !IsInputFormat3dVariant13 || !IsInputFormat3dVariant1 && !IsInputFormat3dVariant2 && !IsInputFormat3dVariant3 && !IsInputFormat3dVariant4 && !IsInputFormat3dVariant5 && !IsInputFormat3dVariant6 && !IsInputFormat3dVariant7 && !IsInputFormat3dVariant8 && !IsInputFormat3dVariant9 && !IsInputFormat3dVariant10 && !IsInputFormat3dVariant11 && !IsInputFormat3dVariant12 && IsInputFormat3dVariant13;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.InputFormat3dVariant1, TResult>? inputFormat3dVariant1 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant2, TResult>? inputFormat3dVariant2 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant3, TResult>? inputFormat3dVariant3 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant4, TResult>? inputFormat3dVariant4 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant5, TResult>? inputFormat3dVariant5 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant6, TResult>? inputFormat3dVariant6 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant7, TResult>? inputFormat3dVariant7 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant8, TResult>? inputFormat3dVariant8 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant9, TResult>? inputFormat3dVariant9 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant10, TResult>? inputFormat3dVariant10 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant11, TResult>? inputFormat3dVariant11 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant12, TResult>? inputFormat3dVariant12 = null,
            global::System.Func<global::Zoo.InputFormat3dVariant13, TResult>? inputFormat3dVariant13 = null,
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
            else if (IsInputFormat3dVariant8 && inputFormat3dVariant8 != null)
            {
                return inputFormat3dVariant8(InputFormat3dVariant8!);
            }
            else if (IsInputFormat3dVariant9 && inputFormat3dVariant9 != null)
            {
                return inputFormat3dVariant9(InputFormat3dVariant9!);
            }
            else if (IsInputFormat3dVariant10 && inputFormat3dVariant10 != null)
            {
                return inputFormat3dVariant10(InputFormat3dVariant10!);
            }
            else if (IsInputFormat3dVariant11 && inputFormat3dVariant11 != null)
            {
                return inputFormat3dVariant11(InputFormat3dVariant11!);
            }
            else if (IsInputFormat3dVariant12 && inputFormat3dVariant12 != null)
            {
                return inputFormat3dVariant12(InputFormat3dVariant12!);
            }
            else if (IsInputFormat3dVariant13 && inputFormat3dVariant13 != null)
            {
                return inputFormat3dVariant13(InputFormat3dVariant13!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.InputFormat3dVariant1>? inputFormat3dVariant1 = null,

            global::System.Action<global::Zoo.InputFormat3dVariant2>? inputFormat3dVariant2 = null,

            global::System.Action<global::Zoo.InputFormat3dVariant3>? inputFormat3dVariant3 = null,

            global::System.Action<global::Zoo.InputFormat3dVariant4>? inputFormat3dVariant4 = null,

            global::System.Action<global::Zoo.InputFormat3dVariant5>? inputFormat3dVariant5 = null,

            global::System.Action<global::Zoo.InputFormat3dVariant6>? inputFormat3dVariant6 = null,

            global::System.Action<global::Zoo.InputFormat3dVariant7>? inputFormat3dVariant7 = null,

            global::System.Action<global::Zoo.InputFormat3dVariant8>? inputFormat3dVariant8 = null,

            global::System.Action<global::Zoo.InputFormat3dVariant9>? inputFormat3dVariant9 = null,

            global::System.Action<global::Zoo.InputFormat3dVariant10>? inputFormat3dVariant10 = null,

            global::System.Action<global::Zoo.InputFormat3dVariant11>? inputFormat3dVariant11 = null,

            global::System.Action<global::Zoo.InputFormat3dVariant12>? inputFormat3dVariant12 = null,

            global::System.Action<global::Zoo.InputFormat3dVariant13>? inputFormat3dVariant13 = null,
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
            else if (IsInputFormat3dVariant8)
            {
                inputFormat3dVariant8?.Invoke(InputFormat3dVariant8!);
            }
            else if (IsInputFormat3dVariant9)
            {
                inputFormat3dVariant9?.Invoke(InputFormat3dVariant9!);
            }
            else if (IsInputFormat3dVariant10)
            {
                inputFormat3dVariant10?.Invoke(InputFormat3dVariant10!);
            }
            else if (IsInputFormat3dVariant11)
            {
                inputFormat3dVariant11?.Invoke(InputFormat3dVariant11!);
            }
            else if (IsInputFormat3dVariant12)
            {
                inputFormat3dVariant12?.Invoke(InputFormat3dVariant12!);
            }
            else if (IsInputFormat3dVariant13)
            {
                inputFormat3dVariant13?.Invoke(InputFormat3dVariant13!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Zoo.InputFormat3dVariant1>? inputFormat3dVariant1 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant2>? inputFormat3dVariant2 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant3>? inputFormat3dVariant3 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant4>? inputFormat3dVariant4 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant5>? inputFormat3dVariant5 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant6>? inputFormat3dVariant6 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant7>? inputFormat3dVariant7 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant8>? inputFormat3dVariant8 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant9>? inputFormat3dVariant9 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant10>? inputFormat3dVariant10 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant11>? inputFormat3dVariant11 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant12>? inputFormat3dVariant12 = null,
            global::System.Action<global::Zoo.InputFormat3dVariant13>? inputFormat3dVariant13 = null,
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
            else if (IsInputFormat3dVariant8)
            {
                inputFormat3dVariant8?.Invoke(InputFormat3dVariant8!);
            }
            else if (IsInputFormat3dVariant9)
            {
                inputFormat3dVariant9?.Invoke(InputFormat3dVariant9!);
            }
            else if (IsInputFormat3dVariant10)
            {
                inputFormat3dVariant10?.Invoke(InputFormat3dVariant10!);
            }
            else if (IsInputFormat3dVariant11)
            {
                inputFormat3dVariant11?.Invoke(InputFormat3dVariant11!);
            }
            else if (IsInputFormat3dVariant12)
            {
                inputFormat3dVariant12?.Invoke(InputFormat3dVariant12!);
            }
            else if (IsInputFormat3dVariant13)
            {
                inputFormat3dVariant13?.Invoke(InputFormat3dVariant13!);
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
                InputFormat3dVariant8,
                typeof(global::Zoo.InputFormat3dVariant8),
                InputFormat3dVariant9,
                typeof(global::Zoo.InputFormat3dVariant9),
                InputFormat3dVariant10,
                typeof(global::Zoo.InputFormat3dVariant10),
                InputFormat3dVariant11,
                typeof(global::Zoo.InputFormat3dVariant11),
                InputFormat3dVariant12,
                typeof(global::Zoo.InputFormat3dVariant12),
                InputFormat3dVariant13,
                typeof(global::Zoo.InputFormat3dVariant13),
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
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant7?>.Default.Equals(InputFormat3dVariant7, other.InputFormat3dVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant8?>.Default.Equals(InputFormat3dVariant8, other.InputFormat3dVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant9?>.Default.Equals(InputFormat3dVariant9, other.InputFormat3dVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant10?>.Default.Equals(InputFormat3dVariant10, other.InputFormat3dVariant10) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant11?>.Default.Equals(InputFormat3dVariant11, other.InputFormat3dVariant11) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant12?>.Default.Equals(InputFormat3dVariant12, other.InputFormat3dVariant12) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.InputFormat3dVariant13?>.Default.Equals(InputFormat3dVariant13, other.InputFormat3dVariant13) 
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
