// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SKU parameters supplied to the create namespace operation
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">Name of this SKU. Possible values include:
        /// 'Basic', 'Standard', 'Premium'</param>
        /// <param name="tier">The billing tier of this particular SKU.
        /// Possible values include: 'Basic', 'Standard', 'Premium'</param>
        /// <param name="capacity">The Event Hubs throughput units for Basic or
        /// Standard tiers, where value should be 0 to 20 throughput units. The
        /// Event Hubs premium units for Premium tier, where value should be 0
        /// to 10 premium units.</param>
        public Sku(string name, string tier = default(string), int? capacity = default(int?))
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of this SKU. Possible values include: 'Basic',
        /// 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the billing tier of this particular SKU. Possible
        /// values include: 'Basic', 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets the Event Hubs throughput units for Basic or Standard
        /// tiers, where value should be 0 to 20 throughput units. The Event
        /// Hubs premium units for Premium tier, where value should be 0 to 10
        /// premium units.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Capacity < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Capacity", 0);
            }
        }
    }
}
