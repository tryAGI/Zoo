
#nullable enable

namespace Zoo
{
    /// <summary>
    /// ISO 10303-21 (STEP) format.
    /// </summary>
    public sealed partial class InputFormat3dVariant6
    {
        /// <summary>
        /// Co-ordinate system of input data.<br/>
        /// Defaults to the [KittyCAD co-ordinate system].<br/>
        /// [KittyCAD co-ordinate system]: ../coord/constant.KITTYCAD.html<br/>
        /// Default Value: {"forward":{"axis":"y","direction":"negative"},"up":{"axis":"z","direction":"positive"}}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coords")]
        public global::Zoo.CoordinateSystem? Coords { get; set; }

        /// <summary>
        /// Splits all closed faces into two open faces.<br/>
        /// Defaults to `false` but is implicitly `true` when importing into the engine.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split_closed_faces")]
        public bool? SplitClosedFaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.InputFormat3dVariant6TypeJsonConverter))]
        public global::Zoo.InputFormat3dVariant6Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFormat3dVariant6" /> class.
        /// </summary>
        /// <param name="coords">
        /// Co-ordinate system of input data.<br/>
        /// Defaults to the [KittyCAD co-ordinate system].<br/>
        /// [KittyCAD co-ordinate system]: ../coord/constant.KITTYCAD.html<br/>
        /// Default Value: {"forward":{"axis":"y","direction":"negative"},"up":{"axis":"z","direction":"positive"}}
        /// </param>
        /// <param name="splitClosedFaces">
        /// Splits all closed faces into two open faces.<br/>
        /// Defaults to `false` but is implicitly `true` when importing into the engine.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputFormat3dVariant6(
            global::Zoo.CoordinateSystem? coords,
            bool? splitClosedFaces,
            global::Zoo.InputFormat3dVariant6Type type)
        {
            this.Coords = coords;
            this.SplitClosedFaces = splitClosedFaces;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFormat3dVariant6" /> class.
        /// </summary>
        public InputFormat3dVariant6()
        {
        }
    }
}