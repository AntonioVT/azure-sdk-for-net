// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Represents a collection of alert rule resources. </summary>
    public partial class DiagnosticSettingsResourceCollection
    {
        /// <summary> Initializes a new instance of DiagnosticSettingsResourceCollection. </summary>
        internal DiagnosticSettingsResourceCollection()
        {
            Value = new ChangeTrackingList<DiagnosticSettingsData>();
        }

        /// <summary> Initializes a new instance of DiagnosticSettingsResourceCollection. </summary>
        /// <param name="value"> The collection of diagnostic settings resources;. </param>
        internal DiagnosticSettingsResourceCollection(IReadOnlyList<DiagnosticSettingsData> value)
        {
            Value = value;
        }

        /// <summary> The collection of diagnostic settings resources;. </summary>
        public IReadOnlyList<DiagnosticSettingsData> Value { get; }
    }
}
