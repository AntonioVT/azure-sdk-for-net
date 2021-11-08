// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Definition of the NetworkVirtualApplianceSkus resource. </summary>
    public partial class NetworkVirtualApplianceSku : Resource
    {
        /// <summary> Initializes a new instance of NetworkVirtualApplianceSku. </summary>
        public NetworkVirtualApplianceSku()
        {
            AvailableVersions = new ChangeTrackingList<string>();
            AvailableScaleUnits = new ChangeTrackingList<NetworkVirtualApplianceSkuInstances>();
        }

        /// <summary> Initializes a new instance of NetworkVirtualApplianceSku. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="vendor"> Network Virtual Appliance Sku vendor. </param>
        /// <param name="availableVersions"> Available Network Virtual Appliance versions. </param>
        /// <param name="availableScaleUnits"> The list of scale units available. </param>
        internal NetworkVirtualApplianceSku(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, string vendor, IReadOnlyList<string> availableVersions, IList<NetworkVirtualApplianceSkuInstances> availableScaleUnits) : base(id, name, type, location, tags)
        {
            Etag = etag;
            Vendor = vendor;
            AvailableVersions = availableVersions;
            AvailableScaleUnits = availableScaleUnits;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Network Virtual Appliance Sku vendor. </summary>
        public string Vendor { get; }
        /// <summary> Available Network Virtual Appliance versions. </summary>
        public IReadOnlyList<string> AvailableVersions { get; }
        /// <summary> The list of scale units available. </summary>
        public IList<NetworkVirtualApplianceSkuInstances> AvailableScaleUnits { get; }
    }
}
