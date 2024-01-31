// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The packet core to delete under a site. </summary>
    public partial class SiteDeletePacketCore
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

        /// <summary> Initializes a new instance of <see cref="SiteDeletePacketCore"/>. </summary>
        public SiteDeletePacketCore()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteDeletePacketCore"/>. </summary>
        /// <param name="packetCore"> Reference to an packet core control plane resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteDeletePacketCore(SubResource packetCore, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PacketCore = packetCore;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Reference to an packet core control plane resource. </summary>
        internal SubResource PacketCore { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PacketCoreId
        {
            get => PacketCore is null ? default : PacketCore.Id;
        }
    }
}
