// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using body_complex.Models;

namespace body_complex
{
    public partial class FlattencomplexClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal FlattencomplexRestClient RestClient { get; }
        /// <summary> Initializes a new instance of FlattencomplexClient for mocking. </summary>
        protected FlattencomplexClient()
        {
        }
        /// <summary> Initializes a new instance of FlattencomplexClient. </summary>
        internal FlattencomplexClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new FlattencomplexRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MyBaseType>> GetValidAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetValidAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MyBaseType> GetValid(CancellationToken cancellationToken = default)
        {
            return RestClient.GetValid(cancellationToken);
        }
    }
}
