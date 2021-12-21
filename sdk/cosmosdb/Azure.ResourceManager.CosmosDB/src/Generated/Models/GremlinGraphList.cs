// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the graphs and their properties. </summary>
    internal partial class GremlinGraphList
    {
        /// <summary> Initializes a new instance of GremlinGraphList. </summary>
        internal GremlinGraphList()
        {
            Value = new ChangeTrackingList<GremlinGraphData>();
        }

        /// <summary> Initializes a new instance of GremlinGraphList. </summary>
        /// <param name="value"> List of graphs and their properties. </param>
        internal GremlinGraphList(IReadOnlyList<GremlinGraphData> value)
        {
            Value = value;
        }

        /// <summary> List of graphs and their properties. </summary>
        public IReadOnlyList<GremlinGraphData> Value { get; }
    }
}
