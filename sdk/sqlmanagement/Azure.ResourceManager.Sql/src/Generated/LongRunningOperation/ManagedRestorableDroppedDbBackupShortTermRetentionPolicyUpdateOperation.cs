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
    /// <summary> Sets a database&apos;s short term retention policy. </summary>
    public partial class ManagedRestorableDroppedDbBackupShortTermRetentionPolicyUpdateOperation : Operation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy>, IOperationSource<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy>
    {
        private readonly OperationInternals<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of ManagedRestorableDroppedDbBackupShortTermRetentionPolicyUpdateOperation for mocking. </summary>
        protected ManagedRestorableDroppedDbBackupShortTermRetentionPolicyUpdateOperation()
        {
        }

        internal ManagedRestorableDroppedDbBackupShortTermRetentionPolicyUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ManagedRestorableDroppedDbBackupShortTermRetentionPolicyUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ManagedRestorableDroppedDbBackupShortTermRetentionPolicy Value => _operation.Value;

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
        public override ValueTask<Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ManagedRestorableDroppedDbBackupShortTermRetentionPolicy IOperationSource<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ManagedBackupShortTermRetentionPolicyData.DeserializeManagedBackupShortTermRetentionPolicyData(document.RootElement);
            return new ManagedRestorableDroppedDbBackupShortTermRetentionPolicy(_operationBase, data);
        }

        async ValueTask<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy> IOperationSource<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ManagedBackupShortTermRetentionPolicyData.DeserializeManagedBackupShortTermRetentionPolicyData(document.RootElement);
            return new ManagedRestorableDroppedDbBackupShortTermRetentionPolicy(_operationBase, data);
        }
    }
}
