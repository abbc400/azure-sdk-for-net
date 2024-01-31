// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The resource names object for load balancer and related resources. </summary>
    public partial class LoadBalancerResourceNames
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

        /// <summary> Initializes a new instance of <see cref="LoadBalancerResourceNames"/>. </summary>
        public LoadBalancerResourceNames()
        {
            FrontendIPConfigurationNames = new ChangeTrackingList<string>();
            BackendPoolNames = new ChangeTrackingList<string>();
            HealthProbeNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="LoadBalancerResourceNames"/>. </summary>
        /// <param name="loadBalancerName"> The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer. </param>
        /// <param name="frontendIPConfigurationNames"> The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database layer. </param>
        /// <param name="backendPoolNames"> The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1. </param>
        /// <param name="healthProbeNames"> The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database layer. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LoadBalancerResourceNames(string loadBalancerName, IList<string> frontendIPConfigurationNames, IList<string> backendPoolNames, IList<string> healthProbeNames, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LoadBalancerName = loadBalancerName;
            FrontendIPConfigurationNames = frontendIPConfigurationNames;
            BackendPoolNames = backendPoolNames;
            HealthProbeNames = healthProbeNames;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer. </summary>
        public string LoadBalancerName { get; set; }
        /// <summary> The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database layer. </summary>
        public IList<string> FrontendIPConfigurationNames { get; }
        /// <summary> The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1. </summary>
        public IList<string> BackendPoolNames { get; }
        /// <summary> The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database layer. </summary>
        public IList<string> HealthProbeNames { get; }
    }
}
