#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// Data item selection.
    /// </summary>
    public readonly partial struct Selection : global::System.IEquatable<Selection>
    {
        /// <summary>
        /// Visit the default scene.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.SelectionVariant1? SelectionVariant1 { get; init; }
#else
        public global::Zoo.SelectionVariant1? SelectionVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SelectionVariant1))]
#endif
        public bool IsSelectionVariant1 => SelectionVariant1 != null;

        /// <summary>
        /// Visit the indexed scene.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.SelectionVariant2? SelectionVariant2 { get; init; }
#else
        public global::Zoo.SelectionVariant2? SelectionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SelectionVariant2))]
#endif
        public bool IsSelectionVariant2 => SelectionVariant2 != null;

        /// <summary>
        /// Visit the first scene with the given name.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.SelectionVariant3? SelectionVariant3 { get; init; }
#else
        public global::Zoo.SelectionVariant3? SelectionVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SelectionVariant3))]
#endif
        public bool IsSelectionVariant3 => SelectionVariant3 != null;

        /// <summary>
        /// Visit the indexed mesh.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.SelectionVariant4? SelectionVariant4 { get; init; }
#else
        public global::Zoo.SelectionVariant4? SelectionVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SelectionVariant4))]
#endif
        public bool IsSelectionVariant4 => SelectionVariant4 != null;

        /// <summary>
        /// Visit the first mesh with the given name.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.SelectionVariant5? SelectionVariant5 { get; init; }
#else
        public global::Zoo.SelectionVariant5? SelectionVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SelectionVariant5))]
