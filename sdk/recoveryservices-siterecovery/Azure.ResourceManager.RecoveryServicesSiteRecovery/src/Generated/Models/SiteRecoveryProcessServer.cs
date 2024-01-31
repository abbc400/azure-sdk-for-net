// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Details of the Process Server. </summary>
    public partial class SiteRecoveryProcessServer
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryProcessServer"/>. </summary>
        internal SiteRecoveryProcessServer()
        {
            MobilityServiceUpdates = new ChangeTrackingList<MobilityServiceUpdate>();
            HealthErrors = new ChangeTrackingList<SiteRecoveryHealthError>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryProcessServer"/>. </summary>
        /// <param name="friendlyName"> The Process Server's friendly name. </param>
        /// <param name="id"> The Process Server Id. </param>
        /// <param name="ipAddress"> The IP address of the server. </param>
        /// <param name="osType"> The OS type of the server. </param>
        /// <param name="agentVersion"> The version of the scout component on the server. </param>
        /// <param name="lastHeartbeatReceivedOn"> The last heartbeat received from the server. </param>
        /// <param name="versionStatus"> Version status. </param>
        /// <param name="mobilityServiceUpdates"> The list of the mobility service updates available on the Process Server. </param>
        /// <param name="hostId"> The agent generated Id. </param>
        /// <param name="machineCount"> The servers configured with this PS. </param>
        /// <param name="replicationPairCount"> The number of replication pairs configured in this PS. </param>
        /// <param name="systemLoad"> The percentage of the system load. </param>
        /// <param name="systemLoadStatus"> The system load status. </param>
        /// <param name="cpuLoad"> The percentage of the CPU load. </param>
        /// <param name="cpuLoadStatus"> The CPU load status. </param>
        /// <param name="totalMemoryInBytes"> The total memory. </param>
        /// <param name="availableMemoryInBytes"> The available memory. </param>
        /// <param name="memoryUsageStatus"> The memory usage status. </param>
        /// <param name="totalSpaceInBytes"> The total space. </param>
        /// <param name="availableSpaceInBytes"> The available space. </param>
        /// <param name="spaceUsageStatus"> The space usage status. </param>
        /// <param name="psServiceStatus"> The PS service status. </param>
        /// <param name="sslCertExpireOn"> The PS SSL cert expiry date. </param>
        /// <param name="sslCertExpiryRemainingDays"> CS SSL cert expiry date. </param>
        /// <param name="osVersion"> OS Version of the process server. Note: This will get populated if user has CS version greater than 9.12.0.0. </param>
        /// <param name="healthErrors"> Health errors. </param>
        /// <param name="agentExpireOn"> Agent expiry date. </param>
        /// <param name="agentVersionDetails"> The agent version details. </param>
        /// <param name="health"> The health of Process Server. </param>
        /// <param name="psStatsRefreshOn"> The process server stats refresh time. </param>
        /// <param name="throughputUploadPendingDataInBytes"> The uploading pending data in bytes. </param>
        /// <param name="throughputInMBps"> The throughput in MBps. </param>
        /// <param name="throughputInBytes"> The throughput in bytes. </param>
        /// <param name="throughputStatus"> The throughput status. </param>
        /// <param name="marsCommunicationStatus"> The MARS communication status. </param>
        /// <param name="marsRegistrationStatus"> The MARS registration status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryProcessServer(string friendlyName, string id, IPAddress ipAddress, string osType, string agentVersion, DateTimeOffset? lastHeartbeatReceivedOn, string versionStatus, IReadOnlyList<MobilityServiceUpdate> mobilityServiceUpdates, string hostId, string machineCount, string replicationPairCount, string systemLoad, string systemLoadStatus, string cpuLoad, string cpuLoadStatus, long? totalMemoryInBytes, long? availableMemoryInBytes, string memoryUsageStatus, long? totalSpaceInBytes, long? availableSpaceInBytes, string spaceUsageStatus, string psServiceStatus, DateTimeOffset? sslCertExpireOn, int? sslCertExpiryRemainingDays, string osVersion, IReadOnlyList<SiteRecoveryHealthError> healthErrors, DateTimeOffset? agentExpireOn, SiteRecoveryVersionDetails agentVersionDetails, SiteRecoveryProtectionHealth? health, DateTimeOffset? psStatsRefreshOn, long? throughputUploadPendingDataInBytes, long? throughputInMBps, long? throughputInBytes, string throughputStatus, string marsCommunicationStatus, string marsRegistrationStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FriendlyName = friendlyName;
            Id = id;
            IPAddress = ipAddress;
            OSType = osType;
            AgentVersion = agentVersion;
            LastHeartbeatReceivedOn = lastHeartbeatReceivedOn;
            VersionStatus = versionStatus;
            MobilityServiceUpdates = mobilityServiceUpdates;
            HostId = hostId;
            MachineCount = machineCount;
            ReplicationPairCount = replicationPairCount;
            SystemLoad = systemLoad;
            SystemLoadStatus = systemLoadStatus;
            CpuLoad = cpuLoad;
            CpuLoadStatus = cpuLoadStatus;
            TotalMemoryInBytes = totalMemoryInBytes;
            AvailableMemoryInBytes = availableMemoryInBytes;
            MemoryUsageStatus = memoryUsageStatus;
            TotalSpaceInBytes = totalSpaceInBytes;
            AvailableSpaceInBytes = availableSpaceInBytes;
            SpaceUsageStatus = spaceUsageStatus;
            PsServiceStatus = psServiceStatus;
            SslCertExpireOn = sslCertExpireOn;
            SslCertExpiryRemainingDays = sslCertExpiryRemainingDays;
            OSVersion = osVersion;
            HealthErrors = healthErrors;
            AgentExpireOn = agentExpireOn;
            AgentVersionDetails = agentVersionDetails;
            Health = health;
            PsStatsRefreshOn = psStatsRefreshOn;
            ThroughputUploadPendingDataInBytes = throughputUploadPendingDataInBytes;
            ThroughputInMBps = throughputInMBps;
            ThroughputInBytes = throughputInBytes;
            ThroughputStatus = throughputStatus;
            MarsCommunicationStatus = marsCommunicationStatus;
            MarsRegistrationStatus = marsRegistrationStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Process Server's friendly name. </summary>
        public string FriendlyName { get; }
        /// <summary> The Process Server Id. </summary>
        public string Id { get; }
        /// <summary> The IP address of the server. </summary>
        public IPAddress IPAddress { get; }
        /// <summary> The OS type of the server. </summary>
        public string OSType { get; }
        /// <summary> The version of the scout component on the server. </summary>
        public string AgentVersion { get; }
        /// <summary> The last heartbeat received from the server. </summary>
        public DateTimeOffset? LastHeartbeatReceivedOn { get; }
        /// <summary> Version status. </summary>
        public string VersionStatus { get; }
        /// <summary> The list of the mobility service updates available on the Process Server. </summary>
        public IReadOnlyList<MobilityServiceUpdate> MobilityServiceUpdates { get; }
        /// <summary> The agent generated Id. </summary>
        public string HostId { get; }
        /// <summary> The servers configured with this PS. </summary>
        public string MachineCount { get; }
        /// <summary> The number of replication pairs configured in this PS. </summary>
        public string ReplicationPairCount { get; }
        /// <summary> The percentage of the system load. </summary>
        public string SystemLoad { get; }
        /// <summary> The system load status. </summary>
        public string SystemLoadStatus { get; }
        /// <summary> The percentage of the CPU load. </summary>
        public string CpuLoad { get; }
        /// <summary> The CPU load status. </summary>
        public string CpuLoadStatus { get; }
        /// <summary> The total memory. </summary>
        public long? TotalMemoryInBytes { get; }
        /// <summary> The available memory. </summary>
        public long? AvailableMemoryInBytes { get; }
        /// <summary> The memory usage status. </summary>
        public string MemoryUsageStatus { get; }
        /// <summary> The total space. </summary>
        public long? TotalSpaceInBytes { get; }
        /// <summary> The available space. </summary>
        public long? AvailableSpaceInBytes { get; }
        /// <summary> The space usage status. </summary>
        public string SpaceUsageStatus { get; }
        /// <summary> The PS service status. </summary>
        public string PsServiceStatus { get; }
        /// <summary> The PS SSL cert expiry date. </summary>
        public DateTimeOffset? SslCertExpireOn { get; }
        /// <summary> CS SSL cert expiry date. </summary>
        public int? SslCertExpiryRemainingDays { get; }
        /// <summary> OS Version of the process server. Note: This will get populated if user has CS version greater than 9.12.0.0. </summary>
        public string OSVersion { get; }
        /// <summary> Health errors. </summary>
        public IReadOnlyList<SiteRecoveryHealthError> HealthErrors { get; }
        /// <summary> Agent expiry date. </summary>
        public DateTimeOffset? AgentExpireOn { get; }
        /// <summary> The agent version details. </summary>
        public SiteRecoveryVersionDetails AgentVersionDetails { get; }
        /// <summary> The health of Process Server. </summary>
        public SiteRecoveryProtectionHealth? Health { get; }
        /// <summary> The process server stats refresh time. </summary>
        public DateTimeOffset? PsStatsRefreshOn { get; }
        /// <summary> The uploading pending data in bytes. </summary>
        public long? ThroughputUploadPendingDataInBytes { get; }
        /// <summary> The throughput in MBps. </summary>
        public long? ThroughputInMBps { get; }
        /// <summary> The throughput in bytes. </summary>
        public long? ThroughputInBytes { get; }
        /// <summary> The throughput status. </summary>
        public string ThroughputStatus { get; }
        /// <summary> The MARS communication status. </summary>
        public string MarsCommunicationStatus { get; }
        /// <summary> The MARS registration status. </summary>
        public string MarsRegistrationStatus { get; }
    }
}
