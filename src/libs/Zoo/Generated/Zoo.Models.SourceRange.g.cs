
#nullable enable

namespace Zoo
{
    /// <summary>
    /// A source range of code.
    /// </summary>
    public sealed partial class SourceRange
    {
        /// <summary>
        /// The end of the range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.SourcePosition End { get; set; }

        /// <summary>
        /// The start of the range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.SourcePosition Start { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceRange" /> class.
        /// </summary>
        /// <param name="end">
        /// The end of the range.
        /// </param>
        /// <param name="start">
        /// The start of the range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceRange(
            global::Zoo.SourcePosition end,
            global::Zoo.SourcePosition start)
        {
            this.End = end ?? throw new global::System.ArgumentNullException(nameof(end));
            this.Start = start ?? throw new global::System.ArgumentNullException(nameof(start));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceRange" /> class.
        /// </summary>
        public SourceRange()
        {
        }
    }
}