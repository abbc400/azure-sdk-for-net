// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan creation properties. </summary>
    public partial class SiteRecoveryCreateRecoveryPlanProperties
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

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryCreateRecoveryPlanProperties"/>. </summary>
        /// <param name="primaryFabricId"> The primary fabric Id. </param>
        /// <param name="recoveryFabricId"> The recovery fabric Id. </param>
        /// <param name="groups"> The recovery plan groups. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="primaryFabricId"/>, <paramref name="recoveryFabricId"/> or <paramref name="groups"/> is null. </exception>
        public SiteRecoveryCreateRecoveryPlanProperties(ResourceIdentifier primaryFabricId, ResourceIdentifier recoveryFabricId, IEnumerable<SiteRecoveryPlanGroup> groups)
        {
            Argument.AssertNotNull(primaryFabricId, nameof(primaryFabricId));
            Argument.AssertNotNull(recoveryFabricId, nameof(recoveryFabricId));
            Argument.AssertNotNull(groups, nameof(groups));

            PrimaryFabricId = primaryFabricId;
            RecoveryFabricId = recoveryFabricId;
            Groups = groups.ToList();
            ProviderSpecificContent = new ChangeTrackingList<RecoveryPlanProviderSpecificContent>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryCreateRecoveryPlanProperties"/>. </summary>
        /// <param name="primaryFabricId"> The primary fabric Id. </param>
        /// <param name="recoveryFabricId"> The recovery fabric Id. </param>
        /// <param name="failoverDeploymentModel"> The failover deployment model. </param>
        /// <param name="groups"> The recovery plan groups. </param>
        /// <param name="providerSpecificContent">
        /// The provider specific input.
        /// Please note <see cref="RecoveryPlanProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RecoveryPlanA2AContent"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryCreateRecoveryPlanProperties(ResourceIdentifier primaryFabricId, ResourceIdentifier recoveryFabricId, FailoverDeploymentModel? failoverDeploymentModel, IList<SiteRecoveryPlanGroup> groups, IList<RecoveryPlanProviderSpecificContent> providerSpecificContent, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrimaryFabricId = primaryFabricId;
            RecoveryFabricId = recoveryFabricId;
            FailoverDeploymentModel = failoverDeploymentModel;
            Groups = groups;
            ProviderSpecificContent = providerSpecificContent;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryCreateRecoveryPlanProperties"/> for deserialization. </summary>
        internal SiteRecoveryCreateRecoveryPlanProperties()
        {
        }

        /// <summary> The primary fabric Id. </summary>
        public ResourceIdentifier PrimaryFabricId { get; }
        /// <summary> The recovery fabric Id. </summary>
        public ResourceIdentifier RecoveryFabricId { get; }
        /// <summary> The failover deployment model. </summary>
        public FailoverDeploymentModel? FailoverDeploymentModel { get; set; }
        /// <summary> The recovery plan groups. </summary>
        public IList<SiteRecoveryPlanGroup> Groups { get; }
        /// <summary>
        /// The provider specific input.
        /// Please note <see cref="RecoveryPlanProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RecoveryPlanA2AContent"/>.
        /// </summary>
        public IList<RecoveryPlanProviderSpecificContent> ProviderSpecificContent { get; }
    }
}
