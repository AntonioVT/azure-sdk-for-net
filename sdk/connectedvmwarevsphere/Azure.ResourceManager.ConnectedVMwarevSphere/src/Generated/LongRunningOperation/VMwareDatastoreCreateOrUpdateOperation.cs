// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ConnectedVMwarevSphere;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Create Or Update datastore. </summary>
    public partial class VMwareDatastoreCreateOrUpdateOperation : Operation<VMwareDatastore>, IOperationSource<VMwareDatastore>
    {
        private readonly OperationInternals<VMwareDatastore> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of VMwareDatastoreCreateOrUpdateOperation for mocking. </summary>
        protected VMwareDatastoreCreateOrUpdateOperation()
        {
        }

        internal VMwareDatastoreCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VMwareDatastore>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "VMwareDatastoreCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VMwareDatastore Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VMwareDatastore>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VMwareDatastore>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VMwareDatastore IOperationSource<VMwareDatastore>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VMwareDatastoreData.DeserializeVMwareDatastoreData(document.RootElement);
            return new VMwareDatastore(_operationBase, data);
        }

        async ValueTask<VMwareDatastore> IOperationSource<VMwareDatastore>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VMwareDatastoreData.DeserializeVMwareDatastoreData(document.RootElement);
            return new VMwareDatastore(_operationBase, data);
        }
    }
}
