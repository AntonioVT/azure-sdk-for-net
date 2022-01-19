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
    /// <summary> Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier. </summary>
    public partial class SiteSlotDomainOwnershipIdentifierCreateOrUpdateOperation : Operation<SiteSlotDomainOwnershipIdentifier>
    {
        private readonly OperationOrResponseInternals<SiteSlotDomainOwnershipIdentifier> _operation;

        /// <summary> Initializes a new instance of SiteSlotDomainOwnershipIdentifierCreateOrUpdateOperation for mocking. </summary>
        protected SiteSlotDomainOwnershipIdentifierCreateOrUpdateOperation()
        {
        }

        internal SiteSlotDomainOwnershipIdentifierCreateOrUpdateOperation(ArmResource operationsBase, Response<IdentifierData> response)
        {
            _operation = new OperationOrResponseInternals<SiteSlotDomainOwnershipIdentifier>(Response.FromValue(new SiteSlotDomainOwnershipIdentifier(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteSlotDomainOwnershipIdentifier Value => _operation.Value;

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
        public override ValueTask<Response<SiteSlotDomainOwnershipIdentifier>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSlotDomainOwnershipIdentifier>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
