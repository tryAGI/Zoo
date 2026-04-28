#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// The valid types of area units.
    /// </summary>
    public readonly partial struct UnitArea : global::System.IEquatable<UnitArea>
    {
        /// <summary>
        /// Square centimeters &lt;https://en.wikipedia.org/wiki/Square_centimeter&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitAreaVariant1? UnitAreaVariant1 { get; init; }
#else
        public global::Zoo.UnitAreaVariant1? UnitAreaVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitAreaVariant1))]
#endif
        public bool IsUnitAreaVariant1 => UnitAreaVariant1 != null;

        /// <summary>
        /// Square decimeters &lt;https://en.wikipedia.org/wiki/Square_decimeter&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitAreaVariant2? UnitAreaVariant2 { get; init; }
#else
        public global::Zoo.UnitAreaVariant2? UnitAreaVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitAreaVariant2))]
#endif
        public bool IsUnitAreaVariant2 => UnitAreaVariant2 != null;

        /// <summary>
        /// Square feet &lt;https://en.wikipedia.org/wiki/Square_foot&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitAreaVariant3? UnitAreaVariant3 { get; init; }
#else
        public global::Zoo.UnitAreaVariant3? UnitAreaVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitAreaVariant3))]
#endif
        public bool IsUnitAreaVariant3 => UnitAreaVariant3 != null;

        /// <summary>
        /// Square inches &lt;https://en.wikipedia.org/wiki/Square_inch&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitAreaVariant4? UnitAreaVariant4 { get; init; }
#else
        public global::Zoo.UnitAreaVariant4? UnitAreaVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitAreaVariant4))]
#endif
        public bool IsUnitAreaVariant4 => UnitAreaVariant4 != null;

        /// <summary>
        /// Square kilometers &lt;https://en.wikipedia.org/wiki/Square_kilometer&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitAreaVariant5? UnitAreaVariant5 { get; init; }
#else
        public global::Zoo.UnitAreaVariant5? UnitAreaVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitAreaVariant5))]
#endif
        public bool IsUnitAreaVariant5 => UnitAreaVariant5 != null;

        /// <summary>
        /// Square meters &lt;https://en.wikipedia.org/wiki/Square_meter&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitAreaVariant6? UnitAreaVariant6 { get; init; }
#else
        public global::Zoo.UnitAreaVariant6? UnitAreaVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitAreaVariant6))]
#endif
        public bool IsUnitAreaVariant6 => UnitAreaVariant6 != null;

        /// <summary>
        /// Square millimeters &lt;https://en.wikipedia.org/wiki/Square_millimeter&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitAreaVariant7? UnitAreaVariant7 { get; init; }
#else
        public global::Zoo.UnitAreaVariant7? UnitAreaVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitAreaVariant7))]
#endif
        public bool IsUnitAreaVariant7 => UnitAreaVariant7 != null;

        /// <summary>
        /// Square yards &lt;https://en.wikipedia.org/wiki/Square_mile&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitAreaVariant8? UnitAreaVariant8 { get; init; }
#else
        public global::Zoo.UnitAreaVariant8? UnitAreaVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitAreaVariant8))]
