// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The CustomRolloutStatus. </summary>
    public partial class CustomRolloutStatus
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

        /// <summary> Initializes a new instance of <see cref="CustomRolloutStatus"/>. </summary>
        public CustomRolloutStatus()
        {
            CompletedRegions = new ChangeTrackingList<AzureLocation>();
            FailedOrSkippedRegions = new ChangeTrackingDictionary<string, ExtendedErrorInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomRolloutStatus"/>. </summary>
        /// <param name="completedRegions"></param>
        /// <param name="failedOrSkippedRegions"> Dictionary of &lt;ExtendedErrorInfo&gt;. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomRolloutStatus(IList<AzureLocation> completedRegions, IDictionary<string, ExtendedErrorInfo> failedOrSkippedRegions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CompletedRegions = completedRegions;
            FailedOrSkippedRegions = failedOrSkippedRegions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the completed regions. </summary>
        public IList<AzureLocation> CompletedRegions { get; }
        /// <summary> Dictionary of &lt;ExtendedErrorInfo&gt;. </summary>
        public IDictionary<string, ExtendedErrorInfo> FailedOrSkippedRegions { get; }
    }
}
