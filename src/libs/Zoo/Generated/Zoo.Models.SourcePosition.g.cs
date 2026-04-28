
#nullable enable

namespace Zoo
{
    /// <summary>
    /// A position in the source code.
    /// </summary>
    public sealed partial class SourcePosition
    {
        /// <summary>
        /// The column number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Column { get; set; }

        /// <summary>
        /// The line number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Line { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourcePosition" /> class.
        /// </summary>
        /// <param name="column">
        /// The column number.
        /// </param>
        /// <param name="line">
        /// The line number.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourcePosition(
            int column,
            int line)
        {
            this.Column = column;
            this.Line = line;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourcePosition" /> class.
        /// </summary>
        public SourcePosition()
        {
        }
    }
}