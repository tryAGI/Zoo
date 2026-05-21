
#nullable enable

namespace Zoo
{
    public partial class MlClient
    {


        private static readonly global::Zoo.EndPointSecurityRequirement s_ListTextToCadPartsForUserSecurityRequirement0 =
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
        private static readonly global::Zoo.EndPointSecurityRequirement[] s_ListTextToCadPartsForUserSecurityRequirements =
            new global::Zoo.EndPointSecurityRequirement[]
            {                s_ListTextToCadPartsForUserSecurityRequirement0,
            };
        partial void PrepareListTextToCadPartsForUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref string? pageToken,
            ref global::Zoo.CreatedAtSortMode? sortBy,
            ref bool? noModels,
            ref bool? noParts,
            ref global::System.Guid? conversationId);
        partial void PrepareListTextToCadPartsForUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            string? pageToken,
            global::Zoo.CreatedAtSortMode? sortBy,
            bool? noModels,
            bool? noParts,
            global::System.Guid? conversationId);
        partial void ProcessListTextToCadPartsForUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListTextToCadPartsForUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Zoo.TextToCadResponseResultsPage> ListTextToCadPartsForUserAsync(
            int? limit = default,
            string? pageToken = default,
            global::Zoo.CreatedAtSortMode? sortBy = default,
            bool? noModels = default,
            bool? noParts = default,
            global::System.Guid? conversationId = default,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListTextToCadPartsForUserAsResponseAsync(
                limit: limit,
                pageToken: pageToken,
                sortBy: sortBy,
                noModels: noModels,
                noParts: noParts,
                conversationId: conversationId,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::Zoo.AutoSDKHttpResponse<global::Zoo.TextToCadResponseResultsPage>> ListTextToCadPartsForUserAsResponseAsync(
            int? limit = default,
            string? pageToken = default,
            global::Zoo.CreatedAtSortMode? sortBy = default,
            bool? noModels = default,
            bool? noParts = default,
            global::System.Guid? conversationId = default,
            global::Zoo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListTextToCadPartsForUserArguments(
                httpClient: HttpClient,
                limit: ref limit,
                pageToken: ref pageToken,
                sortBy: ref sortBy,
                noModels: ref noModels,
                noParts: ref noParts,
                conversationId: ref conversationId);


            var __authorizations = global::Zoo.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListTextToCadPartsForUserSecurityRequirements,
                operationName: "ListTextToCadPartsForUserAsync");

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
                                path: "/user/text-to-cad",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("page_token", pageToken)
                                .AddOptionalParameter("sort_by", sortBy?.ToString())
                                .AddOptionalParameter("no_models", noModels?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("no_parts", noParts?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("conversation_id", conversationId?.ToString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Zoo.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::Zoo.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListTextToCadPartsForUserRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    limit: limit,
                    pageToken: pageToken,
                    sortBy: sortBy,
                    noModels: noModels,
                    noParts: noParts,
                    conversationId: conversationId);

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
                                operationId: "ListTextToCadPartsForUser",
                                methodName: "ListTextToCadPartsForUserAsync",
                                pathTemplate: "\"/user/text-to-cad\"",
                                httpMethod: "GET",
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
                                operationId: "ListTextToCadPartsForUser",
                                methodName: "ListTextToCadPartsForUserAsync",
                                pathTemplate: "\"/user/text-to-cad\"",
                                httpMethod: "GET",
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
                                operationId: "ListTextToCadPartsForUser",
                                methodName: "ListTextToCadPartsForUserAsync",
                                pathTemplate: "\"/user/text-to-cad\"",
                                httpMethod: "GET",
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
                ProcessListTextToCadPartsForUserResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Zoo.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Zoo.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListTextToCadPartsForUser",
                                methodName: "ListTextToCadPartsForUserAsync",
                                pathTemplate: "\"/user/text-to-cad\"",
                                httpMethod: "GET",
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
                                operationId: "ListTextToCadPartsForUser",
                                methodName: "ListTextToCadPartsForUserAsync",
                                pathTemplate: "\"/user/text-to-cad\"",
                                httpMethod: "GET",
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
                                ProcessListTextToCadPartsForUserResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Zoo.TextToCadResponseResultsPage.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Zoo.AutoSDKHttpResponse<global::Zoo.TextToCadResponseResultsPage>(
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

                                    var __value = await global::Zoo.TextToCadResponseResultsPage.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Zoo.AutoSDKHttpResponse<global::Zoo.TextToCadResponseResultsPage>(
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