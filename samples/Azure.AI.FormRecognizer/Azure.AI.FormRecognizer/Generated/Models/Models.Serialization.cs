// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class Models
    {
        internal static Models DeserializeModels(JsonElement element)
        {
            Models result = new Models();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("summary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Summary = ModelsSummary.DeserializeModelsSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("modelList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ModelList = new List<ModelInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.ModelList.Add(ModelInfo.DeserializeModelInfo(item));
                    }
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.NextLink = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
