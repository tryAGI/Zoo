
#nullable enable

namespace Zoo
{
    /// <summary>
    /// Co-ordinate system definition.<br/>
    /// The `up` axis must be orthogonal to the `forward` axis.<br/>
    /// See [cglearn.eu] for background reading.<br/>
    /// [cglearn.eu](https://cglearn.eu/pub/computer-graphics/introduction-to-geometry#material-coordinate-systems-1)
    /// </summary>
    public sealed partial class CoordinateSystem
    {
        /// <summary>
        /// Axis the front face of a model looks along.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forward")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.AxisDirectionPair Forward { get; set; }

        /// <summary>
        /// Axis pointing up and away from a model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("up")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.AxisDirectionPair Up { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinateSystem" /> class.
        /// </summary>
        /// <param name="forward">
        /// Axis the front face of a model looks along.
        /// </param>
        /// <param name="up">
        /// Axis pointing up and away from a model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoordinateSystem(
            global::Zoo.AxisDirectionPair forward,
            global::Zoo.AxisDirectionPair up)
        {
            this.Forward = forward ?? throw new global::System.ArgumentNullException(nameof(forward));
            this.Up = up ?? throw new global::System.ArgumentNullException(nameof(up));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinateSystem" /> class.
        /// </summary>
        public CoordinateSystem()
        {
        }
    }
}