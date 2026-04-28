#nullable enable

namespace Zoo
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Get a text-to-CAD response.<br/>
        /// This endpoint requires authentication by any Zoo user. The user must be the owner of the text-to-CAD model.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zoo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zoo.TextToCadResponse> GetTextToCadPartForUserAsync(
            global::System.Guid id,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a text-to-CAD response.<br/>
        /// This endpoint requires authentication by any Zoo user. The user must be the owner of the text-to-CAD model.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zoo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zoo.AutoSDKHttpResponse<global::Zoo.TextToCadResponse>> GetTextToCadPartForUserAsResponseAsync(
            global::System.Guid id,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}