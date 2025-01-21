// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The properties of an Access Control Rule Privilege. </summary>
    public partial class GalleryInVmAccessControlRulesPrivilege
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

        /// <summary> Initializes a new instance of <see cref="GalleryInVmAccessControlRulesPrivilege"/>. </summary>
        /// <param name="name"> The name of the privilege. </param>
        /// <param name="path"> The HTTP path corresponding to the privilege. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="path"/> is null. </exception>
        public GalleryInVmAccessControlRulesPrivilege(string name, string path)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(path, nameof(path));

            Name = name;
            Path = path;
            QueryParameters = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="GalleryInVmAccessControlRulesPrivilege"/>. </summary>
        /// <param name="name"> The name of the privilege. </param>
        /// <param name="path"> The HTTP path corresponding to the privilege. </param>
        /// <param name="queryParameters"> The query parameters to match in the path. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryInVmAccessControlRulesPrivilege(string name, string path, IDictionary<string, string> queryParameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Path = path;
            QueryParameters = queryParameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GalleryInVmAccessControlRulesPrivilege"/> for deserialization. </summary>
        internal GalleryInVmAccessControlRulesPrivilege()
        {
        }

        /// <summary> The name of the privilege. </summary>
        public string Name { get; set; }
        /// <summary> The HTTP path corresponding to the privilege. </summary>
        public string Path { get; set; }
        /// <summary> The query parameters to match in the path. </summary>
        public IDictionary<string, string> QueryParameters { get; }
    }
}
