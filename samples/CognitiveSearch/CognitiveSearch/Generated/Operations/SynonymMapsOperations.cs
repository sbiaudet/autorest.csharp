// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using CognitiveSearch.Models;

namespace CognitiveSearch
{
    internal partial class SynonymMapsOperations
    {
        private string searchServiceName;
        private string searchDnsSuffix;
        private string ApiVersion;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;
        /// <summary> Initializes a new instance of SynonymMapsOperations. </summary>
        public SynonymMapsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string searchServiceName, string searchDnsSuffix = "search.windows.net", string ApiVersion = "2019-05-06")
        {
            if (searchServiceName == null)
            {
                throw new ArgumentNullException(nameof(searchServiceName));
            }
            if (searchDnsSuffix == null)
            {
                throw new ArgumentNullException(nameof(searchDnsSuffix));
            }
            if (ApiVersion == null)
            {
                throw new ArgumentNullException(nameof(ApiVersion));
            }

            this.searchServiceName = searchServiceName;
            this.searchDnsSuffix = searchDnsSuffix;
            this.ApiVersion = ApiVersion;
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        internal HttpMessage CreateCreateOrUpdateRequest(string synonymMapName, Guid? clientRequestId, string? ifMatch, string? ifNoneMatch, SynonymMap synonymMap)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(searchServiceName, false);
            uri.AppendRaw(".", false);
            uri.AppendRaw(searchDnsSuffix, false);
            uri.AppendPath("/synonymmaps('", false);
            uri.AppendPath(synonymMapName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Prefer", "return=representation");
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(synonymMap);
            request.Content = content;
            return message;
        }
        /// <summary> Creates a new synonym map or updates a synonym map if it already exists. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="synonymMap"> The definition of the synonym map to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<SynonymMap>> CreateOrUpdateAsync(string synonymMapName, Guid? clientRequestId, string? ifMatch, string? ifNoneMatch, SynonymMap synonymMap, CancellationToken cancellationToken = default)
        {
            if (synonymMapName == null)
            {
                throw new ArgumentNullException(nameof(synonymMapName));
            }
            if (synonymMap == null)
            {
                throw new ArgumentNullException(nameof(synonymMap));
            }

            using var scope = clientDiagnostics.CreateScope("SynonymMapsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                using var message = CreateCreateOrUpdateRequest(synonymMapName, clientRequestId, ifMatch, ifNoneMatch, synonymMap);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = SynonymMap.DeserializeSynonymMap(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Creates a new synonym map or updates a synonym map if it already exists. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="synonymMap"> The definition of the synonym map to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SynonymMap> CreateOrUpdate(string synonymMapName, Guid? clientRequestId, string? ifMatch, string? ifNoneMatch, SynonymMap synonymMap, CancellationToken cancellationToken = default)
        {
            if (synonymMapName == null)
            {
                throw new ArgumentNullException(nameof(synonymMapName));
            }
            if (synonymMap == null)
            {
                throw new ArgumentNullException(nameof(synonymMap));
            }

            using var scope = clientDiagnostics.CreateScope("SynonymMapsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                using var message = CreateCreateOrUpdateRequest(synonymMapName, clientRequestId, ifMatch, ifNoneMatch, synonymMap);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = SynonymMap.DeserializeSynonymMap(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDeleteRequest(string synonymMapName, Guid? clientRequestId, string? ifMatch, string? ifNoneMatch)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(searchServiceName, false);
            uri.AppendRaw(".", false);
            uri.AppendRaw(searchDnsSuffix, false);
            uri.AppendPath("/synonymmaps('", false);
            uri.AppendPath(synonymMapName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            return message;
        }
        /// <summary> Deletes a synonym map. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsync(string synonymMapName, Guid? clientRequestId, string? ifMatch, string? ifNoneMatch, CancellationToken cancellationToken = default)
        {
            if (synonymMapName == null)
            {
                throw new ArgumentNullException(nameof(synonymMapName));
            }

            using var scope = clientDiagnostics.CreateScope("SynonymMapsOperations.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(synonymMapName, clientRequestId, ifMatch, ifNoneMatch);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Deletes a synonym map. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string synonymMapName, Guid? clientRequestId, string? ifMatch, string? ifNoneMatch, CancellationToken cancellationToken = default)
        {
            if (synonymMapName == null)
            {
                throw new ArgumentNullException(nameof(synonymMapName));
            }

            using var scope = clientDiagnostics.CreateScope("SynonymMapsOperations.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(synonymMapName, clientRequestId, ifMatch, ifNoneMatch);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateGetRequest(string synonymMapName, Guid? clientRequestId)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(searchServiceName, false);
            uri.AppendRaw(".", false);
            uri.AppendRaw(searchDnsSuffix, false);
            uri.AppendPath("/synonymmaps('", false);
            uri.AppendPath(synonymMapName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            return message;
        }
        /// <summary> Retrieves a synonym map definition. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<SynonymMap>> GetAsync(string synonymMapName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            if (synonymMapName == null)
            {
                throw new ArgumentNullException(nameof(synonymMapName));
            }

            using var scope = clientDiagnostics.CreateScope("SynonymMapsOperations.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(synonymMapName, clientRequestId);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = SynonymMap.DeserializeSynonymMap(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Retrieves a synonym map definition. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SynonymMap> Get(string synonymMapName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            if (synonymMapName == null)
            {
                throw new ArgumentNullException(nameof(synonymMapName));
            }

            using var scope = clientDiagnostics.CreateScope("SynonymMapsOperations.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(synonymMapName, clientRequestId);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = SynonymMap.DeserializeSynonymMap(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateListRequest(string? select, Guid? clientRequestId)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(searchServiceName, false);
            uri.AppendRaw(".", false);
            uri.AppendRaw(searchDnsSuffix, false);
            uri.AppendPath("/synonymmaps", false);
            if (select != null)
            {
                uri.AppendQuery("$select", select, true);
            }
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            return message;
        }
        /// <summary> Lists all synonym maps available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the data sources to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ListSynonymMapsResult>> ListAsync(string? select, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("SynonymMapsOperations.List");
            scope.Start();
            try
            {
                using var message = CreateListRequest(select, clientRequestId);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = ListSynonymMapsResult.DeserializeListSynonymMapsResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Lists all synonym maps available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the data sources to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ListSynonymMapsResult> List(string? select, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("SynonymMapsOperations.List");
            scope.Start();
            try
            {
                using var message = CreateListRequest(select, clientRequestId);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = ListSynonymMapsResult.DeserializeListSynonymMapsResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateCreateRequest(Guid? clientRequestId, SynonymMap synonymMap)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(searchServiceName, false);
            uri.AppendRaw(".", false);
            uri.AppendRaw(searchDnsSuffix, false);
            uri.AppendPath("/synonymmaps", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(synonymMap);
            request.Content = content;
            return message;
        }
        /// <summary> Creates a new synonym map. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="synonymMap"> The definition of the synonym map to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<SynonymMap>> CreateAsync(Guid? clientRequestId, SynonymMap synonymMap, CancellationToken cancellationToken = default)
        {
            if (synonymMap == null)
            {
                throw new ArgumentNullException(nameof(synonymMap));
            }

            using var scope = clientDiagnostics.CreateScope("SynonymMapsOperations.Create");
            scope.Start();
            try
            {
                using var message = CreateCreateRequest(clientRequestId, synonymMap);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 201:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = SynonymMap.DeserializeSynonymMap(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Creates a new synonym map. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="synonymMap"> The definition of the synonym map to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SynonymMap> Create(Guid? clientRequestId, SynonymMap synonymMap, CancellationToken cancellationToken = default)
        {
            if (synonymMap == null)
            {
                throw new ArgumentNullException(nameof(synonymMap));
            }

            using var scope = clientDiagnostics.CreateScope("SynonymMapsOperations.Create");
            scope.Start();
            try
            {
                using var message = CreateCreateRequest(clientRequestId, synonymMap);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 201:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = SynonymMap.DeserializeSynonymMap(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}