#nullable enable

namespace Zoo
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Iterate on a multi-file CAD model with a prompt.<br/>
        /// This endpoint can iterate on multi-file projects.<br/>
        /// Even if you give specific ranges to edit, the model might change more than just those in order to make the changes you requested without breaking the code.<br/>
        /// You always get the whole code back, even if you only changed a small part of it. This endpoint will always return all the code back, including files that were not changed. If your original source code imported a stl/gltf/step/etc file, the output will not include that file since the model will never change non-kcl files. The endpoint will only return the kcl files that were changed.<br/>
        /// This operation is performed asynchronously, the `id` of the operation will be returned. You can use the `id` returned from the request to get status information about the async operation from the `/async/operations/{id}` endpoint.<br/>
        /// Input filepaths will be normalized and re-canonicalized to be under the current working directory -- so returned paths may differ from provided paths, and care must be taken when handling user provided paths.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zoo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zoo.TextToCadMultiFileIteration> CreateTextToCadMultiFileIterationAsync(

            byte[] request,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Iterate on a multi-file CAD model with a prompt.<br/>
        /// This endpoint can iterate on multi-file projects.<br/>
        /// Even if you give specific ranges to edit, the model might change more than just those in order to make the changes you requested without breaking the code.<br/>
        /// You always get the whole code back, even if you only changed a small part of it. This endpoint will always return all the code back, including files that were not changed. If your original source code imported a stl/gltf/step/etc file, the output will not include that file since the model will never change non-kcl files. The endpoint will only return the kcl files that were changed.<br/>
        /// This operation is performed asynchronously, the `id` of the operation will be returned. You can use the `id` returned from the request to get status information about the async operation from the `/async/operations/{id}` endpoint.<br/>
        /// Input filepaths will be normalized and re-canonicalized to be under the current working directory -- so returned paths may differ from provided paths, and care must be taken when handling user provided paths.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zoo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zoo.AutoSDKHttpResponse<global::Zoo.TextToCadMultiFileIteration>> CreateTextToCadMultiFileIterationAsResponseAsync(

            byte[] request,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}