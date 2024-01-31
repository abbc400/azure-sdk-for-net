// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Creates a particular correlation between services. </summary>
    public partial class ServiceCorrelationDescription
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

        /// <summary> Initializes a new instance of <see cref="ServiceCorrelationDescription"/>. </summary>
        /// <param name="scheme"> The ServiceCorrelationScheme which describes the relationship between this service and the service specified via ServiceName. </param>
        /// <param name="serviceName"> The name of the service that the correlation relationship is established with. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public ServiceCorrelationDescription(ServiceCorrelationScheme scheme, string serviceName)
        {
            Argument.AssertNotNull(serviceName, nameof(serviceName));

            Scheme = scheme;
            ServiceName = serviceName;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceCorrelationDescription"/>. </summary>
        /// <param name="scheme"> The ServiceCorrelationScheme which describes the relationship between this service and the service specified via ServiceName. </param>
        /// <param name="serviceName"> The name of the service that the correlation relationship is established with. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceCorrelationDescription(ServiceCorrelationScheme scheme, string serviceName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Scheme = scheme;
            ServiceName = serviceName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceCorrelationDescription"/> for deserialization. </summary>
        internal ServiceCorrelationDescription()
        {
        }

        /// <summary> The ServiceCorrelationScheme which describes the relationship between this service and the service specified via ServiceName. </summary>
        public ServiceCorrelationScheme Scheme { get; set; }
        /// <summary> The name of the service that the correlation relationship is established with. </summary>
        public string ServiceName { get; set; }
    }
}
