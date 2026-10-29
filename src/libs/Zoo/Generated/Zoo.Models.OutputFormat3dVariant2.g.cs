
#nullable enable

namespace Zoo
{
    /// <summary>
    /// glTF 2.0. We refer to this as glTF since that is how our customers refer to it, although by default it will be in binary format and thus technically (glb). If you prefer ASCII output, you can set that option for the export.
    /// </summary>
    public sealed partial class OutputFormat3dVariant2
    {
        /// <summary>
        /// Include engine UUIDs in glTF extras. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_uuids")]
        public bool? IncludeUuids { get; set; }

        /// <summary>
        /// Specifies how the JSON will be presented.<br/>
        /// Default Value: pretty
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.GltfPresentationJsonConverter))]
        public global::Zoo.GltfPresentation? Presentation { get; set; }

        /// <summary>
        /// Specifies which kind of glTF 2.0 will be exported.<br/>
        /// Default Value: embedded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.GltfStorageJsonConverter))]
        public global::Zoo.GltfStorage? Storage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.OutputFormat3dVariant2TypeJsonConverter))]
        public global::Zoo.OutputFormat3dVariant2Type Type { get; set; }

        /// <summary>
        /// Named views in the scene.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("views")]
        public global::System.Collections.Generic.Dictionary<string, global::Zoo.NamedView>? Views { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormat3dVariant2" /> class.
        /// </summary>
        /// <param name="includeUuids">
        /// Include engine UUIDs in glTF extras. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="presentation">
        /// Specifies how the JSON will be presented.<br/>
        /// Default Value: pretty
        /// </param>
        /// <param name="storage">
        /// Specifies which kind of glTF 2.0 will be exported.<br/>
        /// Default Value: embedded
        /// </param>
        /// <param name="type"></param>
        /// <param name="views">
        /// Named views in the scene.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputFormat3dVariant2(
            bool? includeUuids,
            global::Zoo.GltfPresentation? presentation,
            global::Zoo.GltfStorage? storage,
            global::Zoo.OutputFormat3dVariant2Type type,
            global::System.Collections.Generic.Dictionary<string, global::Zoo.NamedView>? views)
        {
            this.IncludeUuids = includeUuids;
            this.Presentation = presentation;
            this.Storage = storage;
            this.Type = type;
            this.Views = views;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormat3dVariant2" /> class.
        /// </summary>
        public OutputFormat3dVariant2()
        {
        }

    }
}