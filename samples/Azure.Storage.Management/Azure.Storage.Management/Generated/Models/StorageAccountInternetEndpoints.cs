// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Storage.Management.Models
{
    /// <summary> The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint. </summary>
    public partial class StorageAccountInternetEndpoints
    {
        /// <summary> Initializes a new instance of StorageAccountInternetEndpoints. </summary>
        public StorageAccountInternetEndpoints()
        {
        }

        /// <summary> Initializes a new instance of StorageAccountInternetEndpoints. </summary>
        /// <param name="blob"> Gets the blob endpoint. </param>
        /// <param name="file"> Gets the file endpoint. </param>
        /// <param name="web"> Gets the web endpoint. </param>
        /// <param name="dfs"> Gets the dfs endpoint. </param>
        internal StorageAccountInternetEndpoints(string blob, string file, string web, string dfs)
        {
            Blob = blob;
            File = file;
            Web = web;
            Dfs = dfs;
        }

        /// <summary> Gets the blob endpoint. </summary>
        public string Blob { get; internal set; }
        /// <summary> Gets the file endpoint. </summary>
        public string File { get; internal set; }
        /// <summary> Gets the web endpoint. </summary>
        public string Web { get; internal set; }
        /// <summary> Gets the dfs endpoint. </summary>
        public string Dfs { get; internal set; }
    }
}
