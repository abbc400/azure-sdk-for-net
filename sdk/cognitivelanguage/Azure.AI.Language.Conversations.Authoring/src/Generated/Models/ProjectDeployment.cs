// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    /// <summary> Represents a project deployment. </summary>
    public partial class ProjectDeployment
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

        /// <summary> Initializes a new instance of <see cref="ProjectDeployment"/>. </summary>
        /// <param name="modelId"> Represents deployment modelId. </param>
        /// <param name="lastTrainedDateTime"> Represents deployment last trained time. </param>
        /// <param name="lastDeployedDateTime"> Represents deployment last deployed time. </param>
        /// <param name="deploymentExpirationDate"> Represents deployment expiration date in the runtime. </param>
        /// <param name="modelTrainingConfigVersion"> Represents model training config version. </param>
        /// <param name="assignedResources"> Represents the metadata of the assigned Azure resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/>, <paramref name="modelTrainingConfigVersion"/> or <paramref name="assignedResources"/> is null. </exception>
        internal ProjectDeployment(string modelId, DateTimeOffset lastTrainedDateTime, DateTimeOffset lastDeployedDateTime, DateTimeOffset deploymentExpirationDate, string modelTrainingConfigVersion, IEnumerable<DeploymentResource> assignedResources)
        {
            Argument.AssertNotNull(modelId, nameof(modelId));
            Argument.AssertNotNull(modelTrainingConfigVersion, nameof(modelTrainingConfigVersion));
            Argument.AssertNotNull(assignedResources, nameof(assignedResources));

            ModelId = modelId;
            LastTrainedDateTime = lastTrainedDateTime;
            LastDeployedDateTime = lastDeployedDateTime;
            DeploymentExpirationDate = deploymentExpirationDate;
            ModelTrainingConfigVersion = modelTrainingConfigVersion;
            AssignedResources = assignedResources.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ProjectDeployment"/>. </summary>
        /// <param name="deploymentName"> Represents deployment name. </param>
        /// <param name="modelId"> Represents deployment modelId. </param>
        /// <param name="lastTrainedDateTime"> Represents deployment last trained time. </param>
        /// <param name="lastDeployedDateTime"> Represents deployment last deployed time. </param>
        /// <param name="deploymentExpirationDate"> Represents deployment expiration date in the runtime. </param>
        /// <param name="modelTrainingConfigVersion"> Represents model training config version. </param>
        /// <param name="assignedResources"> Represents the metadata of the assigned Azure resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProjectDeployment(string deploymentName, string modelId, DateTimeOffset lastTrainedDateTime, DateTimeOffset lastDeployedDateTime, DateTimeOffset deploymentExpirationDate, string modelTrainingConfigVersion, IReadOnlyList<DeploymentResource> assignedResources, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeploymentName = deploymentName;
            ModelId = modelId;
            LastTrainedDateTime = lastTrainedDateTime;
            LastDeployedDateTime = lastDeployedDateTime;
            DeploymentExpirationDate = deploymentExpirationDate;
            ModelTrainingConfigVersion = modelTrainingConfigVersion;
            AssignedResources = assignedResources;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ProjectDeployment"/> for deserialization. </summary>
        internal ProjectDeployment()
        {
        }

        /// <summary> Represents deployment name. </summary>
        public string DeploymentName { get; }
        /// <summary> Represents deployment modelId. </summary>
        public string ModelId { get; }
        /// <summary> Represents deployment last trained time. </summary>
        public DateTimeOffset LastTrainedDateTime { get; }
        /// <summary> Represents deployment last deployed time. </summary>
        public DateTimeOffset LastDeployedDateTime { get; }
        /// <summary> Represents deployment expiration date in the runtime. </summary>
        public DateTimeOffset DeploymentExpirationDate { get; }
        /// <summary> Represents model training config version. </summary>
        public string ModelTrainingConfigVersion { get; }
        /// <summary> Represents the metadata of the assigned Azure resources. </summary>
        public IReadOnlyList<DeploymentResource> AssignedResources { get; }
    }
}
