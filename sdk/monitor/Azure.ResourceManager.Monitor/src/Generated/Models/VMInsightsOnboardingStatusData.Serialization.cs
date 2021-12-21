// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class VmInsightsOnboardingStatusData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId");
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(OnboardingStatus))
            {
                writer.WritePropertyName("onboardingStatus");
                writer.WriteStringValue(OnboardingStatus.Value.ToString());
            }
            if (Optional.IsDefined(DataStatus))
            {
                writer.WritePropertyName("dataStatus");
                writer.WriteStringValue(DataStatus.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data");
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VmInsightsOnboardingStatusData DeserializeVmInsightsOnboardingStatusData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> resourceId = default;
            Optional<OnboardingStatus> onboardingStatus = default;
            Optional<DataStatus> dataStatus = default;
            Optional<IList<DataContainer>> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("resourceId"))
                        {
                            resourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("onboardingStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            onboardingStatus = new OnboardingStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataStatus = new DataStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("data"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DataContainer> array = new List<DataContainer>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataContainer.DeserializeDataContainer(item));
                            }
                            data = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VmInsightsOnboardingStatusData(id, name, type, resourceId.Value, Optional.ToNullable(onboardingStatus), Optional.ToNullable(dataStatus), Optional.ToList(data));
        }
    }
}
