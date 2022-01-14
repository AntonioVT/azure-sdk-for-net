// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppStack : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WebAppStack DeserializeWebAppStack(JsonElement element)
        {
            Optional<string> location = default;
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> displayText = default;
            Optional<string> value = default;
            Optional<IReadOnlyList<WebAppMajorVersion>> majorVersions = default;
            Optional<StackPreferredOs> preferredOs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("displayText"))
                        {
                            displayText = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("value"))
                        {
                            value = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("majorVersions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WebAppMajorVersion> array = new List<WebAppMajorVersion>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WebAppMajorVersion.DeserializeWebAppMajorVersion(item));
                            }
                            majorVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("preferredOs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            preferredOs = property0.Value.GetString().ToStackPreferredOs();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WebAppStack(id, name, type, kind.Value, location.Value, displayText.Value, value.Value, Optional.ToList(majorVersions), Optional.ToNullable(preferredOs));
        }
    }
}
