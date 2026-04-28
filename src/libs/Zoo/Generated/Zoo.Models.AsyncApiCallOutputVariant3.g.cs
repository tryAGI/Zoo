
#nullable enable

namespace Zoo
{
    /// <summary>
    /// A file mass.
    /// </summary>
    public sealed partial class AsyncApiCallOutputVariant3
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
        /// The resulting mass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mass")]
        public double? Mass { get; set; }

        /// <summary>
        /// The material density as denoted by the user.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("material_density")]
        public double? MaterialDensity { get; set; }

        /// <summary>
        /// The material density unit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("material_density_unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.UnitDensityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.UnitDensity MaterialDensityUnit { get; set; }

        /// <summary>
        /// The output unit for the mass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.UnitMassJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.UnitMass OutputUnit { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant3TypeJsonConverter))]
        public global::Zoo.AsyncApiCallOutputVariant3Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="AsyncApiCallOutputVariant3" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The time and date the API call was created.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the API call.<br/>
        /// This is the same as the API call ID.
        /// </param>
        /// <param name="materialDensityUnit">
        /// The material density unit.
        /// </param>
        /// <param name="outputUnit">
        /// The output unit for the mass.
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
        /// <param name="completedAt">
        /// The time and date the API call was completed.
        /// </param>
        /// <param name="error">
        /// The error the function returned, if any.
        /// </param>
        /// <param name="mass">
        /// The resulting mass.
        /// </param>
        /// <param name="materialDensity">
        /// The material density as denoted by the user.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="startedAt">
        /// The time and date the API call was started.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncApiCallOutputVariant3(
            global::System.DateTime createdAt,
            global::System.Guid id,
            global::Zoo.UnitDensity materialDensityUnit,
            global::Zoo.UnitMass outputUnit,
            global::Zoo.FileImportFormat srcFormat,
            global::Zoo.ApiCallStatus status,
            global::System.DateTime updatedAt,
            global::System.Guid userId,
            global::System.DateTime? completedAt,
            string? error,
            double? mass,
            double? materialDensity,
            global::System.DateTime? startedAt,
            global::Zoo.AsyncApiCallOutputVariant3Type type)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Error = error;
            this.Id = id;
            this.Mass = mass;
            this.MaterialDensity = materialDensity;
            this.MaterialDensityUnit = materialDensityUnit;
            this.OutputUnit = outputUnit;
            this.SrcFormat = srcFormat;
            this.StartedAt = startedAt;
            this.Status = status;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncApiCallOutputVariant3" /> class.
        /// </summary>
        public AsyncApiCallOutputVariant3()
        {
        }
    }
}