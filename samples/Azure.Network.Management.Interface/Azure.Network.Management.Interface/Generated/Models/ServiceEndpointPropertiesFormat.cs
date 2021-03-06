// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> The service endpoint properties. </summary>
    public partial class ServiceEndpointPropertiesFormat
    {
        /// <summary> Initializes a new instance of ServiceEndpointPropertiesFormat. </summary>
        public ServiceEndpointPropertiesFormat()
        {
        }

        /// <summary> Initializes a new instance of ServiceEndpointPropertiesFormat. </summary>
        /// <param name="service"> The type of the endpoint service. </param>
        /// <param name="locations"> A list of locations. </param>
        /// <param name="provisioningState"> The provisioning state of the service endpoint resource. </param>
        internal ServiceEndpointPropertiesFormat(string service, IList<string> locations, ProvisioningState? provisioningState)
        {
            Service = service;
            Locations = locations;
            ProvisioningState = provisioningState;
        }

        /// <summary> The type of the endpoint service. </summary>
        public string Service { get; set; }
        /// <summary> A list of locations. </summary>
        public IList<string> Locations { get; set; }
        /// <summary> The provisioning state of the service endpoint resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
    }
}
