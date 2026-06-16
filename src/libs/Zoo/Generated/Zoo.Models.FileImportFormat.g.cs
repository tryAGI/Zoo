#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// The valid types of source file formats.
    /// </summary>
    public readonly partial struct FileImportFormat : global::System.IEquatable<FileImportFormat>
    {
        /// <summary>
        /// ACIS part format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileImportFormatVariant1? FileImportFormatVariant1 { get; init; }
#else
        public global::Zoo.FileImportFormatVariant1? FileImportFormatVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileImportFormatVariant1))]
#endif
        public bool IsFileImportFormatVariant1 => FileImportFormatVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileImportFormatVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.FileImportFormatVariant1? value)
        {
            value = FileImportFormatVariant1;
            return IsFileImportFormatVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.FileImportFormatVariant1 PickFileImportFormatVariant1() => IsFileImportFormatVariant1
            ? FileImportFormatVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileImportFormatVariant1' but the value was {ToString()}.");

        /// <summary>
        /// CATIA part format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileImportFormatVariant2? FileImportFormatVariant2 { get; init; }
#else
        public global::Zoo.FileImportFormatVariant2? FileImportFormatVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileImportFormatVariant2))]
#endif
        public bool IsFileImportFormatVariant2 => FileImportFormatVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileImportFormatVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.FileImportFormatVariant2? value)
        {
            value = FileImportFormatVariant2;
            return IsFileImportFormatVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.FileImportFormatVariant2 PickFileImportFormatVariant2() => IsFileImportFormatVariant2
            ? FileImportFormatVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileImportFormatVariant2' but the value was {ToString()}.");

        /// <summary>
        /// PTC Creo part format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileImportFormatVariant3? FileImportFormatVariant3 { get; init; }
#else
        public global::Zoo.FileImportFormatVariant3? FileImportFormatVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileImportFormatVariant3))]
#endif
        public bool IsFileImportFormatVariant3 => FileImportFormatVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileImportFormatVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.FileImportFormatVariant3? value)
        {
            value = FileImportFormatVariant3;
            return IsFileImportFormatVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.FileImportFormatVariant3 PickFileImportFormatVariant3() => IsFileImportFormatVariant3
            ? FileImportFormatVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileImportFormatVariant3' but the value was {ToString()}.");

        /// <summary>
        /// Autodesk Filmbox (FBX) format. &lt;https://en.wikipedia.org/wiki/FBX&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileImportFormatVariant4? FileImportFormatVariant4 { get; init; }
#else
        public global::Zoo.FileImportFormatVariant4? FileImportFormatVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileImportFormatVariant4))]
#endif
        public bool IsFileImportFormatVariant4 => FileImportFormatVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileImportFormatVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.FileImportFormatVariant4? value)
        {
            value = FileImportFormatVariant4;
            return IsFileImportFormatVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.FileImportFormatVariant4 PickFileImportFormatVariant4() => IsFileImportFormatVariant4
            ? FileImportFormatVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileImportFormatVariant4' but the value was {ToString()}.");

        /// <summary>
        /// glTF 2.0.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileImportFormatVariant5? FileImportFormatVariant5 { get; init; }
#else
        public global::Zoo.FileImportFormatVariant5? FileImportFormatVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileImportFormatVariant5))]
#endif
        public bool IsFileImportFormatVariant5 => FileImportFormatVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileImportFormatVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.FileImportFormatVariant5? value)
        {
            value = FileImportFormatVariant5;
            return IsFileImportFormatVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.FileImportFormatVariant5 PickFileImportFormatVariant5() => IsFileImportFormatVariant5
            ? FileImportFormatVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileImportFormatVariant5' but the value was {ToString()}.");

        /// <summary>
        /// Autodesk Inventor part format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileImportFormatVariant6? FileImportFormatVariant6 { get; init; }
#else
        public global::Zoo.FileImportFormatVariant6? FileImportFormatVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileImportFormatVariant6))]
#endif
        public bool IsFileImportFormatVariant6 => FileImportFormatVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileImportFormatVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.FileImportFormatVariant6? value)
        {
            value = FileImportFormatVariant6;
            return IsFileImportFormatVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.FileImportFormatVariant6 PickFileImportFormatVariant6() => IsFileImportFormatVariant6
            ? FileImportFormatVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileImportFormatVariant6' but the value was {ToString()}.");

        /// <summary>
        /// Siemens NX part format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileImportFormatVariant7? FileImportFormatVariant7 { get; init; }
#else
        public global::Zoo.FileImportFormatVariant7? FileImportFormatVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileImportFormatVariant7))]
