
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Visit the indexed mesh.
    /// </summary>
    public sealed partial class SelectionVariant4
    {
        /// <summary>
        /// The index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.SelectionVariant4TypeJsonConverter))]
        public global::Zoo.SelectionVariant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionVariant4" /> class.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SelectionVariant4(
            int index,
            global::Zoo.SelectionVariant4Type type)
        {
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionVariant4" /> class.
        /// </summary>
        public SelectionVariant4()
        {
        }
    }
}