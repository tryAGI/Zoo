
#nullable enable

namespace Zoo
{
    public partial class MlClient
    {


        private static readonly global::Zoo.EndPointSecurityRequirement s_CreateTextToCadSecurityRequirement0 =
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
        private static readonly global::Zoo.EndPointSecurityRequirement[] s_CreateTextToCadSecurityRequirements =
            new global::Zoo.EndPointSecurityRequirement[]
            {                s_CreateTextToCadSecurityRequirement0,
            };
        partial void PrepareCreateTextToCadArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Zoo.FileExportFormat outputFormat,
            ref bool? kcl,
            global::Zoo.TextToCadCreateBody request);
        partial void PrepareCreateTextToCadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Zoo.FileExportFormat outputFormat,
            bool? kcl,
            global::Zoo.TextToCadCreateBody request);
        partial void ProcessCreateTextToCadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTextToCadResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Zoo.TextToCad> CreateTextToCadAsync(
            global::Zoo.FileExportFormat outputFormat,

            global::Zoo.TextToCadCreateBody request,
            bool? kcl = default,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateTextToCadAsResponseAsync(
                outputFormat: outputFormat,

                request: request,
                kcl: kcl,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::Zoo.AutoSDKHttpResponse<global::Zoo.TextToCad>> CreateTextToCadAsResponseAsync(
            global::Zoo.FileExportFormat outputFormat,

            global::Zoo.TextToCadCreateBody request,
            bool? kcl = default,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTextToCadArguments(
                httpClient: HttpClient,
                outputFormat: ref outputFormat,
                kcl: ref kcl,
                request: request);


            var __authorizations = global::Zoo.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTextToCadSecurityRequirements,
                operationName: "CreateTextToCadAsync");

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
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Zoo.PathBuilder(
                                path: $"/ai/text-to-cad/{outputFormat}",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("kcl", kcl?.ToString().ToLowerInvariant()) 
                                ;
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Zoo.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateTextToCadRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    outputFormat: outputFormat,
                    kcl: kcl,
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
                                operationId: "CreateTextToCad",
                                methodName: "CreateTextToCadAsync",
                                pathTemplate: "$\"/ai/text-to-cad/{outputFormat}\"",
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Zoo.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Zoo.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToCad",
                                methodName: "CreateTextToCadAsync",
                                pathTemplate: "$\"/ai/text-to-cad/{outputFormat}\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Zoo.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Zoo.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Zoo.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Zoo.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToCad",
                                methodName: "CreateTextToCadAsync",
                                pathTemplate: "$\"/ai/text-to-cad/{outputFormat}\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Zoo.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessCreateTextToCadResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Zoo.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Zoo.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToCad",
                                methodName: "CreateTextToCadAsync",
                                pathTemplate: "$\"/ai/text-to-cad/{outputFormat}\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Zoo.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Zoo.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToCad",
                                methodName: "CreateTextToCadAsync",
                                pathTemplate: "$\"/ai/text-to-cad/{outputFormat}\"",
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
                                ProcessCreateTextToCadResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Zoo.TextToCad.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Zoo.AutoSDKHttpResponse<global::Zoo.TextToCad>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Zoo.AutoSDKHttpResponse.CreateHeaders(__response),
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

                                    var __value = await global::Zoo.TextToCad.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Zoo.AutoSDKHttpResponse<global::Zoo.TextToCad>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Zoo.AutoSDKHttpResponse.CreateHeaders(__response),
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
        public async global::System.Threading.Tasks.Task<global::Zoo.TextToCad> CreateTextToCadAsync(
            global::Zoo.FileExportFormat outputFormat,
            string prompt,
            bool? kcl = default,
            string? kclVersion = default,
            string? modelVersion = default,
            string? projectName = default,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Zoo.TextToCadCreateBody
            {
                KclVersion = kclVersion,
                ModelVersion = modelVersion,
                ProjectName = projectName,
                Prompt = prompt,
            };

            return await CreateTextToCadAsync(
                outputFormat: outputFormat,
                kcl: kcl,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}