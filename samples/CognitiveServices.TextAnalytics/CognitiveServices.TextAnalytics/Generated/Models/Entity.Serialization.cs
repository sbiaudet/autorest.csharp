// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class Entity
    {
        internal static Entity DeserializeEntity(JsonElement element)
        {
            Entity result = new Entity();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"))
                {
                    result.Text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    result.Type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subtype"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Subtype = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offset"))
                {
                    result.Offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"))
                {
                    result.Length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("score"))
                {
                    result.Score = property.Value.GetDouble();
                    continue;
                }
            }
            return result;
        }
    }
}
