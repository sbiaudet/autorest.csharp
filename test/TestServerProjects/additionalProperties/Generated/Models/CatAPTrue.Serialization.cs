// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace additionalProperties.Models.V100
{
    public partial class CatAPTrue : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Friendly != null)
            {
                writer.WritePropertyName("friendly");
                writer.WriteBooleanValue(Friendly.Value);
            }
            writer.WritePropertyName("id");
            writer.WriteNumberValue(Id);
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Status != null)
            {
                writer.WritePropertyName("status");
                writer.WriteBooleanValue(Status.Value);
            }
            foreach (var item in this)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }
        internal static CatAPTrue DeserializeCatAPTrue(JsonElement element)
        {
            CatAPTrue result = new CatAPTrue();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Friendly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    result.Id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Status = property.Value.GetBoolean();
                    continue;
                }
                result.Add(property.Name, property.Value.GetObject());
            }
            return result;
        }
    }
}