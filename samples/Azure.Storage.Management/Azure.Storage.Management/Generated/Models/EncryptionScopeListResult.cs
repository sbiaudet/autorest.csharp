// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Storage.Management.Models
{
    /// <summary> List of encryption scopes requested, and if paging is required, a URL to the next page of encryption scopes. </summary>
    public partial class EncryptionScopeListResult
    {
        /// <summary> List of encryption scopes requested. </summary>
        public ICollection<EncryptionScope> Value { get; internal set; }
        /// <summary> Request URL that can be used to query next page of encryption scopes. Returned when total number of requested encryption scopes exceeds the maximum page size. </summary>
        public string NextLink { get; internal set; }
    }
}
