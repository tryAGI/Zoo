
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Wavefront OBJ format.
    /// </summary>
    public sealed partial class OutputFormat3dVariant3
    {
        /// <summary>
        /// Co-ordinate system of output data.<br/>
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.OutputFormat3dVariant3TypeJsonConverter))]
        public global::Zoo.OutputFormat3dVariant3Type Type { get; set; }

        /// <summary>
        /// Export length unit.<br/>
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
        /// Initializes a new instance of the <see cref="OutputFormat3dVariant3" /> class.
        /// </summary>
        /// <param name="coords">
        /// Co-ordinate system of output data.<br/>
        /// Defaults to the [KittyCAD co-ordinate system].<br/>
        /// [KittyCAD co-ordinate system]: ../coord/constant.KITTYCAD.html
        /// </param>
        /// <param name="units">
        /// Export length unit.<br/>
        /// Defaults to millimeters.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputFormat3dVariant3(
            global::Zoo.CoordinateSystem coords,
            global::Zoo.UnitLength units,
            global::Zoo.OutputFormat3dVariant3Type type)
        {
            this.Coords = coords ?? throw new global::System.ArgumentNullException(nameof(coords));
            this.Type = type;
            this.Units = units;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormat3dVariant3" /> class.
        /// </summary>
        public OutputFormat3dVariant3()
        {
        }
    }
}