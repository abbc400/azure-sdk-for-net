// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Helm mapping rule profile. </summary>
    public partial class HelmMappingRuleProfile
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

        /// <summary> Initializes a new instance of <see cref="HelmMappingRuleProfile"/>. </summary>
        public HelmMappingRuleProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HelmMappingRuleProfile"/>. </summary>
        /// <param name="releaseNamespace"> Helm release namespace. </param>
        /// <param name="releaseName"> Helm release name. </param>
        /// <param name="helmPackageVersion"> Helm package version. </param>
        /// <param name="values"> Helm release values. </param>
        /// <param name="options"> The helm deployment options. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HelmMappingRuleProfile(string releaseNamespace, string releaseName, string helmPackageVersion, string values, HelmMappingRuleProfileConfig options, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReleaseNamespace = releaseNamespace;
            ReleaseName = releaseName;
            HelmPackageVersion = helmPackageVersion;
            Values = values;
            Options = options;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Helm release namespace. </summary>
        public string ReleaseNamespace { get; set; }
        /// <summary> Helm release name. </summary>
        public string ReleaseName { get; set; }
        /// <summary> Helm package version. </summary>
        public string HelmPackageVersion { get; set; }
        /// <summary> Helm release values. </summary>
        public string Values { get; set; }
        /// <summary> The helm deployment options. </summary>
        public HelmMappingRuleProfileConfig Options { get; set; }
    }
}
