// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace paging.Models
{
    public partial class OdataProductResult
    {
        internal static OdataProductResult DeserializeOdataProductResult(JsonElement element)
        {
            OdataProductResult result = new OdataProductResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("values"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Values = new List<Product>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Values.Add(Product.DeserializeProduct(item));
                    }
                    continue;
                }
                if (property.NameEquals("odata.nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.OdataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
