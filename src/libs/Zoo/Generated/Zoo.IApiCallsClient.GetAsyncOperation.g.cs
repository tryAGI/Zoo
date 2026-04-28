#nullable enable

namespace Zoo
{
    public partial interface IApiCallsClient
    {
        /// <summary>
        /// Get an async operation.<br/>
        /// Get the status and output of an async operation.<br/>
        /// This endpoint requires authentication by any Zoo user. It returns details of the requested async operation for the user.<br/>
        /// If the user is not authenticated to view the specified async operation, then it is not returned.<br/>
        /// Only Zoo employees with the proper access can view async operations for other users.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zoo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zoo.AsyncApiCallOutput> GetAsyncOperationAsync(
            global::System.Guid id,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an async operation.<br/>
        /// Get the status and output of an async operation.<br/>
        /// This endpoint requires authentication by any Zoo user. It returns details of the requested async operation for the user.<br/>
        /// If the user is not authenticated to view the specified async operation, then it is not returned.<br/>
        /// Only Zoo employees with the proper access can view async operations for other users.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zoo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zoo.AutoSDKHttpResponse<global::Zoo.AsyncApiCallOutput>> GetAsyncOperationAsResponseAsync(
            global::System.Guid id,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}