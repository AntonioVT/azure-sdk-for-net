// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Creates a new Hybrid Connection using a Service Bus relay. </summary>
    public partial class SiteSlotHybridConnectionNamespaceRelayCreateOrUpdateOperation : Operation<SiteSlotHybridConnectionNamespaceRelay>
    {
        private readonly OperationOrResponseInternals<SiteSlotHybridConnectionNamespaceRelay> _operation;

        /// <summary> Initializes a new instance of SiteSlotHybridConnectionNamespaceRelayCreateOrUpdateOperation for mocking. </summary>
        protected SiteSlotHybridConnectionNamespaceRelayCreateOrUpdateOperation()
        {
        }

        internal SiteSlotHybridConnectionNamespaceRelayCreateOrUpdateOperation(ArmResource operationsBase, Response<HybridConnectionData> response)
        {
            _operation = new OperationOrResponseInternals<SiteSlotHybridConnectionNamespaceRelay>(Response.FromValue(new SiteSlotHybridConnectionNamespaceRelay(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteSlotHybridConnectionNamespaceRelay Value => _operation.Value;

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
        public override ValueTask<Response<SiteSlotHybridConnectionNamespaceRelay>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSlotHybridConnectionNamespaceRelay>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
