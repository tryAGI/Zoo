#nullable enable

namespace Zoo
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Generate a CAD model from text.<br/>
        /// Because our source of truth for the resulting model is a STEP file, you will always have STEP file contents when you list your generated parts. Any other formats you request here will also be returned when you list your generated parts.<br/>
        /// This operation is performed asynchronously, the `id` of the operation will be returned. You can use the `id` returned from the request to get status information about the async operation from the `/async/operations/{id}` endpoint.<br/>
        /// One thing to note, if you hit the cache, this endpoint will return right away. So you only have to wait if the status is not `Completed` or `Failed`.
        /// </summary>
        /// <param name="outputFormat">
        /// The valid types of output file formats.
        /// </param>
        /// <param name="kcl"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zoo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zoo.TextToCad> CreateTextToCadAsync(
            global::Zoo.FileExportFormat outputFormat,

            global::Zoo.TextToCadCreateBody request,
            bool? kcl = default,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a CAD model from text.<br/>
        /// Because our source of truth for the resulting model is a STEP file, you will always have STEP file contents when you list your generated parts. Any other formats you request here will also be returned when you list your generated parts.<br/>
        /// This operation is performed asynchronously, the `id` of the operation will be returned. You can use the `id` returned from the request to get status information about the async operation from the `/async/operations/{id}` endpoint.<br/>
        /// One thing to note, if you hit the cache, this endpoint will return right away. So you only have to wait if the status is not `Completed` or `Failed`.
        /// </summary>
        /// <param name="outputFormat">
        /// The valid types of output file formats.
        /// </param>
        /// <param name="kcl"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zoo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zoo.AutoSDKHttpResponse<global::Zoo.TextToCad>> CreateTextToCadAsResponseAsync(
            global::Zoo.FileExportFormat outputFormat,

            global::Zoo.TextToCadCreateBody request,
            bool? kcl = default,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a CAD model from text.<br/>
        /// Because our source of truth for the resulting model is a STEP file, you will always have STEP file contents when you list your generated parts. Any other formats you request here will also be returned when you list your generated parts.<br/>
        /// This operation is performed asynchronously, the `id` of the operation will be returned. You can use the `id` returned from the request to get status information about the async operation from the `/async/operations/{id}` endpoint.<br/>
        /// One thing to note, if you hit the cache, this endpoint will return right away. So you only have to wait if the status is not `Completed` or `Failed`.
        /// </summary>
        /// <param name="outputFormat">
        /// The valid types of output file formats.
        /// </param>
        /// <param name="kcl"></param>
        /// <param name="kclVersion">
        /// The version of kcl to use. If empty, the latest version will be used.
        /// </param>
        /// <param name="modelVersion">
        /// Zoo provided model, or custom model which should be used to process this request.
        /// </param>
        /// <param name="projectName">
        /// The project name. This is used to tie the prompt to a project. Which helps us make our models better over time.
        /// </param>
        /// <param name="prompt">
        /// The prompt for the desired part.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zoo.TextToCad> CreateTextToCadAsync(
            global::Zoo.FileExportFormat outputFormat,
            string prompt,
            bool? kcl = default,
            string? kclVersion = default,
            string? modelVersion = default,
            string? projectName = default,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}