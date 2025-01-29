// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring.Models
{
    /// <summary> Represents the settings used to define the project behavior. </summary>
    public partial class ProjectSettings
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

        /// <summary> Initializes a new instance of <see cref="ProjectSettings"/>. </summary>
        public ProjectSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProjectSettings"/>. </summary>
        /// <param name="confidenceThreshold"> The threshold of the class with the highest confidence, at which the prediction will automatically be changed to "None". The value of the threshold should be between 0 and 1 inclusive. </param>
        /// <param name="amlProjectPath"> The path to the AML connected project. </param>
        /// <param name="isLabelingLocked"> Indicates whether the labeling experience can be modified or not. </param>
        /// <param name="runGptPredictions"> Indicates whether to run GPT predictions or not. </param>
        /// <param name="gptPredictiveLookahead"> The predictive lookahead for GPT predictions that is specified by the user. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProjectSettings(float? confidenceThreshold, string amlProjectPath, bool? isLabelingLocked, bool? runGptPredictions, int? gptPredictiveLookahead, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConfidenceThreshold = confidenceThreshold;
            AmlProjectPath = amlProjectPath;
            IsLabelingLocked = isLabelingLocked;
            RunGptPredictions = runGptPredictions;
            GptPredictiveLookahead = gptPredictiveLookahead;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The threshold of the class with the highest confidence, at which the prediction will automatically be changed to "None". The value of the threshold should be between 0 and 1 inclusive. </summary>
        public float? ConfidenceThreshold { get; set; }
        /// <summary> The path to the AML connected project. </summary>
        public string AmlProjectPath { get; set; }
        /// <summary> Indicates whether the labeling experience can be modified or not. </summary>
        public bool? IsLabelingLocked { get; set; }
        /// <summary> Indicates whether to run GPT predictions or not. </summary>
        public bool? RunGptPredictions { get; set; }
        /// <summary> The predictive lookahead for GPT predictions that is specified by the user. </summary>
        public int? GptPredictiveLookahead { get; set; }
    }
}
