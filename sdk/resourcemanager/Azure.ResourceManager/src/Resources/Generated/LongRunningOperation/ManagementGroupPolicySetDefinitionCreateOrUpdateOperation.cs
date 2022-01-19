// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> This operation creates or updates a policy set definition in the given management group with the given name. </summary>
    public partial class ManagementGroupPolicySetDefinitionCreateOrUpdateOperation : Operation<ManagementGroupPolicySetDefinition>
    {
        private readonly OperationOrResponseInternals<ManagementGroupPolicySetDefinition> _operation;

        /// <summary> Initializes a new instance of ManagementGroupPolicySetDefinitionCreateOrUpdateOperation for mocking. </summary>
        protected ManagementGroupPolicySetDefinitionCreateOrUpdateOperation()
        {
        }

        internal ManagementGroupPolicySetDefinitionCreateOrUpdateOperation(ArmResource operationsBase, Response<PolicySetDefinitionData> response)
        {
            _operation = new OperationOrResponseInternals<ManagementGroupPolicySetDefinition>(Response.FromValue(new ManagementGroupPolicySetDefinition(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ManagementGroupPolicySetDefinition Value => _operation.Value;

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
        public override ValueTask<Response<ManagementGroupPolicySetDefinition>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ManagementGroupPolicySetDefinition>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
