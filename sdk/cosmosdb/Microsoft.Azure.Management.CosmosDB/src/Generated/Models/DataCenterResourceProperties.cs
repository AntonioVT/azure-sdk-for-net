// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of a managed Cassandra data center.
    /// </summary>
    public partial class DataCenterResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the DataCenterResourceProperties
        /// class.
        /// </summary>
        public DataCenterResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataCenterResourceProperties
        /// class.
        /// </summary>
        /// <param name="provisioningState">Possible values include:
        /// 'Creating', 'Updating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Canceled'</param>
        /// <param name="dataCenterLocation">The region this data center should
        /// be created in.</param>
        /// <param name="delegatedSubnetId">Resource id of a subnet the nodes
        /// in this data center should have their network interfaces connected
        /// to. The subnet must be in the same region specified in
        /// 'dataCenterLocation' and must be able to route to the subnet
        /// specified in the cluster's 'delegatedManagementSubnetId' property.
        /// This resource id will be of the form
        /// '/subscriptions/&lt;subscription id&gt;/resourceGroups/&lt;resource
        /// group&gt;/providers/Microsoft.Network/virtualNetworks/&lt;virtual
        /// network&gt;/subnets/&lt;subnet&gt;'.</param>
        /// <param name="nodeCount">The number of nodes the data center should
        /// have. This is the desired number. After it is set, it may take some
        /// time for the data center to be scaled to match. To monitor the
        /// number of nodes and their status, use the fetchNodeStatus method on
        /// the cluster.</param>
        /// <param name="seedNodes">IP addresses for seed nodes in this data
        /// center. This is for reference. Generally you will want to use the
        /// seedNodes property on the cluster, which aggregates the seed nodes
        /// from all data centers in the cluster.</param>
        /// <param name="base64EncodedCassandraYamlFragment">A fragment of a
        /// cassandra.yaml configuration file to be included in the
        /// cassandra.yaml for all nodes in this data center. The fragment
        /// should be Base64 encoded, and only a subset of keys are
        /// allowed.</param>
        /// <param name="managedDiskCustomerKeyUri">Key uri to use for
        /// encryption of managed disks. Ensure the system assigned identity of
        /// the cluster has been assigned appropriate permissions(key
        /// get/wrap/unwrap permissions) on the key.</param>
        /// <param name="backupStorageCustomerKeyUri">Indicates the Key Uri of
        /// the customer key to use for encryption of the backup storage
        /// account.</param>
        /// <param name="sku">Virtual Machine SKU used for data centers.
        /// Default value is Standard_DS14_v2</param>
        /// <param name="diskSku">Disk SKU used for data centers. Default value
        /// is P30.</param>
        /// <param name="diskCapacity">Number of disk used for data centers.
        /// Default value is 4.</param>
        /// <param name="availabilityZone">If the azure data center has
        /// Availability Zone support, apply it to the Virtual Machine ScaleSet
        /// that host the cassandra data center virtual machines.</param>
        public DataCenterResourceProperties(string provisioningState = default(string), string dataCenterLocation = default(string), string delegatedSubnetId = default(string), int? nodeCount = default(int?), IList<SeedNode> seedNodes = default(IList<SeedNode>), string base64EncodedCassandraYamlFragment = default(string), string managedDiskCustomerKeyUri = default(string), string backupStorageCustomerKeyUri = default(string), string sku = default(string), string diskSku = default(string), int? diskCapacity = default(int?), bool? availabilityZone = default(bool?))
        {
            ProvisioningState = provisioningState;
            DataCenterLocation = dataCenterLocation;
            DelegatedSubnetId = delegatedSubnetId;
            NodeCount = nodeCount;
            SeedNodes = seedNodes;
            Base64EncodedCassandraYamlFragment = base64EncodedCassandraYamlFragment;
            ManagedDiskCustomerKeyUri = managedDiskCustomerKeyUri;
            BackupStorageCustomerKeyUri = backupStorageCustomerKeyUri;
            Sku = sku;
            DiskSku = diskSku;
            DiskCapacity = diskCapacity;
            AvailabilityZone = availabilityZone;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Creating', 'Updating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the region this data center should be created in.
        /// </summary>
        [JsonProperty(PropertyName = "dataCenterLocation")]
        public string DataCenterLocation { get; set; }

        /// <summary>
        /// Gets or sets resource id of a subnet the nodes in this data center
        /// should have their network interfaces connected to. The subnet must
        /// be in the same region specified in 'dataCenterLocation' and must be
        /// able to route to the subnet specified in the cluster's
        /// 'delegatedManagementSubnetId' property. This resource id will be of
        /// the form '/subscriptions/&amp;lt;subscription
        /// id&amp;gt;/resourceGroups/&amp;lt;resource
        /// group&amp;gt;/providers/Microsoft.Network/virtualNetworks/&amp;lt;virtual
        /// network&amp;gt;/subnets/&amp;lt;subnet&amp;gt;'.
        /// </summary>
        [JsonProperty(PropertyName = "delegatedSubnetId")]
        public string DelegatedSubnetId { get; set; }

        /// <summary>
        /// Gets or sets the number of nodes the data center should have. This
        /// is the desired number. After it is set, it may take some time for
        /// the data center to be scaled to match. To monitor the number of
        /// nodes and their status, use the fetchNodeStatus method on the
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "nodeCount")]
        public int? NodeCount { get; set; }

        /// <summary>
        /// Gets IP addresses for seed nodes in this data center. This is for
        /// reference. Generally you will want to use the seedNodes property on
        /// the cluster, which aggregates the seed nodes from all data centers
        /// in the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "seedNodes")]
        public IList<SeedNode> SeedNodes { get; private set; }

        /// <summary>
        /// Gets or sets a fragment of a cassandra.yaml configuration file to
        /// be included in the cassandra.yaml for all nodes in this data
        /// center. The fragment should be Base64 encoded, and only a subset of
        /// keys are allowed.
        /// </summary>
        [JsonProperty(PropertyName = "base64EncodedCassandraYamlFragment")]
        public string Base64EncodedCassandraYamlFragment { get; set; }

        /// <summary>
        /// Gets or sets key uri to use for encryption of managed disks. Ensure
        /// the system assigned identity of the cluster has been assigned
        /// appropriate permissions(key get/wrap/unwrap permissions) on the
        /// key.
        /// </summary>
        [JsonProperty(PropertyName = "managedDiskCustomerKeyUri")]
        public string ManagedDiskCustomerKeyUri { get; set; }

        /// <summary>
        /// Gets or sets indicates the Key Uri of the customer key to use for
        /// encryption of the backup storage account.
        /// </summary>
        [JsonProperty(PropertyName = "backupStorageCustomerKeyUri")]
        public string BackupStorageCustomerKeyUri { get; set; }

        /// <summary>
        /// Gets or sets virtual Machine SKU used for data centers. Default
        /// value is Standard_DS14_v2
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets disk SKU used for data centers. Default value is P30.
        /// </summary>
        [JsonProperty(PropertyName = "diskSku")]
        public string DiskSku { get; set; }

        /// <summary>
        /// Gets or sets number of disk used for data centers. Default value is
        /// 4.
        /// </summary>
        [JsonProperty(PropertyName = "diskCapacity")]
        public int? DiskCapacity { get; set; }

        /// <summary>
        /// Gets or sets if the azure data center has Availability Zone
        /// support, apply it to the Virtual Machine ScaleSet that host the
        /// cassandra data center virtual machines.
        /// </summary>
        [JsonProperty(PropertyName = "availabilityZone")]
        public bool? AvailabilityZone { get; set; }

    }
}
