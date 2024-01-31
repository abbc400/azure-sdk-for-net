// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> Data Product Information. </summary>
    public partial class DataProductInformation
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

        /// <summary> Initializes a new instance of <see cref="DataProductInformation"/>. </summary>
        /// <param name="dataProductName"> Name of data product. </param>
        /// <param name="description"> Description about data product. </param>
        /// <param name="dataProductVersions"> Version information of data product. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataProductName"/>, <paramref name="description"/> or <paramref name="dataProductVersions"/> is null. </exception>
        public DataProductInformation(string dataProductName, string description, IEnumerable<DataProductVersion> dataProductVersions)
        {
            Argument.AssertNotNull(dataProductName, nameof(dataProductName));
            Argument.AssertNotNull(description, nameof(description));
            Argument.AssertNotNull(dataProductVersions, nameof(dataProductVersions));

            DataProductName = dataProductName;
            Description = description;
            DataProductVersions = dataProductVersions.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DataProductInformation"/>. </summary>
        /// <param name="dataProductName"> Name of data product. </param>
        /// <param name="description"> Description about data product. </param>
        /// <param name="dataProductVersions"> Version information of data product. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataProductInformation(string dataProductName, string description, IList<DataProductVersion> dataProductVersions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DataProductName = dataProductName;
            Description = description;
            DataProductVersions = dataProductVersions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataProductInformation"/> for deserialization. </summary>
        internal DataProductInformation()
        {
        }

        /// <summary> Name of data product. </summary>
        public string DataProductName { get; set; }
        /// <summary> Description about data product. </summary>
        public string Description { get; set; }
        /// <summary> Version information of data product. </summary>
        public IList<DataProductVersion> DataProductVersions { get; }
    }
}
