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
    internal partial class ServerListResult
    {
        internal static ServerListResult DeserializeServerListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SqlServerData>> value = default;
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
                    List<SqlServerData> array = new List<SqlServerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlServerData.DeserializeSqlServerData(item));
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
            return new ServerListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
