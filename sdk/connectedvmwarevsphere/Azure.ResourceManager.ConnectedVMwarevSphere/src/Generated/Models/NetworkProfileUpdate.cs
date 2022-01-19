// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Defines the update resource properties. </summary>
    public partial class NetworkProfileUpdate
    {
        /// <summary> Initializes a new instance of NetworkProfileUpdate. </summary>
        public NetworkProfileUpdate()
        {
            NetworkInterfaces = new ChangeTrackingList<NetworkInterfaceUpdate>();
        }

        /// <summary> Gets or sets the list of network interfaces associated with the virtual machine. </summary>
        public IList<NetworkInterfaceUpdate> NetworkInterfaces { get; }
    }
}
