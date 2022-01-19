// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Properties of a private link resource. </summary>
    public partial class PrivateLinkResourceProperties
    {
        /// <summary> Initializes a new instance of PrivateLinkResourceProperties. </summary>
        internal PrivateLinkResourceProperties()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PrivateLinkResourceProperties. </summary>
        /// <param name="groupId"> GroupId of a private link resource. </param>
        /// <param name="requiredMembers"> RequiredMembers of a private link resource. </param>
        /// <param name="requiredZoneNames"> RequiredZoneNames of a private link resource. </param>
        internal PrivateLinkResourceProperties(string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> GroupId of a private link resource. </summary>
        public string GroupId { get; }
        /// <summary> RequiredMembers of a private link resource. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> RequiredZoneNames of a private link resource. </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
    }
}
