#nullable enable

namespace Zoo
{
    public partial interface IMlClient
    {
        /// <summary>
        /// List text-to-CAD parts you've generated.<br/>
        /// This will always return the STEP file contents as well as the format the user originally requested.<br/>
        /// This endpoint requires authentication by any Zoo user. It returns the text-to-CAD parts for the authenticated user.<br/>
        /// The text-to-CAD parts are returned in order of creation, with the most recently created text-to-CAD parts first.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="pageToken"></param>
        /// <param name="sortBy">
        /// Supported set of sort modes for scanning by created_at only.<br/>
        /// Currently, we only support scanning in ascending order.
        /// </param>
        /// <param name="noModels"></param>
        /// <param name="noParts"></param>
        /// <param name="conversationId">
        /// A UUID usually v4 or v7
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zoo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zoo.TextToCadResponseResultsPage> ListTextToCadPartsForUserAsync(
            int? limit = default,
            string? pageToken = default,
            global::Zoo.CreatedAtSortMode? sortBy = default,
            bool? noModels = default,
            bool? noParts = default,
            global::System.Guid? conversationId = default,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List text-to-CAD parts you've generated.<br/>
        /// This will always return the STEP file contents as well as the format the user originally requested.<br/>
        /// This endpoint requires authentication by any Zoo user. It returns the text-to-CAD parts for the authenticated user.<br/>
        /// The text-to-CAD parts are returned in order of creation, with the most recently created text-to-CAD parts first.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="pageToken"></param>
        /// <param name="sortBy">
        /// Supported set of sort modes for scanning by created_at only.<br/>
        /// Currently, we only support scanning in ascending order.
        /// </param>
        /// <param name="noModels"></param>
        /// <param name="noParts"></param>
        /// <param name="conversationId">
        /// A UUID usually v4 or v7
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zoo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zoo.AutoSDKHttpResponse<global::Zoo.TextToCadResponseResultsPage>> ListTextToCadPartsForUserAsResponseAsync(
            int? limit = default,
            string? pageToken = default,
            global::Zoo.CreatedAtSortMode? sortBy = default,
            bool? noModels = default,
            bool? noParts = default,
            global::System.Guid? conversationId = default,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}