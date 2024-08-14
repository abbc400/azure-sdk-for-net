// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing the HciClusterSecuritySetting data model.
    /// Security settings proxy resource
    /// </summary>
    public partial class HciClusterSecuritySettingData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="HciClusterSecuritySettingData"/>. </summary>
        public HciClusterSecuritySettingData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HciClusterSecuritySettingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="securedCoreComplianceAssignment"> Secured Core Compliance Assignment. </param>
        /// <param name="wdacComplianceAssignment"> WDAC Compliance Assignment. </param>
        /// <param name="smbEncryptionForIntraClusterTrafficComplianceAssignment"> SMB encryption for intra-cluster traffic Compliance Assignment. </param>
        /// <param name="securityComplianceStatus"> Security Compliance Status. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HciClusterSecuritySettingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, HciClusterComplianceAssignmentType? securedCoreComplianceAssignment, HciClusterComplianceAssignmentType? wdacComplianceAssignment, HciClusterComplianceAssignmentType? smbEncryptionForIntraClusterTrafficComplianceAssignment, SecurityComplianceStatus securityComplianceStatus, HciProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            SecuredCoreComplianceAssignment = securedCoreComplianceAssignment;
            WdacComplianceAssignment = wdacComplianceAssignment;
            SmbEncryptionForIntraClusterTrafficComplianceAssignment = smbEncryptionForIntraClusterTrafficComplianceAssignment;
            SecurityComplianceStatus = securityComplianceStatus;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Secured Core Compliance Assignment. </summary>
        [WirePath("properties.securedCoreComplianceAssignment")]
        public HciClusterComplianceAssignmentType? SecuredCoreComplianceAssignment { get; set; }
        /// <summary> WDAC Compliance Assignment. </summary>
        [WirePath("properties.wdacComplianceAssignment")]
        public HciClusterComplianceAssignmentType? WdacComplianceAssignment { get; set; }
        /// <summary> SMB encryption for intra-cluster traffic Compliance Assignment. </summary>
        [WirePath("properties.smbEncryptionForIntraClusterTrafficComplianceAssignment")]
        public HciClusterComplianceAssignmentType? SmbEncryptionForIntraClusterTrafficComplianceAssignment { get; set; }
        /// <summary> Security Compliance Status. </summary>
        [WirePath("properties.securityComplianceStatus")]
        public SecurityComplianceStatus SecurityComplianceStatus { get; }
        /// <summary> The status of the last operation. </summary>
        [WirePath("properties.provisioningState")]
        public HciProvisioningState? ProvisioningState { get; set; }
    }
}
