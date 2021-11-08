// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The cluster create parameters.
    /// </summary>
    public partial class ClusterCreateProperties
    {
        /// <summary>
        /// Initializes a new instance of the ClusterCreateProperties class.
        /// </summary>
        public ClusterCreateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterCreateProperties class.
        /// </summary>
        /// <param name="clusterVersion">The version of the cluster.</param>
        /// <param name="osType">The type of operating system. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="tier">The cluster tier. Possible values include:
        /// 'Standard', 'Premium'</param>
        /// <param name="clusterDefinition">The cluster definition.</param>
        /// <param name="kafkaRestProperties">The cluster kafka rest proxy
        /// configuration.</param>
        /// <param name="securityProfile">The security profile.</param>
        /// <param name="computeProfile">The compute profile.</param>
        /// <param name="storageProfile">The storage profile.</param>
        /// <param name="diskEncryptionProperties">The disk encryption
        /// properties.</param>
        /// <param name="encryptionInTransitProperties">The
        /// encryption-in-transit properties.</param>
        /// <param name="minSupportedTlsVersion">The minimal supported tls
        /// version.</param>
        /// <param name="networkProperties">The network properties.</param>
        /// <param name="computeIsolationProperties">The compute isolation
        /// properties.</param>
        /// <param name="privateLinkConfigurations">The private link
        /// configurations.</param>
        public ClusterCreateProperties(string clusterVersion = default(string), string osType = default(string), string tier = default(string), ClusterDefinition clusterDefinition = default(ClusterDefinition), KafkaRestProperties kafkaRestProperties = default(KafkaRestProperties), SecurityProfile securityProfile = default(SecurityProfile), ComputeProfile computeProfile = default(ComputeProfile), StorageProfile storageProfile = default(StorageProfile), DiskEncryptionProperties diskEncryptionProperties = default(DiskEncryptionProperties), EncryptionInTransitProperties encryptionInTransitProperties = default(EncryptionInTransitProperties), string minSupportedTlsVersion = default(string), NetworkProperties networkProperties = default(NetworkProperties), ComputeIsolationProperties computeIsolationProperties = default(ComputeIsolationProperties), IList<PrivateLinkConfiguration> privateLinkConfigurations = default(IList<PrivateLinkConfiguration>))
        {
            ClusterVersion = clusterVersion;
            OsType = osType;
            Tier = tier;
            ClusterDefinition = clusterDefinition;
            KafkaRestProperties = kafkaRestProperties;
            SecurityProfile = securityProfile;
            ComputeProfile = computeProfile;
            StorageProfile = storageProfile;
            DiskEncryptionProperties = diskEncryptionProperties;
            EncryptionInTransitProperties = encryptionInTransitProperties;
            MinSupportedTlsVersion = minSupportedTlsVersion;
            NetworkProperties = networkProperties;
            ComputeIsolationProperties = computeIsolationProperties;
            PrivateLinkConfigurations = privateLinkConfigurations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "clusterVersion")]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// Gets or sets the type of operating system. Possible values include:
        /// 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the cluster tier. Possible values include: 'Standard',
        /// 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets the cluster definition.
        /// </summary>
        [JsonProperty(PropertyName = "clusterDefinition")]
        public ClusterDefinition ClusterDefinition { get; set; }

        /// <summary>
        /// Gets or sets the cluster kafka rest proxy configuration.
        /// </summary>
        [JsonProperty(PropertyName = "kafkaRestProperties")]
        public KafkaRestProperties KafkaRestProperties { get; set; }

        /// <summary>
        /// Gets or sets the security profile.
        /// </summary>
        [JsonProperty(PropertyName = "securityProfile")]
        public SecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Gets or sets the compute profile.
        /// </summary>
        [JsonProperty(PropertyName = "computeProfile")]
        public ComputeProfile ComputeProfile { get; set; }

        /// <summary>
        /// Gets or sets the storage profile.
        /// </summary>
        [JsonProperty(PropertyName = "storageProfile")]
        public StorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets the disk encryption properties.
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionProperties")]
        public DiskEncryptionProperties DiskEncryptionProperties { get; set; }

        /// <summary>
        /// Gets or sets the encryption-in-transit properties.
        /// </summary>
        [JsonProperty(PropertyName = "encryptionInTransitProperties")]
        public EncryptionInTransitProperties EncryptionInTransitProperties { get; set; }

        /// <summary>
        /// Gets or sets the minimal supported tls version.
        /// </summary>
        [JsonProperty(PropertyName = "minSupportedTlsVersion")]
        public string MinSupportedTlsVersion { get; set; }

        /// <summary>
        /// Gets or sets the network properties.
        /// </summary>
        [JsonProperty(PropertyName = "networkProperties")]
        public NetworkProperties NetworkProperties { get; set; }

        /// <summary>
        /// Gets or sets the compute isolation properties.
        /// </summary>
        [JsonProperty(PropertyName = "computeIsolationProperties")]
        public ComputeIsolationProperties ComputeIsolationProperties { get; set; }

        /// <summary>
        /// Gets or sets the private link configurations.
        /// </summary>
        [JsonProperty(PropertyName = "privateLinkConfigurations")]
        public IList<PrivateLinkConfiguration> PrivateLinkConfigurations { get; set; }

    }
}
