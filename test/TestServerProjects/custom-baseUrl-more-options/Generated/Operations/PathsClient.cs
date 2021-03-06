// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace custom_baseUrl_more_options
{
    public partial class PathsClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal PathsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of PathsClient for mocking. </summary>
        protected PathsClient()
        {
        }
        /// <summary> Initializes a new instance of PathsClient. </summary>
        internal PathsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string dnsSuffix = "host")
        {
            RestClient = new PathsRestClient(clientDiagnostics, pipeline, subscriptionId, dnsSuffix);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Get a 200 to test a valid base uri. </summary>
        /// <param name="vault"> The vault name, e.g. https://myvault. </param>
        /// <param name="secret"> Secret value. </param>
        /// <param name="keyName"> The key name with value &apos;key1&apos;. </param>
        /// <param name="keyVersion"> The key version. Default value &apos;v1&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetEmptyAsync(string vault, string secret, string keyName, string keyVersion, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetEmptyAsync(vault, secret, keyName, keyVersion, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Get a 200 to test a valid base uri. </summary>
        /// <param name="vault"> The vault name, e.g. https://myvault. </param>
        /// <param name="secret"> Secret value. </param>
        /// <param name="keyName"> The key name with value &apos;key1&apos;. </param>
        /// <param name="keyVersion"> The key version. Default value &apos;v1&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetEmpty(string vault, string secret, string keyName, string keyVersion, CancellationToken cancellationToken = default)
        {
            return RestClient.GetEmpty(vault, secret, keyName, keyVersion, cancellationToken);
        }
    }
}
