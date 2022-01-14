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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of TemplateSpecVersion and their operations over its parent. </summary>
    public partial class TemplateSpecVersionCollection : ArmCollection, IEnumerable<TemplateSpecVersion>, IAsyncEnumerable<TemplateSpecVersion>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly TemplateSpecVersionsRestOperations _templateSpecVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="TemplateSpecVersionCollection"/> class for mocking. </summary>
        protected TemplateSpecVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of TemplateSpecVersionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal TemplateSpecVersionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _templateSpecVersionsRestClient = new TemplateSpecVersionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TemplateSpec.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TemplateSpec.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates a Template Spec version. </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="templateSpecVersionModel"> Template Spec Version supplied to the operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> or <paramref name="templateSpecVersionModel"/> is null. </exception>
        public virtual TemplateSpecVersionCreateOrUpdateOperation CreateOrUpdate(string templateSpecVersion, TemplateSpecVersionData templateSpecVersionModel, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }
            if (templateSpecVersionModel == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersionModel));
            }

            using var scope = _clientDiagnostics.CreateScope("TemplateSpecVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _templateSpecVersionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, templateSpecVersionModel, cancellationToken);
                var operation = new TemplateSpecVersionCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Creates or updates a Template Spec version. </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="templateSpecVersionModel"> Template Spec Version supplied to the operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> or <paramref name="templateSpecVersionModel"/> is null. </exception>
        public async virtual Task<TemplateSpecVersionCreateOrUpdateOperation> CreateOrUpdateAsync(string templateSpecVersion, TemplateSpecVersionData templateSpecVersionModel, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }
            if (templateSpecVersionModel == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersionModel));
            }

            using var scope = _clientDiagnostics.CreateScope("TemplateSpecVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _templateSpecVersionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, templateSpecVersionModel, cancellationToken).ConfigureAwait(false);
                var operation = new TemplateSpecVersionCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Gets a Template Spec version from a specific Template Spec. </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> is null. </exception>
        public virtual Response<TemplateSpecVersion> Get(string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("TemplateSpecVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _templateSpecVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TemplateSpecVersion(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a Template Spec version from a specific Template Spec. </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> is null. </exception>
        public async virtual Task<Response<TemplateSpecVersion>> GetAsync(string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("TemplateSpecVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _templateSpecVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new TemplateSpecVersion(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> is null. </exception>
        public virtual Response<TemplateSpecVersion> GetIfExists(string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("TemplateSpecVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _templateSpecVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<TemplateSpecVersion>(null, response.GetRawResponse())
                    : Response.FromValue(new TemplateSpecVersion(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> is null. </exception>
        public async virtual Task<Response<TemplateSpecVersion>> GetIfExistsAsync(string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("TemplateSpecVersionCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _templateSpecVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<TemplateSpecVersion>(null, response.GetRawResponse())
                    : Response.FromValue(new TemplateSpecVersion(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> is null. </exception>
        public virtual Response<bool> Exists(string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("TemplateSpecVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(templateSpecVersion, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("TemplateSpecVersionCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(templateSpecVersion, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the Template Spec versions in the specified Template Spec. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TemplateSpecVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TemplateSpecVersion> GetAll(CancellationToken cancellationToken = default)
        {
            Page<TemplateSpecVersion> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TemplateSpecVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _templateSpecVersionsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TemplateSpecVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TemplateSpecVersion> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TemplateSpecVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _templateSpecVersionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TemplateSpecVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the Template Spec versions in the specified Template Spec. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TemplateSpecVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TemplateSpecVersion> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<TemplateSpecVersion>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TemplateSpecVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _templateSpecVersionsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TemplateSpecVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TemplateSpecVersion>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TemplateSpecVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _templateSpecVersionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TemplateSpecVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<TemplateSpecVersion> IEnumerable<TemplateSpecVersion>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TemplateSpecVersion> IAsyncEnumerable<TemplateSpecVersion>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, TemplateSpecVersion, TemplateSpecVersionData> Construct() { }
    }
}
