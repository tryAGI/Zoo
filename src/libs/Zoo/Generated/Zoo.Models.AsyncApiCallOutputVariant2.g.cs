
#nullable enable

namespace Zoo
{
    /// <summary>
    /// File center of mass.
    /// </summary>
    public sealed partial class AsyncApiCallOutputVariant2
    {
        /// <summary>
        /// The resulting center of mass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("center_of_mass")]
        public global::Zoo.Point3d? CenterOfMass { get; set; }

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
        /// The output unit for the center of mass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.UnitLengthJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.UnitLength OutputUnit { get; set; }

        /// <summary>
        /// The source format of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.FileImportFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.FileImportFormat SrcFormat { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant2TypeJsonConverter))]
        public global::Zoo.AsyncApiCallOutputVariant2Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="AsyncApiCallOutputVariant2" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The time and date the API call was created.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the API call.<br/>
        /// This is the same as the API call ID.
        /// </param>
        /// <param name="outputUnit">
        /// The output unit for the center of mass.
        /// </param>
        /// <param name="srcFormat">
        /// The source format of the file.
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
        /// <param name="centerOfMass">
        /// The resulting center of mass.
        /// </param>
        /// <param name="completedAt">
        /// The time and date the API call was completed.
        /// </param>
        /// <param name="error">
        /// The error the function returned, if any.
        /// </param>
        /// <param name="startedAt">
        /// The time and date the API call was started.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncApiCallOutputVariant2(
            global::System.DateTime createdAt,
            global::System.Guid id,
            global::Zoo.UnitLength outputUnit,
            global::Zoo.FileImportFormat srcFormat,
            global::Zoo.ApiCallStatus status,
            global::System.DateTime updatedAt,
            global::System.Guid userId,
            global::Zoo.Point3d? centerOfMass,
            global::System.DateTime? completedAt,
            string? error,
            global::System.DateTime? startedAt,
            global::Zoo.AsyncApiCallOutputVariant2Type type)
        {
            this.CenterOfMass = centerOfMass;
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Error = error;
            this.Id = id;
            this.OutputUnit = outputUnit;
            this.SrcFormat = srcFormat;
            this.StartedAt = startedAt;
            this.Status = status;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncApiCallOutputVariant2" /> class.
        /// </summary>
        public AsyncApiCallOutputVariant2()
        {
        }
    }
}