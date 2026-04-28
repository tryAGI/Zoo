
#nullable enable

namespace Zoo
{
    /// <summary>
    /// A response from a text to CAD multi-file iteration.
    /// </summary>
    public sealed partial class TextToCadMultiFileIteration
    {
        /// <summary>
        /// The time and date the API call was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The conversation ID Conversations group different prompts together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ConversationId { get; set; }

        /// <summary>
        /// The time and date the API call was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The error the function returned, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Feedback from the user, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.MlFeedbackJsonConverter))]
        public global::Zoo.MlFeedback? Feedback { get; set; }

        /// <summary>
        /// The unique identifier of the API call.<br/>
        /// This is the same as the API call ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The version of kcl to use. If empty, the latest version will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kcl_version")]
        public string? KclVersion { get; set; }

        /// <summary>
        /// The model being used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.TextToCadModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.TextToCadModel Model { get; set; }

        /// <summary>
        /// The version of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelVersion { get; set; }

        /// <summary>
        /// The output files. Returns a map of the file name to the file contents. The file contents are not encoded since kcl files are not binary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.Dictionary<string, string>? Outputs { get; set; }

        /// <summary>
        /// The project name. This is used to tie the prompt to a project. Which helps us make our models better over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// The prompt for the overall changes. This is optional if you only want changes on specific source ranges. This will apply to all the files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The source ranges the user suggested to change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_ranges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Zoo.SourceRangePrompt> SourceRanges { get; set; }

        /// <summary>
        /// The time and date the API call was started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// The status of the API call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.ApiCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.ApiCallStatus Status { get; set; }

        /// <summary>
        /// The time and date the API call was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The user ID of the user who created the API call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToCadMultiFileIteration" /> class.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation ID Conversations group different prompts together.
        /// </param>
        /// <param name="createdAt">
        /// The time and date the API call was created.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the API call.<br/>
        /// This is the same as the API call ID.
        /// </param>
        /// <param name="model">
        /// The model being used.
        /// </param>
        /// <param name="modelVersion">
        /// The version of the model.
        /// </param>
        /// <param name="sourceRanges">
        /// The source ranges the user suggested to change.
        /// </param>
        /// <param name="status">
        /// The status of the API call.
        /// </param>
        /// <param name="updatedAt">
        /// The time and date the API call was last updated.
        /// </param>
        /// <param name="userId">
        /// The user ID of the user who created the API call.
        /// </param>
        /// <param name="completedAt">
        /// The time and date the API call was completed.
        /// </param>
        /// <param name="error">
        /// The error the function returned, if any.
        /// </param>
        /// <param name="feedback">
        /// Feedback from the user, if any.
        /// </param>
        /// <param name="kclVersion">
        /// The version of kcl to use. If empty, the latest version will be used.
        /// </param>
        /// <param name="outputs">
        /// The output files. Returns a map of the file name to the file contents. The file contents are not encoded since kcl files are not binary.
        /// </param>
        /// <param name="projectName">
        /// The project name. This is used to tie the prompt to a project. Which helps us make our models better over time.
        /// </param>
        /// <param name="prompt">
        /// The prompt for the overall changes. This is optional if you only want changes on specific source ranges. This will apply to all the files.
        /// </param>
        /// <param name="startedAt">
        /// The time and date the API call was started.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToCadMultiFileIteration(
            global::System.Guid conversationId,
            global::System.DateTime createdAt,
            global::System.Guid id,
            global::Zoo.TextToCadModel model,
            string modelVersion,
            global::System.Collections.Generic.IList<global::Zoo.SourceRangePrompt> sourceRanges,
            global::Zoo.ApiCallStatus status,
            global::System.DateTime updatedAt,
            global::System.Guid userId,
            global::System.DateTime? completedAt,
            string? error,
            global::Zoo.MlFeedback? feedback,
            string? kclVersion,
            global::System.Collections.Generic.Dictionary<string, string>? outputs,
            string? projectName,
            string? prompt,
            global::System.DateTime? startedAt)
        {
            this.CompletedAt = completedAt;
            this.ConversationId = conversationId;
            this.CreatedAt = createdAt;
            this.Error = error;
            this.Feedback = feedback;
            this.Id = id;
            this.KclVersion = kclVersion;
            this.Model = model;
            this.ModelVersion = modelVersion ?? throw new global::System.ArgumentNullException(nameof(modelVersion));
            this.Outputs = outputs;
            this.ProjectName = projectName;
            this.Prompt = prompt;
            this.SourceRanges = sourceRanges ?? throw new global::System.ArgumentNullException(nameof(sourceRanges));
            this.StartedAt = startedAt;
            this.Status = status;
            this.UpdatedAt = updatedAt;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToCadMultiFileIteration" /> class.
        /// </summary>
        public TextToCadMultiFileIteration()
        {
        }
    }
}