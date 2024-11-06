// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Group Quota details. </summary>
    public partial class GroupQuotaDetails
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

        /// <summary> Initializes a new instance of <see cref="GroupQuotaDetails"/>. </summary>
        public GroupQuotaDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GroupQuotaDetails"/>. </summary>
        /// <param name="resourceName"> The resource name, such as SKU name. </param>
        /// <param name="limit"> The current Group Quota Limit at the parentId level. </param>
        /// <param name="comment"> Any comment related to quota request. </param>
        /// <param name="unit"> The usages units, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response in the request body of your PUT operation. </param>
        /// <param name="availableLimit"> The available Group Quota Limit at the MG level. This Group quota can be allocated to subscription(s). </param>
        /// <param name="allocatedToSubscriptions"> Quota allocated to subscriptions. </param>
        /// <param name="value"> Resource name. </param>
        /// <param name="localizedValue"> Resource display name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GroupQuotaDetails(string resourceName, long? limit, string comment, string unit, long? availableLimit, AllocatedQuotaToSubscriptionList allocatedToSubscriptions, string value, string localizedValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceName = resourceName;
            Limit = limit;
            Comment = comment;
            Unit = unit;
            AvailableLimit = availableLimit;
            AllocatedToSubscriptions = allocatedToSubscriptions;
            Value = value;
            LocalizedValue = localizedValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource name, such as SKU name. </summary>
        [WirePath("resourceName")]
        public string ResourceName { get; set; }
        /// <summary> The current Group Quota Limit at the parentId level. </summary>
        [WirePath("limit")]
        public long? Limit { get; set; }
        /// <summary> Any comment related to quota request. </summary>
        [WirePath("comment")]
        public string Comment { get; set; }
        /// <summary> The usages units, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response in the request body of your PUT operation. </summary>
        [WirePath("unit")]
        public string Unit { get; }
        /// <summary> The available Group Quota Limit at the MG level. This Group quota can be allocated to subscription(s). </summary>
        [WirePath("availableLimit")]
        public long? AvailableLimit { get; }
        /// <summary> Quota allocated to subscriptions. </summary>
        internal AllocatedQuotaToSubscriptionList AllocatedToSubscriptions { get; }
        /// <summary> List of Group Quota Limit allocated to subscriptions. </summary>
        [WirePath("allocatedToSubscriptions.value")]
        public IReadOnlyList<SubscriptionAllocatedQuota> AllocatedToSubscriptionsValue
        {
            get => AllocatedToSubscriptions?.Value;
        }

        /// <summary> Resource name. </summary>
        [WirePath("name.value")]
        public string Value { get; }
        /// <summary> Resource display name. </summary>
        [WirePath("name.localizedValue")]
        public string LocalizedValue { get; }
    }
}
