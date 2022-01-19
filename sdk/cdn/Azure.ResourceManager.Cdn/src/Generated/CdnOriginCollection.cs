// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of CdnOrigin and their operations over its parent. </summary>
    public partial class CdnOriginCollection : ArmCollection, IEnumerable<CdnOrigin>, IAsyncEnumerable<CdnOrigin>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CdnOriginsRestOperations _cdnOriginsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CdnOriginCollection"/> class for mocking. </summary>
        protected CdnOriginCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CdnOriginCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CdnOriginCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(CdnOrigin.ResourceType, out string apiVersion);
            _cdnOriginsRestClient = new CdnOriginsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CdnEndpoint.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CdnEndpoint.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a new origin within the specified endpoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="originName"> Name of the origin that is unique within the endpoint. </param>
        /// <param name="origin"> Origin properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> or <paramref name="origin"/> is null. </exception>
        public virtual CdnOriginCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string originName, CdnOriginData origin, CancellationToken cancellationToken = default)
        {
            if (originName == null)
            {
                throw new ArgumentNullException(nameof(originName));
            }
            if (origin == null)
            {
                throw new ArgumentNullException(nameof(origin));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cdnOriginsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, origin, cancellationToken);
                var operation = new CdnOriginCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _cdnOriginsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, origin).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new origin within the specified endpoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="originName"> Name of the origin that is unique within the endpoint. </param>
        /// <param name="origin"> Origin properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> or <paramref name="origin"/> is null. </exception>
        public async virtual Task<CdnOriginCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string originName, CdnOriginData origin, CancellationToken cancellationToken = default)
        {
            if (originName == null)
            {
                throw new ArgumentNullException(nameof(originName));
            }
            if (origin == null)
            {
                throw new ArgumentNullException(nameof(origin));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cdnOriginsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, origin, cancellationToken).ConfigureAwait(false);
                var operation = new CdnOriginCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _cdnOriginsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, origin).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing origin within an endpoint. </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual Response<CdnOrigin> Get(string originName, CancellationToken cancellationToken = default)
        {
            if (originName == null)
            {
                throw new ArgumentNullException(nameof(originName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginCollection.Get");
            scope.Start();
            try
            {
                var response = _cdnOriginsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnOrigin(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing origin within an endpoint. </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public async virtual Task<Response<CdnOrigin>> GetAsync(string originName, CancellationToken cancellationToken = default)
        {
            if (originName == null)
            {
                throw new ArgumentNullException(nameof(originName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginCollection.Get");
            scope.Start();
            try
            {
                var response = await _cdnOriginsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CdnOrigin(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual Response<CdnOrigin> GetIfExists(string originName, CancellationToken cancellationToken = default)
        {
            if (originName == null)
            {
                throw new ArgumentNullException(nameof(originName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cdnOriginsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CdnOrigin>(null, response.GetRawResponse());
                return Response.FromValue(new CdnOrigin(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public async virtual Task<Response<CdnOrigin>> GetIfExistsAsync(string originName, CancellationToken cancellationToken = default)
        {
            if (originName == null)
            {
                throw new ArgumentNullException(nameof(originName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cdnOriginsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CdnOrigin>(null, response.GetRawResponse());
                return Response.FromValue(new CdnOrigin(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual Response<bool> Exists(string originName, CancellationToken cancellationToken = default)
        {
            if (originName == null)
            {
                throw new ArgumentNullException(nameof(originName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(originName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string originName, CancellationToken cancellationToken = default)
        {
            if (originName == null)
            {
                throw new ArgumentNullException(nameof(originName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(originName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the existing origins within an endpoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CdnOrigin" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CdnOrigin> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CdnOrigin> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnOriginCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cdnOriginsRestClient.ListByEndpoint(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnOrigin(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CdnOrigin> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnOriginCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cdnOriginsRestClient.ListByEndpointNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnOrigin(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the existing origins within an endpoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CdnOrigin" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CdnOrigin> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CdnOrigin>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnOriginCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cdnOriginsRestClient.ListByEndpointAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnOrigin(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CdnOrigin>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnOriginCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cdnOriginsRestClient.ListByEndpointNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnOrigin(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<CdnOrigin> IEnumerable<CdnOrigin>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CdnOrigin> IAsyncEnumerable<CdnOrigin>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, CdnOrigin, CdnOriginData> Construct() { }
    }
}
