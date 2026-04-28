
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Visit the first scene with the given name.
    /// </summary>
    public sealed partial class SelectionVariant3
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.SelectionVariant3TypeJsonConverter))]
        public global::Zoo.SelectionVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionVariant3" /> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SelectionVariant3(
            string name,
            global::Zoo.SelectionVariant3Type type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionVariant3" /> class.
        /// </summary>
        public SelectionVariant3()
        {
        }
    }
}