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
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Create or update an Azure Cosmos DB SQL trigger. </summary>
    public partial class SqlTriggerCreateOrUpdateOperation : Operation<SqlTrigger>, IOperationSource<SqlTrigger>
    {
        private readonly OperationInternals<SqlTrigger> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of SqlTriggerCreateOrUpdateOperation for mocking. </summary>
        protected SqlTriggerCreateOrUpdateOperation()
        {
        }

        internal SqlTriggerCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<SqlTrigger>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SqlTriggerCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SqlTrigger Value => _operation.Value;

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
        public override ValueTask<Response<SqlTrigger>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SqlTrigger>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SqlTrigger IOperationSource<SqlTrigger>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlTriggerData.DeserializeSqlTriggerData(document.RootElement);
            return new SqlTrigger(_operationBase, data);
        }

        async ValueTask<SqlTrigger> IOperationSource<SqlTrigger>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlTriggerData.DeserializeSqlTriggerData(document.RootElement);
            return new SqlTrigger(_operationBase, data);
        }
    }
}
