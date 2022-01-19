// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class InstanceFailoverGroupListResult
    {
        internal static InstanceFailoverGroupListResult DeserializeInstanceFailoverGroupListResult(JsonElement element)
        {
            Optional<IReadOnlyList<InstanceFailoverGroupData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<InstanceFailoverGroupData> array = new List<InstanceFailoverGroupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstanceFailoverGroupData.DeserializeInstanceFailoverGroupData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new InstanceFailoverGroupListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
