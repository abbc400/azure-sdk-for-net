// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// Resource type used for verification.
    /// Serialized Name: CheckQuotaNameResourceTypes
    /// </summary>
    public readonly partial struct NetAppQuotaAvailabilityResourceType : IEquatable<NetAppQuotaAvailabilityResourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetAppQuotaAvailabilityResourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetAppQuotaAvailabilityResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftNetAppNetAppAccountsValue = "Microsoft.NetApp/netAppAccounts";
        private const string MicrosoftNetAppNetAppAccountsCapacityPoolsValue = "Microsoft.NetApp/netAppAccounts/capacityPools";
        private const string MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesValue = "Microsoft.NetApp/netAppAccounts/capacityPools/volumes";
        private const string MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesSnapshotsValue = "Microsoft.NetApp/netAppAccounts/capacityPools/volumes/snapshots";

        /// <summary>
        /// Microsoft.NetApp/netAppAccounts
        /// Serialized Name: CheckQuotaNameResourceTypes.Microsoft.NetApp/netAppAccounts
        /// </summary>
        public static NetAppQuotaAvailabilityResourceType MicrosoftNetAppNetAppAccounts { get; } = new NetAppQuotaAvailabilityResourceType(MicrosoftNetAppNetAppAccountsValue);
        /// <summary>
        /// Microsoft.NetApp/netAppAccounts/capacityPools
        /// Serialized Name: CheckQuotaNameResourceTypes.Microsoft.NetApp/netAppAccounts/capacityPools
        /// </summary>
        public static NetAppQuotaAvailabilityResourceType MicrosoftNetAppNetAppAccountsCapacityPools { get; } = new NetAppQuotaAvailabilityResourceType(MicrosoftNetAppNetAppAccountsCapacityPoolsValue);
        /// <summary>
        /// Microsoft.NetApp/netAppAccounts/capacityPools/volumes
        /// Serialized Name: CheckQuotaNameResourceTypes.Microsoft.NetApp/netAppAccounts/capacityPools/volumes
        /// </summary>
        public static NetAppQuotaAvailabilityResourceType MicrosoftNetAppNetAppAccountsCapacityPoolsVolumes { get; } = new NetAppQuotaAvailabilityResourceType(MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesValue);
        /// <summary>
        /// Microsoft.NetApp/netAppAccounts/capacityPools/volumes/snapshots
        /// Serialized Name: CheckQuotaNameResourceTypes.Microsoft.NetApp/netAppAccounts/capacityPools/volumes/snapshots
        /// </summary>
        public static NetAppQuotaAvailabilityResourceType MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesSnapshots { get; } = new NetAppQuotaAvailabilityResourceType(MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesSnapshotsValue);
        /// <summary> Determines if two <see cref="NetAppQuotaAvailabilityResourceType"/> values are the same. </summary>
        public static bool operator ==(NetAppQuotaAvailabilityResourceType left, NetAppQuotaAvailabilityResourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetAppQuotaAvailabilityResourceType"/> values are not the same. </summary>
        public static bool operator !=(NetAppQuotaAvailabilityResourceType left, NetAppQuotaAvailabilityResourceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetAppQuotaAvailabilityResourceType"/>. </summary>
        public static implicit operator NetAppQuotaAvailabilityResourceType(string value) => new NetAppQuotaAvailabilityResourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetAppQuotaAvailabilityResourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetAppQuotaAvailabilityResourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
