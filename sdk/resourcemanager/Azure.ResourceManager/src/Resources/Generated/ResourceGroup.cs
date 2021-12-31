// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a ResourceGroup along with the instance operations that can be performed on it. </summary>
    public partial class ResourceGroup : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceGroup"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ResourceGroupsRestOperations _resourceGroupsRestClient;
        private readonly ResourceGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroup"/> class for mocking. </summary>
        protected ResourceGroup()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResourceGroup"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ResourceGroup(ArmResource options, ResourceGroupData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _resourceGroupsRestClient = new ResourceGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroup"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroup(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _resourceGroupsRestClient = new ResourceGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroup"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroup(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _resourceGroupsRestClient = new ResourceGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/resourceGroups";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResourceGroupData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// OperationId: ResourceGroups_Get
        /// <summary> Gets a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ResourceGroup>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.Get");
            scope.Start();
            try
            {
                var response = await _resourceGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// OperationId: ResourceGroups_Get
        /// <summary> Gets a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGroup> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.Get");
            scope.Start();
            try
            {
                var response = _resourceGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// OperationId: ResourceGroups_Delete
        /// <summary> When you delete a resource group, all of its resources are also deleted. Deleting a resource group deletes all of its template deployments and currently stored operations. </summary>
        /// <param name="forceDeletionTypes"> The resource types you want to force delete. Currently, only the following is supported: forceDeletionTypes=Microsoft.Compute/virtualMachines,Microsoft.Compute/virtualMachineScaleSets. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ResourceGroupDeleteOperation> DeleteAsync(string forceDeletionTypes = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.Delete");
            scope.Start();
            try
            {
                var response = await _resourceGroupsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, forceDeletionTypes, cancellationToken).ConfigureAwait(false);
                var operation = new ResourceGroupDeleteOperation(_clientDiagnostics, Pipeline, _resourceGroupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, forceDeletionTypes).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// OperationId: ResourceGroups_Delete
        /// <summary> When you delete a resource group, all of its resources are also deleted. Deleting a resource group deletes all of its template deployments and currently stored operations. </summary>
        /// <param name="forceDeletionTypes"> The resource types you want to force delete. Currently, only the following is supported: forceDeletionTypes=Microsoft.Compute/virtualMachines,Microsoft.Compute/virtualMachineScaleSets. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ResourceGroupDeleteOperation Delete(string forceDeletionTypes = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.Delete");
            scope.Start();
            try
            {
                var response = _resourceGroupsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, forceDeletionTypes, cancellationToken);
                var operation = new ResourceGroupDeleteOperation(_clientDiagnostics, Pipeline, _resourceGroupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, forceDeletionTypes).Request, response);
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

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public async virtual Task<Response<ResourceGroup>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _resourceGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroup(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public virtual Response<ResourceGroup> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _resourceGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                return Response.FromValue(new ResourceGroup(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public async virtual Task<Response<ResourceGroup>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _resourceGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroup(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public virtual Response<ResourceGroup> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _resourceGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                return Response.FromValue(new ResourceGroup(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public async virtual Task<Response<ResourceGroup>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _resourceGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroup(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public virtual Response<ResourceGroup> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _resourceGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                return Response.FromValue(new ResourceGroup(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// OperationId: ResourceGroups_Update
        /// <summary> Resource groups can be updated through a simple PATCH operation to a group address. The format of the request is the same as that for creating a resource group. If a field is unspecified, the current value is retained. </summary>
        /// <param name="parameters"> Parameters supplied to update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<ResourceGroup>> UpdateAsync(ResourceGroupPatchable parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.Update");
            scope.Start();
            try
            {
                var response = await _resourceGroupsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// OperationId: ResourceGroups_Update
        /// <summary> Resource groups can be updated through a simple PATCH operation to a group address. The format of the request is the same as that for creating a resource group. If a field is unspecified, the current value is retained. </summary>
        /// <param name="parameters"> Parameters supplied to update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<ResourceGroup> Update(ResourceGroupPatchable parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.Update");
            scope.Start();
            try
            {
                var response = _resourceGroupsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, parameters, cancellationToken);
                return Response.FromValue(new ResourceGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/exportTemplate
        /// ContextualPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// OperationId: ResourceGroups_ExportTemplate
        /// <summary> Captures the specified resource group as a template. </summary>
        /// <param name="parameters"> Parameters for exporting the template. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ResourceGroupExportTemplateOperation> ExportTemplateAsync(ExportTemplateRequest parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.ExportTemplate");
            scope.Start();
            try
            {
                var response = await _resourceGroupsRestClient.ExportTemplateAsync(Id.SubscriptionId, Id.ResourceGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ResourceGroupExportTemplateOperation(_clientDiagnostics, Pipeline, _resourceGroupsRestClient.CreateExportTemplateRequest(Id.SubscriptionId, Id.ResourceGroupName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/exportTemplate
        /// ContextualPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// OperationId: ResourceGroups_ExportTemplate
        /// <summary> Captures the specified resource group as a template. </summary>
        /// <param name="parameters"> Parameters for exporting the template. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ResourceGroupExportTemplateOperation ExportTemplate(ExportTemplateRequest parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.ExportTemplate");
            scope.Start();
            try
            {
                var response = _resourceGroupsRestClient.ExportTemplate(Id.SubscriptionId, Id.ResourceGroupName, parameters, cancellationToken);
                var operation = new ResourceGroupExportTemplateOperation(_clientDiagnostics, Pipeline, _resourceGroupsRestClient.CreateExportTemplateRequest(Id.SubscriptionId, Id.ResourceGroupName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// OperationId: ResourceGroups_CheckExistence
        /// <summary> Checks whether a resource group exists. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> CheckExistenceAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.CheckExistence");
            scope.Start();
            try
            {
                var response = await _resourceGroupsRestClient.CheckExistenceAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// OperationId: ResourceGroups_CheckExistence
        /// <summary> Checks whether a resource group exists. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckExistence(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroup.CheckExistence");
            scope.Start();
            try
            {
                var response = _resourceGroupsRestClient.CheckExistence(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
