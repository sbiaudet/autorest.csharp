// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class ListAccountSasResponse
    {
        internal static ListAccountSasResponse DeserializeListAccountSasResponse(JsonElement element)
        {
            ListAccountSasResponse result = new ListAccountSasResponse();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountSasToken"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.AccountSasToken = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
