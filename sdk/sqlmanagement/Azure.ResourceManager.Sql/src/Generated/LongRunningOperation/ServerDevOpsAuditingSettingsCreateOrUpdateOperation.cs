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
    /// <summary> Creates or updates a server&apos;s DevOps audit settings. </summary>
    public partial class ServerDevOpsAuditingSettingsCreateOrUpdateOperation : Operation<ServerDevOpsAuditingSettings>, IOperationSource<ServerDevOpsAuditingSettings>
    {
        private readonly OperationInternals<ServerDevOpsAuditingSettings> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of ServerDevOpsAuditingSettingsCreateOrUpdateOperation for mocking. </summary>
        protected ServerDevOpsAuditingSettingsCreateOrUpdateOperation()
        {
        }

        internal ServerDevOpsAuditingSettingsCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ServerDevOpsAuditingSettings>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "ServerDevOpsAuditingSettingsCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ServerDevOpsAuditingSettings Value => _operation.Value;

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
        public override ValueTask<Response<ServerDevOpsAuditingSettings>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServerDevOpsAuditingSettings>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ServerDevOpsAuditingSettings IOperationSource<ServerDevOpsAuditingSettings>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServerDevOpsAuditingSettingsData.DeserializeServerDevOpsAuditingSettingsData(document.RootElement);
            return new ServerDevOpsAuditingSettings(_operationBase, data);
        }

        async ValueTask<ServerDevOpsAuditingSettings> IOperationSource<ServerDevOpsAuditingSettings>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServerDevOpsAuditingSettingsData.DeserializeServerDevOpsAuditingSettingsData(document.RootElement);
            return new ServerDevOpsAuditingSettings(_operationBase, data);
        }
    }
}
