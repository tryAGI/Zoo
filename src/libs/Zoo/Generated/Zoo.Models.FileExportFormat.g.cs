#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// The valid types of output file formats.
    /// </summary>
    public readonly partial struct FileExportFormat : global::System.IEquatable<FileExportFormat>
    {
        /// <summary>
        /// Autodesk Filmbox (FBX) format. &lt;https://en.wikipedia.org/wiki/FBX&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileExportFormatVariant1? FileExportFormatVariant1 { get; init; }
#else
        public global::Zoo.FileExportFormatVariant1? FileExportFormatVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileExportFormatVariant1))]
#endif
        public bool IsFileExportFormatVariant1 => FileExportFormatVariant1 != null;

        /// <summary>
        /// Binary glTF 2.0.<br/>
        /// This is a single binary with .glb extension.<br/>
        /// This is better if you want a compressed format as opposed to the human readable glTF that lacks compression.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileExportFormatVariant2? FileExportFormatVariant2 { get; init; }
#else
        public global::Zoo.FileExportFormatVariant2? FileExportFormatVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileExportFormatVariant2))]
#endif
        public bool IsFileExportFormatVariant2 => FileExportFormatVariant2 != null;

        /// <summary>
        /// glTF 2.0. Embedded glTF 2.0 (pretty printed).<br/>
        /// Single JSON file with .gltf extension binary data encoded as base64 data URIs.<br/>
        /// The JSON contents are pretty printed.<br/>
        /// It is human readable, single file, and you can view the diff easily in a git commit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileExportFormatVariant3? FileExportFormatVariant3 { get; init; }
#else
        public global::Zoo.FileExportFormatVariant3? FileExportFormatVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileExportFormatVariant3))]
#endif
        public bool IsFileExportFormatVariant3 => FileExportFormatVariant3 != null;

        /// <summary>
        /// The OBJ file format. &lt;https://en.wikipedia.org/wiki/Wavefront_.obj_file&gt; It may or may not have an an attached material (mtl // mtllib) within the file, but we interact with it as if it does not.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileExportFormatVariant4? FileExportFormatVariant4 { get; init; }
#else
        public global::Zoo.FileExportFormatVariant4? FileExportFormatVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileExportFormatVariant4))]
#endif
        public bool IsFileExportFormatVariant4 => FileExportFormatVariant4 != null;

        /// <summary>
        /// The PLY file format. &lt;https://en.wikipedia.org/wiki/PLY_(file_format)&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileExportFormatVariant5? FileExportFormatVariant5 { get; init; }
#else
        public global::Zoo.FileExportFormatVariant5? FileExportFormatVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileExportFormatVariant5))]
#endif
        public bool IsFileExportFormatVariant5 => FileExportFormatVariant5 != null;

        /// <summary>
        /// The STEP file format. &lt;https://en.wikipedia.org/wiki/ISO_10303-21&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileExportFormatVariant6? FileExportFormatVariant6 { get; init; }
#else
        public global::Zoo.FileExportFormatVariant6? FileExportFormatVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileExportFormatVariant6))]
#endif
        public bool IsFileExportFormatVariant6 => FileExportFormatVariant6 != null;

        /// <summary>
        /// The STL file format. &lt;https://en.wikipedia.org/wiki/STL_(file_format)&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.FileExportFormatVariant7? FileExportFormatVariant7 { get; init; }
#else
        public global::Zoo.FileExportFormatVariant7? FileExportFormatVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileExportFormatVariant7))]
