// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes the settings to be used when encoding the input video into a desired output bitrate layer with the H.265 video codec. </summary>
    public partial class H265Layer : H265VideoLayer
    {
        /// <summary> Initializes a new instance of <see cref="H265Layer"/>. </summary>
        /// <param name="bitrate"> The average bitrate in bits per second at which to encode the input video when generating this layer. For example: a target bitrate of 3000Kbps or 3Mbps means this value should be 3000000 This is a required field. </param>
        public H265Layer(int bitrate) : base(bitrate)
        {
        }

        /// <summary> Initializes a new instance of <see cref="H265Layer"/>. </summary>
        /// <param name="width"> The width of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in width as the input. </param>
        /// <param name="height"> The height of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in height as the input. </param>
        /// <param name="label"> The alphanumeric label for this layer, which can be used in multiplexing different video and audio layers, or in naming the output file. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="bitrate"> The average bitrate in bits per second at which to encode the input video when generating this layer. For example: a target bitrate of 3000Kbps or 3Mbps means this value should be 3000000 This is a required field. </param>
        /// <param name="maxBitrate"> The maximum bitrate (in bits per second), at which the VBV buffer should be assumed to refill. If not specified, defaults to the same value as bitrate. </param>
        /// <param name="bFrames"> The number of B-frames to be used when encoding this layer.  If not specified, the encoder chooses an appropriate number based on the video profile and level. </param>
        /// <param name="frameRate"> The frame rate (in frames per second) at which to encode this layer. The value can be in the form of M/N where M and N are integers (For example, 30000/1001), or in the form of a number (For example, 30, or 29.97). The encoder enforces constraints on allowed frame rates based on the profile and level. If it is not specified, the encoder will use the same frame rate as the input video. </param>
        /// <param name="slices"> The number of slices to be used when encoding this layer. If not specified, default is zero, which means that encoder will use a single slice for each frame. </param>
        /// <param name="useAdaptiveBFrame"> Specifies whether or not adaptive B-frames are to be used when encoding this layer. If not specified, the encoder will turn it on whenever the video profile permits its use. </param>
        /// <param name="profile"> We currently support Main. Default is Auto. </param>
        /// <param name="level"> We currently support Level up to 6.2. The value can be Auto, or a number that matches the H.265 profile. If not specified, the default is Auto, which lets the encoder choose the Level that is appropriate for this layer. </param>
        /// <param name="bufferWindow"> The VBV buffer window length. The value should be in ISO 8601 format. The value should be in the range [0.1-100] seconds. The default is 5 seconds (for example, PT5S). </param>
        /// <param name="crf"> The value of CRF to be used when encoding this layer. This setting takes effect when RateControlMode of video codec is set at CRF mode. The range of CRF value is between 0 and 51, where lower values would result in better quality, at the expense of higher file sizes. Higher values mean more compression, but at some point quality degradation will be noticed. Default value is 28. </param>
        /// <param name="referenceFrames"> The number of reference frames to be used when encoding this layer. If not specified, the encoder determines an appropriate number based on the encoder complexity setting. </param>
        internal H265Layer(string width, string height, string label, IDictionary<string, BinaryData> serializedAdditionalRawData, int bitrate, int? maxBitrate, int? bFrames, string frameRate, int? slices, bool? useAdaptiveBFrame, H265VideoProfile? profile, string level, TimeSpan? bufferWindow, float? crf, int? referenceFrames) : base(width, height, label, serializedAdditionalRawData, bitrate, maxBitrate, bFrames, frameRate, slices, useAdaptiveBFrame)
        {
            Profile = profile;
            Level = level;
            BufferWindow = bufferWindow;
            Crf = crf;
            ReferenceFrames = referenceFrames;
        }

        /// <summary> Initializes a new instance of <see cref="H265Layer"/> for deserialization. </summary>
        internal H265Layer()
        {
        }

        /// <summary> We currently support Main. Default is Auto. </summary>
        public H265VideoProfile? Profile { get; set; }
        /// <summary> We currently support Level up to 6.2. The value can be Auto, or a number that matches the H.265 profile. If not specified, the default is Auto, which lets the encoder choose the Level that is appropriate for this layer. </summary>
        public string Level { get; set; }
        /// <summary> The VBV buffer window length. The value should be in ISO 8601 format. The value should be in the range [0.1-100] seconds. The default is 5 seconds (for example, PT5S). </summary>
        public TimeSpan? BufferWindow { get; set; }
        /// <summary> The value of CRF to be used when encoding this layer. This setting takes effect when RateControlMode of video codec is set at CRF mode. The range of CRF value is between 0 and 51, where lower values would result in better quality, at the expense of higher file sizes. Higher values mean more compression, but at some point quality degradation will be noticed. Default value is 28. </summary>
        public float? Crf { get; set; }
        /// <summary> The number of reference frames to be used when encoding this layer. If not specified, the encoder determines an appropriate number based on the encoder complexity setting. </summary>
        public int? ReferenceFrames { get; set; }
    }
}
