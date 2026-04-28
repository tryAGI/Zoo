
#nullable enable

namespace Zoo
{
    /// <summary>
    /// ISO 10303-21 (STEP) format.
    /// </summary>
    public sealed partial class OutputFormat3dVariant5
    {
        /// <summary>
        /// Co-ordinate system of output data.<br/>
        /// Defaults to the [KittyCAD co-ordinate system].<br/>
        /// [KittyCAD co-ordinate system]: ../coord/constant.KITTYCAD.html<br/>
        /// Default Value: {"forward":{"axis":"y","direction":"negative"},"up":{"axis":"z","direction":"positive"}}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coords")]
        public global::Zoo.CoordinateSystem? Coords { get; set; }

        /// <summary>
        /// Timestamp override.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Presentation style.<br/>
        /// Default Value: pretty
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.StepPresentationJsonConverter))]
        public global::Zoo.StepPresentation? Presentation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.OutputFormat3dVariant5TypeJsonConverter))]
        public global::Zoo.OutputFormat3dVariant5Type Type { get; set; }

        /// <summary>
        /// Export length unit.<br/>
        /// Defaults to meters.<br/>
        /// Default Value: m
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.UnitLengthJsonConverter))]
        public global::Zoo.UnitLength? Units { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormat3dVariant5" /> class.
        /// </summary>
        /// <param name="coords">
        /// Co-ordinate system of output data.<br/>
        /// Defaults to the [KittyCAD co-ordinate system].<br/>
        /// [KittyCAD co-ordinate system]: ../coord/constant.KITTYCAD.html<br/>
        /// Default Value: {"forward":{"axis":"y","direction":"negative"},"up":{"axis":"z","direction":"positive"}}
        /// </param>
        /// <param name="created">
        /// Timestamp override.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="presentation">
        /// Presentation style.<br/>
        /// Default Value: pretty
        /// </param>
        /// <param name="type"></param>
        /// <param name="units">
        /// Export length unit.<br/>
        /// Defaults to meters.<br/>
        /// Default Value: m
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputFormat3dVariant5(
            global::Zoo.CoordinateSystem? coords,
            global::System.DateTime? created,
            global::Zoo.StepPresentation? presentation,
            global::Zoo.OutputFormat3dVariant5Type type,
            global::Zoo.UnitLength? units)
        {
            this.Coords = coords;
            this.Created = created;
            this.Presentation = presentation;
            this.Type = type;
            this.Units = units;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormat3dVariant5" /> class.
        /// </summary>
        public OutputFormat3dVariant5()
        {
        }
    }
}