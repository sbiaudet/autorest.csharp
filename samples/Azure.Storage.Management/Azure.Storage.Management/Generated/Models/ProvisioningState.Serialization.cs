// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Management.Models
{
    internal static class ProvisioningStateExtensions
    {
        public static string ToSerialString(this ProvisioningState value) => value switch
        {
            ProvisioningState.Creating => "Creating",
            ProvisioningState.ResolvingDNS => "ResolvingDNS",
            ProvisioningState.Succeeded => "Succeeded",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProvisioningState value.")
        };

        public static ProvisioningState ToProvisioningState(this string value) => value switch
        {
            "Creating" => ProvisioningState.Creating,
            "ResolvingDNS" => ProvisioningState.ResolvingDNS,
            "Succeeded" => ProvisioningState.Succeeded,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProvisioningState value.")
        };
    }
}