#endif
        public bool IsFileImportFormatVariant7 => FileImportFormatVariant7 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileImportFormatVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.FileImportFormatVariant7? value)
        {
            value = FileImportFormatVariant7;
            return IsFileImportFormatVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.FileImportFormatVariant7 PickFileImportFormatVariant7() => IsFileImportFormatVariant7
            ? FileImportFormatVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileImportFormatVariant7' but the value was {ToString()}.");

        /// <summary>
        /// The OBJ file format. &lt;https://en.wikipedia.org/wiki/Wavefront_.obj_file&gt; It may or may not have an an attached material (mtl // mtllib) within the file, but we interact with it as if it does not.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileImportFormatVariant8? FileImportFormatVariant8 { get; init; }
#else
        public global::Zoo.FileImportFormatVariant8? FileImportFormatVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileImportFormatVariant8))]
#endif
        public bool IsFileImportFormatVariant8 => FileImportFormatVariant8 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileImportFormatVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.FileImportFormatVariant8? value)
        {
            value = FileImportFormatVariant8;
            return IsFileImportFormatVariant8;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.FileImportFormatVariant8 PickFileImportFormatVariant8() => IsFileImportFormatVariant8
            ? FileImportFormatVariant8!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileImportFormatVariant8' but the value was {ToString()}.");

        /// <summary>
        /// Parasolid part format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileImportFormatVariant9? FileImportFormatVariant9 { get; init; }
#else
        public global::Zoo.FileImportFormatVariant9? FileImportFormatVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileImportFormatVariant9))]
#endif
        public bool IsFileImportFormatVariant9 => FileImportFormatVariant9 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileImportFormatVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.FileImportFormatVariant9? value)
        {
            value = FileImportFormatVariant9;
            return IsFileImportFormatVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.FileImportFormatVariant9 PickFileImportFormatVariant9() => IsFileImportFormatVariant9
            ? FileImportFormatVariant9!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileImportFormatVariant9' but the value was {ToString()}.");

        /// <summary>
        /// The PLY file format. &lt;https://en.wikipedia.org/wiki/PLY_(file_format)&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileImportFormatVariant10? FileImportFormatVariant10 { get; init; }
#else
        public global::Zoo.FileImportFormatVariant10? FileImportFormatVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileImportFormatVariant10))]
#endif
        public bool IsFileImportFormatVariant10 => FileImportFormatVariant10 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileImportFormatVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.FileImportFormatVariant10? value)
        {
            value = FileImportFormatVariant10;
            return IsFileImportFormatVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.FileImportFormatVariant10 PickFileImportFormatVariant10() => IsFileImportFormatVariant10
            ? FileImportFormatVariant10!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileImportFormatVariant10' but the value was {ToString()}.");

        /// <summary>
        /// SolidWorks part (SLDPRT) format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileImportFormatVariant11? FileImportFormatVariant11 { get; init; }
#else
        public global::Zoo.FileImportFormatVariant11? FileImportFormatVariant11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileImportFormatVariant11))]
#endif
        public bool IsFileImportFormatVariant11 => FileImportFormatVariant11 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileImportFormatVariant11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.FileImportFormatVariant11? value)
        {
            value = FileImportFormatVariant11;
            return IsFileImportFormatVariant11;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.FileImportFormatVariant11 PickFileImportFormatVariant11() => IsFileImportFormatVariant11
            ? FileImportFormatVariant11!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileImportFormatVariant11' but the value was {ToString()}.");

        /// <summary>
        /// The STEP file format. &lt;https://en.wikipedia.org/wiki/ISO_10303-21&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileImportFormatVariant12? FileImportFormatVariant12 { get; init; }
#else
        public global::Zoo.FileImportFormatVariant12? FileImportFormatVariant12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileImportFormatVariant12))]
