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
        /// Autodesk Filmbox (FBX) format. &lt;https://en.wikipedia.org/wiki/FBX&gt;
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
        /// glTF 2.0.
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
        /// The OBJ file format. &lt;https://en.wikipedia.org/wiki/Wavefront_.obj_file&gt; It may or may not have an an attached material (mtl // mtllib) within the file, but we interact with it as if it does not.
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
        /// The PLY file format. &lt;https://en.wikipedia.org/wiki/PLY_(file_format)&gt;
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
        /// SolidWorks part (SLDPRT) format.
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
        /// The STEP file format. &lt;https://en.wikipedia.org/wiki/ISO_10303-21&gt;
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
        /// The STL file format. &lt;https://en.wikipedia.org/wiki/STL_(file_format)&gt;
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
        public FileImportFormat(
            global::Zoo.FileImportFormatVariant1? fileImportFormatVariant1,
            global::Zoo.FileImportFormatVariant2? fileImportFormatVariant2,
            global::Zoo.FileImportFormatVariant3? fileImportFormatVariant3,
            global::Zoo.FileImportFormatVariant4? fileImportFormatVariant4,
            global::Zoo.FileImportFormatVariant5? fileImportFormatVariant5,
            global::Zoo.FileImportFormatVariant6? fileImportFormatVariant6,
            global::Zoo.FileImportFormatVariant7? fileImportFormatVariant7
            )
        {
            FileImportFormatVariant1 = fileImportFormatVariant1;
            FileImportFormatVariant2 = fileImportFormatVariant2;
            FileImportFormatVariant3 = fileImportFormatVariant3;
            FileImportFormatVariant4 = fileImportFormatVariant4;
            FileImportFormatVariant5 = fileImportFormatVariant5;
            FileImportFormatVariant6 = fileImportFormatVariant6;
            FileImportFormatVariant7 = fileImportFormatVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            FileImportFormatVariant7?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 || !IsFileImportFormatVariant1 && IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && IsFileImportFormatVariant6 && !IsFileImportFormatVariant7 || !IsFileImportFormatVariant1 && !IsFileImportFormatVariant2 && !IsFileImportFormatVariant3 && !IsFileImportFormatVariant4 && !IsFileImportFormatVariant5 && !IsFileImportFormatVariant6 && IsFileImportFormatVariant7;
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
                global::System.Collections.Generic.EqualityComparer<global::Zoo.FileImportFormatVariant7?>.Default.Equals(FileImportFormatVariant7, other.FileImportFormatVariant7) 
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
