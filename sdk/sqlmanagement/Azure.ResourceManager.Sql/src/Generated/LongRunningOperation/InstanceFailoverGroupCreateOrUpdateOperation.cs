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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Creates or updates a failover group. </summary>
    public partial class InstanceFailoverGroupCreateOrUpdateOperation : Operation<InstanceFailoverGroup>, IOperationSource<InstanceFailoverGroup>
    {
        private readonly OperationInternals<InstanceFailoverGroup> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of InstanceFailoverGroupCreateOrUpdateOperation for mocking. </summary>
        protected InstanceFailoverGroupCreateOrUpdateOperation()
        {
        }

        internal InstanceFailoverGroupCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<InstanceFailoverGroup>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "InstanceFailoverGroupCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override InstanceFailoverGroup Value => _operation.Value;

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
        public override ValueTask<Response<InstanceFailoverGroup>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<InstanceFailoverGroup>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        InstanceFailoverGroup IOperationSource<InstanceFailoverGroup>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = InstanceFailoverGroupData.DeserializeInstanceFailoverGroupData(document.RootElement);
            return new InstanceFailoverGroup(_operationBase, data);
        }

        async ValueTask<InstanceFailoverGroup> IOperationSource<InstanceFailoverGroup>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = InstanceFailoverGroupData.DeserializeInstanceFailoverGroupData(document.RootElement);
            return new InstanceFailoverGroup(_operationBase, data);
        }
    }
}