#endif
        public bool IsFileImportFormatVariant12 => FileImportFormatVariant12 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileImportFormatVariant12(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.FileImportFormatVariant12? value)
        {
            value = FileImportFormatVariant12;
            return IsFileImportFormatVariant12;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.FileImportFormatVariant12 PickFileImportFormatVariant12() => IsFileImportFormatVariant12
            ? FileImportFormatVariant12!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileImportFormatVariant12' but the value was {ToString()}.");

        /// <summary>
        /// The STL file format. &lt;https://en.wikipedia.org/wiki/STL_(file_format)&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileImportFormatVariant13? FileImportFormatVariant13 { get; init; }
#else
        public global::Zoo.FileImportFormatVariant13? FileImportFormatVariant13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileImportFormatVariant13))]
#endif
        public bool IsFileImportFormatVariant13 => FileImportFormatVariant13 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileImportFormatVariant13(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Zoo.FileImportFormatVariant13? value)
        {
            value = FileImportFormatVariant13;
            return IsFileImportFormatVariant13;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Zoo.FileImportFormatVariant13 PickFileImportFormatVariant13() => IsFileImportFormatVariant13
            ? FileImportFormatVariant13!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileImportFormatVariant13' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileImportFormat(global::Zoo.FileImportFormatVariant1 value) => new FileImportFormat((global::Zoo.FileImportFormatVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileImportFormatVariant1?(FileImportFormat @this) => @this.FileImportFormatVariant1;

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(global::Zoo.FileImportFormatVariant1? value)
        {
            FileImportFormatVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FileImportFormat FromFileImportFormatVariant1(global::Zoo.FileImportFormatVariant1? value) => new FileImportFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileImportFormat(global::Zoo.FileImportFormatVariant2 value) => new FileImportFormat((global::Zoo.FileImportFormatVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileImportFormatVariant2?(FileImportFormat @this) => @this.FileImportFormatVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(global::Zoo.FileImportFormatVariant2? value)
        {
            FileImportFormatVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FileImportFormat FromFileImportFormatVariant2(global::Zoo.FileImportFormatVariant2? value) => new FileImportFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileImportFormat(global::Zoo.FileImportFormatVariant3 value) => new FileImportFormat((global::Zoo.FileImportFormatVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileImportFormatVariant3?(FileImportFormat @this) => @this.FileImportFormatVariant3;

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(global::Zoo.FileImportFormatVariant3? value)
        {
            FileImportFormatVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FileImportFormat FromFileImportFormatVariant3(global::Zoo.FileImportFormatVariant3? value) => new FileImportFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileImportFormat(global::Zoo.FileImportFormatVariant4 value) => new FileImportFormat((global::Zoo.FileImportFormatVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileImportFormatVariant4?(FileImportFormat @this) => @this.FileImportFormatVariant4;

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(global::Zoo.FileImportFormatVariant4? value)
        {
            FileImportFormatVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FileImportFormat FromFileImportFormatVariant4(global::Zoo.FileImportFormatVariant4? value) => new FileImportFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileImportFormat(global::Zoo.FileImportFormatVariant5 value) => new FileImportFormat((global::Zoo.FileImportFormatVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileImportFormatVariant5?(FileImportFormat @this) => @this.FileImportFormatVariant5;

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(global::Zoo.FileImportFormatVariant5? value)
        {
            FileImportFormatVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FileImportFormat FromFileImportFormatVariant5(global::Zoo.FileImportFormatVariant5? value) => new FileImportFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileImportFormat(global::Zoo.FileImportFormatVariant6 value) => new FileImportFormat((global::Zoo.FileImportFormatVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileImportFormatVariant6?(FileImportFormat @this) => @this.FileImportFormatVariant6;

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(global::Zoo.FileImportFormatVariant6? value)
        {
            FileImportFormatVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FileImportFormat FromFileImportFormatVariant6(global::Zoo.FileImportFormatVariant6? value) => new FileImportFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileImportFormat(global::Zoo.FileImportFormatVariant7 value) => new FileImportFormat((global::Zoo.FileImportFormatVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileImportFormatVariant7?(FileImportFormat @this) => @this.FileImportFormatVariant7;

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(global::Zoo.FileImportFormatVariant7? value)
        {
            FileImportFormatVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FileImportFormat FromFileImportFormatVariant7(global::Zoo.FileImportFormatVariant7? value) => new FileImportFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileImportFormat(global::Zoo.FileImportFormatVariant8 value) => new FileImportFormat((global::Zoo.FileImportFormatVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileImportFormatVariant8?(FileImportFormat @this) => @this.FileImportFormatVariant8;

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(global::Zoo.FileImportFormatVariant8? value)
        {
            FileImportFormatVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FileImportFormat FromFileImportFormatVariant8(global::Zoo.FileImportFormatVariant8? value) => new FileImportFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileImportFormat(global::Zoo.FileImportFormatVariant9 value) => new FileImportFormat((global::Zoo.FileImportFormatVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileImportFormatVariant9?(FileImportFormat @this) => @this.FileImportFormatVariant9;

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(global::Zoo.FileImportFormatVariant9? value)
        {
            FileImportFormatVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FileImportFormat FromFileImportFormatVariant9(global::Zoo.FileImportFormatVariant9? value) => new FileImportFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileImportFormat(global::Zoo.FileImportFormatVariant10 value) => new FileImportFormat((global::Zoo.FileImportFormatVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileImportFormatVariant10?(FileImportFormat @this) => @this.FileImportFormatVariant10;

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(global::Zoo.FileImportFormatVariant10? value)
        {
            FileImportFormatVariant10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FileImportFormat FromFileImportFormatVariant10(global::Zoo.FileImportFormatVariant10? value) => new FileImportFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileImportFormat(global::Zoo.FileImportFormatVariant11 value) => new FileImportFormat((global::Zoo.FileImportFormatVariant11?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileImportFormatVariant11?(FileImportFormat @this) => @this.FileImportFormatVariant11;

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(global::Zoo.FileImportFormatVariant11? value)
        {
            FileImportFormatVariant11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FileImportFormat FromFileImportFormatVariant11(global::Zoo.FileImportFormatVariant11? value) => new FileImportFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileImportFormat(global::Zoo.FileImportFormatVariant12 value) => new FileImportFormat((global::Zoo.FileImportFormatVariant12?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileImportFormatVariant12?(FileImportFormat @this) => @this.FileImportFormatVariant12;

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(global::Zoo.FileImportFormatVariant12? value)
        {
            FileImportFormatVariant12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FileImportFormat FromFileImportFormatVariant12(global::Zoo.FileImportFormatVariant12? value) => new FileImportFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileImportFormat(global::Zoo.FileImportFormatVariant13 value) => new FileImportFormat((global::Zoo.FileImportFormatVariant13?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileImportFormatVariant13?(FileImportFormat @this) => @this.FileImportFormatVariant13;

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(global::Zoo.FileImportFormatVariant13? value)
        {
            FileImportFormatVariant13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FileImportFormat FromFileImportFormatVariant13(global::Zoo.FileImportFormatVariant13? value) => new FileImportFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public FileImportFormat(
            global::Zoo.FileImportFormatVariant1? fileImportFormatVariant1,
            global::Zoo.FileImportFormatVariant2? fileImportFormatVariant2,
            global::Zoo.FileImportFormatVariant3? fileImportFormatVariant3,
            global::Zoo.FileImportFormatVariant4? fileImportFormatVariant4,
            global::Zoo.FileImportFormatVariant5? fileImportFormatVariant5,
            global::Zoo.FileImportFormatVariant6? fileImportFormatVariant6,
            global::Zoo.FileImportFormatVariant7? fileImportFormatVariant7,
            global::Zoo.FileImportFormatVariant8? fileImportFormatVariant8,
            global::Zoo.FileImportFormatVariant9? fileImportFormatVariant9,
            global::Zoo.FileImportFormatVariant10? fileImportFormatVariant10,
            global::Zoo.FileImportFormatVariant11? fileImportFormatVariant11,
            global::Zoo.FileImportFormatVariant12? fileImportFormatVariant12,
            global::Zoo.FileImportFormatVariant13? fileImportFormatVariant13
            )
        {
            FileImportFormatVariant1 = fileImportFormatVariant1;
            FileImportFormatVariant2 = fileImportFormatVariant2;
            FileImportFormatVariant3 = fileImportFormatVariant3;
            FileImportFormatVariant4 = fileImportFormatVariant4;
            FileImportFormatVariant5 = fileImportFormatVariant5;
            FileImportFormatVariant6 = fileImportFormatVariant6;
            FileImportFormatVariant7 = fileImportFormatVariant7;
            FileImportFormatVariant8 = fileImportFormatVariant8;
            FileImportFormatVariant9 = fileImportFormatVariant9;
            FileImportFormatVariant10 = fileImportFormatVariant10;
            FileImportFormatVariant11 = fileImportFormatVariant11;
            FileImportFormatVariant12 = fileImportFormatVariant12;
            FileImportFormatVariant13 = fileImportFormatVariant13;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FileImportFormatVariant13 as object ??
            FileImportFormatVariant12 as object ??
            FileImportFormatVariant11 as object ??
            FileImportFormatVariant10 as object ??
            FileImportFormatVariant9 as object ??
            FileImportFormatVariant8 as object ??
            FileImportFormatVariant7 as object ??
            FileImportFormatVariant6 as object ??
            FileImportFormatVariant5 as object ??
            FileImportFormatVariant4 as object ??
            FileImportFormatVariant3 as object ??
            FileImportFormatVariant2 as object ??
            FileImportFormatVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileImportFormatVariant1?.ToValueString() ??
            FileImportFormatVariant2?.ToValueString() ??
            FileImportFormatVariant3?.ToValueString() ??
            FileImportFormatVariant4?.ToValueString() ??
            FileImportFormatVariant5?.ToValueString() ??
            FileImportFormatVariant6?.ToValueString() ??
            FileImportFormatVariant7?.ToValueString() ??
            FileImportFormatVariant8?.ToValueString() ??
            FileImportFormatVariant9?.ToValueString() ??
            FileImportFormatVariant10?.ToValueString() ??
            FileImportFormatVariant11?.ToValueString() ??
            FileImportFormatVariant12?.ToValueString() ??
            FileImportFormatVariant13?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 && !IsFileImportFormatVariant8 && !IsFileImportFormatVariant9 && !IsFileImportFormatVariant10 && !IsFileImportFormatVariant11 && !IsFileImportFormatVariant12 && !IsFileImportFormatVariant13 || !IsFileImportFormatVariant1 && IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 && !IsFileImportFormatVariant8 && !IsFileImportFormatVariant9 && !IsFileImportFormatVariant10 && !IsFileImportFormatVariant11 && !IsFileImportFormatVariant12 && !IsFileImportFormatVariant13 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 && !IsFileImportFormatVariant8 && !IsFileImportFormatVariant9 && !IsFileImportFormatVariant10 && !IsFileImportFormatVariant11 && !IsFileImportFormatVariant12 && !IsFileImportFormatVariant13 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 && !IsFileImportFormatVariant8 && !IsFileImportFormatVariant9 && !IsFileImportFormatVariant10 && !IsFileImportFormatVariant11 && !IsFileImportFormatVariant12 && !IsFileImportFormatVariant13 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 && !IsFileImportFormatVariant8 && !IsFileImportFormatVariant9 && !IsFileImportFormatVariant10 && !IsFileImportFormatVariant11 && !IsFileImportFormatVariant12 && !IsFileImportFormatVariant13 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 && !IsFileImportFormatVariant8 && !IsFileImportFormatVariant9 && !IsFileImportFormatVariant10 && !IsFileImportFormatVariant11 && !IsFileImportFormatVariant12 && !IsFileImportFormatVariant13 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && IsFileImportFormatVariant7 && !IsFileImportFormatVariant8 && !IsFileImportFormatVariant9 && !IsFileImportFormatVariant10 && !IsFileImportFormatVariant11 && !IsFileImportFormatVariant12 && !IsFileImportFormatVariant13 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 && IsFileImportFormatVariant8 && !IsFileImportFormatVariant9 && !IsFileImportFormatVariant10 && !IsFileImportFormatVariant11 && !IsFileImportFormatVariant12 && !IsFileImportFormatVariant13 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 && !IsFileImportFormatVariant8 && IsFileImportFormatVariant9 && !IsFileImportFormatVariant10 && !IsFileImportFormatVariant11 && !IsFileImportFormatVariant12 && !IsFileImportFormatVariant13 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 && !IsFileImportFormatVariant8 && !IsFileImportFormatVariant9 && IsFileImportFormatVariant10 && !IsFileImportFormatVariant11 && !IsFileImportFormatVariant12 && !IsFileImportFormatVariant13 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 && !IsFileImportFormatVariant8 && !IsFileImportFormatVariant9 && !IsFileImportFormatVariant10 && IsFileImportFormatVariant11 && !IsFileImportFormatVariant12 && !IsFileImportFormatVariant13 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 && !IsFileImportFormatVariant8 && !IsFileImportFormatVariant9 && !IsFileImportFormatVariant10 && !IsFileImportFormatVariant11 && IsFileImportFormatVariant12 && !IsFileImportFormatVariant13 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 && !IsFileImportFormatVariant8 && !IsFileImportFormatVariant9 && !IsFileImportFormatVariant10 && !IsFileImportFormatVariant11 && !IsFileImportFormatVariant12 && IsFileImportFormatVariant13;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.FileImportFormatVariant1?, TResult>? fileImportFormatVariant1 = null,
            global::System.Func<global::Zoo.FileImportFormatVariant2?, TResult>? fileImportFormatVariant2 = null,
            global::System.Func<global::Zoo.FileImportFormatVariant3?, TResult>? fileImportFormatVariant3 = null,
            global::System.Func<global::Zoo.FileImportFormatVariant4?, TResult>? fileImportFormatVariant4 = null,
            global::System.Func<global::Zoo.FileImportFormatVariant5?, TResult>? fileImportFormatVariant5 = null,
            global::System.Func<global::Zoo.FileImportFormatVariant6?, TResult>? fileImportFormatVariant6 = null,
            global::System.Func<global::Zoo.FileImportFormatVariant7?, TResult>? fileImportFormatVariant7 = null,
            global::System.Func<global::Zoo.FileImportFormatVariant8?, TResult>? fileImportFormatVariant8 = null,
            global::System.Func<global::Zoo.FileImportFormatVariant9?, TResult>? fileImportFormatVariant9 = null,
            global::System.Func<global::Zoo.FileImportFormatVariant10?, TResult>? fileImportFormatVariant10 = null,
            global::System.Func<global::Zoo.FileImportFormatVariant11?, TResult>? fileImportFormatVariant11 = null,
            global::System.Func<global::Zoo.FileImportFormatVariant12?, TResult>? fileImportFormatVariant12 = null,
            global::System.Func<global::Zoo.FileImportFormatVariant13?, TResult>? fileImportFormatVariant13 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileImportFormatVariant1 && fileImportFormatVariant1 != null)
            {
                return fileImportFormatVariant1(FileImportFormatVariant1!);
            }
            else if (IsFileImportFormatVariant2 && fileImportFormatVariant2 != null)
            {
                return fileImportFormatVariant2(FileImportFormatVariant2!);
            }
            else if (IsFileImportFormatVariant3 && fileImportFormatVariant3 != null)
            {
                return fileImportFormatVariant3(FileImportFormatVariant3!);
            }
            else if (IsFileImportFormatVariant4 && fileImportFormatVariant4 != null)
            {
                return fileImportFormatVariant4(FileImportFormatVariant4!);
            }
            else if (IsFileImportFormatVariant5 && fileImportFormatVariant5 != null)
            {
                return fileImportFormatVariant5(FileImportFormatVariant5!);
            }
            else if (IsFileImportFormatVariant6 && fileImportFormatVariant6 != null)
            {
                return fileImportFormatVariant6(FileImportFormatVariant6!);
            }
            else if (IsFileImportFormatVariant7 && fileImportFormatVariant7 != null)
            {
                return fileImportFormatVariant7(FileImportFormatVariant7!);
            }
            else if (IsFileImportFormatVariant8 && fileImportFormatVariant8 != null)
            {
                return fileImportFormatVariant8(FileImportFormatVariant8!);
            }
            else if (IsFileImportFormatVariant9 && fileImportFormatVariant9 != null)
            {
                return fileImportFormatVariant9(FileImportFormatVariant9!);
            }
            else if (IsFileImportFormatVariant10 && fileImportFormatVariant10 != null)
            {
                return fileImportFormatVariant10(FileImportFormatVariant10!);
            }
            else if (IsFileImportFormatVariant11 && fileImportFormatVariant11 != null)
            {
                return fileImportFormatVariant11(FileImportFormatVariant11!);
            }
            else if (IsFileImportFormatVariant12 && fileImportFormatVariant12 != null)
            {
                return fileImportFormatVariant12(FileImportFormatVariant12!);
            }
            else if (IsFileImportFormatVariant13 && fileImportFormatVariant13 != null)
            {
                return fileImportFormatVariant13(FileImportFormatVariant13!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.FileImportFormatVariant1?>? fileImportFormatVariant1 = null,

            global::System.Action<global::Zoo.FileImportFormatVariant2?>? fileImportFormatVariant2 = null,

            global::System.Action<global::Zoo.FileImportFormatVariant3?>? fileImportFormatVariant3 = null,

            global::System.Action<global::Zoo.FileImportFormatVariant4?>? fileImportFormatVariant4 = null,

            global::System.Action<global::Zoo.FileImportFormatVariant5?>? fileImportFormatVariant5 = null,

            global::System.Action<global::Zoo.FileImportFormatVariant6?>? fileImportFormatVariant6 = null,

            global::System.Action<global::Zoo.FileImportFormatVariant7?>? fileImportFormatVariant7 = null,

            global::System.Action<global::Zoo.FileImportFormatVariant8?>? fileImportFormatVariant8 = null,

            global::System.Action<global::Zoo.FileImportFormatVariant9?>? fileImportFormatVariant9 = null,

            global::System.Action<global::Zoo.FileImportFormatVariant10?>? fileImportFormatVariant10 = null,

            global::System.Action<global::Zoo.FileImportFormatVariant11?>? fileImportFormatVariant11 = null,

            global::System.Action<global::Zoo.FileImportFormatVariant12?>? fileImportFormatVariant12 = null,

            global::System.Action<global::Zoo.FileImportFormatVariant13?>? fileImportFormatVariant13 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileImportFormatVariant1)
            {
                fileImportFormatVariant1?.Invoke(FileImportFormatVariant1!);
            }
            else if (IsFileImportFormatVariant2)
            {
                fileImportFormatVariant2?.Invoke(FileImportFormatVariant2!);
            }
            else if (IsFileImportFormatVariant3)
            {
                fileImportFormatVariant3?.Invoke(FileImportFormatVariant3!);
            }
            else if (IsFileImportFormatVariant4)
            {
                fileImportFormatVariant4?.Invoke(FileImportFormatVariant4!);
            }
            else if (IsFileImportFormatVariant5)
            {
                fileImportFormatVariant5?.Invoke(FileImportFormatVariant5!);
            }
            else if (IsFileImportFormatVariant6)
            {
                fileImportFormatVariant6?.Invoke(FileImportFormatVariant6!);
            }
            else if (IsFileImportFormatVariant7)
            {
                fileImportFormatVariant7?.Invoke(FileImportFormatVariant7!);
            }
            else if (IsFileImportFormatVariant8)
            {
                fileImportFormatVariant8?.Invoke(FileImportFormatVariant8!);
            }
            else if (IsFileImportFormatVariant9)
            {
                fileImportFormatVariant9?.Invoke(FileImportFormatVariant9!);
            }
            else if (IsFileImportFormatVariant10)
            {
                fileImportFormatVariant10?.Invoke(FileImportFormatVariant10!);
            }
            else if (IsFileImportFormatVariant11)
            {
                fileImportFormatVariant11?.Invoke(FileImportFormatVariant11!);
            }
            else if (IsFileImportFormatVariant12)
            {
                fileImportFormatVariant12?.Invoke(FileImportFormatVariant12!);
            }
            else if (IsFileImportFormatVariant13)
            {
                fileImportFormatVariant13?.Invoke(FileImportFormatVariant13!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Zoo.FileImportFormatVariant1?>? fileImportFormatVariant1 = null,
            global::System.Action<global::Zoo.FileImportFormatVariant2?>? fileImportFormatVariant2 = null,
            global::System.Action<global::Zoo.FileImportFormatVariant3?>? fileImportFormatVariant3 = null,
            global::System.Action<global::Zoo.FileImportFormatVariant4?>? fileImportFormatVariant4 = null,
            global::System.Action<global::Zoo.FileImportFormatVariant5?>? fileImportFormatVariant5 = null,
            global::System.Action<global::Zoo.FileImportFormatVariant6?>? fileImportFormatVariant6 = null,
            global::System.Action<global::Zoo.FileImportFormatVariant7?>? fileImportFormatVariant7 = null,
            global::System.Action<global::Zoo.FileImportFormatVariant8?>? fileImportFormatVariant8 = null,
            global::System.Action<global::Zoo.FileImportFormatVariant9?>? fileImportFormatVariant9 = null,
            global::System.Action<global::Zoo.FileImportFormatVariant10?>? fileImportFormatVariant10 = null,
            global::System.Action<global::Zoo.FileImportFormatVariant11?>? fileImportFormatVariant11 = null,
            global::System.Action<global::Zoo.FileImportFormatVariant12?>? fileImportFormatVariant12 = null,
            global::System.Action<global::Zoo.FileImportFormatVariant13?>? fileImportFormatVariant13 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileImportFormatVariant1)
            {
                fileImportFormatVariant1?.Invoke(FileImportFormatVariant1!);
            }
            else if (IsFileImportFormatVariant2)
            {
                fileImportFormatVariant2?.Invoke(FileImportFormatVariant2!);
            }
            else if (IsFileImportFormatVariant3)
            {
                fileImportFormatVariant3?.Invoke(FileImportFormatVariant3!);
            }
            else if (IsFileImportFormatVariant4)
            {
                fileImportFormatVariant4?.Invoke(FileImportFormatVariant4!);
            }
            else if (IsFileImportFormatVariant5)
            {
                fileImportFormatVariant5?.Invoke(FileImportFormatVariant5!);
            }
            else if (IsFileImportFormatVariant6)
            {
                fileImportFormatVariant6?.Invoke(FileImportFormatVariant6!);
            }
            else if (IsFileImportFormatVariant7)
            {
                fileImportFormatVariant7?.Invoke(FileImportFormatVariant7!);
            }
            else if (IsFileImportFormatVariant8)
            {
                fileImportFormatVariant8?.Invoke(FileImportFormatVariant8!);
            }
            else if (IsFileImportFormatVariant9)
            {
                fileImportFormatVariant9?.Invoke(FileImportFormatVariant9!);
            }
            else if (IsFileImportFormatVariant10)
            {
                fileImportFormatVariant10?.Invoke(FileImportFormatVariant10!);
            }
            else if (IsFileImportFormatVariant11)
            {
                fileImportFormatVariant11?.Invoke(FileImportFormatVariant11!);
            }
            else if (IsFileImportFormatVariant12)
            {
                fileImportFormatVariant12?.Invoke(FileImportFormatVariant12!);
            }
            else if (IsFileImportFormatVariant13)
            {
                fileImportFormatVariant13?.Invoke(FileImportFormatVariant13!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileImportFormatVariant1,
                typeof(global::Zoo.FileImportFormatVariant1),
                FileImportFormatVariant2,
                typeof(global::Zoo.FileImportFormatVariant2),
                FileImportFormatVariant3,
                typeof(global::Zoo.FileImportFormatVariant3),
                FileImportFormatVariant4,
                typeof(global::Zoo.FileImportFormatVariant4),
                FileImportFormatVariant5,
                typeof(global::Zoo.FileImportFormatVariant5),
                FileImportFormatVariant6,
                typeof(global::Zoo.FileImportFormatVariant6),
                FileImportFormatVariant7,
                typeof(global::Zoo.FileImportFormatVariant7),
                FileImportFormatVariant8,
                typeof(global::Zoo.FileImportFormatVariant8),
                FileImportFormatVariant9,
                typeof(global::Zoo.FileImportFormatVariant9),
                FileImportFormatVariant10,
                typeof(global::Zoo.FileImportFormatVariant10),
                FileImportFormatVariant11,
                typeof(global::Zoo.FileImportFormatVariant11),
                FileImportFormatVariant12,
                typeof(global::Zoo.FileImportFormatVariant12),
                FileImportFormatVariant13,
                typeof(global::Zoo.FileImportFormatVariant13),
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
        public bool Equals(FileImportFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant1?>.Default.Equals(FileImportFormatVariant1, other.FileImportFormatVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant2?>.Default.Equals(FileImportFormatVariant2, other.FileImportFormatVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant3?>.Default.Equals(FileImportFormatVariant3, other.FileImportFormatVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant4?>.Default.Equals(FileImportFormatVariant4, other.FileImportFormatVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant5?>.Default.Equals(FileImportFormatVariant5, other.FileImportFormatVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant6?>.Default.Equals(FileImportFormatVariant6, other.FileImportFormatVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant7?>.Default.Equals(FileImportFormatVariant7, other.FileImportFormatVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant8?>.Default.Equals(FileImportFormatVariant8, other.FileImportFormatVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant9?>.Default.Equals(FileImportFormatVariant9, other.FileImportFormatVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant10?>.Default.Equals(FileImportFormatVariant10, other.FileImportFormatVariant10) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant11?>.Default.Equals(FileImportFormatVariant11, other.FileImportFormatVariant11) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant12?>.Default.Equals(FileImportFormatVariant12, other.FileImportFormatVariant12) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant13?>.Default.Equals(FileImportFormatVariant13, other.FileImportFormatVariant13) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FileImportFormat obj1, FileImportFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FileImportFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FileImportFormat obj1, FileImportFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FileImportFormat o && Equals(o);
        }
    }
}
