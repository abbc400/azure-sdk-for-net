// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Quota availability request content. </summary>
    public partial class NetAppQuotaAvailabilityContent
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

        /// <summary> Initializes a new instance of <see cref="NetAppQuotaAvailabilityContent"/>. </summary>
        /// <param name="name"> Name of the resource to verify. </param>
        /// <param name="availabilityResourceType"> Resource type used for verification. </param>
        /// <param name="resourceGroup"> Resource group name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="resourceGroup"/> is null. </exception>
        public NetAppQuotaAvailabilityContent(string name, NetAppQuotaAvailabilityResourceType availabilityResourceType, string resourceGroup)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(resourceGroup, nameof(resourceGroup));

            Name = name;
            AvailabilityResourceType = availabilityResourceType;
            ResourceGroup = resourceGroup;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppQuotaAvailabilityContent"/>. </summary>
        /// <param name="name"> Name of the resource to verify. </param>
        /// <param name="availabilityResourceType"> Resource type used for verification. </param>
        /// <param name="resourceGroup"> Resource group name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppQuotaAvailabilityContent(string name, NetAppQuotaAvailabilityResourceType availabilityResourceType, string resourceGroup, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            AvailabilityResourceType = availabilityResourceType;
            ResourceGroup = resourceGroup;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppQuotaAvailabilityContent"/> for deserialization. </summary>
        internal NetAppQuotaAvailabilityContent()
        {
        }

        /// <summary> Name of the resource to verify. </summary>
        public string Name { get; }
        /// <summary> Resource type used for verification. </summary>
        public NetAppQuotaAvailabilityResourceType AvailabilityResourceType { get; }
        /// <summary> Resource group name. </summary>
        public string ResourceGroup { get; }
    }
}
