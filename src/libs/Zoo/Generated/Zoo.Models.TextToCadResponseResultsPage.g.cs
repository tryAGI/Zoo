
#nullable enable

namespace Zoo
{
    /// <summary>
    /// A single page of results
    /// </summary>
    public sealed partial class TextToCadResponseResultsPage
    {
        /// <summary>
        /// list of items on this page of results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Zoo.TextToCadResponse> Items { get; set; }

        /// <summary>
        /// token used to fetch the next page of results (if any)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToCadResponseResultsPage" /> class.
        /// </summary>
        /// <param name="items">
        /// list of items on this page of results
        /// </param>
        /// <param name="nextPage">
        /// token used to fetch the next page of results (if any)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToCadResponseResultsPage(
            global::System.Collections.Generic.IList<global::Zoo.TextToCadResponse> items,
            string? nextPage)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToCadResponseResultsPage" /> class.
        /// </summary>
        public TextToCadResponseResultsPage()
        {
        }
    }
}