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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of RecommendedAction and their operations over its parent. </summary>
    public partial class RecommendedActionCollection : ArmCollection, IEnumerable<RecommendedAction>, IAsyncEnumerable<RecommendedAction>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DatabaseRecommendedActionsRestOperations _databaseRecommendedActionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RecommendedActionCollection"/> class for mocking. </summary>
        protected RecommendedActionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RecommendedActionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RecommendedActionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(RecommendedAction.ResourceType, out string apiVersion);
            _databaseRecommendedActionsRestClient = new DatabaseRecommendedActionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServerDatabaseAdvisor.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServerDatabaseAdvisor.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// OperationId: DatabaseRecommendedActions_Get
        /// <summary> Gets a database recommended action. </summary>
        /// <param name="recommendedActionName"> The name of Database Recommended Action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public virtual Response<RecommendedAction> Get(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            if (recommendedActionName == null)
            {
                throw new ArgumentNullException(nameof(recommendedActionName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.Get");
            scope.Start();
            try
            {
                var response = _databaseRecommendedActionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recommendedActionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecommendedAction(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// OperationId: DatabaseRecommendedActions_Get
        /// <summary> Gets a database recommended action. </summary>
        /// <param name="recommendedActionName"> The name of Database Recommended Action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public async virtual Task<Response<RecommendedAction>> GetAsync(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            if (recommendedActionName == null)
            {
                throw new ArgumentNullException(nameof(recommendedActionName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.Get");
            scope.Start();
            try
            {
                var response = await _databaseRecommendedActionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recommendedActionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RecommendedAction(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="recommendedActionName"> The name of Database Recommended Action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public virtual Response<RecommendedAction> GetIfExists(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            if (recommendedActionName == null)
            {
                throw new ArgumentNullException(nameof(recommendedActionName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _databaseRecommendedActionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recommendedActionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RecommendedAction>(null, response.GetRawResponse());
                return Response.FromValue(new RecommendedAction(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="recommendedActionName"> The name of Database Recommended Action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public async virtual Task<Response<RecommendedAction>> GetIfExistsAsync(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            if (recommendedActionName == null)
            {
                throw new ArgumentNullException(nameof(recommendedActionName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _databaseRecommendedActionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recommendedActionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RecommendedAction>(null, response.GetRawResponse());
                return Response.FromValue(new RecommendedAction(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="recommendedActionName"> The name of Database Recommended Action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public virtual Response<bool> Exists(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            if (recommendedActionName == null)
            {
                throw new ArgumentNullException(nameof(recommendedActionName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(recommendedActionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="recommendedActionName"> The name of Database Recommended Action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            if (recommendedActionName == null)
            {
                throw new ArgumentNullException(nameof(recommendedActionName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(recommendedActionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// OperationId: DatabaseRecommendedActions_ListByDatabaseAdvisor
        /// <summary> Gets list of Database Recommended Actions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RecommendedAction" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RecommendedAction> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RecommendedAction> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _databaseRecommendedActionsRestClient.ListByDatabaseAdvisor(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Select(value => new RecommendedAction(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// OperationId: DatabaseRecommendedActions_ListByDatabaseAdvisor
        /// <summary> Gets list of Database Recommended Actions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RecommendedAction" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RecommendedAction> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RecommendedAction>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _databaseRecommendedActionsRestClient.ListByDatabaseAdvisorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Select(value => new RecommendedAction(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<RecommendedAction> IEnumerable<RecommendedAction>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RecommendedAction> IAsyncEnumerable<RecommendedAction>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, RecommendedAction, RecommendedActionData> Construct() { }
    }
}
