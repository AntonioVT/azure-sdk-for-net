// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Create Or Update HybridIdentityMetadata. </summary>
    public partial class HybridIdentityMetadataCreateOrUpdateOperation : Operation<HybridIdentityMetadata>
    {
        private readonly OperationOrResponseInternals<HybridIdentityMetadata> _operation;

        /// <summary> Initializes a new instance of HybridIdentityMetadataCreateOrUpdateOperation for mocking. </summary>
        protected HybridIdentityMetadataCreateOrUpdateOperation()
        {
        }

        internal HybridIdentityMetadataCreateOrUpdateOperation(ArmResource operationsBase, Response<HybridIdentityMetadataData> response)
        {
            _operation = new OperationOrResponseInternals<HybridIdentityMetadata>(Response.FromValue(new HybridIdentityMetadata(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override HybridIdentityMetadata Value => _operation.Value;

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
        public override ValueTask<Response<HybridIdentityMetadata>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<HybridIdentityMetadata>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
