#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Type that encompasses all Text-to-CAD response types, including iteration and multi-file iteration.
    /// </summary>
    public readonly partial struct TextToCadResponse : global::System.IEquatable<TextToCadResponse>
    {
        /// <summary>
        /// A response from a text to CAD prompt.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.TextToCadResponseVariant1? TextToCadResponseVariant1 { get; init; }
#else
        public global::Zoo.TextToCadResponseVariant1? TextToCadResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToCadResponseVariant1))]
#endif
        public bool IsTextToCadResponseVariant1 => TextToCadResponseVariant1 != null;

        /// <summary>
        /// A response from a text to CAD iteration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.TextToCadResponseVariant2? TextToCadResponseVariant2 { get; init; }
#else
        public global::Zoo.TextToCadResponseVariant2? TextToCadResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToCadResponseVariant2))]
#endif
        public bool IsTextToCadResponseVariant2 => TextToCadResponseVariant2 != null;

        /// <summary>
        /// A response from a text to CAD multi-file iteration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.TextToCadResponseVariant3? TextToCadResponseVariant3 { get; init; }
#else
        public global::Zoo.TextToCadResponseVariant3? TextToCadResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToCadResponseVariant3))]
#endif
        public bool IsTextToCadResponseVariant3 => TextToCadResponseVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToCadResponse(global::Zoo.TextToCadResponseVariant1 value) => new TextToCadResponse((global::Zoo.TextToCadResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.TextToCadResponseVariant1?(TextToCadResponse @this) => @this.TextToCadResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public TextToCadResponse(global::Zoo.TextToCadResponseVariant1? value)
        {
            TextToCadResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToCadResponse(global::Zoo.TextToCadResponseVariant2 value) => new TextToCadResponse((global::Zoo.TextToCadResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.TextToCadResponseVariant2?(TextToCadResponse @this) => @this.TextToCadResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TextToCadResponse(global::Zoo.TextToCadResponseVariant2? value)
        {
            TextToCadResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToCadResponse(global::Zoo.TextToCadResponseVariant3 value) => new TextToCadResponse((global::Zoo.TextToCadResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.TextToCadResponseVariant3?(TextToCadResponse @this) => @this.TextToCadResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public TextToCadResponse(global::Zoo.TextToCadResponseVariant3? value)
        {
            TextToCadResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TextToCadResponse(
            global::Zoo.TextToCadResponseVariant1? textToCadResponseVariant1,
            global::Zoo.TextToCadResponseVariant2? textToCadResponseVariant2,
            global::Zoo.TextToCadResponseVariant3? textToCadResponseVariant3
            )
        {
            TextToCadResponseVariant1 = textToCadResponseVariant1;
            TextToCadResponseVariant2 = textToCadResponseVariant2;
            TextToCadResponseVariant3 = textToCadResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextToCadResponseVariant3 as object ??
            TextToCadResponseVariant2 as object ??
            TextToCadResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextToCadResponseVariant1?.ToString() ??
            TextToCadResponseVariant2?.ToString() ??
            TextToCadResponseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextToCadResponseVariant1 && !IsTextToCadResponseVariant2 && !IsTextToCadResponseVariant3 || !IsTextToCadResponseVariant1 && IsTextToCadResponseVariant2 && !IsTextToCadResponseVariant3 || !IsTextToCadResponseVariant1 && !IsTextToCadResponseVariant2 && IsTextToCadResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.TextToCadResponseVariant1?, TResult>? textToCadResponseVariant1 = null,
            global::System.Func<global::Zoo.TextToCadResponseVariant2?, TResult>? textToCadResponseVariant2 = null,
            global::System.Func<global::Zoo.TextToCadResponseVariant3?, TResult>? textToCadResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToCadResponseVariant1 && textToCadResponseVariant1 != null)
            {
                return textToCadResponseVariant1(TextToCadResponseVariant1!);
            }
            else if (IsTextToCadResponseVariant2 && textToCadResponseVariant2 != null)
            {
                return textToCadResponseVariant2(TextToCadResponseVariant2!);
            }
            else if (IsTextToCadResponseVariant3 && textToCadResponseVariant3 != null)
            {
                return textToCadResponseVariant3(TextToCadResponseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.TextToCadResponseVariant1?>? textToCadResponseVariant1 = null,
            global::System.Action<global::Zoo.TextToCadResponseVariant2?>? textToCadResponseVariant2 = null,
            global::System.Action<global::Zoo.TextToCadResponseVariant3?>? textToCadResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToCadResponseVariant1)
            {
                textToCadResponseVariant1?.Invoke(TextToCadResponseVariant1!);
            }
            else if (IsTextToCadResponseVariant2)
            {
                textToCadResponseVariant2?.Invoke(TextToCadResponseVariant2!);
            }
            else if (IsTextToCadResponseVariant3)
            {
                textToCadResponseVariant3?.Invoke(TextToCadResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextToCadResponseVariant1,
                typeof(global::Zoo.TextToCadResponseVariant1),
                TextToCadResponseVariant2,
                typeof(global::Zoo.TextToCadResponseVariant2),
                TextToCadResponseVariant3,
                typeof(global::Zoo.TextToCadResponseVariant3),
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
        public bool Equals(TextToCadResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.TextToCadResponseVariant1?>.Default.Equals(TextToCadResponseVariant1, other.TextToCadResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.TextToCadResponseVariant2?>.Default.Equals(TextToCadResponseVariant2, other.TextToCadResponseVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.TextToCadResponseVariant3?>.Default.Equals(TextToCadResponseVariant3, other.TextToCadResponseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TextToCadResponse obj1, TextToCadResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextToCadResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TextToCadResponse obj1, TextToCadResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextToCadResponse o && Equals(o);
        }
    }
}
