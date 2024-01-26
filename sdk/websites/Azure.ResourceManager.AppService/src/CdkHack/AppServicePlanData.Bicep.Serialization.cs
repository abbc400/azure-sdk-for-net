// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServicePlanData : IModelJsonSerializable<AppServicePlanData>
    {
        void IModelJsonSerializable<AppServicePlanData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => ((IUtf8JsonSerializable)this).Write(writer);

        AppServicePlanData IModelJsonSerializable<AppServicePlanData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServicePlanData(doc.RootElement);
        }

        BinaryData IModelSerializable<AppServicePlanData>.Serialize(ModelSerializerOptions options) => (options.Format.ToString()) switch
        {
            "J" or "W" => ModelSerializer.SerializeCore(this, options),
            "bicep" => SerializeBicep(options),
            _ => throw new FormatException($"Unsupported format {options.Format}")
        };

        AppServicePlanData IModelSerializable<AppServicePlanData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var document = JsonDocument.Parse(data);
            return DeserializeAppServicePlanData(document.RootElement);
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
            sb.AppendLine($"  sku: {{");
            sb.AppendChildObject(Sku, options, true);
            sb.AppendLine($"  }}");
            if (Optional.IsDefined(Kind))
            {
                sb.AppendLine($" kind: '{Kind}'");
            }
            sb.AppendLine($"  properties: {{");
            sb.AppendLine($"   reserved: {IsReserved.ToString().ToLower()}");
            sb.AppendLine($"  }}");
            return BinaryData.FromString(sb.ToString());
        }
    }
}
