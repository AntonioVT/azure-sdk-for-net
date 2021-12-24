// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Monitor.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing collection of LogSearchRule and their operations over its parent. </summary>
    public partial class LogSearchRuleCollection : ArmCollection, IEnumerable<LogSearchRule>, IAsyncEnumerable<LogSearchRule>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ScheduledQueryRulesRestOperations _scheduledQueryRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogSearchRuleCollection"/> class for mocking. </summary>
        protected LogSearchRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of LogSearchRuleCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal LogSearchRuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _scheduledQueryRulesRestClient = new ScheduledQueryRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ScheduledQueryRules_CreateOrUpdate
        /// <summary> Creates or updates an log search rule. </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="parameters"> The parameters of the rule to create or update. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ScheduledQueryRuleCreateOrUpdateOperation CreateOrUpdate(string ruleName, LogSearchRuleData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LogSearchRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scheduledQueryRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ruleName, parameters, cancellationToken);
                var operation = new ScheduledQueryRuleCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ScheduledQueryRules_CreateOrUpdate
        /// <summary> Creates or updates an log search rule. </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="parameters"> The parameters of the rule to create or update. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ScheduledQueryRuleCreateOrUpdateOperation> CreateOrUpdateAsync(string ruleName, LogSearchRuleData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LogSearchRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scheduledQueryRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ruleName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ScheduledQueryRuleCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ScheduledQueryRules_Get
        /// <summary> Gets an Log Search rule. </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<LogSearchRule> Get(string ruleName, CancellationToken cancellationToken = default)
        {
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var scope = _clientDiagnostics.CreateScope("LogSearchRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _scheduledQueryRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogSearchRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ScheduledQueryRules_Get
        /// <summary> Gets an Log Search rule. </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public async virtual Task<Response<LogSearchRule>> GetAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var scope = _clientDiagnostics.CreateScope("LogSearchRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _scheduledQueryRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new LogSearchRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<LogSearchRule> GetIfExists(string ruleName, CancellationToken cancellationToken = default)
        {
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var scope = _clientDiagnostics.CreateScope("LogSearchRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _scheduledQueryRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<LogSearchRule>(null, response.GetRawResponse())
                    : Response.FromValue(new LogSearchRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public async virtual Task<Response<LogSearchRule>> GetIfExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var scope = _clientDiagnostics.CreateScope("LogSearchRuleCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _scheduledQueryRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<LogSearchRule>(null, response.GetRawResponse())
                    : Response.FromValue(new LogSearchRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleName, CancellationToken cancellationToken = default)
        {
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var scope = _clientDiagnostics.CreateScope("LogSearchRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(ruleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var scope = _clientDiagnostics.CreateScope("LogSearchRuleCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ScheduledQueryRules_ListByResourceGroup
        /// <summary> List the Log Search rules within a resource group. </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://msdn.microsoft.com/en-us/library/azure/dn931934.aspx. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogSearchRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogSearchRule> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<LogSearchRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LogSearchRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _scheduledQueryRulesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LogSearchRule(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ScheduledQueryRules_ListByResourceGroup
        /// <summary> List the Log Search rules within a resource group. </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://msdn.microsoft.com/en-us/library/azure/dn931934.aspx. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogSearchRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogSearchRule> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<LogSearchRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LogSearchRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _scheduledQueryRulesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LogSearchRule(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="LogSearchRule" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LogSearchRuleCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(LogSearchRule.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="LogSearchRule" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LogSearchRuleCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(LogSearchRule.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LogSearchRule> IEnumerable<LogSearchRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LogSearchRule> IAsyncEnumerable<LogSearchRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, LogSearchRule, LogSearchRuleData> Construct() { }
    }
}
