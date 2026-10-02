
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The response from the 'BoundingBox'.
    /// </summary>
    public sealed partial class BoundingBox
    {
        /// <summary>
        /// Center of the box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("center")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.Point3d Center { get; set; }

        /// <summary>
        /// Dimensions of the box along each axis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zoo.Point3d Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox" /> class.
        /// </summary>
        /// <param name="center">
        /// Center of the box.
        /// </param>
        /// <param name="dimensions">
        /// Dimensions of the box along each axis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BoundingBox(
            global::Zoo.Point3d center,
            global::Zoo.Point3d dimensions)
        {
            this.Center = center ?? throw new global::System.ArgumentNullException(nameof(center));
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox" /> class.
        /// </summary>
        public BoundingBox()
        {
        }

    }
}