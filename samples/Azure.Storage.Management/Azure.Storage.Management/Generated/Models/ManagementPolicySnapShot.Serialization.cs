// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class ManagementPolicySnapShot : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Delete != null)
            {
                writer.WritePropertyName("delete");
                writer.WriteObjectValue(Delete);
            }
            writer.WriteEndObject();
        }
        internal static ManagementPolicySnapShot DeserializeManagementPolicySnapShot(JsonElement element)
        {
            ManagementPolicySnapShot result = new ManagementPolicySnapShot();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("delete"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Delete = DateAfterCreation.DeserializeDateAfterCreation(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}
