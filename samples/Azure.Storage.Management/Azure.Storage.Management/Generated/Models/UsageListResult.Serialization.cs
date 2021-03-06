// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class UsageListResult
    {
        internal static UsageListResult DeserializeUsageListResult(JsonElement element)
        {
            UsageListResult result = new UsageListResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Value = new List<Usage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Value.Add(Usage.DeserializeUsage(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
