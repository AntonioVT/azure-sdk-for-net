// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The protocol of a Network Rule resource. </summary>
    public readonly partial struct AzureFirewallNetworkRuleProtocol : IEquatable<AzureFirewallNetworkRuleProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureFirewallNetworkRuleProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureFirewallNetworkRuleProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TCPValue = "TCP";
        private const string UDPValue = "UDP";
        private const string AnyValue = "Any";
        private const string IcmpValue = "ICMP";

        /// <summary> TCP. </summary>
        public static AzureFirewallNetworkRuleProtocol TCP { get; } = new AzureFirewallNetworkRuleProtocol(TCPValue);
        /// <summary> UDP. </summary>
        public static AzureFirewallNetworkRuleProtocol UDP { get; } = new AzureFirewallNetworkRuleProtocol(UDPValue);
        /// <summary> Any. </summary>
        public static AzureFirewallNetworkRuleProtocol Any { get; } = new AzureFirewallNetworkRuleProtocol(AnyValue);
        /// <summary> ICMP. </summary>
        public static AzureFirewallNetworkRuleProtocol Icmp { get; } = new AzureFirewallNetworkRuleProtocol(IcmpValue);
        /// <summary> Determines if two <see cref="AzureFirewallNetworkRuleProtocol"/> values are the same. </summary>
        public static bool operator ==(AzureFirewallNetworkRuleProtocol left, AzureFirewallNetworkRuleProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureFirewallNetworkRuleProtocol"/> values are not the same. </summary>
        public static bool operator !=(AzureFirewallNetworkRuleProtocol left, AzureFirewallNetworkRuleProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureFirewallNetworkRuleProtocol"/>. </summary>
        public static implicit operator AzureFirewallNetworkRuleProtocol(string value) => new AzureFirewallNetworkRuleProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureFirewallNetworkRuleProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureFirewallNetworkRuleProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
