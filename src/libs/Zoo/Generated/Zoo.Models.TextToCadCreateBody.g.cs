
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Body for generating parts from text.
    /// </summary>
    public sealed partial class TextToCadCreateBody
    {
        /// <summary>
        /// The version of kcl to use. If empty, the latest version will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kcl_version")]
        public string? KclVersion { get; set; }

        /// <summary>
        /// Zoo provided model, or custom model which should be used to process this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// The project name. This is used to tie the prompt to a project. Which helps us make our models better over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// The prompt for the desired part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToCadCreateBody" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for the desired part.
        /// </param>
        /// <param name="kclVersion">
        /// The version of kcl to use. If empty, the latest version will be used.
        /// </param>
        /// <param name="modelVersion">
        /// Zoo provided model, or custom model which should be used to process this request.
        /// </param>
        /// <param name="projectName">
        /// The project name. This is used to tie the prompt to a project. Which helps us make our models better over time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToCadCreateBody(
            string prompt,
            string? kclVersion,
            string? modelVersion,
            string? projectName)
        {
            this.KclVersion = kclVersion;
            this.ModelVersion = modelVersion;
            this.ProjectName = projectName;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToCadCreateBody" /> class.
        /// </summary>
        public TextToCadCreateBody()
        {
        }
    }
}