
#nullable enable

namespace Zoo
{
    /// <summary>
    /// A source range and prompt for a text to CAD iteration.
    /// </summary>
    public sealed partial class SourceRangePrompt
    {
        /// <summary>
        /// The name of the file the source range applies to. This is the relative path to the file from the root of the project. This only applies to multi-file iterations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public string? File { get; set; }

        /// <summary>
        /// The prompt for the changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The range of the source code to change. If you want to apply the prompt to the whole file, set the start to 0 and the end to the end of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.SourceRange Range { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceRangePrompt" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for the changes.
        /// </param>
        /// <param name="range">
        /// The range of the source code to change. If you want to apply the prompt to the whole file, set the start to 0 and the end to the end of the file.
        /// </param>
        /// <param name="file">
        /// The name of the file the source range applies to. This is the relative path to the file from the root of the project. This only applies to multi-file iterations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceRangePrompt(
            string prompt,
            global::Zoo.SourceRange range,
            string? file)
        {
            this.File = file;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Range = range ?? throw new global::System.ArgumentNullException(nameof(range));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceRangePrompt" /> class.
        /// </summary>
        public SourceRangePrompt()
        {
        }
    }
}