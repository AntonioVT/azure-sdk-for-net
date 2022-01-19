// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The PrivateStore data structure.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateStore : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateStore class.
        /// </summary>
        public PrivateStore()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateStore class.
        /// </summary>
        /// <param name="id">The resource ID.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource</param>
        /// <param name="availability">Indicates private store availability.
        /// Possible values include: 'enabled', 'disabled'</param>
        /// <param name="privateStoreId">Private Store id</param>
        /// <param name="eTag">Identifier for purposes of race
        /// condition</param>
        /// <param name="privateStoreName">Private Store Name</param>
        /// <param name="tenantId">Tenant id</param>
        /// <param name="isGov">Is government</param>
        /// <param name="collectionIds">Gets list of associated collection
        /// ids</param>
        /// <param name="branding">Gets or sets list of branding
        /// characteristics</param>
        /// <param name="recipients">Gets or sets list of notified recipients
        /// for new requests</param>
        /// <param name="sendToAllMarketplaceAdmins">Gets or sets whether to
        /// send email to all marketplace admins for new requests</param>
        public PrivateStore(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string availability = default(string), string privateStoreId = default(string), string eTag = default(string), string privateStoreName = default(string), string tenantId = default(string), bool? isGov = default(bool?), IList<string> collectionIds = default(IList<string>), IDictionary<string, string> branding = default(IDictionary<string, string>), IList<Recipient> recipients = default(IList<Recipient>), bool? sendToAllMarketplaceAdmins = default(bool?))
            : base(id, name, type, systemData)
        {
            Availability = availability;
            PrivateStoreId = privateStoreId;
            ETag = eTag;
            PrivateStoreName = privateStoreName;
            TenantId = tenantId;
            IsGov = isGov;
            CollectionIds = collectionIds;
            Branding = branding;
            Recipients = recipients;
            SendToAllMarketplaceAdmins = sendToAllMarketplaceAdmins;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates private store availability. Possible values
        /// include: 'enabled', 'disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.availability")]
        public string Availability { get; set; }

        /// <summary>
        /// Gets private Store id
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateStoreId")]
        public string PrivateStoreId { get; private set; }

        /// <summary>
        /// Gets or sets identifier for purposes of race condition
        /// </summary>
        [JsonProperty(PropertyName = "properties.eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets private Store Name
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateStoreName")]
        public string PrivateStoreName { get; set; }

        /// <summary>
        /// Gets or sets tenant id
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets is government
        /// </summary>
        [JsonProperty(PropertyName = "properties.isGov")]
        public bool? IsGov { get; set; }

        /// <summary>
        /// Gets list of associated collection ids
        /// </summary>
        [JsonProperty(PropertyName = "properties.collectionIds")]
        public IList<string> CollectionIds { get; private set; }

        /// <summary>
        /// Gets or sets list of branding characteristics
        /// </summary>
        [JsonProperty(PropertyName = "properties.branding")]
        public IDictionary<string, string> Branding { get; set; }

        /// <summary>
        /// Gets or sets list of notified recipients for new requests
        /// </summary>
        [JsonProperty(PropertyName = "properties.notificationsSettings.recipients")]
        public IList<Recipient> Recipients { get; set; }

        /// <summary>
        /// Gets or sets whether to send email to all marketplace admins for
        /// new requests
        /// </summary>
        [JsonProperty(PropertyName = "properties.notificationsSettings.sendToAllMarketplaceAdmins")]
        public bool? SendToAllMarketplaceAdmins { get; set; }

    }
}
