#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// A type of Text-to-CAD model.
    /// </summary>
    public readonly partial struct TextToCadModel : global::System.IEquatable<TextToCadModel>
    {
        /// <summary>
        /// CAD.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.TextToCadModelVariant1? TextToCadModelVariant1 { get; init; }
#else
        public global::Zoo.TextToCadModelVariant1? TextToCadModelVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToCadModelVariant1))]
#endif
        public bool IsTextToCadModelVariant1 => TextToCadModelVariant1 != null;

        /// <summary>
        /// KCL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.TextToCadModelVariant2? TextToCadModelVariant2 { get; init; }
#else
        public global::Zoo.TextToCadModelVariant2? TextToCadModelVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToCadModelVariant2))]
#endif
        public bool IsTextToCadModelVariant2 => TextToCadModelVariant2 != null;

        /// <summary>
        /// KCL iteration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.TextToCadModelVariant3? TextToCadModelVariant3 { get; init; }
#else
        public global::Zoo.TextToCadModelVariant3? TextToCadModelVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToCadModelVariant3))]
#endif
        public bool IsTextToCadModelVariant3 => TextToCadModelVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToCadModel(global::Zoo.TextToCadModelVariant1 value) => new TextToCadModel((global::Zoo.TextToCadModelVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.TextToCadModelVariant1?(TextToCadModel @this) => @this.TextToCadModelVariant1;

        /// <summary>
        /// 
        /// </summary>
        public TextToCadModel(global::Zoo.TextToCadModelVariant1? value)
        {
            TextToCadModelVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToCadModel(global::Zoo.TextToCadModelVariant2 value) => new TextToCadModel((global::Zoo.TextToCadModelVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.TextToCadModelVariant2?(TextToCadModel @this) => @this.TextToCadModelVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TextToCadModel(global::Zoo.TextToCadModelVariant2? value)
        {
            TextToCadModelVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToCadModel(global::Zoo.TextToCadModelVariant3 value) => new TextToCadModel((global::Zoo.TextToCadModelVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.TextToCadModelVariant3?(TextToCadModel @this) => @this.TextToCadModelVariant3;

        /// <summary>
        /// 
        /// </summary>
        public TextToCadModel(global::Zoo.TextToCadModelVariant3? value)
        {
            TextToCadModelVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TextToCadModel(
            global::Zoo.TextToCadModelVariant1? textToCadModelVariant1,
            global::Zoo.TextToCadModelVariant2? textToCadModelVariant2,
            global::Zoo.TextToCadModelVariant3? textToCadModelVariant3
            )
        {
            TextToCadModelVariant1 = textToCadModelVariant1;
            TextToCadModelVariant2 = textToCadModelVariant2;
            TextToCadModelVariant3 = textToCadModelVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextToCadModelVariant3 as object ??
            TextToCadModelVariant2 as object ??
            TextToCadModelVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextToCadModelVariant1?.ToValueString() ??
            TextToCadModelVariant2?.ToValueString() ??
            TextToCadModelVariant3?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextToCadModelVariant1 && !IsTextToCadModelVariant2 && !IsTextToCadModelVariant3 || !IsTextToCadModelVariant1 && IsTextToCadModelVariant2 && !IsTextToCadModelVariant3 || !IsTextToCadModelVariant1 && !IsTextToCadModelVariant2 && IsTextToCadModelVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.TextToCadModelVariant1?, TResult>? textToCadModelVariant1 = null,
            global::System.Func<global::Zoo.TextToCadModelVariant2?, TResult>? textToCadModelVariant2 = null,
            global::System.Func<global::Zoo.TextToCadModelVariant3?, TResult>? textToCadModelVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToCadModelVariant1 && textToCadModelVariant1 != null)
            {
                return textToCadModelVariant1(TextToCadModelVariant1!);
            }
            else if (IsTextToCadModelVariant2 && textToCadModelVariant2 != null)
            {
                return textToCadModelVariant2(TextToCadModelVariant2!);
            }
            else if (IsTextToCadModelVariant3 && textToCadModelVariant3 != null)
            {
                return textToCadModelVariant3(TextToCadModelVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.TextToCadModelVariant1?>? textToCadModelVariant1 = null,
            global::System.Action<global::Zoo.TextToCadModelVariant2?>? textToCadModelVariant2 = null,
            global::System.Action<global::Zoo.TextToCadModelVariant3?>? textToCadModelVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToCadModelVariant1)
            {
                textToCadModelVariant1?.Invoke(TextToCadModelVariant1!);
            }
            else if (IsTextToCadModelVariant2)
            {
                textToCadModelVariant2?.Invoke(TextToCadModelVariant2!);
            }
            else if (IsTextToCadModelVariant3)
            {
                textToCadModelVariant3?.Invoke(TextToCadModelVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextToCadModelVariant1,
                typeof(global::Zoo.TextToCadModelVariant1),
                TextToCadModelVariant2,
                typeof(global::Zoo.TextToCadModelVariant2),
                TextToCadModelVariant3,
                typeof(global::Zoo.TextToCadModelVariant3),
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
        public bool Equals(TextToCadModel other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.TextToCadModelVariant1?>.Default.Equals(TextToCadModelVariant1, other.TextToCadModelVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.TextToCadModelVariant2?>.Default.Equals(TextToCadModelVariant2, other.TextToCadModelVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.TextToCadModelVariant3?>.Default.Equals(TextToCadModelVariant3, other.TextToCadModelVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TextToCadModel obj1, TextToCadModel obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextToCadModel>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TextToCadModel obj1, TextToCadModel obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextToCadModel o && Equals(o);
        }
    }
}
