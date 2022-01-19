// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information regarding Subscription Quota Item.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SubscriptionQuotaItem : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionQuotaItem class.
        /// </summary>
        public SubscriptionQuotaItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionQuotaItem class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="current">The current quota value.</param>
        /// <param name="defaultProperty">The default quota value.</param>
        /// <param name="systemData">The system meta data relating to this
        /// resource.</param>
        public SubscriptionQuotaItem(string id = default(string), string name = default(string), string type = default(string), int? current = default(int?), int? defaultProperty = default(int?), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            Current = current;
            DefaultProperty = defaultProperty;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the current quota value.
        /// </summary>
        [JsonProperty(PropertyName = "properties.current")]
        public int? Current { get; private set; }

        /// <summary>
        /// Gets the default quota value.
        /// </summary>
        [JsonProperty(PropertyName = "properties.default")]
        public int? DefaultProperty { get; private set; }

        /// <summary>
        /// Gets the system meta data relating to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
