// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class SkuInfoCollection
    {
        internal static SkuInfoCollection DeserializeSkuInfoCollection(JsonElement element)
        {
            IReadOnlyList<SkuInfo> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<SkuInfo> array = new List<SkuInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SkuInfo.DeserializeSkuInfo(item));
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
            return new SkuInfoCollection(value, nextLink.Value);
        }
    }
}
