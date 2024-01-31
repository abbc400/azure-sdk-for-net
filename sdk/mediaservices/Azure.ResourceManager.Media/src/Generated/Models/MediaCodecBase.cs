// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Describes the basic properties of all codecs.
    /// Please note <see cref="MediaCodecBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AacAudio"/>, <see cref="MediaAudioBase"/>, <see cref="CodecCopyAudio"/>, <see cref="CodecCopyVideo"/>, <see cref="DDAudio"/>, <see cref="H264Video"/>, <see cref="H265Video"/>, <see cref="MediaImageBase"/>, <see cref="JpgImage"/>, <see cref="PngImage"/> and <see cref="MediaVideoBase"/>.
    /// </summary>
    public abstract partial class MediaCodecBase
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MediaCodecBase"/>. </summary>
        protected MediaCodecBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaCodecBase"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="label"> An optional label for the codec. The label can be used to control muxing behavior. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaCodecBase(string odataType, string label, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OdataType = odataType;
            Label = label;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
        /// <summary> An optional label for the codec. The label can be used to control muxing behavior. </summary>
        public string Label { get; set; }
    }
}
