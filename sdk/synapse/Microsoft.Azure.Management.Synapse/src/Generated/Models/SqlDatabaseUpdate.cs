// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A sql database resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SqlDatabaseUpdate
    {
        /// <summary>
        /// Initializes a new instance of the SqlDatabaseUpdate class.
        /// </summary>
        public SqlDatabaseUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlDatabaseUpdate class.
        /// </summary>
        /// <param name="status">The status of the database. Possible values
        /// include: 'Online', 'Restoring', 'RecoveryPending', 'Recovering',
        /// 'Suspect', 'Offline', 'Standby', 'Shutdown', 'EmergencyMode',
        /// 'AutoClosed', 'Copying', 'Creating', 'Inaccessible',
        /// 'OfflineSecondary', 'Pausing', 'Paused', 'Resuming', 'Scaling',
        /// 'OfflineChangingDwPerformanceTiers',
        /// 'OnlineChangingDwPerformanceTiers', 'Disabled'</param>
        /// <param name="collation">The collation of the database.</param>
        /// <param name="databaseGuid">The Guid of the database.</param>
        /// <param name="storageRedundancy">The storage redundancy of the
        /// database. Possible values include: 'Local', 'Geo', 'Zone',
        /// 'GeoZone'</param>
        /// <param name="dataRetention">Sql database data retention.</param>
        /// <param name="tags">Resource tags.</param>
        public SqlDatabaseUpdate(string status = default(string), string collation = default(string), System.Guid? databaseGuid = default(System.Guid?), string storageRedundancy = default(string), SqlDatabaseDataRetention dataRetention = default(SqlDatabaseDataRetention), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Status = status;
            Collation = collation;
            DatabaseGuid = databaseGuid;
            StorageRedundancy = storageRedundancy;
            DataRetention = dataRetention;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the status of the database. Possible values include: 'Online',
        /// 'Restoring', 'RecoveryPending', 'Recovering', 'Suspect', 'Offline',
        /// 'Standby', 'Shutdown', 'EmergencyMode', 'AutoClosed', 'Copying',
        /// 'Creating', 'Inaccessible', 'OfflineSecondary', 'Pausing',
        /// 'Paused', 'Resuming', 'Scaling',
        /// 'OfflineChangingDwPerformanceTiers',
        /// 'OnlineChangingDwPerformanceTiers', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or sets the collation of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Gets the Guid of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseGuid")]
        public System.Guid? DatabaseGuid { get; private set; }

        /// <summary>
        /// Gets or sets the storage redundancy of the database. Possible
        /// values include: 'Local', 'Geo', 'Zone', 'GeoZone'
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageRedundancy")]
        public string StorageRedundancy { get; set; }

        /// <summary>
        /// Gets or sets sql database data retention.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataRetention")]
        public SqlDatabaseDataRetention DataRetention { get; set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
