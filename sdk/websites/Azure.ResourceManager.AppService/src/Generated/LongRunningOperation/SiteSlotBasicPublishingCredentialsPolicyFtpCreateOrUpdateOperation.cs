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
    /// <summary> Description for Updates whether FTP is allowed on the site or not. </summary>
    public partial class SiteSlotBasicPublishingCredentialsPolicyFtpCreateOrUpdateOperation : Operation<SiteSlotBasicPublishingCredentialsPolicyFtp>
    {
        private readonly OperationOrResponseInternals<SiteSlotBasicPublishingCredentialsPolicyFtp> _operation;

        /// <summary> Initializes a new instance of SiteSlotBasicPublishingCredentialsPolicyFtpCreateOrUpdateOperation for mocking. </summary>
        protected SiteSlotBasicPublishingCredentialsPolicyFtpCreateOrUpdateOperation()
        {
        }

        internal SiteSlotBasicPublishingCredentialsPolicyFtpCreateOrUpdateOperation(ArmResource operationsBase, Response<CsmPublishingCredentialsPoliciesEntityData> response)
        {
            _operation = new OperationOrResponseInternals<SiteSlotBasicPublishingCredentialsPolicyFtp>(Response.FromValue(new SiteSlotBasicPublishingCredentialsPolicyFtp(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteSlotBasicPublishingCredentialsPolicyFtp Value => _operation.Value;

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
        public override ValueTask<Response<SiteSlotBasicPublishingCredentialsPolicyFtp>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSlotBasicPublishingCredentialsPolicyFtp>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
