
#nullable enable

namespace Zoo
{
    /// <summary>
    /// The output of the model in the given file format the user requested, base64 encoded. The key of the map is the path of the output file.
    /// </summary>
    public sealed partial class TextToCadOutputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}