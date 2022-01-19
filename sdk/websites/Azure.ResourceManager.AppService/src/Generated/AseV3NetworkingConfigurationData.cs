// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the AseV3NetworkingConfiguration data model. </summary>
    public partial class AseV3NetworkingConfigurationData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of AseV3NetworkingConfigurationData. </summary>
        public AseV3NetworkingConfigurationData()
        {
            WindowsOutboundIpAddresses = new ChangeTrackingList<string>();
            LinuxOutboundIpAddresses = new ChangeTrackingList<string>();
            ExternalInboundIpAddresses = new ChangeTrackingList<string>();
            InternalInboundIpAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AseV3NetworkingConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="windowsOutboundIpAddresses"></param>
        /// <param name="linuxOutboundIpAddresses"></param>
        /// <param name="externalInboundIpAddresses"></param>
        /// <param name="internalInboundIpAddresses"></param>
        /// <param name="allowNewPrivateEndpointConnections"> Property to enable and disable new private endpoint connection creation on ASE. </param>
        internal AseV3NetworkingConfigurationData(ResourceIdentifier id, string name, ResourceType type, string kind, IReadOnlyList<string> windowsOutboundIpAddresses, IReadOnlyList<string> linuxOutboundIpAddresses, IReadOnlyList<string> externalInboundIpAddresses, IReadOnlyList<string> internalInboundIpAddresses, bool? allowNewPrivateEndpointConnections) : base(id, name, type, kind)
        {
            WindowsOutboundIpAddresses = windowsOutboundIpAddresses;
            LinuxOutboundIpAddresses = linuxOutboundIpAddresses;
            ExternalInboundIpAddresses = externalInboundIpAddresses;
            InternalInboundIpAddresses = internalInboundIpAddresses;
            AllowNewPrivateEndpointConnections = allowNewPrivateEndpointConnections;
        }

        /// <summary> Gets the windows outbound ip addresses. </summary>
        public IReadOnlyList<string> WindowsOutboundIpAddresses { get; }
        /// <summary> Gets the linux outbound ip addresses. </summary>
        public IReadOnlyList<string> LinuxOutboundIpAddresses { get; }
        /// <summary> Gets the external inbound ip addresses. </summary>
        public IReadOnlyList<string> ExternalInboundIpAddresses { get; }
        /// <summary> Gets the internal inbound ip addresses. </summary>
        public IReadOnlyList<string> InternalInboundIpAddresses { get; }
        /// <summary> Property to enable and disable new private endpoint connection creation on ASE. </summary>
        public bool? AllowNewPrivateEndpointConnections { get; set; }
    }
}
