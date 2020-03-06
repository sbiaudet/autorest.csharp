// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Storage.Management.Models
{
    /// <summary> A private link resource. </summary>
    public partial class PrivateLinkResource : Resource
    {
        /// <summary> The private link resource group id. </summary>
        public string GroupId { get; internal set; }
        /// <summary> The private link resource required member names. </summary>
        public ICollection<string> RequiredMembers { get; internal set; }
        /// <summary> The private link resource Private link DNS zone name. </summary>
        public ICollection<string> RequiredZoneNames { get; set; }
    }
}
