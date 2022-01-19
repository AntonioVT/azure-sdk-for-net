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
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Register a user provided function app with a static site build. </summary>
    public partial class StaticSiteBuildUserProvidedFunctionAppCreateOrUpdateOperation : Operation<StaticSiteBuildUserProvidedFunctionApp>, IOperationSource<StaticSiteBuildUserProvidedFunctionApp>
    {
        private readonly OperationInternals<StaticSiteBuildUserProvidedFunctionApp> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of StaticSiteBuildUserProvidedFunctionAppCreateOrUpdateOperation for mocking. </summary>
        protected StaticSiteBuildUserProvidedFunctionAppCreateOrUpdateOperation()
        {
        }

        internal StaticSiteBuildUserProvidedFunctionAppCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<StaticSiteBuildUserProvidedFunctionApp>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "StaticSiteBuildUserProvidedFunctionAppCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override StaticSiteBuildUserProvidedFunctionApp Value => _operation.Value;

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
        public override ValueTask<Response<StaticSiteBuildUserProvidedFunctionApp>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<StaticSiteBuildUserProvidedFunctionApp>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        StaticSiteBuildUserProvidedFunctionApp IOperationSource<StaticSiteBuildUserProvidedFunctionApp>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StaticSiteUserProvidedFunctionAppARMResourceData.DeserializeStaticSiteUserProvidedFunctionAppARMResourceData(document.RootElement);
            return new StaticSiteBuildUserProvidedFunctionApp(_operationBase, data);
        }

        async ValueTask<StaticSiteBuildUserProvidedFunctionApp> IOperationSource<StaticSiteBuildUserProvidedFunctionApp>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StaticSiteUserProvidedFunctionAppARMResourceData.DeserializeStaticSiteUserProvidedFunctionAppARMResourceData(document.RootElement);
            return new StaticSiteBuildUserProvidedFunctionApp(_operationBase, data);
        }
    }
}
