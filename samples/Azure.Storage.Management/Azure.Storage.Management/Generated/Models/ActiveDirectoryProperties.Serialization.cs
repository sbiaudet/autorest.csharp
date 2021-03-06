// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class ActiveDirectoryProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("domainName");
            writer.WriteStringValue(DomainName);
            writer.WritePropertyName("netBiosDomainName");
            writer.WriteStringValue(NetBiosDomainName);
            writer.WritePropertyName("forestName");
            writer.WriteStringValue(ForestName);
            writer.WritePropertyName("domainGuid");
            writer.WriteStringValue(DomainGuid);
            writer.WritePropertyName("domainSid");
            writer.WriteStringValue(DomainSid);
            writer.WritePropertyName("azureStorageSid");
            writer.WriteStringValue(AzureStorageSid);
            writer.WriteEndObject();
        }

        internal static ActiveDirectoryProperties DeserializeActiveDirectoryProperties(JsonElement element)
        {
            ActiveDirectoryProperties result = new ActiveDirectoryProperties();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"))
                {
                    result.DomainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("netBiosDomainName"))
                {
                    result.NetBiosDomainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("forestName"))
                {
                    result.ForestName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainGuid"))
                {
                    result.DomainGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainSid"))
                {
                    result.DomainSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureStorageSid"))
                {
                    result.AzureStorageSid = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
