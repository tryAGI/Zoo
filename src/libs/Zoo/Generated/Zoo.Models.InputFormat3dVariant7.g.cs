
#nullable enable

namespace Zoo
{
    /// <summary>
    /// *ST**ereo**L**ithography format.
    /// </summary>
    public sealed partial class InputFormat3dVariant7
    {
        /// <summary>
        /// Co-ordinate system of input data.<br/>
        /// Defaults to the [KittyCAD co-ordinate system].<br/>
        /// [KittyCAD co-ordinate system]: ../coord/constant.KITTYCAD.html
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.CoordinateSystem Coords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.InputFormat3dVariant7TypeJsonConverter))]
        public global::Zoo.InputFormat3dVariant7Type Type { get; set; }

        /// <summary>
        /// The units of the input data.<br/>
        /// This is very important for correct scaling and when calculating physics properties like mass, etc.<br/>
        /// Defaults to millimeters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.UnitLengthJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.UnitLength Units { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFormat3dVariant7" /> class.
        /// </summary>
        /// <param name="coords">
        /// Co-ordinate system of input data.<br/>
        /// Defaults to the [KittyCAD co-ordinate system].<br/>
        /// [KittyCAD co-ordinate system]: ../coord/constant.KITTYCAD.html
        /// </param>
        /// <param name="units">
        /// The units of the input data.<br/>
        /// This is very important for correct scaling and when calculating physics properties like mass, etc.<br/>
        /// Defaults to millimeters.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputFormat3dVariant7(
            global::Zoo.CoordinateSystem coords,
            global::Zoo.UnitLength units,
            global::Zoo.InputFormat3dVariant7Type type)
        {
            this.Coords = coords ?? throw new global::System.ArgumentNullException(nameof(coords));
            this.Type = type;
            this.Units = units;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFormat3dVariant7" /> class.
        /// </summary>
        public InputFormat3dVariant7()
        {
        }
    }
}