#endif
        public bool IsUnitAreaVariant8 => UnitAreaVariant8 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitArea(global::Zoo.UnitAreaVariant1 value) => new UnitArea((global::Zoo.UnitAreaVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitAreaVariant1?(UnitArea @this) => @this.UnitAreaVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UnitArea(global::Zoo.UnitAreaVariant1? value)
        {
            UnitAreaVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitArea(global::Zoo.UnitAreaVariant2 value) => new UnitArea((global::Zoo.UnitAreaVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitAreaVariant2?(UnitArea @this) => @this.UnitAreaVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UnitArea(global::Zoo.UnitAreaVariant2? value)
        {
            UnitAreaVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitArea(global::Zoo.UnitAreaVariant3 value) => new UnitArea((global::Zoo.UnitAreaVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitAreaVariant3?(UnitArea @this) => @this.UnitAreaVariant3;

        /// <summary>
        /// 
        /// </summary>
        public UnitArea(global::Zoo.UnitAreaVariant3? value)
        {
            UnitAreaVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitArea(global::Zoo.UnitAreaVariant4 value) => new UnitArea((global::Zoo.UnitAreaVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitAreaVariant4?(UnitArea @this) => @this.UnitAreaVariant4;

        /// <summary>
        /// 
        /// </summary>
        public UnitArea(global::Zoo.UnitAreaVariant4? value)
        {
            UnitAreaVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitArea(global::Zoo.UnitAreaVariant5 value) => new UnitArea((global::Zoo.UnitAreaVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitAreaVariant5?(UnitArea @this) => @this.UnitAreaVariant5;

        /// <summary>
        /// 
        /// </summary>
        public UnitArea(global::Zoo.UnitAreaVariant5? value)
        {
            UnitAreaVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitArea(global::Zoo.UnitAreaVariant6 value) => new UnitArea((global::Zoo.UnitAreaVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitAreaVariant6?(UnitArea @this) => @this.UnitAreaVariant6;

        /// <summary>
        /// 
        /// </summary>
        public UnitArea(global::Zoo.UnitAreaVariant6? value)
        {
            UnitAreaVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitArea(global::Zoo.UnitAreaVariant7 value) => new UnitArea((global::Zoo.UnitAreaVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitAreaVariant7?(UnitArea @this) => @this.UnitAreaVariant7;

        /// <summary>
        /// 
        /// </summary>
        public UnitArea(global::Zoo.UnitAreaVariant7? value)
        {
            UnitAreaVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitArea(global::Zoo.UnitAreaVariant8 value) => new UnitArea((global::Zoo.UnitAreaVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitAreaVariant8?(UnitArea @this) => @this.UnitAreaVariant8;

        /// <summary>
        /// 
        /// </summary>
        public UnitArea(global::Zoo.UnitAreaVariant8? value)
        {
            UnitAreaVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UnitArea(
            global::Zoo.UnitAreaVariant1? unitAreaVariant1,
            global::Zoo.UnitAreaVariant2? unitAreaVariant2,
            global::Zoo.UnitAreaVariant3? unitAreaVariant3,
            global::Zoo.UnitAreaVariant4? unitAreaVariant4,
            global::Zoo.UnitAreaVariant5? unitAreaVariant5,
            global::Zoo.UnitAreaVariant6? unitAreaVariant6,
            global::Zoo.UnitAreaVariant7? unitAreaVariant7,
            global::Zoo.UnitAreaVariant8? unitAreaVariant8
            )
        {
            UnitAreaVariant1 = unitAreaVariant1;
            UnitAreaVariant2 = unitAreaVariant2;
            UnitAreaVariant3 = unitAreaVariant3;
            UnitAreaVariant4 = unitAreaVariant4;
            UnitAreaVariant5 = unitAreaVariant5;
            UnitAreaVariant6 = unitAreaVariant6;
            UnitAreaVariant7 = unitAreaVariant7;
            UnitAreaVariant8 = unitAreaVariant8;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UnitAreaVariant8 as object ??
            UnitAreaVariant7 as object ??
            UnitAreaVariant6 as object ??
            UnitAreaVariant5 as object ??
            UnitAreaVariant4 as object ??
            UnitAreaVariant3 as object ??
            UnitAreaVariant2 as object ??
            UnitAreaVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UnitAreaVariant1?.ToValueString() ??
            UnitAreaVariant2?.ToValueString() ??
            UnitAreaVariant3?.ToValueString() ??
            UnitAreaVariant4?.ToValueString() ??
            UnitAreaVariant5?.ToValueString() ??
            UnitAreaVariant6?.ToValueString() ??
            UnitAreaVariant7?.ToValueString() ??
            UnitAreaVariant8?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnitAreaVariant1 && !IsUnitAreaVariant2 && !IsUnitAreaVariant3 && !IsUnitAreaVariant4 && !IsUnitAreaVariant5 && !IsUnitAreaVariant6 && !IsUnitAreaVariant7 && !IsUnitAreaVariant8 || !IsUnitAreaVariant1 && IsUnitAreaVariant2 && !IsUnitAreaVariant3 && !IsUnitAreaVariant4 && !IsUnitAreaVariant5 && !IsUnitAreaVariant6 && !IsUnitAreaVariant7 && !IsUnitAreaVariant8 || !IsUnitAreaVariant1 && !IsUnitAreaVariant2 && IsUnitAreaVariant3 && !IsUnitAreaVariant4 && !IsUnitAreaVariant5 && !IsUnitAreaVariant6 && !IsUnitAreaVariant7 && !IsUnitAreaVariant8 || !IsUnitAreaVariant1 && !IsUnitAreaVariant2 && !IsUnitAreaVariant3 && IsUnitAreaVariant4 && !IsUnitAreaVariant5 && !IsUnitAreaVariant6 && !IsUnitAreaVariant7 && !IsUnitAreaVariant8 || !IsUnitAreaVariant1 && !IsUnitAreaVariant2 && !IsUnitAreaVariant3 && !IsUnitAreaVariant4 && IsUnitAreaVariant5 && !IsUnitAreaVariant6 && !IsUnitAreaVariant7 && !IsUnitAreaVariant8 || !IsUnitAreaVariant1 && !IsUnitAreaVariant2 && !IsUnitAreaVariant3 && !IsUnitAreaVariant4 && !IsUnitAreaVariant5 && IsUnitAreaVariant6 && !IsUnitAreaVariant7 && !IsUnitAreaVariant8 || !IsUnitAreaVariant1 && !IsUnitAreaVariant2 && !IsUnitAreaVariant3 && !IsUnitAreaVariant4 && !IsUnitAreaVariant5 && !IsUnitAreaVariant6 && IsUnitAreaVariant7 && !IsUnitAreaVariant8 || !IsUnitAreaVariant1 && !IsUnitAreaVariant2 && !IsUnitAreaVariant3 && !IsUnitAreaVariant4 && !IsUnitAreaVariant5 && !IsUnitAreaVariant6 && !IsUnitAreaVariant7 && IsUnitAreaVariant8;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.UnitAreaVariant1?, TResult>? unitAreaVariant1 = null,
            global::System.Func<global::Zoo.UnitAreaVariant2?, TResult>? unitAreaVariant2 = null,
            global::System.Func<global::Zoo.UnitAreaVariant3?, TResult>? unitAreaVariant3 = null,
            global::System.Func<global::Zoo.UnitAreaVariant4?, TResult>? unitAreaVariant4 = null,
            global::System.Func<global::Zoo.UnitAreaVariant5?, TResult>? unitAreaVariant5 = null,
            global::System.Func<global::Zoo.UnitAreaVariant6?, TResult>? unitAreaVariant6 = null,
            global::System.Func<global::Zoo.UnitAreaVariant7?, TResult>? unitAreaVariant7 = null,
            global::System.Func<global::Zoo.UnitAreaVariant8?, TResult>? unitAreaVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnitAreaVariant1 && unitAreaVariant1 != null)
            {
                return unitAreaVariant1(UnitAreaVariant1!);
            }
            else if (IsUnitAreaVariant2 && unitAreaVariant2 != null)
            {
                return unitAreaVariant2(UnitAreaVariant2!);
            }
            else if (IsUnitAreaVariant3 && unitAreaVariant3 != null)
            {
                return unitAreaVariant3(UnitAreaVariant3!);
            }
            else if (IsUnitAreaVariant4 && unitAreaVariant4 != null)
            {
                return unitAreaVariant4(UnitAreaVariant4!);
            }
            else if (IsUnitAreaVariant5 && unitAreaVariant5 != null)
            {
                return unitAreaVariant5(UnitAreaVariant5!);
            }
            else if (IsUnitAreaVariant6 && unitAreaVariant6 != null)
            {
                return unitAreaVariant6(UnitAreaVariant6!);
            }
            else if (IsUnitAreaVariant7 && unitAreaVariant7 != null)
            {
                return unitAreaVariant7(UnitAreaVariant7!);
            }
            else if (IsUnitAreaVariant8 && unitAreaVariant8 != null)
            {
                return unitAreaVariant8(UnitAreaVariant8!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.UnitAreaVariant1?>? unitAreaVariant1 = null,
            global::System.Action<global::Zoo.UnitAreaVariant2?>? unitAreaVariant2 = null,
            global::System.Action<global::Zoo.UnitAreaVariant3?>? unitAreaVariant3 = null,
            global::System.Action<global::Zoo.UnitAreaVariant4?>? unitAreaVariant4 = null,
            global::System.Action<global::Zoo.UnitAreaVariant5?>? unitAreaVariant5 = null,
            global::System.Action<global::Zoo.UnitAreaVariant6?>? unitAreaVariant6 = null,
            global::System.Action<global::Zoo.UnitAreaVariant7?>? unitAreaVariant7 = null,
            global::System.Action<global::Zoo.UnitAreaVariant8?>? unitAreaVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnitAreaVariant1)
            {
                unitAreaVariant1?.Invoke(UnitAreaVariant1!);
            }
            else if (IsUnitAreaVariant2)
            {
                unitAreaVariant2?.Invoke(UnitAreaVariant2!);
            }
            else if (IsUnitAreaVariant3)
            {
                unitAreaVariant3?.Invoke(UnitAreaVariant3!);
            }
            else if (IsUnitAreaVariant4)
            {
                unitAreaVariant4?.Invoke(UnitAreaVariant4!);
            }
            else if (IsUnitAreaVariant5)
            {
                unitAreaVariant5?.Invoke(UnitAreaVariant5!);
            }
            else if (IsUnitAreaVariant6)
            {
                unitAreaVariant6?.Invoke(UnitAreaVariant6!);
            }
            else if (IsUnitAreaVariant7)
            {
                unitAreaVariant7?.Invoke(UnitAreaVariant7!);
            }
            else if (IsUnitAreaVariant8)
            {
                unitAreaVariant8?.Invoke(UnitAreaVariant8!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnitAreaVariant1,
                typeof(global::Zoo.UnitAreaVariant1),
                UnitAreaVariant2,
                typeof(global::Zoo.UnitAreaVariant2),
                UnitAreaVariant3,
                typeof(global::Zoo.UnitAreaVariant3),
                UnitAreaVariant4,
                typeof(global::Zoo.UnitAreaVariant4),
                UnitAreaVariant5,
                typeof(global::Zoo.UnitAreaVariant5),
                UnitAreaVariant6,
                typeof(global::Zoo.UnitAreaVariant6),
                UnitAreaVariant7,
                typeof(global::Zoo.UnitAreaVariant7),
                UnitAreaVariant8,
                typeof(global::Zoo.UnitAreaVariant8),
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
        public bool Equals(UnitArea other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitAreaVariant1?>.Default.Equals(UnitAreaVariant1, other.UnitAreaVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitAreaVariant2?>.Default.Equals(UnitAreaVariant2, other.UnitAreaVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitAreaVariant3?>.Default.Equals(UnitAreaVariant3, other.UnitAreaVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitAreaVariant4?>.Default.Equals(UnitAreaVariant4, other.UnitAreaVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitAreaVariant5?>.Default.Equals(UnitAreaVariant5, other.UnitAreaVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitAreaVariant6?>.Default.Equals(UnitAreaVariant6, other.UnitAreaVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitAreaVariant7?>.Default.Equals(UnitAreaVariant7, other.UnitAreaVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitAreaVariant8?>.Default.Equals(UnitAreaVariant8, other.UnitAreaVariant8) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UnitArea obj1, UnitArea obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnitArea>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UnitArea obj1, UnitArea obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnitArea o && Equals(o);
        }
    }
}
