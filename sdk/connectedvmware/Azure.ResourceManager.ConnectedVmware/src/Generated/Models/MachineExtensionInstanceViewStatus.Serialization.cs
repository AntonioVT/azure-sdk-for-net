// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVmware.Models
{
    public partial class MachineExtensionInstanceViewStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static MachineExtensionInstanceViewStatus DeserializeMachineExtensionInstanceViewStatus(JsonElement element)
        {
            Optional<string> code = default;
            Optional<StatusLevelTypes> level = default;
            Optional<string> displayStatus = default;
            Optional<string> message = default;
            Optional<DateTimeOffset> time = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    level = new StatusLevelTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayStatus"))
                {
                    displayStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("time"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    time = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new MachineExtensionInstanceViewStatus(code.Value, Optional.ToNullable(level), displayStatus.Value, message.Value, Optional.ToNullable(time));
        }
    }
}
