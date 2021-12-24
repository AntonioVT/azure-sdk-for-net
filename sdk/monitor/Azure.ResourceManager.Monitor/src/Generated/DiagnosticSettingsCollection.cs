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
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing collection of DiagnosticSettings and their operations over its parent. </summary>
    public partial class DiagnosticSettingsCollection : ArmCollection, IEnumerable<DiagnosticSettings>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DiagnosticSettingsRestOperations _diagnosticSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingsCollection"/> class for mocking. </summary>
        protected DiagnosticSettingsCollection()
        {
        }

        /// <summary> Initializes a new instance of DiagnosticSettingsCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DiagnosticSettingsCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _diagnosticSettingsRestClient = new DiagnosticSettingsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.Root.ResourceType;

        /// <summary> Verify that the input resource Id is a valid collection for this type. </summary>
        /// <param name="identifier"> The input resource Id to check. </param>
        protected override void ValidateResourceType(ResourceIdentifier identifier)
        {
        }

        // Collection level operations.

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// ContextualPath: /{resourceUri}
        /// OperationId: DiagnosticSettings_CreateOrUpdate
        /// <summary> Creates or updates diagnostic settings for the specified resource. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DiagnosticSettingCreateOrUpdateOperation CreateOrUpdate(string name, DiagnosticSettingsData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsRestClient.CreateOrUpdate(Id, name, parameters, cancellationToken);
                var operation = new DiagnosticSettingCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// ContextualPath: /{resourceUri}
        /// OperationId: DiagnosticSettings_CreateOrUpdate
        /// <summary> Creates or updates diagnostic settings for the specified resource. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DiagnosticSettingCreateOrUpdateOperation> CreateOrUpdateAsync(string name, DiagnosticSettingsData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsRestClient.CreateOrUpdateAsync(Id, name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new DiagnosticSettingCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// ContextualPath: /{resourceUri}
        /// OperationId: DiagnosticSettings_Get
        /// <summary> Gets the active diagnostic settings for the specified resource. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DiagnosticSettings> Get(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsRestClient.Get(Id, name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettings(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// ContextualPath: /{resourceUri}
        /// OperationId: DiagnosticSettings_Get
        /// <summary> Gets the active diagnostic settings for the specified resource. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<DiagnosticSettings>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsRestClient.GetAsync(Id, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DiagnosticSettings(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DiagnosticSettings> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsRestClient.Get(Id, name, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DiagnosticSettings>(null, response.GetRawResponse())
                    : Response.FromValue(new DiagnosticSettings(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<DiagnosticSettings>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsRestClient.GetAsync(Id, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DiagnosticSettings>(null, response.GetRawResponse())
                    : Response.FromValue(new DiagnosticSettings(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings
        /// ContextualPath: /{resourceUri}
        /// OperationId: DiagnosticSettings_List
        /// <summary> Gets the active diagnostic settings list for the specified resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<DiagnosticSettings>> GetAll(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCollection.GetAll");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsRestClient.List(Id, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(value => new DiagnosticSettings(Parent, value)).ToArray() as IReadOnlyList<DiagnosticSettings>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings
        /// ContextualPath: /{resourceUri}
        /// OperationId: DiagnosticSettings_List
        /// <summary> Gets the active diagnostic settings list for the specified resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<IReadOnlyList<DiagnosticSettings>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCollection.GetAll");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsRestClient.ListAsync(Id, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(value => new DiagnosticSettings(Parent, value)).ToArray() as IReadOnlyList<DiagnosticSettings>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiagnosticSettings> IEnumerable<DiagnosticSettings>.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, DiagnosticSettings, DiagnosticSettingsData> Construct() { }
    }
}
