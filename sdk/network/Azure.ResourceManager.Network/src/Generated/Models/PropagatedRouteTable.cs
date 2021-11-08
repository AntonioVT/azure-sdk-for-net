// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The list of RouteTables to advertise the routes to. </summary>
    public partial class PropagatedRouteTable
    {
        /// <summary> Initializes a new instance of PropagatedRouteTable. </summary>
        public PropagatedRouteTable()
        {
            Labels = new ChangeTrackingList<string>();
            Ids = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of PropagatedRouteTable. </summary>
        /// <param name="labels"> The list of labels. </param>
        /// <param name="ids"> The list of resource ids of all the RouteTables. </param>
        internal PropagatedRouteTable(IList<string> labels, IList<WritableSubResource> ids)
        {
            Labels = labels;
            Ids = ids;
        }

        /// <summary> The list of labels. </summary>
        public IList<string> Labels { get; }
        /// <summary> The list of resource ids of all the RouteTables. </summary>
        public IList<WritableSubResource> Ids { get; }
    }
}
