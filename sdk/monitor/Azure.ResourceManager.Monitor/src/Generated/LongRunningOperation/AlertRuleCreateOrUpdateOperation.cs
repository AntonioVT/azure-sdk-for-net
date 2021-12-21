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
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Creates or updates a classic metric alert rule. </summary>
    public partial class AlertRuleCreateOrUpdateOperation : Operation<AlertRule>
    {
        private readonly OperationOrResponseInternals<AlertRule> _operation;

        /// <summary> Initializes a new instance of AlertRuleCreateOrUpdateOperation for mocking. </summary>
        protected AlertRuleCreateOrUpdateOperation()
        {
        }

        internal AlertRuleCreateOrUpdateOperation(ArmResource operationsBase, Response<AlertRuleData> response)
        {
            _operation = new OperationOrResponseInternals<AlertRule>(Azure.Response.FromValue(new AlertRule(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AlertRule Value => _operation.Value;

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
        public override ValueTask<Response<AlertRule>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AlertRule>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
