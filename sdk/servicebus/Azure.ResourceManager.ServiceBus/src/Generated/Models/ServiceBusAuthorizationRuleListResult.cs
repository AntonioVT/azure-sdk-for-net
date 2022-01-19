// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> The response to the List Namespace operation. </summary>
    internal partial class ServiceBusAuthorizationRuleListResult
    {
        /// <summary> Initializes a new instance of ServiceBusAuthorizationRuleListResult. </summary>
        internal ServiceBusAuthorizationRuleListResult()
        {
            Value = new ChangeTrackingList<ServiceBusAuthorizationRuleData>();
        }

        /// <summary> Initializes a new instance of ServiceBusAuthorizationRuleListResult. </summary>
        /// <param name="value"> Result of the List Authorization Rules operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of Authorization Rules. </param>
        internal ServiceBusAuthorizationRuleListResult(IReadOnlyList<ServiceBusAuthorizationRuleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Result of the List Authorization Rules operation. </summary>
        public IReadOnlyList<ServiceBusAuthorizationRuleData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of Authorization Rules. </summary>
        public string NextLink { get; }
    }
}
