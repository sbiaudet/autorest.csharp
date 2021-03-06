// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace httpInfrastructure
{
    public partial class HttpRedirectsClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal HttpRedirectsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of HttpRedirectsClient for mocking. </summary>
        protected HttpRedirectsClient()
        {
        }
        /// <summary> Initializes a new instance of HttpRedirectsClient. </summary>
        internal HttpRedirectsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new HttpRedirectsRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Return 300 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Head300Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Head300Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Return 300 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Head300(CancellationToken cancellationToken = default)
        {
            return RestClient.Head300(cancellationToken);
        }

        /// <summary> Return 300 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Get300Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Get300Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Return 300 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get300(CancellationToken cancellationToken = default)
        {
            return RestClient.Get300(cancellationToken);
        }

        /// <summary> Return 301 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Head301Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Head301Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Return 301 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Head301(CancellationToken cancellationToken = default)
        {
            return RestClient.Head301(cancellationToken);
        }

        /// <summary> Return 301 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Get301Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Get301Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Return 301 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get301(CancellationToken cancellationToken = default)
        {
            return RestClient.Get301(cancellationToken);
        }

        /// <summary> Put true Boolean value in request returns 301.  This request should not be automatically redirected, but should return the received 301 to the caller for evaluation. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Put301Async(CancellationToken cancellationToken = default)
        {
            return (await RestClient.Put301Async(cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Put true Boolean value in request returns 301.  This request should not be automatically redirected, but should return the received 301 to the caller for evaluation. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Put301(CancellationToken cancellationToken = default)
        {
            return RestClient.Put301(cancellationToken).GetRawResponse();
        }

        /// <summary> Return 302 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Head302Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Head302Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Return 302 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Head302(CancellationToken cancellationToken = default)
        {
            return RestClient.Head302(cancellationToken);
        }

        /// <summary> Return 302 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Get302Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Get302Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Return 302 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get302(CancellationToken cancellationToken = default)
        {
            return RestClient.Get302(cancellationToken);
        }

        /// <summary> Patch true Boolean value in request returns 302.  This request should not be automatically redirected, but should return the received 302 to the caller for evaluation. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Patch302Async(CancellationToken cancellationToken = default)
        {
            return (await RestClient.Patch302Async(cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Patch true Boolean value in request returns 302.  This request should not be automatically redirected, but should return the received 302 to the caller for evaluation. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Patch302(CancellationToken cancellationToken = default)
        {
            return RestClient.Patch302(cancellationToken).GetRawResponse();
        }

        /// <summary> Post true Boolean value in request returns 303.  This request should be automatically redirected usign a get, ultimately returning a 200 status code. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Post303Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Post303Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Post true Boolean value in request returns 303.  This request should be automatically redirected usign a get, ultimately returning a 200 status code. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Post303(CancellationToken cancellationToken = default)
        {
            return RestClient.Post303(cancellationToken);
        }

        /// <summary> Redirect with 307, resulting in a 200 success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Head307Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Head307Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Redirect with 307, resulting in a 200 success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Head307(CancellationToken cancellationToken = default)
        {
            return RestClient.Head307(cancellationToken);
        }

        /// <summary> Redirect get with 307, resulting in a 200 success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Get307Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Get307Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Redirect get with 307, resulting in a 200 success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get307(CancellationToken cancellationToken = default)
        {
            return RestClient.Get307(cancellationToken);
        }

        /// <summary> options redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Options307Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Options307Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> options redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Options307(CancellationToken cancellationToken = default)
        {
            return RestClient.Options307(cancellationToken);
        }

        /// <summary> Put redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Put307Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Put307Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Put redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Put307(CancellationToken cancellationToken = default)
        {
            return RestClient.Put307(cancellationToken);
        }

        /// <summary> Patch redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Patch307Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Patch307Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Patch redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Patch307(CancellationToken cancellationToken = default)
        {
            return RestClient.Patch307(cancellationToken);
        }

        /// <summary> Post redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Post307Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Post307Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Post redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Post307(CancellationToken cancellationToken = default)
        {
            return RestClient.Post307(cancellationToken);
        }

        /// <summary> Delete redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Delete307Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Delete307Async(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Delete redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete307(CancellationToken cancellationToken = default)
        {
            return RestClient.Delete307(cancellationToken);
        }
    }
}
