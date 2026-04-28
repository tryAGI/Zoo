
#nullable enable

namespace Zoo
{
    /// <summary>
    /// *ST**ereo**L**ithography format.
    /// </summary>
    public sealed partial class OutputFormat3dVariant6
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
        /// Export storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.StlStorageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.StlStorage Storage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.OutputFormat3dVariant6TypeJsonConverter))]
        public global::Zoo.OutputFormat3dVariant6Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="OutputFormat3dVariant6" /> class.
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
        /// Export storage.
        /// </param>
        /// <param name="units">
        /// Export length unit.<br/>
        /// Defaults to millimeters.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputFormat3dVariant6(
            global::Zoo.CoordinateSystem coords,
            global::Zoo.Selection selection,
            global::Zoo.StlStorage storage,
            global::Zoo.UnitLength units,
            global::Zoo.OutputFormat3dVariant6Type type)
        {
            this.Coords = coords ?? throw new global::System.ArgumentNullException(nameof(coords));
            this.Selection = selection;
            this.Storage = storage;
            this.Type = type;
            this.Units = units;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormat3dVariant6" /> class.
        /// </summary>
        public OutputFormat3dVariant6()
        {
        }
    }
}