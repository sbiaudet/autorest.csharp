// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using ExtensionClientName.Models;

namespace ExtensionClientName
{
    public partial class ServiceClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal ServiceRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ServiceClient for mocking. </summary>
        protected ServiceClient()
        {
        }
        /// <summary> Initializes a new instance of ServiceClient. </summary>
        internal ServiceClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new ServiceRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <param name="renamedPathParameter"> The String to use. </param>
        /// <param name="renamedQueryParameter"> The String to use. </param>
        /// <param name="renamedBodyParameter"> The RenamedSchema to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RenamedSchema>> RenamedOperationAsync(string renamedPathParameter, string renamedQueryParameter, RenamedSchema renamedBodyParameter, CancellationToken cancellationToken = default)
        {
            return await RestClient.RenamedOperationAsync(renamedPathParameter, renamedQueryParameter, renamedBodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <param name="renamedPathParameter"> The String to use. </param>
        /// <param name="renamedQueryParameter"> The String to use. </param>
        /// <param name="renamedBodyParameter"> The RenamedSchema to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RenamedSchema> RenamedOperation(string renamedPathParameter, string renamedQueryParameter, RenamedSchema renamedBodyParameter, CancellationToken cancellationToken = default)
        {
            return RestClient.RenamedOperation(renamedPathParameter, renamedQueryParameter, renamedBodyParameter, cancellationToken);
        }
    }
}
