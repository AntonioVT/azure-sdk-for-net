// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the data to be used for importing data to azure.
    /// </summary>
    public partial class DataImportDetails
    {
        /// <summary>
        /// Initializes a new instance of the DataImportDetails class.
        /// </summary>
        public DataImportDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataImportDetails class.
        /// </summary>
        /// <param name="accountDetails">Account details of the data to be
        /// transferred</param>
        /// <param name="logCollectionLevel">Level of the logs to be collected.
        /// Possible values include: 'Error', 'Verbose'</param>
        public DataImportDetails(DataAccountDetails accountDetails, LogCollectionLevel? logCollectionLevel = default(LogCollectionLevel?))
        {
            AccountDetails = accountDetails;
            LogCollectionLevel = logCollectionLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets account details of the data to be transferred
        /// </summary>
        [JsonProperty(PropertyName = "accountDetails")]
        public DataAccountDetails AccountDetails { get; set; }

        /// <summary>
        /// Gets or sets level of the logs to be collected. Possible values
        /// include: 'Error', 'Verbose'
        /// </summary>
        [JsonProperty(PropertyName = "logCollectionLevel")]
        public LogCollectionLevel? LogCollectionLevel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AccountDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccountDetails");
            }
        }
    }
}
