
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The PLY Polygon File Format.
    /// </summary>
    public sealed partial class OutputFormat3dVariant4
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
        /// Export selection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.SelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.Selection Selection { get; set; }

        /// <summary>
        /// The storage for the output PLY file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.PlyStorageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.PlyStorage Storage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.OutputFormat3dVariant4TypeJsonConverter))]
        public global::Zoo.OutputFormat3dVariant4Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="OutputFormat3dVariant4" /> class.
        /// </summary>
        /// <param name="coords">
        /// Co-ordinate system of output data.<br/>
        /// Defaults to the [KittyCAD co-ordinate system].<br/>
        /// [KittyCAD co-ordinate system]: ../coord/constant.KITTYCAD.html
        /// </param>
        /// <param name="selection">
        /// Export selection.
        /// </param>
        /// <param name="storage">
        /// The storage for the output PLY file.
        /// </param>
        /// <param name="units">
        /// Export length unit.<br/>
        /// Defaults to millimeters.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputFormat3dVariant4(
            global::Zoo.CoordinateSystem coords,
            global::Zoo.Selection selection,
            global::Zoo.PlyStorage storage,
            global::Zoo.UnitLength units,
            global::Zoo.OutputFormat3dVariant4Type type)
        {
            this.Coords = coords ?? throw new global::System.ArgumentNullException(nameof(coords));
            this.Selection = selection;
            this.Storage = storage;
            this.Type = type;
            this.Units = units;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormat3dVariant4" /> class.
        /// </summary>
        public OutputFormat3dVariant4()
        {
        }
    }
}