// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class NetworkInterfaceDnsSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (DnsServers != null)
            {
                writer.WritePropertyName("dnsServers");
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (AppliedDnsServers != null)
            {
                writer.WritePropertyName("appliedDnsServers");
                writer.WriteStartArray();
                foreach (var item in AppliedDnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (InternalDnsNameLabel != null)
            {
                writer.WritePropertyName("internalDnsNameLabel");
                writer.WriteStringValue(InternalDnsNameLabel);
            }
            if (InternalFqdn != null)
            {
                writer.WritePropertyName("internalFqdn");
                writer.WriteStringValue(InternalFqdn);
            }
            if (InternalDomainNameSuffix != null)
            {
                writer.WritePropertyName("internalDomainNameSuffix");
                writer.WriteStringValue(InternalDomainNameSuffix);
            }
            writer.WriteEndObject();
        }

        internal static NetworkInterfaceDnsSettings DeserializeNetworkInterfaceDnsSettings(JsonElement element)
        {
            NetworkInterfaceDnsSettings result = new NetworkInterfaceDnsSettings();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsServers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.DnsServers = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.DnsServers.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("appliedDnsServers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.AppliedDnsServers = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.AppliedDnsServers.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("internalDnsNameLabel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.InternalDnsNameLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("internalFqdn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.InternalFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("internalDomainNameSuffix"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.InternalDomainNameSuffix = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
