// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class StorageAccountKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (KeyName != null)
            {
                writer.WritePropertyName("keyName");
                writer.WriteStringValue(KeyName);
            }
            if (Value != null)
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            if (Permissions != null)
            {
                writer.WritePropertyName("permissions");
                writer.WriteStringValue(Permissions.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }
        internal static StorageAccountKey DeserializeStorageAccountKey(JsonElement element)
        {
            StorageAccountKey result = new StorageAccountKey();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.KeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("permissions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Permissions = property.Value.GetString().ToKeyPermission();
                    continue;
                }
            }
            return result;
        }
    }
}
