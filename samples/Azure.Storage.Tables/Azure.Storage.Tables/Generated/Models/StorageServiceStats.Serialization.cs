// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Tables.Models
{
    public partial class StorageServiceStats
    {
        internal static StorageServiceStats DeserializeStorageServiceStats(XElement element)
        {
            StorageServiceStats result = default;
            result = new StorageServiceStats(); GeoReplication value = default;
            var geoReplication = element.Element("GeoReplication");
            if (geoReplication != null)
            {
                value = GeoReplication.DeserializeGeoReplication(geoReplication);
            }
            result.GeoReplication = value;
            return result;
        }
    }
}
