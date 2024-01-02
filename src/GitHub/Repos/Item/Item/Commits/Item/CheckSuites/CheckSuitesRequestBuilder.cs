// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Commits.Item.CheckSuites {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\commits\{commits-id}\check-suites
    /// </summary>
    public class CheckSuitesRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new CheckSuitesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckSuitesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/commits/{commits%2Did}/check-suites{?app_id*,check_name*,per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CheckSuitesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckSuitesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/commits/{commits%2Did}/check-suites{?app_id*,check_name*,per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Lists check suites for a commit `ref`. The `ref` can be a SHA, branch name, or a tag name.GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to list check suites. OAuth apps and authenticated users must have the `repo` scope to get check suites in a private repository.**Note:** The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.
        /// API method documentation <see href="https://docs.github.com/rest/checks/suites#list-check-suites-for-a-git-reference" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CheckSuitesGetResponse?> GetAsCheckSuitesGetResponseAsync(Action<RequestConfiguration<CheckSuitesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CheckSuitesGetResponse> GetAsCheckSuitesGetResponseAsync(Action<RequestConfiguration<CheckSuitesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<CheckSuitesGetResponse>(requestInfo, CheckSuitesGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists check suites for a commit `ref`. The `ref` can be a SHA, branch name, or a tag name.GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to list check suites. OAuth apps and authenticated users must have the `repo` scope to get check suites in a private repository.**Note:** The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.
        /// API method documentation <see href="https://docs.github.com/rest/checks/suites#list-check-suites-for-a-git-reference" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsCheckSuitesGetResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CheckSuitesResponse?> GetAsync(Action<RequestConfiguration<CheckSuitesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CheckSuitesResponse> GetAsync(Action<RequestConfiguration<CheckSuitesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<CheckSuitesResponse>(requestInfo, CheckSuitesResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists check suites for a commit `ref`. The `ref` can be a SHA, branch name, or a tag name.GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to list check suites. OAuth apps and authenticated users must have the `repo` scope to get check suites in a private repository.**Note:** The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CheckSuitesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CheckSuitesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CheckSuitesRequestBuilder WithUrl(string rawUrl) {
            return new CheckSuitesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists check suites for a commit `ref`. The `ref` can be a SHA, branch name, or a tag name.GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to list check suites. OAuth apps and authenticated users must have the `repo` scope to get check suites in a private repository.**Note:** The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.
        /// </summary>
        public class CheckSuitesRequestBuilderGetQueryParameters {
            /// <summary>Filters check suites by GitHub App `id`.</summary>
            [QueryParameter("app_id")]
            public int? AppId { get; set; }
            /// <summary>Returns check runs with the specified `name`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("check_name")]
            public string? CheckName { get; set; }
#nullable restore
#else
            [QueryParameter("check_name")]
            public string CheckName { get; set; }
#endif
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CheckSuitesRequestBuilderGetRequestConfiguration : RequestConfiguration<CheckSuitesRequestBuilderGetQueryParameters> {
        }
    }
}
