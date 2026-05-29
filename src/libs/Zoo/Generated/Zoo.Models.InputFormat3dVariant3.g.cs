
#nullable enable

namespace Zoo
{
    /// <summary>
    /// PTC Creo part format.
    /// </summary>
    public sealed partial class InputFormat3dVariant3
    {
        /// <summary>
        /// Co-ordinate system of input data.<br/>
        /// Default Value: {"forward":{"axis":"z","direction":"positive"},"up":{"axis":"y","direction":"positive"}}
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.InputFormat3dVariant3TypeJsonConverter))]
        public global::Zoo.InputFormat3dVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFormat3dVariant3" /> class.
        /// </summary>
        /// <param name="coords">
        /// Co-ordinate system of input data.<br/>
        /// Default Value: {"forward":{"axis":"z","direction":"positive"},"up":{"axis":"y","direction":"positive"}}
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
        public InputFormat3dVariant3(
            global::Zoo.CoordinateSystem? coords,
            bool? splitClosedFaces,
            global::Zoo.InputFormat3dVariant3Type type)
        {
            this.Coords = coords;
            this.SplitClosedFaces = splitClosedFaces;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFormat3dVariant3" /> class.
        /// </summary>
        public InputFormat3dVariant3()
        {
        }

    }
}