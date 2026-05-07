#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Zoo
{
    /// <summary>
    /// The valid types of volume units.
    /// </summary>
    public readonly partial struct UnitVolume : global::System.IEquatable<UnitVolume>
    {
        /// <summary>
        /// Cubic millimeters (mm³)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitVolumeVariant1? UnitVolumeVariant1 { get; init; }
#else
        public global::Zoo.UnitVolumeVariant1? UnitVolumeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitVolumeVariant1))]
#endif
        public bool IsUnitVolumeVariant1 => UnitVolumeVariant1 != null;

        /// <summary>
        /// Cubic centimeters (cc or cm³) &lt;https://en.wikipedia.org/wiki/Cubic_centimeter&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitVolumeVariant2? UnitVolumeVariant2 { get; init; }
#else
        public global::Zoo.UnitVolumeVariant2? UnitVolumeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitVolumeVariant2))]
#endif
        public bool IsUnitVolumeVariant2 => UnitVolumeVariant2 != null;

        /// <summary>
        /// Cubic feet (ft³) &lt;https://en.wikipedia.org/wiki/Cubic_foot&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitVolumeVariant3? UnitVolumeVariant3 { get; init; }
#else
        public global::Zoo.UnitVolumeVariant3? UnitVolumeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitVolumeVariant3))]
#endif
        public bool IsUnitVolumeVariant3 => UnitVolumeVariant3 != null;

        /// <summary>
        /// Cubic inches (cu in or in³) &lt;https://en.wikipedia.org/wiki/Cubic_inch&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitVolumeVariant4? UnitVolumeVariant4 { get; init; }
#else
        public global::Zoo.UnitVolumeVariant4? UnitVolumeVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitVolumeVariant4))]
#endif
        public bool IsUnitVolumeVariant4 => UnitVolumeVariant4 != null;

        /// <summary>
        /// Cubic meters (m³) &lt;https://en.wikipedia.org/wiki/Cubic_meter&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitVolumeVariant5? UnitVolumeVariant5 { get; init; }
#else
        public global::Zoo.UnitVolumeVariant5? UnitVolumeVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitVolumeVariant5))]
#endif
        public bool IsUnitVolumeVariant5 => UnitVolumeVariant5 != null;

        /// <summary>
        /// Cubic yards (yd³) &lt;https://en.wikipedia.org/wiki/Cubic_yard&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitVolumeVariant6? UnitVolumeVariant6 { get; init; }
#else
        public global::Zoo.UnitVolumeVariant6? UnitVolumeVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitVolumeVariant6))]
#endif
        public bool IsUnitVolumeVariant6 => UnitVolumeVariant6 != null;

        /// <summary>
        /// US Fluid Ounces (fl oz) &lt;https://en.wikipedia.org/wiki/Fluid_ounce&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitVolumeVariant7? UnitVolumeVariant7 { get; init; }
#else
        public global::Zoo.UnitVolumeVariant7? UnitVolumeVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitVolumeVariant7))]
#endif
        public bool IsUnitVolumeVariant7 => UnitVolumeVariant7 != null;

        /// <summary>
        /// US Gallons (gal US) &lt;https://en.wikipedia.org/wiki/Gallon&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitVolumeVariant8? UnitVolumeVariant8 { get; init; }
#else
        public global::Zoo.UnitVolumeVariant8? UnitVolumeVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitVolumeVariant8))]
#endif
        public bool IsUnitVolumeVariant8 => UnitVolumeVariant8 != null;

        /// <summary>
        /// Liters (l) &lt;https://en.wikipedia.org/wiki/Litre&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitVolumeVariant9? UnitVolumeVariant9 { get; init; }
#else
        public global::Zoo.UnitVolumeVariant9? UnitVolumeVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitVolumeVariant9))]
#endif
        public bool IsUnitVolumeVariant9 => UnitVolumeVariant9 != null;

        /// <summary>
        /// Milliliters (ml) &lt;https://en.wikipedia.org/wiki/Litre&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Zoo.UnitVolumeVariant10? UnitVolumeVariant10 { get; init; }
#else
        public global::Zoo.UnitVolumeVariant10? UnitVolumeVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnitVolumeVariant10))]
