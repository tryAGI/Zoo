
#nullable enable

namespace Zoo
{
    /// <summary>
    /// A file conversion.
    /// </summary>
    public sealed partial class AsyncApiCallOutputVariant1
    {
        /// <summary>
        /// The time and date the API call was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

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
        /// The unique identifier of the API call.<br/>
        /// This is the same as the API call ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The output format of the file conversion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.FileExportFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.FileExportFormat OutputFormat { get; set; }

        /// <summary>
        /// The output format options of the file conversion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format_options")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.OutputFormat3dJsonConverter))]
        public global::Zoo.OutputFormat3d? OutputFormatOptions { get; set; }

        /// <summary>
        /// The converted files (if multiple file conversion), if completed, base64 encoded. The key of the map is the path of the output file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.Dictionary<string, byte[]>? Outputs { get; set; }

        /// <summary>
        /// The source format of the file conversion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.FileImportFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.FileImportFormat SrcFormat { get; set; }

        /// <summary>
        /// The source format options of the file conversion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src_format_options")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.InputFormat3dJsonConverter))]
        public global::Zoo.InputFormat3d? SrcFormatOptions { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant1TypeJsonConverter))]
        public global::Zoo.AsyncApiCallOutputVariant1Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="AsyncApiCallOutputVariant1" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The time and date the API call was created.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the API call.<br/>
        /// This is the same as the API call ID.
        /// </param>
        /// <param name="outputFormat">
        /// The output format of the file conversion.
        /// </param>
        /// <param name="srcFormat">
        /// The source format of the file conversion.
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
        /// <param name="outputFormatOptions">
        /// The output format options of the file conversion.
        /// </param>
        /// <param name="outputs">
        /// The converted files (if multiple file conversion), if completed, base64 encoded. The key of the map is the path of the output file.
        /// </param>
        /// <param name="srcFormatOptions">
        /// The source format options of the file conversion.
        /// </param>
        /// <param name="startedAt">
        /// The time and date the API call was started.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncApiCallOutputVariant1(
            global::System.DateTime createdAt,
            global::System.Guid id,
            global::Zoo.FileExportFormat outputFormat,
            global::Zoo.FileImportFormat srcFormat,
            global::Zoo.ApiCallStatus status,
            global::System.DateTime updatedAt,
            global::System.Guid userId,
            global::System.DateTime? completedAt,
            string? error,
            global::Zoo.OutputFormat3d? outputFormatOptions,
            global::System.Collections.Generic.Dictionary<string, byte[]>? outputs,
            global::Zoo.InputFormat3d? srcFormatOptions,
            global::System.DateTime? startedAt,
            global::Zoo.AsyncApiCallOutputVariant1Type type)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Error = error;
            this.Id = id;
            this.OutputFormat = outputFormat;
            this.OutputFormatOptions = outputFormatOptions;
            this.Outputs = outputs;
            this.SrcFormat = srcFormat;
            this.SrcFormatOptions = srcFormatOptions;
            this.StartedAt = startedAt;
            this.Status = status;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncApiCallOutputVariant1" /> class.
        /// </summary>
        public AsyncApiCallOutputVariant1()
        {
        }
    }
}