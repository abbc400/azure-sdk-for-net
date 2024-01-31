// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Ray distribution configuration. </summary>
    public partial class RayDistributionConfiguration : MachineLearningDistributionConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="RayDistributionConfiguration"/>. </summary>
        public RayDistributionConfiguration()
        {
            DistributionType = DistributionType.Ray;
        }

        /// <summary> Initializes a new instance of <see cref="RayDistributionConfiguration"/>. </summary>
        /// <param name="distributionType"> [Required] Specifies the type of distribution framework. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="address"> The address of Ray head node. </param>
        /// <param name="dashboardPort"> The port to bind the dashboard server to. </param>
        /// <param name="headNodeAdditionalArgs"> Additional arguments passed to ray start in head node. </param>
        /// <param name="includeDashboard"> Provide this argument to start the Ray dashboard GUI. </param>
        /// <param name="port"> The port of the head ray process. </param>
        /// <param name="workerNodeAdditionalArgs"> Additional arguments passed to ray start in worker node. </param>
        internal RayDistributionConfiguration(DistributionType distributionType, IDictionary<string, BinaryData> serializedAdditionalRawData, string address, int? dashboardPort, string headNodeAdditionalArgs, bool? includeDashboard, int? port, string workerNodeAdditionalArgs) : base(distributionType, serializedAdditionalRawData)
        {
            Address = address;
            DashboardPort = dashboardPort;
            HeadNodeAdditionalArgs = headNodeAdditionalArgs;
            IncludeDashboard = includeDashboard;
            Port = port;
            WorkerNodeAdditionalArgs = workerNodeAdditionalArgs;
            DistributionType = distributionType;
        }

        /// <summary> The address of Ray head node. </summary>
        public string Address { get; set; }
        /// <summary> The port to bind the dashboard server to. </summary>
        public int? DashboardPort { get; set; }
        /// <summary> Additional arguments passed to ray start in head node. </summary>
        public string HeadNodeAdditionalArgs { get; set; }
        /// <summary> Provide this argument to start the Ray dashboard GUI. </summary>
        public bool? IncludeDashboard { get; set; }
        /// <summary> The port of the head ray process. </summary>
        public int? Port { get; set; }
        /// <summary> Additional arguments passed to ray start in worker node. </summary>
        public string WorkerNodeAdditionalArgs { get; set; }
    }
}
