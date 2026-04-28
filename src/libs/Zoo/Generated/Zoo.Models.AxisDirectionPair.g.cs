
#nullable enable

namespace Zoo
{
    /// <summary>
    /// An [`Axis`] paired with a [`Direction`].
    /// </summary>
    public sealed partial class AxisDirectionPair
    {
        /// <summary>
        /// Axis specifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("axis")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.AxisJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.Axis Axis { get; set; }

        /// <summary>
        /// Specifies which direction the axis is pointing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zoo.JsonConverters.DirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.Direction Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AxisDirectionPair" /> class.
        /// </summary>
        /// <param name="axis">
        /// Axis specifier.
        /// </param>
        /// <param name="direction">
        /// Specifies which direction the axis is pointing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AxisDirectionPair(
            global::Zoo.Axis axis,
            global::Zoo.Direction direction)
        {
            this.Axis = axis;
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AxisDirectionPair" /> class.
        /// </summary>
        public AxisDirectionPair()
        {
        }
    }
}