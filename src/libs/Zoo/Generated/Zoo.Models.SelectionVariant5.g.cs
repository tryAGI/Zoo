
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Visit the first mesh with the given name.
    /// </summary>
    public sealed partial class SelectionVariant5
    {
        /// <summary>
        /// The name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.SelectionVariant5TypeJsonConverter))]
        public global::Zoo.SelectionVariant5Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionVariant5" /> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SelectionVariant5(
            string name,
            global::Zoo.SelectionVariant5Type type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionVariant5" /> class.
        /// </summary>
        public SelectionVariant5()
        {
        }
    }
}