#endif
        public bool IsUnitVolumeVariant10 => UnitVolumeVariant10 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitVolume(global::Zoo.UnitVolumeVariant1 value) => new UnitVolume((global::Zoo.UnitVolumeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitVolumeVariant1?(UnitVolume @this) => @this.UnitVolumeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UnitVolume(global::Zoo.UnitVolumeVariant1? value)
        {
            UnitVolumeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitVolume(global::Zoo.UnitVolumeVariant2 value) => new UnitVolume((global::Zoo.UnitVolumeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitVolumeVariant2?(UnitVolume @this) => @this.UnitVolumeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UnitVolume(global::Zoo.UnitVolumeVariant2? value)
        {
            UnitVolumeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitVolume(global::Zoo.UnitVolumeVariant3 value) => new UnitVolume((global::Zoo.UnitVolumeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitVolumeVariant3?(UnitVolume @this) => @this.UnitVolumeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public UnitVolume(global::Zoo.UnitVolumeVariant3? value)
        {
            UnitVolumeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitVolume(global::Zoo.UnitVolumeVariant4 value) => new UnitVolume((global::Zoo.UnitVolumeVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitVolumeVariant4?(UnitVolume @this) => @this.UnitVolumeVariant4;

        /// <summary>
        /// 
        /// </summary>
        public UnitVolume(global::Zoo.UnitVolumeVariant4? value)
        {
            UnitVolumeVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitVolume(global::Zoo.UnitVolumeVariant5 value) => new UnitVolume((global::Zoo.UnitVolumeVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitVolumeVariant5?(UnitVolume @this) => @this.UnitVolumeVariant5;

        /// <summary>
        /// 
        /// </summary>
        public UnitVolume(global::Zoo.UnitVolumeVariant5? value)
        {
            UnitVolumeVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitVolume(global::Zoo.UnitVolumeVariant6 value) => new UnitVolume((global::Zoo.UnitVolumeVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitVolumeVariant6?(UnitVolume @this) => @this.UnitVolumeVariant6;

        /// <summary>
        /// 
        /// </summary>
        public UnitVolume(global::Zoo.UnitVolumeVariant6? value)
        {
            UnitVolumeVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitVolume(global::Zoo.UnitVolumeVariant7 value) => new UnitVolume((global::Zoo.UnitVolumeVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitVolumeVariant7?(UnitVolume @this) => @this.UnitVolumeVariant7;

        /// <summary>
        /// 
        /// </summary>
        public UnitVolume(global::Zoo.UnitVolumeVariant7? value)
        {
            UnitVolumeVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitVolume(global::Zoo.UnitVolumeVariant8 value) => new UnitVolume((global::Zoo.UnitVolumeVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitVolumeVariant8?(UnitVolume @this) => @this.UnitVolumeVariant8;

        /// <summary>
        /// 
        /// </summary>
        public UnitVolume(global::Zoo.UnitVolumeVariant8? value)
        {
            UnitVolumeVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitVolume(global::Zoo.UnitVolumeVariant9 value) => new UnitVolume((global::Zoo.UnitVolumeVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitVolumeVariant9?(UnitVolume @this) => @this.UnitVolumeVariant9;

        /// <summary>
        /// 
        /// </summary>
        public UnitVolume(global::Zoo.UnitVolumeVariant9? value)
        {
            UnitVolumeVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnitVolume(global::Zoo.UnitVolumeVariant10 value) => new UnitVolume((global::Zoo.UnitVolumeVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Zoo.UnitVolumeVariant10?(UnitVolume @this) => @this.UnitVolumeVariant10;

        /// <summary>
        /// 
        /// </summary>
        public UnitVolume(global::Zoo.UnitVolumeVariant10? value)
        {
            UnitVolumeVariant10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UnitVolume(
            global::Zoo.UnitVolumeVariant1? unitVolumeVariant1,
            global::Zoo.UnitVolumeVariant2? unitVolumeVariant2,
            global::Zoo.UnitVolumeVariant3? unitVolumeVariant3,
            global::Zoo.UnitVolumeVariant4? unitVolumeVariant4,
            global::Zoo.UnitVolumeVariant5? unitVolumeVariant5,
            global::Zoo.UnitVolumeVariant6? unitVolumeVariant6,
            global::Zoo.UnitVolumeVariant7? unitVolumeVariant7,
            global::Zoo.UnitVolumeVariant8? unitVolumeVariant8,
            global::Zoo.UnitVolumeVariant9? unitVolumeVariant9,
            global::Zoo.UnitVolumeVariant10? unitVolumeVariant10
            )
        {
            UnitVolumeVariant1 = unitVolumeVariant1;
            UnitVolumeVariant2 = unitVolumeVariant2;
            UnitVolumeVariant3 = unitVolumeVariant3;
            UnitVolumeVariant4 = unitVolumeVariant4;
            UnitVolumeVariant5 = unitVolumeVariant5;
            UnitVolumeVariant6 = unitVolumeVariant6;
            UnitVolumeVariant7 = unitVolumeVariant7;
            UnitVolumeVariant8 = unitVolumeVariant8;
            UnitVolumeVariant9 = unitVolumeVariant9;
            UnitVolumeVariant10 = unitVolumeVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UnitVolumeVariant10 as object ??
            UnitVolumeVariant9 as object ??
            UnitVolumeVariant8 as object ??
            UnitVolumeVariant7 as object ??
            UnitVolumeVariant6 as object ??
            UnitVolumeVariant5 as object ??
            UnitVolumeVariant4 as object ??
            UnitVolumeVariant3 as object ??
            UnitVolumeVariant2 as object ??
            UnitVolumeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UnitVolumeVariant1?.ToValueString() ??
            UnitVolumeVariant2?.ToValueString() ??
            UnitVolumeVariant3?.ToValueString() ??
            UnitVolumeVariant4?.ToValueString() ??
            UnitVolumeVariant5?.ToValueString() ??
            UnitVolumeVariant6?.ToValueString() ??
            UnitVolumeVariant7?.ToValueString() ??
            UnitVolumeVariant8?.ToValueString() ??
            UnitVolumeVariant9?.ToValueString() ??
            UnitVolumeVariant10?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnitVolumeVariant1 && !IsUnitVolumeVariant2 && !IsUnitVolumeVariant3 && !IsUnitVolumeVariant4 && !IsUnitVolumeVariant5 && !IsUnitVolumeVariant6 && !IsUnitVolumeVariant7 && !IsUnitVolumeVariant8 && !IsUnitVolumeVariant9 && !IsUnitVolumeVariant10 || !IsUnitVolumeVariant1 && IsUnitVolumeVariant2 && !IsUnitVolumeVariant3 && !IsUnitVolumeVariant4 && !IsUnitVolumeVariant5 && !IsUnitVolumeVariant6 && !IsUnitVolumeVariant7 && !IsUnitVolumeVariant8 && !IsUnitVolumeVariant9 && !IsUnitVolumeVariant10 || !IsUnitVolumeVariant1 && !IsUnitVolumeVariant2 && IsUnitVolumeVariant3 && !IsUnitVolumeVariant4 && !IsUnitVolumeVariant5 && !IsUnitVolumeVariant6 && !IsUnitVolumeVariant7 && !IsUnitVolumeVariant8 && !IsUnitVolumeVariant9 && !IsUnitVolumeVariant10 || !IsUnitVolumeVariant1 && !IsUnitVolumeVariant2 && !IsUnitVolumeVariant3 && IsUnitVolumeVariant4 && !IsUnitVolumeVariant5 && !IsUnitVolumeVariant6 && !IsUnitVolumeVariant7 && !IsUnitVolumeVariant8 && !IsUnitVolumeVariant9 && !IsUnitVolumeVariant10 || !IsUnitVolumeVariant1 && !IsUnitVolumeVariant2 && !IsUnitVolumeVariant3 && !IsUnitVolumeVariant4 && IsUnitVolumeVariant5 && !IsUnitVolumeVariant6 && !IsUnitVolumeVariant7 && !IsUnitVolumeVariant8 && !IsUnitVolumeVariant9 && !IsUnitVolumeVariant10 || !IsUnitVolumeVariant1 && !IsUnitVolumeVariant2 && !IsUnitVolumeVariant3 && !IsUnitVolumeVariant4 && !IsUnitVolumeVariant5 && IsUnitVolumeVariant6 && !IsUnitVolumeVariant7 && !IsUnitVolumeVariant8 && !IsUnitVolumeVariant9 && !IsUnitVolumeVariant10 || !IsUnitVolumeVariant1 && !IsUnitVolumeVariant2 && !IsUnitVolumeVariant3 && !IsUnitVolumeVariant4 && !IsUnitVolumeVariant5 && !IsUnitVolumeVariant6 && IsUnitVolumeVariant7 && !IsUnitVolumeVariant8 && !IsUnitVolumeVariant9 && !IsUnitVolumeVariant10 || !IsUnitVolumeVariant1 && !IsUnitVolumeVariant2 && !IsUnitVolumeVariant3 && !IsUnitVolumeVariant4 && !IsUnitVolumeVariant5 && !IsUnitVolumeVariant6 && !IsUnitVolumeVariant7 && IsUnitVolumeVariant8 && !IsUnitVolumeVariant9 && !IsUnitVolumeVariant10 || !IsUnitVolumeVariant1 && !IsUnitVolumeVariant2 && !IsUnitVolumeVariant3 && !IsUnitVolumeVariant4 && !IsUnitVolumeVariant5 && !IsUnitVolumeVariant6 && !IsUnitVolumeVariant7 && !IsUnitVolumeVariant8 && IsUnitVolumeVariant9 && !IsUnitVolumeVariant10 || !IsUnitVolumeVariant1 && !IsUnitVolumeVariant2 && !IsUnitVolumeVariant3 && !IsUnitVolumeVariant4 && !IsUnitVolumeVariant5 && !IsUnitVolumeVariant6 && !IsUnitVolumeVariant7 && !IsUnitVolumeVariant8 && !IsUnitVolumeVariant9 && IsUnitVolumeVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Zoo.UnitVolumeVariant1?, TResult>? unitVolumeVariant1 = null,
            global::System.Func<global::Zoo.UnitVolumeVariant2?, TResult>? unitVolumeVariant2 = null,
            global::System.Func<global::Zoo.UnitVolumeVariant3?, TResult>? unitVolumeVariant3 = null,
            global::System.Func<global::Zoo.UnitVolumeVariant4?, TResult>? unitVolumeVariant4 = null,
            global::System.Func<global::Zoo.UnitVolumeVariant5?, TResult>? unitVolumeVariant5 = null,
            global::System.Func<global::Zoo.UnitVolumeVariant6?, TResult>? unitVolumeVariant6 = null,
            global::System.Func<global::Zoo.UnitVolumeVariant7?, TResult>? unitVolumeVariant7 = null,
            global::System.Func<global::Zoo.UnitVolumeVariant8?, TResult>? unitVolumeVariant8 = null,
            global::System.Func<global::Zoo.UnitVolumeVariant9?, TResult>? unitVolumeVariant9 = null,
            global::System.Func<global::Zoo.UnitVolumeVariant10?, TResult>? unitVolumeVariant10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnitVolumeVariant1 && unitVolumeVariant1 != null)
            {
                return unitVolumeVariant1(UnitVolumeVariant1!);
            }
            else if (IsUnitVolumeVariant2 && unitVolumeVariant2 != null)
            {
                return unitVolumeVariant2(UnitVolumeVariant2!);
            }
            else if (IsUnitVolumeVariant3 && unitVolumeVariant3 != null)
            {
                return unitVolumeVariant3(UnitVolumeVariant3!);
            }
            else if (IsUnitVolumeVariant4 && unitVolumeVariant4 != null)
            {
                return unitVolumeVariant4(UnitVolumeVariant4!);
            }
            else if (IsUnitVolumeVariant5 && unitVolumeVariant5 != null)
            {
                return unitVolumeVariant5(UnitVolumeVariant5!);
            }
            else if (IsUnitVolumeVariant6 && unitVolumeVariant6 != null)
            {
                return unitVolumeVariant6(UnitVolumeVariant6!);
            }
            else if (IsUnitVolumeVariant7 && unitVolumeVariant7 != null)
            {
                return unitVolumeVariant7(UnitVolumeVariant7!);
            }
            else if (IsUnitVolumeVariant8 && unitVolumeVariant8 != null)
            {
                return unitVolumeVariant8(UnitVolumeVariant8!);
            }
            else if (IsUnitVolumeVariant9 && unitVolumeVariant9 != null)
            {
                return unitVolumeVariant9(UnitVolumeVariant9!);
            }
            else if (IsUnitVolumeVariant10 && unitVolumeVariant10 != null)
            {
                return unitVolumeVariant10(UnitVolumeVariant10!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Zoo.UnitVolumeVariant1?>? unitVolumeVariant1 = null,
            global::System.Action<global::Zoo.UnitVolumeVariant2?>? unitVolumeVariant2 = null,
            global::System.Action<global::Zoo.UnitVolumeVariant3?>? unitVolumeVariant3 = null,
            global::System.Action<global::Zoo.UnitVolumeVariant4?>? unitVolumeVariant4 = null,
            global::System.Action<global::Zoo.UnitVolumeVariant5?>? unitVolumeVariant5 = null,
            global::System.Action<global::Zoo.UnitVolumeVariant6?>? unitVolumeVariant6 = null,
            global::System.Action<global::Zoo.UnitVolumeVariant7?>? unitVolumeVariant7 = null,
            global::System.Action<global::Zoo.UnitVolumeVariant8?>? unitVolumeVariant8 = null,
            global::System.Action<global::Zoo.UnitVolumeVariant9?>? unitVolumeVariant9 = null,
            global::System.Action<global::Zoo.UnitVolumeVariant10?>? unitVolumeVariant10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnitVolumeVariant1)
            {
                unitVolumeVariant1?.Invoke(UnitVolumeVariant1!);
            }
            else if (IsUnitVolumeVariant2)
            {
                unitVolumeVariant2?.Invoke(UnitVolumeVariant2!);
            }
            else if (IsUnitVolumeVariant3)
            {
                unitVolumeVariant3?.Invoke(UnitVolumeVariant3!);
            }
            else if (IsUnitVolumeVariant4)
            {
                unitVolumeVariant4?.Invoke(UnitVolumeVariant4!);
            }
            else if (IsUnitVolumeVariant5)
            {
                unitVolumeVariant5?.Invoke(UnitVolumeVariant5!);
            }
            else if (IsUnitVolumeVariant6)
            {
                unitVolumeVariant6?.Invoke(UnitVolumeVariant6!);
            }
            else if (IsUnitVolumeVariant7)
            {
                unitVolumeVariant7?.Invoke(UnitVolumeVariant7!);
            }
            else if (IsUnitVolumeVariant8)
            {
                unitVolumeVariant8?.Invoke(UnitVolumeVariant8!);
            }
            else if (IsUnitVolumeVariant9)
            {
                unitVolumeVariant9?.Invoke(UnitVolumeVariant9!);
            }
            else if (IsUnitVolumeVariant10)
            {
                unitVolumeVariant10?.Invoke(UnitVolumeVariant10!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnitVolumeVariant1,
                typeof(global::Zoo.UnitVolumeVariant1),
                UnitVolumeVariant2,
                typeof(global::Zoo.UnitVolumeVariant2),
                UnitVolumeVariant3,
                typeof(global::Zoo.UnitVolumeVariant3),
                UnitVolumeVariant4,
                typeof(global::Zoo.UnitVolumeVariant4),
                UnitVolumeVariant5,
                typeof(global::Zoo.UnitVolumeVariant5),
                UnitVolumeVariant6,
                typeof(global::Zoo.UnitVolumeVariant6),
                UnitVolumeVariant7,
                typeof(global::Zoo.UnitVolumeVariant7),
                UnitVolumeVariant8,
                typeof(global::Zoo.UnitVolumeVariant8),
                UnitVolumeVariant9,
                typeof(global::Zoo.UnitVolumeVariant9),
                UnitVolumeVariant10,
                typeof(global::Zoo.UnitVolumeVariant10),
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
        public bool Equals(UnitVolume other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitVolumeVariant1?>.Default.Equals(UnitVolumeVariant1, other.UnitVolumeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitVolumeVariant2?>.Default.Equals(UnitVolumeVariant2, other.UnitVolumeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitVolumeVariant3?>.Default.Equals(UnitVolumeVariant3, other.UnitVolumeVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitVolumeVariant4?>.Default.Equals(UnitVolumeVariant4, other.UnitVolumeVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitVolumeVariant5?>.Default.Equals(UnitVolumeVariant5, other.UnitVolumeVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitVolumeVariant6?>.Default.Equals(UnitVolumeVariant6, other.UnitVolumeVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitVolumeVariant7?>.Default.Equals(UnitVolumeVariant7, other.UnitVolumeVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitVolumeVariant8?>.Default.Equals(UnitVolumeVariant8, other.UnitVolumeVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitVolumeVariant9?>.Default.Equals(UnitVolumeVariant9, other.UnitVolumeVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Zoo.UnitVolumeVariant10?>.Default.Equals(UnitVolumeVariant10, other.UnitVolumeVariant10) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UnitVolume obj1, UnitVolume obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnitVolume>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UnitVolume obj1, UnitVolume obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnitVolume o && Equals(o);
        }
    }
}
