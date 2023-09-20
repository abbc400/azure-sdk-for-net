// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.CognitiveServices
{
    public partial class CognitiveServicesAccountData : IModelJsonSerializable<CognitiveServicesAccountData>
    {
        void IModelJsonSerializable<CognitiveServicesAccountData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => ((IUtf8JsonSerializable)this).Write(writer);

        CognitiveServicesAccountData IModelJsonSerializable<CognitiveServicesAccountData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCognitiveServicesAccountData(doc.RootElement);
        }

        BinaryData IModelSerializable<CognitiveServicesAccountData>.Serialize(ModelSerializerOptions options) => (options.Format.ToString()) switch
        {
            "J" or "W" => ModelSerializer.SerializeCore(this, options),
            "bicep" => SerializeBicep(options),
            _ => throw new FormatException($"Unsupported format {options.Format}")
        };

        CognitiveServicesAccountData IModelSerializable<CognitiveServicesAccountData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var document = JsonDocument.Parse(data);
            return DeserializeCognitiveServicesAccountData(document.RootElement);
        }

        private BinaryData SerializeBicep(ModelSerializerOptions options)
        {
            StringBuilder sb = new StringBuilder();
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
            sb.AppendLine($"  sku: {{");
            sb.AppendChildObject(Sku, options, true);
            sb.AppendLine($"  }}");
            sb.AppendLine($"  kind: '{Kind}'");
            sb.AppendLine($"  properties: {{");
            sb.AppendChildObject(Properties, options, true);
            sb.AppendLine($"  }}");
            if(Optional.IsDefined(Identity)){
                sb.AppendLine($"  identity: {{");
                sb.AppendLine($"    type: '{Identity.ManagedServiceIdentityType}'");
                if(Optional.IsDefined(Identity.UserAssignedIdentities)){
                    sb.AppendLine($"    userAssignedIdentities: {{");
                    foreach(var kv in Identity.UserAssignedIdentities){
                        sb.AppendLine($"      '{kv.Key}': {{}}");
                    }
                    sb.AppendLine($"    }}");
                }
                sb.AppendLine($"  }}");
            }
            return BinaryData.FromString(sb.ToString());
        }
    }
}
