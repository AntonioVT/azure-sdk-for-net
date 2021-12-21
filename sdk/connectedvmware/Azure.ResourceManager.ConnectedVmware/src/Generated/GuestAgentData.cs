// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ConnectedVmware.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ConnectedVmware
{
    /// <summary> A class representing the GuestAgent data model. </summary>
    public partial class GuestAgentData : Resource
    {
        /// <summary> Initializes a new instance of GuestAgentData. </summary>
        public GuestAgentData()
        {
            Statuses = new ChangeTrackingList<ResourceStatus>();
        }

        /// <summary> Initializes a new instance of GuestAgentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The system data. </param>
        /// <param name="uuid"> Gets or sets a unique identifier for this resource. </param>
        /// <param name="credentials"> Username / Password Credentials to provision guest agent. </param>
        /// <param name="httpProxyConfig"> HTTP Proxy configuration for the VM. </param>
        /// <param name="provisioningAction"> Gets or sets the guest agent provisioning action. </param>
        /// <param name="status"> Gets or sets the guest agent status. </param>
        /// <param name="customResourceName"> Gets the name of the corresponding resource in Kubernetes. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        internal GuestAgentData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string uuid, GuestCredential credentials, HttpProxyConfiguration httpProxyConfig, ProvisioningAction? provisioningAction, string status, string customResourceName, IReadOnlyList<ResourceStatus> statuses, string provisioningState) : base(id, name, type)
        {
            SystemData = systemData;
            Uuid = uuid;
            Credentials = credentials;
            HttpProxyConfig = httpProxyConfig;
            ProvisioningAction = provisioningAction;
            Status = status;
            CustomResourceName = customResourceName;
            Statuses = statuses;
            ProvisioningState = provisioningState;
        }

        /// <summary> The system data. </summary>
        public SystemData SystemData { get; }
        /// <summary> Gets or sets a unique identifier for this resource. </summary>
        public string Uuid { get; }
        /// <summary> Username / Password Credentials to provision guest agent. </summary>
        public GuestCredential Credentials { get; set; }
        /// <summary> HTTP Proxy configuration for the VM. </summary>
        public HttpProxyConfiguration HttpProxyConfig { get; set; }
        /// <summary> Gets or sets the guest agent provisioning action. </summary>
        public ProvisioningAction? ProvisioningAction { get; set; }
        /// <summary> Gets or sets the guest agent status. </summary>
        public string Status { get; }
        /// <summary> Gets the name of the corresponding resource in Kubernetes. </summary>
        public string CustomResourceName { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<ResourceStatus> Statuses { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
