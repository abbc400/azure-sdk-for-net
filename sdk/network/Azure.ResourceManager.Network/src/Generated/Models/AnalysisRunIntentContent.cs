// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Intent information. </summary>
    public partial class AnalysisRunIntentContent
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

        /// <summary> Initializes a new instance of <see cref="AnalysisRunIntentContent"/>. </summary>
        /// <param name="sourceResourceId"> Source resource id of the intent. </param>
        /// <param name="destinationResourceId"> Destination resource id of the intent. </param>
        /// <param name="ipTraffic"> IP traffic information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceResourceId"/>, <paramref name="destinationResourceId"/> or <paramref name="ipTraffic"/> is null. </exception>
        internal AnalysisRunIntentContent(ResourceIdentifier sourceResourceId, ResourceIdentifier destinationResourceId, NetworkVerifierIPTraffic ipTraffic)
        {
            Argument.AssertNotNull(sourceResourceId, nameof(sourceResourceId));
            Argument.AssertNotNull(destinationResourceId, nameof(destinationResourceId));
            Argument.AssertNotNull(ipTraffic, nameof(ipTraffic));

            SourceResourceId = sourceResourceId;
            DestinationResourceId = destinationResourceId;
            IPTraffic = ipTraffic;
        }

        /// <summary> Initializes a new instance of <see cref="AnalysisRunIntentContent"/>. </summary>
        /// <param name="description"></param>
        /// <param name="sourceResourceId"> Source resource id of the intent. </param>
        /// <param name="destinationResourceId"> Destination resource id of the intent. </param>
        /// <param name="ipTraffic"> IP traffic information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalysisRunIntentContent(string description, ResourceIdentifier sourceResourceId, ResourceIdentifier destinationResourceId, NetworkVerifierIPTraffic ipTraffic, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            SourceResourceId = sourceResourceId;
            DestinationResourceId = destinationResourceId;
            IPTraffic = ipTraffic;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalysisRunIntentContent"/> for deserialization. </summary>
        internal AnalysisRunIntentContent()
        {
        }

        /// <summary> Gets the description. </summary>
        public string Description { get; }
        /// <summary> Source resource id of the intent. </summary>
        public ResourceIdentifier SourceResourceId { get; }
        /// <summary> Destination resource id of the intent. </summary>
        public ResourceIdentifier DestinationResourceId { get; }
        /// <summary> IP traffic information. </summary>
        public NetworkVerifierIPTraffic IPTraffic { get; }
    }
}
