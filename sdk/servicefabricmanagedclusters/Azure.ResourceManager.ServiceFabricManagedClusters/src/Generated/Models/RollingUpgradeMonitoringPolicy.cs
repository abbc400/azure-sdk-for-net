// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The policy used for monitoring the application upgrade. </summary>
    public partial class RollingUpgradeMonitoringPolicy
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

        /// <summary> Initializes a new instance of <see cref="RollingUpgradeMonitoringPolicy"/>. </summary>
        /// <param name="failureAction"> The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations. Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically. Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode. </param>
        /// <param name="healthCheckWaitDuration"> The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        /// <param name="healthCheckStableDuration"> The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        /// <param name="healthCheckRetryTimeout"> The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        /// <param name="upgradeTimeout"> The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        /// <param name="upgradeDomainTimeout"> The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        public RollingUpgradeMonitoringPolicy(PolicyViolationCompensationAction failureAction, TimeSpan healthCheckWaitDuration, TimeSpan healthCheckStableDuration, TimeSpan healthCheckRetryTimeout, TimeSpan upgradeTimeout, TimeSpan upgradeDomainTimeout)
        {
            FailureAction = failureAction;
            HealthCheckWaitDuration = healthCheckWaitDuration;
            HealthCheckStableDuration = healthCheckStableDuration;
            HealthCheckRetryTimeout = healthCheckRetryTimeout;
            UpgradeTimeout = upgradeTimeout;
            UpgradeDomainTimeout = upgradeDomainTimeout;
        }

        /// <summary> Initializes a new instance of <see cref="RollingUpgradeMonitoringPolicy"/>. </summary>
        /// <param name="failureAction"> The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations. Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically. Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode. </param>
        /// <param name="healthCheckWaitDuration"> The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        /// <param name="healthCheckStableDuration"> The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        /// <param name="healthCheckRetryTimeout"> The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        /// <param name="upgradeTimeout"> The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        /// <param name="upgradeDomainTimeout"> The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RollingUpgradeMonitoringPolicy(PolicyViolationCompensationAction failureAction, TimeSpan healthCheckWaitDuration, TimeSpan healthCheckStableDuration, TimeSpan healthCheckRetryTimeout, TimeSpan upgradeTimeout, TimeSpan upgradeDomainTimeout, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FailureAction = failureAction;
            HealthCheckWaitDuration = healthCheckWaitDuration;
            HealthCheckStableDuration = healthCheckStableDuration;
            HealthCheckRetryTimeout = healthCheckRetryTimeout;
            UpgradeTimeout = upgradeTimeout;
            UpgradeDomainTimeout = upgradeDomainTimeout;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RollingUpgradeMonitoringPolicy"/> for deserialization. </summary>
        internal RollingUpgradeMonitoringPolicy()
        {
        }

        /// <summary> The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations. Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically. Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode. </summary>
        public PolicyViolationCompensationAction FailureAction { get; set; }
        /// <summary> The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </summary>
        public TimeSpan HealthCheckWaitDuration { get; set; }
        /// <summary> The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </summary>
        public TimeSpan HealthCheckStableDuration { get; set; }
        /// <summary> The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </summary>
        public TimeSpan HealthCheckRetryTimeout { get; set; }
        /// <summary> The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </summary>
        public TimeSpan UpgradeTimeout { get; set; }
        /// <summary> The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </summary>
        public TimeSpan UpgradeDomainTimeout { get; set; }
    }
}