#endif
        public bool IsFileExportFormatVariant7 => FileExportFormatVariant7 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileExportFormat(global::Zoo.FileExportFormatVariant1 value) => new FileExportFormat((global::Zoo.FileExportFormatVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileExportFormatVariant1?(FileExportFormat @this) => @this.FileExportFormatVariant1;

        /// <summary>
        /// 
        /// </summary>
        public FileExportFormat(global::Zoo.FileExportFormatVariant1? value)
        {
            FileExportFormatVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileExportFormat(global::Zoo.FileExportFormatVariant2 value) => new FileExportFormat((global::Zoo.FileExportFormatVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileExportFormatVariant2?(FileExportFormat @this) => @this.FileExportFormatVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FileExportFormat(global::Zoo.FileExportFormatVariant2? value)
        {
            FileExportFormatVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileExportFormat(global::Zoo.FileExportFormatVariant3 value) => new FileExportFormat((global::Zoo.FileExportFormatVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileExportFormatVariant3?(FileExportFormat @this) => @this.FileExportFormatVariant3;

        /// <summary>
        /// 
        /// </summary>
        public FileExportFormat(global::Zoo.FileExportFormatVariant3? value)
        {
            FileExportFormatVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileExportFormat(global::Zoo.FileExportFormatVariant4 value) => new FileExportFormat((global::Zoo.FileExportFormatVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileExportFormatVariant4?(FileExportFormat @this) => @this.FileExportFormatVariant4;

        /// <summary>
        /// 
        /// </summary>
        public FileExportFormat(global::Zoo.FileExportFormatVariant4? value)
        {
            FileExportFormatVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileExportFormat(global::Zoo.FileExportFormatVariant5 value) => new FileExportFormat((global::Zoo.FileExportFormatVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileExportFormatVariant5?(FileExportFormat @this) => @this.FileExportFormatVariant5;

        /// <summary>
        /// 
        /// </summary>
        public FileExportFormat(global::Zoo.FileExportFormatVariant5? value)
        {
            FileExportFormatVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileExportFormat(global::Zoo.FileExportFormatVariant6 value) => new FileExportFormat((global::Zoo.FileExportFormatVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileExportFormatVariant6?(FileExportFormat @this) => @this.FileExportFormatVariant6;

        /// <summary>
        /// 
        /// </summary>
        public FileExportFormat(global::Zoo.FileExportFormatVariant6? value)
        {
            FileExportFormatVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileExportFormat(global::Zoo.FileExportFormatVariant7 value) => new FileExportFormat((global::Zoo.FileExportFormatVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.FileExportFormatVariant7?(FileExportFormat @this) => @this.FileExportFormatVariant7;

        /// <summary>
        /// 
        /// </summary>
        public FileExportFormat(global::Zoo.FileExportFormatVariant7? value)
        {
            FileExportFormatVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FileExportFormat(
            global::Zoo.FileExportFormatVariant1? fileExportFormatVariant1,
            global::Zoo.FileExportFormatVariant2? fileExportFormatVariant2,
            global::Zoo.FileExportFormatVariant3? fileExportFormatVariant3,
            global::Zoo.FileExportFormatVariant4? fileExportFormatVariant4,
            global::Zoo.FileExportFormatVariant5? fileExportFormatVariant5,
            global::Zoo.FileExportFormatVariant6? fileExportFormatVariant6,
            global::Zoo.FileExportFormatVariant7? fileExportFormatVariant7
            )
        {
            FileExportFormatVariant1 = fileExportFormatVariant1;
            FileExportFormatVariant2 = fileExportFormatVariant2;
            FileExportFormatVariant3 = fileExportFormatVariant3;
            FileExportFormatVariant4 = fileExportFormatVariant4;
            FileExportFormatVariant5 = fileExportFormatVariant5;
            FileExportFormatVariant6 = fileExportFormatVariant6;
            FileExportFormatVariant7 = fileExportFormatVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FileExportFormatVariant7 as object ??
            FileExportFormatVariant6 as object ??
            FileExportFormatVariant5 as object ??
            FileExportFormatVariant4 as object ??
            FileExportFormatVariant3 as object ??
            FileExportFormatVariant2 as object ??
            FileExportFormatVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileExportFormatVariant1?.ToValueString() ??
            FileExportFormatVariant2?.ToValueString() ??
            FileExportFormatVariant3?.ToValueString() ??
            FileExportFormatVariant4?.ToValueString() ??
            FileExportFormatVariant5?.ToValueString() ??
            FileExportFormatVariant6?.ToValueString() ??
            FileExportFormatVariant7?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileExportFormatVariant1 && !IsFileExportFormatVariant2 && !IsFileExportFormatVariant3 && !IsFileExportFormatVariant4 && !IsFileExportFormatVariant5 && !IsFileExportFormatVariant6 && !IsFileExportFormatVariant7 || !IsFileExportFormatVariant1 && IsFileExportFormatVariant2 && !IsFileExportFormatVariant3 && !IsFileExportFormatVariant4 && !IsFileExportFormatVariant5 && !IsFileExportFormatVariant6 && !IsFileExportFormatVariant7 || !IsFileExportFormatVariant1 && !IsFileExportFormatVariant2 && IsFileExportFormatVariant3 && !IsFileExportFormatVariant4 && !IsFileExportFormatVariant5 && !IsFileExportFormatVariant6 && !IsFileExportFormatVariant7 || !IsFileExportFormatVariant1 && !IsFileExportFormatVariant2 && !IsFileExportFormatVariant3 && IsFileExportFormatVariant4 && !IsFileExportFormatVariant5 && !IsFileExportFormatVariant6 && !IsFileExportFormatVariant7 || !IsFileExportFormatVariant1 && !IsFileExportFormatVariant2 && !IsFileExportFormatVariant3 && !IsFileExportFormatVariant4 && IsFileExportFormatVariant5 && !IsFileExportFormatVariant6 && !IsFileExportFormatVariant7 || !IsFileExportFormatVariant1 && !IsFileExportFormatVariant2 && !IsFileExportFormatVariant3 && !IsFileExportFormatVariant4 && !IsFileExportFormatVariant5 && IsFileExportFormatVariant6 && !IsFileExportFormatVariant7 || !IsFileExportFormatVariant1 && !IsFileExportFormatVariant2 && !IsFileExportFormatVariant3 && !IsFileExportFormatVariant4 && !IsFileExportFormatVariant5 && !IsFileExportFormatVariant6 && IsFileExportFormatVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.FileExportFormatVariant1?, TResult>? fileExportFormatVariant1 = null,
            global::System.Func<global::Zoo.FileExportFormatVariant2?, TResult>? fileExportFormatVariant2 = null,
            global::System.Func<global::Zoo.FileExportFormatVariant3?, TResult>? fileExportFormatVariant3 = null,
            global::System.Func<global::Zoo.FileExportFormatVariant4?, TResult>? fileExportFormatVariant4 = null,
            global::System.Func<global::Zoo.FileExportFormatVariant5?, TResult>? fileExportFormatVariant5 = null,
            global::System.Func<global::Zoo.FileExportFormatVariant6?, TResult>? fileExportFormatVariant6 = null,
            global::System.Func<global::Zoo.FileExportFormatVariant7?, TResult>? fileExportFormatVariant7 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileExportFormatVariant1 && fileExportFormatVariant1 != null)
            {
                return fileExportFormatVariant1(FileExportFormatVariant1!);
            }
            else if (IsFileExportFormatVariant2 && fileExportFormatVariant2 != null)
            {
                return fileExportFormatVariant2(FileExportFormatVariant2!);
            }
            else if (IsFileExportFormatVariant3 && fileExportFormatVariant3 != null)
            {
                return fileExportFormatVariant3(FileExportFormatVariant3!);
            }
            else if (IsFileExportFormatVariant4 && fileExportFormatVariant4 != null)
            {
                return fileExportFormatVariant4(FileExportFormatVariant4!);
            }
            else if (IsFileExportFormatVariant5 && fileExportFormatVariant5 != null)
            {
                return fileExportFormatVariant5(FileExportFormatVariant5!);
            }
            else if (IsFileExportFormatVariant6 && fileExportFormatVariant6 != null)
            {
                return fileExportFormatVariant6(FileExportFormatVariant6!);
            }
            else if (IsFileExportFormatVariant7 && fileExportFormatVariant7 != null)
            {
                return fileExportFormatVariant7(FileExportFormatVariant7!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.FileExportFormatVariant1?>? fileExportFormatVariant1 = null,
            global::System.Action<global::Zoo.FileExportFormatVariant2?>? fileExportFormatVariant2 = null,
            global::System.Action<global::Zoo.FileExportFormatVariant3?>? fileExportFormatVariant3 = null,
            global::System.Action<global::Zoo.FileExportFormatVariant4?>? fileExportFormatVariant4 = null,
            global::System.Action<global::Zoo.FileExportFormatVariant5?>? fileExportFormatVariant5 = null,
            global::System.Action<global::Zoo.FileExportFormatVariant6?>? fileExportFormatVariant6 = null,
            global::System.Action<global::Zoo.FileExportFormatVariant7?>? fileExportFormatVariant7 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileExportFormatVariant1)
            {
                fileExportFormatVariant1?.Invoke(FileExportFormatVariant1!);
            }
            else if (IsFileExportFormatVariant2)
            {
                fileExportFormatVariant2?.Invoke(FileExportFormatVariant2!);
            }
            else if (IsFileExportFormatVariant3)
            {
                fileExportFormatVariant3?.Invoke(FileExportFormatVariant3!);
            }
            else if (IsFileExportFormatVariant4)
            {
                fileExportFormatVariant4?.Invoke(FileExportFormatVariant4!);
            }
            else if (IsFileExportFormatVariant5)
            {
                fileExportFormatVariant5?.Invoke(FileExportFormatVariant5!);
            }
            else if (IsFileExportFormatVariant6)
            {
                fileExportFormatVariant6?.Invoke(FileExportFormatVariant6!);
            }
            else if (IsFileExportFormatVariant7)
            {
                fileExportFormatVariant7?.Invoke(FileExportFormatVariant7!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileExportFormatVariant1,
                typeof(global::Zoo.FileExportFormatVariant1),
                FileExportFormatVariant2,
                typeof(global::Zoo.FileExportFormatVariant2),
                FileExportFormatVariant3,
                typeof(global::Zoo.FileExportFormatVariant3),
                FileExportFormatVariant4,
                typeof(global::Zoo.FileExportFormatVariant4),
                FileExportFormatVariant5,
                typeof(global::Zoo.FileExportFormatVariant5),
                FileExportFormatVariant6,
                typeof(global::Zoo.FileExportFormatVariant6),
                FileExportFormatVariant7,
                typeof(global::Zoo.FileExportFormatVariant7),
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
        public bool Equals(FileExportFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileExportFormatVariant1?>.Default.Equals(FileExportFormatVariant1, other.FileExportFormatVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileExportFormatVariant2?>.Default.Equals(FileExportFormatVariant2, other.FileExportFormatVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileExportFormatVariant3?>.Default.Equals(FileExportFormatVariant3, other.FileExportFormatVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileExportFormatVariant4?>.Default.Equals(FileExportFormatVariant4, other.FileExportFormatVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileExportFormatVariant5?>.Default.Equals(FileExportFormatVariant5, other.FileExportFormatVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileExportFormatVariant6?>.Default.Equals(FileExportFormatVariant6, other.FileExportFormatVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileExportFormatVariant7?>.Default.Equals(FileExportFormatVariant7, other.FileExportFormatVariant7) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FileExportFormat obj1, FileExportFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FileExportFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FileExportFormat obj1, FileExportFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FileExportFormat o && Equals(o);
        }
    }
}
