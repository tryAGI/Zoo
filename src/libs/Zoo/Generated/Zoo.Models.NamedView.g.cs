
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Options for exporting glTF 2.0.
    /// </summary>
    public sealed partial class NamedView
    {
        /// <summary>
        /// Baseline visibility.<br/>
        /// Determines whether entities are visible or by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.VisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.Visibility Baseline { get; set; }

        /// <summary>
        /// Exceptions to the baseline visibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("except_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ExceptIds { get; set; }

        /// <summary>
        /// Projection kind.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.ProjectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.Projection Projection { get; set; }

        /// <summary>
        /// Target point.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.Point3d Target { get; set; }

        /// <summary>
        /// Up direction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("up")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.Point3d Up { get; set; }

        /// <summary>
        /// Vantage point.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vantage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.Point3d Vantage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedView" /> class.
        /// </summary>
        /// <param name="baseline">
        /// Baseline visibility.<br/>
        /// Determines whether entities are visible or by default.
        /// </param>
        /// <param name="exceptIds">
        /// Exceptions to the baseline visibility.
        /// </param>
        /// <param name="projection">
        /// Projection kind.
        /// </param>
        /// <param name="target">
        /// Target point.
        /// </param>
        /// <param name="up">
        /// Up direction.
        /// </param>
        /// <param name="vantage">
        /// Vantage point.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamedView(
            global::Zoo.Visibility baseline,
            global::System.Collections.Generic.IList<global::System.Guid> exceptIds,
            global::Zoo.Projection projection,
            global::Zoo.Point3d target,
            global::Zoo.Point3d up,
            global::Zoo.Point3d vantage)
        {
            this.Baseline = baseline;
            this.ExceptIds = exceptIds ?? throw new global::System.ArgumentNullException(nameof(exceptIds));
            this.Projection = projection;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Up = up ?? throw new global::System.ArgumentNullException(nameof(up));
            this.Vantage = vantage ?? throw new global::System.ArgumentNullException(nameof(vantage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedView" /> class.
        /// </summary>
        public NamedView()
        {
        }

    }
}