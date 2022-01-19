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
using Azure.ResourceManager;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing collection of VMwareCluster and their operations over its parent. </summary>
    public partial class VMwareClusterCollection : ArmCollection, IEnumerable<VMwareCluster>, IAsyncEnumerable<VMwareCluster>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ClustersRestOperations _clustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="VMwareClusterCollection"/> class for mocking. </summary>
        protected VMwareClusterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VMwareClusterCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VMwareClusterCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(VMwareCluster.ResourceType, out string apiVersion);
            _clustersRestClient = new ClustersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Clusters_Create
        /// <summary> Create Or Update cluster. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual VMwareClusterCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string clusterName, VMwareClusterData body = null, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _clustersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, clusterName, body, cancellationToken);
                var operation = new VMwareClusterCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _clustersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, body).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Clusters_Create
        /// <summary> Create Or Update cluster. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public async virtual Task<VMwareClusterCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string clusterName, VMwareClusterData body = null, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _clustersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, body, cancellationToken).ConfigureAwait(false);
                var operation = new VMwareClusterCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _clustersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, body).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Clusters_Get
        /// <summary> Implements cluster GET method. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<VMwareCluster> Get(string clusterName, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.Get");
            scope.Start();
            try
            {
                var response = _clustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareCluster(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Clusters_Get
        /// <summary> Implements cluster GET method. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public async virtual Task<Response<VMwareCluster>> GetAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.Get");
            scope.Start();
            try
            {
                var response = await _clustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VMwareCluster(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<VMwareCluster> GetIfExists(string clusterName, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _clustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VMwareCluster>(null, response.GetRawResponse());
                return Response.FromValue(new VMwareCluster(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public async virtual Task<Response<VMwareCluster>> GetIfExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _clustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VMwareCluster>(null, response.GetRawResponse());
                return Response.FromValue(new VMwareCluster(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<bool> Exists(string clusterName, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(clusterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Clusters_ListByResourceGroup
        /// <summary> List of clusters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VMwareCluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VMwareCluster> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VMwareCluster> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _clustersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareCluster(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VMwareCluster> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _clustersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareCluster(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Clusters_ListByResourceGroup
        /// <summary> List of clusters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VMwareCluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VMwareCluster> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VMwareCluster>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _clustersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareCluster(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VMwareCluster>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _clustersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareCluster(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VMwareCluster" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VMwareCluster.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VMwareCluster" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VMwareClusterCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VMwareCluster.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VMwareCluster> IEnumerable<VMwareCluster>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VMwareCluster> IAsyncEnumerable<VMwareCluster>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VMwareCluster, VMwareClusterData> Construct() { }
    }
}
