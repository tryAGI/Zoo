
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Body for generating parts from text.
    /// </summary>
    public sealed partial class TextToCadIterationBody
    {
        /// <summary>
        /// The version of kcl to use. If empty, the latest version will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kcl_version")]
        public string? KclVersion { get; set; }

        /// <summary>
        /// The source code for the model (in kcl) that is to be edited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_source_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalSourceCode { get; set; }

        /// <summary>
        /// The project name. This is used to tie the prompt to a project. Which helps us make our models better over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// The prompt for the model, if not using source ranges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The source ranges the user suggested to change. If empty, the prompt will be used and is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_ranges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Zoo.SourceRangePrompt> SourceRanges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToCadIterationBody" /> class.
        /// </summary>
        /// <param name="originalSourceCode">
        /// The source code for the model (in kcl) that is to be edited.
        /// </param>
        /// <param name="sourceRanges">
        /// The source ranges the user suggested to change. If empty, the prompt will be used and is required.
        /// </param>
        /// <param name="kclVersion">
        /// The version of kcl to use. If empty, the latest version will be used.
        /// </param>
        /// <param name="projectName">
        /// The project name. This is used to tie the prompt to a project. Which helps us make our models better over time.
        /// </param>
        /// <param name="prompt">
        /// The prompt for the model, if not using source ranges.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToCadIterationBody(
            string originalSourceCode,
            global::System.Collections.Generic.IList<global::Zoo.SourceRangePrompt> sourceRanges,
            string? kclVersion,
            string? projectName,
            string? prompt)
        {
            this.KclVersion = kclVersion;
            this.OriginalSourceCode = originalSourceCode ?? throw new global::System.ArgumentNullException(nameof(originalSourceCode));
            this.ProjectName = projectName;
            this.Prompt = prompt;
            this.SourceRanges = sourceRanges ?? throw new global::System.ArgumentNullException(nameof(sourceRanges));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToCadIterationBody" /> class.
        /// </summary>
        public TextToCadIterationBody()
        {
        }
    }
}