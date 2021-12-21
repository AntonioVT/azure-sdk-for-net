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
    /// <summary> Create or update an Azure Cosmos DB MongoDB Collection. </summary>
    public partial class MongoDBResourceCreateUpdateMongoDBCollectionOperation : Operation<MongoDBCollection>, IOperationSource<MongoDBCollection>
    {
        private readonly OperationInternals<MongoDBCollection> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of MongoDBResourceCreateUpdateMongoDBCollectionOperation for mocking. </summary>
        protected MongoDBResourceCreateUpdateMongoDBCollectionOperation()
        {
        }

        internal MongoDBResourceCreateUpdateMongoDBCollectionOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<MongoDBCollection>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "MongoDBResourceCreateUpdateMongoDBCollectionOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override MongoDBCollection Value => _operation.Value;

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
        public override ValueTask<Response<MongoDBCollection>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<MongoDBCollection>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        MongoDBCollection IOperationSource<MongoDBCollection>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new MongoDBCollection(_operationBase, MongoDBCollectionData.DeserializeMongoDBCollectionData(document.RootElement));
        }

        async ValueTask<MongoDBCollection> IOperationSource<MongoDBCollection>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new MongoDBCollection(_operationBase, MongoDBCollectionData.DeserializeMongoDBCollectionData(document.RootElement));
        }
    }
}
