// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class LegalHoldProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (HasLegalHold != null)
            {
                writer.WritePropertyName("hasLegalHold");
                writer.WriteBooleanValue(HasLegalHold.Value);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartArray();
                foreach (var item in Tags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static LegalHoldProperties DeserializeLegalHoldProperties(JsonElement element)
        {
            LegalHoldProperties result = new LegalHoldProperties();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hasLegalHold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.HasLegalHold = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Tags = new List<TagProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Tags.Add(TagProperty.DeserializeTagProperty(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
