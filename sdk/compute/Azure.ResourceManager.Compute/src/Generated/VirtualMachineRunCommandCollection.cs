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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of VirtualMachineRunCommand and their operations over its parent. </summary>
    public partial class VirtualMachineRunCommandCollection : ArmCollection, IEnumerable<VirtualMachineRunCommand>, IAsyncEnumerable<VirtualMachineRunCommand>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualMachineRunCommandsRestOperations _virtualMachineRunCommandsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineRunCommandCollection"/> class for mocking. </summary>
        protected VirtualMachineRunCommandCollection()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineRunCommandCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualMachineRunCommandCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _virtualMachineRunCommandsRestClient = new VirtualMachineRunCommandsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachine.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachine.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> The operation to create or update the run command. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="runCommand"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="runCommand"/> is null. </exception>
        public virtual VirtualMachineRunCommandCreateOrUpdateOperation CreateOrUpdate(string runCommandName, VirtualMachineRunCommandData runCommand, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (runCommandName == null)
            {
                throw new ArgumentNullException(nameof(runCommandName));
            }
            if (runCommand == null)
            {
                throw new ArgumentNullException(nameof(runCommand));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineRunCommandsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, runCommand, cancellationToken);
                var operation = new VirtualMachineRunCommandCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualMachineRunCommandsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, runCommand).Request, response);
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

        /// <summary> The operation to create or update the run command. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="runCommand"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="runCommand"/> is null. </exception>
        public async virtual Task<VirtualMachineRunCommandCreateOrUpdateOperation> CreateOrUpdateAsync(string runCommandName, VirtualMachineRunCommandData runCommand, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (runCommandName == null)
            {
                throw new ArgumentNullException(nameof(runCommandName));
            }
            if (runCommand == null)
            {
                throw new ArgumentNullException(nameof(runCommand));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineRunCommandsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, runCommand, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualMachineRunCommandCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualMachineRunCommandsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, runCommand).Request, response);
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

        /// <summary> The operation to get the run command. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<VirtualMachineRunCommand> Get(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (runCommandName == null)
            {
                throw new ArgumentNullException(nameof(runCommandName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineRunCommandsRestClient.GetByVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineRunCommand(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get the run command. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineRunCommand>> GetAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (runCommandName == null)
            {
                throw new ArgumentNullException(nameof(runCommandName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineRunCommandsRestClient.GetByVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineRunCommand(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<VirtualMachineRunCommand> GetIfExists(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (runCommandName == null)
            {
                throw new ArgumentNullException(nameof(runCommandName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineRunCommandsRestClient.GetByVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualMachineRunCommand>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualMachineRunCommand(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineRunCommand>> GetIfExistsAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (runCommandName == null)
            {
                throw new ArgumentNullException(nameof(runCommandName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _virtualMachineRunCommandsRestClient.GetByVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualMachineRunCommand>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualMachineRunCommand(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<bool> Exists(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (runCommandName == null)
            {
                throw new ArgumentNullException(nameof(runCommandName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(runCommandName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (runCommandName == null)
            {
                throw new ArgumentNullException(nameof(runCommandName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(runCommandName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineRunCommand" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineRunCommand> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineRunCommand> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineRunCommandsRestClient.ListByVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineRunCommand(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineRunCommand> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineRunCommandsRestClient.ListByVirtualMachineNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineRunCommand(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineRunCommand" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineRunCommand> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineRunCommand>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineRunCommandsRestClient.ListByVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineRunCommand(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineRunCommand>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineRunCommandsRestClient.ListByVirtualMachineNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineRunCommand(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<VirtualMachineRunCommand> IEnumerable<VirtualMachineRunCommand>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineRunCommand> IAsyncEnumerable<VirtualMachineRunCommand>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VirtualMachineRunCommand, VirtualMachineRunCommandData> Construct() { }
    }
}
