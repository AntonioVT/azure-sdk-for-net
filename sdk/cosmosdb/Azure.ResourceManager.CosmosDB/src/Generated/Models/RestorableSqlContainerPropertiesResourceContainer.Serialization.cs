// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class RestorableSqlContainerPropertiesResourceContainer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(IndexingPolicy))
            {
                writer.WritePropertyName("indexingPolicy");
                writer.WriteObjectValue(IndexingPolicy);
            }
            if (Optional.IsDefined(PartitionKey))
            {
                writer.WritePropertyName("partitionKey");
                writer.WriteObjectValue(PartitionKey);
            }
            if (Optional.IsDefined(DefaultTtl))
            {
                writer.WritePropertyName("defaultTtl");
                writer.WriteNumberValue(DefaultTtl.Value);
            }
            if (Optional.IsDefined(UniqueKeyPolicy))
            {
                writer.WritePropertyName("uniqueKeyPolicy");
                writer.WriteObjectValue(UniqueKeyPolicy);
            }
            if (Optional.IsDefined(ConflictResolutionPolicy))
            {
                writer.WritePropertyName("conflictResolutionPolicy");
                writer.WriteObjectValue(ConflictResolutionPolicy);
            }
            if (Optional.IsDefined(AnalyticalStorageTtl))
            {
                writer.WritePropertyName("analyticalStorageTtl");
                writer.WriteNumberValue(AnalyticalStorageTtl.Value);
            }
            writer.WriteEndObject();
        }

        internal static RestorableSqlContainerPropertiesResourceContainer DeserializeRestorableSqlContainerPropertiesResourceContainer(JsonElement element)
        {
            Optional<string> self = default;
            Optional<string> rid = default;
            Optional<float> ts = default;
            Optional<string> etag = default;
            string id = default;
            Optional<IndexingPolicy> indexingPolicy = default;
            Optional<ContainerPartitionKey> partitionKey = default;
            Optional<int> defaultTtl = default;
            Optional<UniqueKeyPolicy> uniqueKeyPolicy = default;
            Optional<ConflictResolutionPolicy> conflictResolutionPolicy = default;
            Optional<long> analyticalStorageTtl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_self"))
                {
                    self = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_rid"))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("indexingPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    indexingPolicy = IndexingPolicy.DeserializeIndexingPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("partitionKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionKey = ContainerPartitionKey.DeserializeContainerPartitionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("defaultTtl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultTtl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("uniqueKeyPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    uniqueKeyPolicy = UniqueKeyPolicy.DeserializeUniqueKeyPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("conflictResolutionPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    conflictResolutionPolicy = ConflictResolutionPolicy.DeserializeConflictResolutionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("analyticalStorageTtl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    analyticalStorageTtl = property.Value.GetInt64();
                    continue;
                }
            }
            return new RestorableSqlContainerPropertiesResourceContainer(id, indexingPolicy.Value, partitionKey.Value, Optional.ToNullable(defaultTtl), uniqueKeyPolicy.Value, conflictResolutionPolicy.Value, Optional.ToNullable(analyticalStorageTtl), self.Value, rid.Value, Optional.ToNullable(ts), etag.Value);
        }
    }
}
