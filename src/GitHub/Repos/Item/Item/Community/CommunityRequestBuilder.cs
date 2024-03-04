// <auto-generated/>
using GitHub.Repos.Item.Item.Community.Profile;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Repos.Item.Item.Community {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\community
    /// </summary>
    public class CommunityRequestBuilder : BaseRequestBuilder {
        /// <summary>The profile property</summary>
        public ProfileRequestBuilder Profile { get =>
            new ProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="CommunityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CommunityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/community", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="CommunityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CommunityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/community", rawUrl) {
        }
    }
}
