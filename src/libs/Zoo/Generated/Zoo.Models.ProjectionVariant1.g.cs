
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Orthographic (parallel) projection.
    /// </summary>
    public sealed partial class ProjectionVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.ProjectionVariant1TypeJsonConverter))]
        public global::Zoo.ProjectionVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectionVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectionVariant1(
            global::Zoo.ProjectionVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectionVariant1" /> class.
        /// </summary>
        public ProjectionVariant1()
        {
        }

    }
}