#endif
        public bool IsSelectionVariant5 => SelectionVariant5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Selection(global::Zoo.SelectionVariant1 value) => new Selection((global::Zoo.SelectionVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.SelectionVariant1?(Selection @this) => @this.SelectionVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Selection(global::Zoo.SelectionVariant1? value)
        {
            SelectionVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Selection(global::Zoo.SelectionVariant2 value) => new Selection((global::Zoo.SelectionVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.SelectionVariant2?(Selection @this) => @this.SelectionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Selection(global::Zoo.SelectionVariant2? value)
        {
            SelectionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Selection(global::Zoo.SelectionVariant3 value) => new Selection((global::Zoo.SelectionVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.SelectionVariant3?(Selection @this) => @this.SelectionVariant3;

        /// <summary>
        /// 
        /// </summary>
        public Selection(global::Zoo.SelectionVariant3? value)
        {
            SelectionVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Selection(global::Zoo.SelectionVariant4 value) => new Selection((global::Zoo.SelectionVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.SelectionVariant4?(Selection @this) => @this.SelectionVariant4;

        /// <summary>
        /// 
        /// </summary>
        public Selection(global::Zoo.SelectionVariant4? value)
        {
            SelectionVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Selection(global::Zoo.SelectionVariant5 value) => new Selection((global::Zoo.SelectionVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.SelectionVariant5?(Selection @this) => @this.SelectionVariant5;

        /// <summary>
        /// 
        /// </summary>
        public Selection(global::Zoo.SelectionVariant5? value)
        {
            SelectionVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Selection(
            global::Zoo.SelectionVariant1? selectionVariant1,
            global::Zoo.SelectionVariant2? selectionVariant2,
            global::Zoo.SelectionVariant3? selectionVariant3,
            global::Zoo.SelectionVariant4? selectionVariant4,
            global::Zoo.SelectionVariant5? selectionVariant5
            )
        {
            SelectionVariant1 = selectionVariant1;
            SelectionVariant2 = selectionVariant2;
            SelectionVariant3 = selectionVariant3;
            SelectionVariant4 = selectionVariant4;
            SelectionVariant5 = selectionVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SelectionVariant5 as object ??
            SelectionVariant4 as object ??
            SelectionVariant3 as object ??
            SelectionVariant2 as object ??
            SelectionVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SelectionVariant1?.ToString() ??
            SelectionVariant2?.ToString() ??
            SelectionVariant3?.ToString() ??
            SelectionVariant4?.ToString() ??
            SelectionVariant5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSelectionVariant1 && !IsSelectionVariant2 && !IsSelectionVariant3 && !IsSelectionVariant4 && !IsSelectionVariant5 || !IsSelectionVariant1 && IsSelectionVariant2 && !IsSelectionVariant3 && !IsSelectionVariant4 && !IsSelectionVariant5 || !IsSelectionVariant1 && !IsSelectionVariant2 && IsSelectionVariant3 && !IsSelectionVariant4 && !IsSelectionVariant5 || !IsSelectionVariant1 && !IsSelectionVariant2 && !IsSelectionVariant3 && IsSelectionVariant4 && !IsSelectionVariant5 || !IsSelectionVariant1 && !IsSelectionVariant2 && !IsSelectionVariant3 && !IsSelectionVariant4 && IsSelectionVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.SelectionVariant1?, TResult>? selectionVariant1 = null,
            global::System.Func<global::Zoo.SelectionVariant2?, TResult>? selectionVariant2 = null,
            global::System.Func<global::Zoo.SelectionVariant3?, TResult>? selectionVariant3 = null,
            global::System.Func<global::Zoo.SelectionVariant4?, TResult>? selectionVariant4 = null,
            global::System.Func<global::Zoo.SelectionVariant5?, TResult>? selectionVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSelectionVariant1 && selectionVariant1 != null)
            {
                return selectionVariant1(SelectionVariant1!);
            }
            else if (IsSelectionVariant2 && selectionVariant2 != null)
            {
                return selectionVariant2(SelectionVariant2!);
            }
            else if (IsSelectionVariant3 && selectionVariant3 != null)
            {
                return selectionVariant3(SelectionVariant3!);
            }
            else if (IsSelectionVariant4 && selectionVariant4 != null)
            {
                return selectionVariant4(SelectionVariant4!);
            }
            else if (IsSelectionVariant5 && selectionVariant5 != null)
            {
                return selectionVariant5(SelectionVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.SelectionVariant1?>? selectionVariant1 = null,
            global::System.Action<global::Zoo.SelectionVariant2?>? selectionVariant2 = null,
            global::System.Action<global::Zoo.SelectionVariant3?>? selectionVariant3 = null,
            global::System.Action<global::Zoo.SelectionVariant4?>? selectionVariant4 = null,
            global::System.Action<global::Zoo.SelectionVariant5?>? selectionVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSelectionVariant1)
            {
                selectionVariant1?.Invoke(SelectionVariant1!);
            }
            else if (IsSelectionVariant2)
            {
                selectionVariant2?.Invoke(SelectionVariant2!);
            }
            else if (IsSelectionVariant3)
            {
                selectionVariant3?.Invoke(SelectionVariant3!);
            }
            else if (IsSelectionVariant4)
            {
                selectionVariant4?.Invoke(SelectionVariant4!);
            }
            else if (IsSelectionVariant5)
            {
                selectionVariant5?.Invoke(SelectionVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SelectionVariant1,
                typeof(global::Zoo.SelectionVariant1),
                SelectionVariant2,
                typeof(global::Zoo.SelectionVariant2),
                SelectionVariant3,
                typeof(global::Zoo.SelectionVariant3),
                SelectionVariant4,
                typeof(global::Zoo.SelectionVariant4),
                SelectionVariant5,
                typeof(global::Zoo.SelectionVariant5),
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
        public bool Equals(Selection other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.SelectionVariant1?>.Default.Equals(SelectionVariant1, other.SelectionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.SelectionVariant2?>.Default.Equals(SelectionVariant2, other.SelectionVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.SelectionVariant3?>.Default.Equals(SelectionVariant3, other.SelectionVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.SelectionVariant4?>.Default.Equals(SelectionVariant4, other.SelectionVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.SelectionVariant5?>.Default.Equals(SelectionVariant5, other.SelectionVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Selection obj1, Selection obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Selection>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Selection obj1, Selection obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Selection o && Equals(o);
        }
    }
}
