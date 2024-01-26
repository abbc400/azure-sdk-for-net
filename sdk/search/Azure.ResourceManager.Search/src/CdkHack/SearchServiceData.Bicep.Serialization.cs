// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search
{
    public partial class SearchServiceData : IModelJsonSerializable<SearchServiceData>
    {
        void IModelJsonSerializable<SearchServiceData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => ((IUtf8JsonSerializable)this).Write(writer);

        SearchServiceData IModelJsonSerializable<SearchServiceData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchServiceData(document.RootElement);
        }

        BinaryData IModelSerializable<SearchServiceData>.Serialize(ModelSerializerOptions options) => (options.Format.ToString()) switch
        {
            "J" or "W" => ModelSerializer.SerializeCore(this, options),
            "bicep" => SerializeBicep(options),
            _ => throw new FormatException($"Unsupported format {options.Format}")
        };

        SearchServiceData IModelSerializable<SearchServiceData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var document = JsonDocument.Parse(data);
            return DeserializeSearchServiceData(document.RootElement);
        }

        private BinaryData SerializeBicep(ModelSerializerOptions options)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"  name: '{Name}'");
            sb.AppendLine($"  location: '{Location}'");
            if (Optional.IsCollectionDefined(Tags) && Tags.Count > 0)
            {
                sb.AppendLine($"  tags: {{");
                foreach (var kv in Tags)
                {
                    sb.AppendLine($"    '{kv.Key}': '{kv.Value}'");
                }
                sb.AppendLine($"  }}");
            }
            if (Optional.IsDefined(Sku))
            {
                sb.AppendLine($"  sku: {{");
                sb.AppendChildObject(Sku, options, true);
                sb.AppendLine($"  }}");
            }
            if (Optional.IsDefined(Identity))
            {
                sb.AppendLine($"  identity: {{");
                sb.AppendLine($"    type: '{Identity.ManagedServiceIdentityType}'");
                sb.AppendLine($"  }}");
            }
            sb.AppendLine($"  properties: {{");
            if (Optional.IsDefined(ReplicaCount))
            {
                sb.AppendLine($"    replicaCount: {ReplicaCount.Value}");
            }
            if (Optional.IsDefined(PartitionCount))
            {
                sb.AppendLine($"    partitionCount: {PartitionCount.Value}");
            }
            if (Optional.IsDefined(HostingMode))
            {
                sb.AppendLine($"    hostingMode: '{HostingMode.Value.ToSerialString()}'");
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                sb.AppendLine($"    publicNetworkAccess: '{PublicNetworkAccess.Value.ToSerialString()}'");
            }
            if (Optional.IsDefined(NetworkRuleSet))
            {
                sb.AppendLine($"    networkRuleSet: {{");
                sb.AppendChildObject(NetworkRuleSet, options, true);
                sb.AppendLine($"    }}");
            }
            if (Optional.IsDefined(EncryptionWithCmk))
            {
                sb.AppendLine($"    encryptionWithCmk: {{");
                sb.AppendChildObject(EncryptionWithCmk, options, true);
                sb.AppendLine($"    }}");
            }
            if (IsLocalAuthDisabled.HasValue)
            {
                sb.AppendLine($"    disableLocalAuth: {IsLocalAuthDisabled.Value.ToString().ToLower()}");
            }
            else
            {
                sb.AppendLine($"    disableLocalAuth: null");
            }
            if (Optional.IsDefined(AuthOptions))
            {
                sb.AppendLine($"    authOptions: {{");
                sb.AppendChildObject(AuthOptions, options, true);
                sb.AppendLine($"    }}");
            }
            sb.AppendLine($"  }}");
            return BinaryData.FromString(sb.ToString());
        }
    }
}
