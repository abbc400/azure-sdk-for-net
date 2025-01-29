// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    /// <summary> Defines the message schema reference properties. </summary>
    public partial class MessageSchemaReference
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

        /// <summary> Initializes a new instance of <see cref="MessageSchemaReference"/>. </summary>
        /// <param name="schemaRegistryNamespace"> The message schema registry namespace. </param>
        /// <param name="schemaName"> The message schema name. </param>
        /// <param name="schemaVersion"> The message schema version. </param>
        internal MessageSchemaReference(string schemaRegistryNamespace, string schemaName, string schemaVersion)
        {
            SchemaRegistryNamespace = schemaRegistryNamespace;
            SchemaName = schemaName;
            SchemaVersion = schemaVersion;
        }

        /// <summary> Initializes a new instance of <see cref="MessageSchemaReference"/>. </summary>
        /// <param name="schemaRegistryNamespace"> The message schema registry namespace. </param>
        /// <param name="schemaName"> The message schema name. </param>
        /// <param name="schemaVersion"> The message schema version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MessageSchemaReference(string schemaRegistryNamespace, string schemaName, string schemaVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SchemaRegistryNamespace = schemaRegistryNamespace;
            SchemaName = schemaName;
            SchemaVersion = schemaVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MessageSchemaReference"/> for deserialization. </summary>
        internal MessageSchemaReference()
        {
        }

        /// <summary> The message schema registry namespace. </summary>
        public string SchemaRegistryNamespace { get; }
        /// <summary> The message schema name. </summary>
        public string SchemaName { get; }
        /// <summary> The message schema version. </summary>
        public string SchemaVersion { get; }
    }
}
