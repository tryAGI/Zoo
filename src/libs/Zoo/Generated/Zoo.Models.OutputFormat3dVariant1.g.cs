
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Autodesk Filmbox (FBX) format.
    /// </summary>
    public sealed partial class OutputFormat3dVariant1
    {
        /// <summary>
        /// Timestamp override.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Specifies which kind of FBX will be exported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.FbxStorageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.FbxStorage Storage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.OutputFormat3dVariant1TypeJsonConverter))]
        public global::Zoo.OutputFormat3dVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormat3dVariant1" /> class.
        /// </summary>
        /// <param name="storage">
        /// Specifies which kind of FBX will be exported.
        /// </param>
        /// <param name="created">
        /// Timestamp override.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputFormat3dVariant1(
            global::Zoo.FbxStorage storage,
            global::System.DateTime? created,
            global::Zoo.OutputFormat3dVariant1Type type)
        {
            this.Created = created;
            this.Storage = storage;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormat3dVariant1" /> class.
        /// </summary>
        public OutputFormat3dVariant1()
        {
        }
    }
}