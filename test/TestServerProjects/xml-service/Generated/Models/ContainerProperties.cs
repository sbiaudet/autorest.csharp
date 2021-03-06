// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace xml_service.Models
{
    /// <summary> Properties of a container. </summary>
    public partial class ContainerProperties
    {
        /// <summary> Initializes a new instance of ContainerProperties. </summary>
        internal ContainerProperties()
        {
        }

        /// <summary> Initializes a new instance of ContainerProperties. </summary>
        /// <param name="lastModified"> . </param>
        /// <param name="etag"> . </param>
        /// <param name="leaseStatus"> . </param>
        /// <param name="leaseState"> . </param>
        /// <param name="leaseDuration"> . </param>
        /// <param name="publicAccess"> . </param>
        internal ContainerProperties(DateTimeOffset lastModified, string etag, LeaseStatusType? leaseStatus, LeaseStateType? leaseState, LeaseDurationType? leaseDuration, PublicAccessType? publicAccess)
        {
            LastModified = lastModified;
            Etag = etag;
            LeaseStatus = leaseStatus;
            LeaseState = leaseState;
            LeaseDuration = leaseDuration;
            PublicAccess = publicAccess;
        }

        public DateTimeOffset LastModified { get; internal set; }
        public string Etag { get; internal set; }
        public LeaseStatusType? LeaseStatus { get; internal set; }
        public LeaseStateType? LeaseState { get; internal set; }
        public LeaseDurationType? LeaseDuration { get; internal set; }
        public PublicAccessType? PublicAccess { get; internal set; }
    }
}
