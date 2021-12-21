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
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Approve or reject a private endpoint connection with a given name. </summary>
    public partial class PrivateLinkScopedResourceCreateOrUpdateOperation : Operation<ScopedPrivateLink>, IOperationSource<ScopedPrivateLink>
    {
        private readonly OperationInternals<ScopedPrivateLink> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of PrivateLinkScopedResourceCreateOrUpdateOperation for mocking. </summary>
        protected PrivateLinkScopedResourceCreateOrUpdateOperation()
        {
        }

        internal PrivateLinkScopedResourceCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Azure.Response response)
        {
            _operation = new OperationInternals<ScopedPrivateLink>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "PrivateLinkScopedResourceCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ScopedPrivateLink Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Azure.Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Azure.Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Azure.Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ScopedPrivateLink>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ScopedPrivateLink>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ScopedPrivateLink IOperationSource<ScopedPrivateLink>.CreateResult(Azure.Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new ScopedPrivateLink(_operationBase, ScopedPrivateLinkData.DeserializeScopedPrivateLinkData(document.RootElement));
        }

        async ValueTask<ScopedPrivateLink> IOperationSource<ScopedPrivateLink>.CreateResultAsync(Azure.Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new ScopedPrivateLink(_operationBase, ScopedPrivateLinkData.DeserializeScopedPrivateLinkData(document.RootElement));
        }
    }
}
