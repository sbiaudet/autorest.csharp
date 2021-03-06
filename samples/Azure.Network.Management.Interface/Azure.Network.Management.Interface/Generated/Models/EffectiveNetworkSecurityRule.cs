// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Effective network security rules. </summary>
    public partial class EffectiveNetworkSecurityRule
    {
        /// <summary> Initializes a new instance of EffectiveNetworkSecurityRule. </summary>
        internal EffectiveNetworkSecurityRule()
        {
        }

        /// <summary> Initializes a new instance of EffectiveNetworkSecurityRule. </summary>
        /// <param name="name"> The name of the security rule specified by the user (if created by the user). </param>
        /// <param name="protocol"> The network protocol this rule applies to. </param>
        /// <param name="sourcePortRange"> The source port or range. </param>
        /// <param name="destinationPortRange"> The destination port or range. </param>
        /// <param name="sourcePortRanges"> The source port ranges. Expected values include a single integer between 0 and 65535, a range using &apos;-&apos; as separator (e.g. 100-400), or an asterisk (*). </param>
        /// <param name="destinationPortRanges"> The destination port ranges. Expected values include a single integer between 0 and 65535, a range using &apos;-&apos; as separator (e.g. 100-400), or an asterisk (*). </param>
        /// <param name="sourceAddressPrefix"> The source address prefix. </param>
        /// <param name="destinationAddressPrefix"> The destination address prefix. </param>
        /// <param name="sourceAddressPrefixes"> The source address prefixes. Expected values include CIDR IP ranges, Default Tags (VirtualNetwork, AzureLoadBalancer, Internet), System Tags, and the asterisk (*). </param>
        /// <param name="destinationAddressPrefixes"> The destination address prefixes. Expected values include CIDR IP ranges, Default Tags (VirtualNetwork, AzureLoadBalancer, Internet), System Tags, and the asterisk (*). </param>
        /// <param name="expandedSourceAddressPrefix"> The expanded source address prefix. </param>
        /// <param name="expandedDestinationAddressPrefix"> Expanded destination address prefix. </param>
        /// <param name="access"> Whether network traffic is allowed or denied. </param>
        /// <param name="priority"> The priority of the rule. </param>
        /// <param name="direction"> The direction of the rule. </param>
        internal EffectiveNetworkSecurityRule(string name, EffectiveSecurityRuleProtocol? protocol, string sourcePortRange, string destinationPortRange, IList<string> sourcePortRanges, IList<string> destinationPortRanges, string sourceAddressPrefix, string destinationAddressPrefix, IList<string> sourceAddressPrefixes, IList<string> destinationAddressPrefixes, IList<string> expandedSourceAddressPrefix, IList<string> expandedDestinationAddressPrefix, SecurityRuleAccess? access, int? priority, SecurityRuleDirection? direction)
        {
            Name = name;
            Protocol = protocol;
            SourcePortRange = sourcePortRange;
            DestinationPortRange = destinationPortRange;
            SourcePortRanges = sourcePortRanges;
            DestinationPortRanges = destinationPortRanges;
            SourceAddressPrefix = sourceAddressPrefix;
            DestinationAddressPrefix = destinationAddressPrefix;
            SourceAddressPrefixes = sourceAddressPrefixes;
            DestinationAddressPrefixes = destinationAddressPrefixes;
            ExpandedSourceAddressPrefix = expandedSourceAddressPrefix;
            ExpandedDestinationAddressPrefix = expandedDestinationAddressPrefix;
            Access = access;
            Priority = priority;
            Direction = direction;
        }

        /// <summary> The name of the security rule specified by the user (if created by the user). </summary>
        public string Name { get; internal set; }
        /// <summary> The network protocol this rule applies to. </summary>
        public EffectiveSecurityRuleProtocol? Protocol { get; internal set; }
        /// <summary> The source port or range. </summary>
        public string SourcePortRange { get; internal set; }
        /// <summary> The destination port or range. </summary>
        public string DestinationPortRange { get; internal set; }
        /// <summary> The source port ranges. Expected values include a single integer between 0 and 65535, a range using &apos;-&apos; as separator (e.g. 100-400), or an asterisk (*). </summary>
        public IList<string> SourcePortRanges { get; internal set; }
        /// <summary> The destination port ranges. Expected values include a single integer between 0 and 65535, a range using &apos;-&apos; as separator (e.g. 100-400), or an asterisk (*). </summary>
        public IList<string> DestinationPortRanges { get; internal set; }
        /// <summary> The source address prefix. </summary>
        public string SourceAddressPrefix { get; internal set; }
        /// <summary> The destination address prefix. </summary>
        public string DestinationAddressPrefix { get; internal set; }
        /// <summary> The source address prefixes. Expected values include CIDR IP ranges, Default Tags (VirtualNetwork, AzureLoadBalancer, Internet), System Tags, and the asterisk (*). </summary>
        public IList<string> SourceAddressPrefixes { get; internal set; }
        /// <summary> The destination address prefixes. Expected values include CIDR IP ranges, Default Tags (VirtualNetwork, AzureLoadBalancer, Internet), System Tags, and the asterisk (*). </summary>
        public IList<string> DestinationAddressPrefixes { get; internal set; }
        /// <summary> The expanded source address prefix. </summary>
        public IList<string> ExpandedSourceAddressPrefix { get; internal set; }
        /// <summary> Expanded destination address prefix. </summary>
        public IList<string> ExpandedDestinationAddressPrefix { get; internal set; }
        /// <summary> Whether network traffic is allowed or denied. </summary>
        public SecurityRuleAccess? Access { get; internal set; }
        /// <summary> The priority of the rule. </summary>
        public int? Priority { get; internal set; }
        /// <summary> The direction of the rule. </summary>
        public SecurityRuleDirection? Direction { get; internal set; }
    }
}
