
#nullable enable

namespace Zoo
{
    public partial class MlClient
    {


        private static readonly global::Zoo.EndPointSecurityRequirement s_CreateTextToCadMultiFileIterationSecurityRequirement0 =
            new global::Zoo.EndPointSecurityRequirement
            {
                Authorizations = new global::Zoo.EndPointAuthorizationRequirement[]
                {                    new global::Zoo.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Zoo.EndPointSecurityRequirement[] s_CreateTextToCadMultiFileIterationSecurityRequirements =
            new global::Zoo.EndPointSecurityRequirement[]
            {                s_CreateTextToCadMultiFileIterationSecurityRequirement0,
            };
        partial void PrepareCreateTextToCadMultiFileIterationArguments(
            global::System.Net.Http.HttpClient httpClient,
            byte[] request);
        partial void PrepareCreateTextToCadMultiFileIterationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            byte[] request);
        partial void ProcessCreateTextToCadMultiFileIterationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTextToCadMultiFileIterationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Zoo.TextToCadMultiFileIteration> CreateTextToCadMultiFileIterationAsync(

            byte[] request,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateTextToCadMultiFileIterationAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::Zoo.AutoSDKHttpResponse<global::Zoo.TextToCadMultiFileIteration>> CreateTextToCadMultiFileIterationAsResponseAsync(

            byte[] request,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTextToCadMultiFileIterationArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Zoo.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTextToCadMultiFileIterationSecurityRequirements,
                operationName: "CreateTextToCadMultiFileIterationAsync");

            using var __timeoutCancellationTokenSource = global::Zoo.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Zoo.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Zoo.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Zoo.PathBuilder(
                                path: "/ml/text-to-cad/multi-file/iteration",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Zoo.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();

                            __httpRequest.Content = __httpRequestContent;

                global::Zoo.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateTextToCadMultiFileIterationRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Zoo.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Zoo.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToCadMultiFileIteration",
                                methodName: "CreateTextToCadMultiFileIterationAsync",
                                pathTemplate: "\"/ml/text-to-cad/multi-file/iteration\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Zoo.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Zoo.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Zoo.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToCadMultiFileIteration",
                                methodName: "CreateTextToCadMultiFileIterationAsync",
                                pathTemplate: "\"/ml/text-to-cad/multi-file/iteration\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Zoo.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Zoo.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Zoo.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Zoo.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Zoo.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToCadMultiFileIteration",
                                methodName: "CreateTextToCadMultiFileIterationAsync",
                                pathTemplate: "\"/ml/text-to-cad/multi-file/iteration\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Zoo.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateTextToCadMultiFileIterationResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Zoo.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Zoo.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToCadMultiFileIteration",
                                methodName: "CreateTextToCadMultiFileIterationAsync",
                                pathTemplate: "\"/ml/text-to-cad/multi-file/iteration\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Zoo.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Zoo.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToCadMultiFileIteration",
                                methodName: "CreateTextToCadMultiFileIterationAsync",
                                pathTemplate: "\"/ml/text-to-cad/multi-file/iteration\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Error
                            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
                            {
                                string? __content_4XX = null;
                                global::System.Exception? __exception_4XX = null;
                                global::Zoo.Error? __value_4XX = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_4XX = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_4XX = global::Zoo.Error.FromJson(__content_4XX, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_4XX = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_4XX = global::Zoo.Error.FromJson(__content_4XX, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_4XX = __ex;
                                }

                                throw new global::Zoo.ApiException<global::Zoo.Error>(
                                    message: __content_4XX ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_4XX,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_4XX,
                                    ResponseObject = __value_4XX,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Error
                            if ((int)__response.StatusCode >= 500 && (int)__response.StatusCode <= 599)
                            {
                                string? __content_5XX = null;
                                global::System.Exception? __exception_5XX = null;
                                global::Zoo.Error? __value_5XX = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_5XX = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_5XX = global::Zoo.Error.FromJson(__content_5XX, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_5XX = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_5XX = global::Zoo.Error.FromJson(__content_5XX, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_5XX = __ex;
                                }

                                throw new global::Zoo.ApiException<global::Zoo.Error>(
                                    message: __content_5XX ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_5XX,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_5XX,
                                    ResponseObject = __value_5XX,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateTextToCadMultiFileIterationResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Zoo.TextToCadMultiFileIteration.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Zoo.AutoSDKHttpResponse<global::Zoo.TextToCadMultiFileIteration>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Zoo.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Zoo.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Zoo.TextToCadMultiFileIteration.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Zoo.AutoSDKHttpResponse<global::Zoo.TextToCadMultiFileIteration>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Zoo.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::Zoo.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}