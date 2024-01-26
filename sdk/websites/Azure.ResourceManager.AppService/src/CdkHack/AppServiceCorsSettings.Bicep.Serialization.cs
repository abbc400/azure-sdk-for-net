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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceCorsSettings : IModelJsonSerializable<AppServiceCorsSettings>
    {
        void IModelJsonSerializable<AppServiceCorsSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => ((IUtf8JsonSerializable)this).Write(writer);

        AppServiceCorsSettings IModelJsonSerializable<AppServiceCorsSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceCorsSettings(doc.RootElement);
        }

        BinaryData IModelSerializable<AppServiceCorsSettings>.Serialize(ModelSerializerOptions options) => (options.Format.ToString()) switch
        {
            "J" or "W" => ModelSerializer.SerializeCore(this, options),
            "bicep" => SerializeBicep(options),
            _ => throw new FormatException($"Unsupported format {options.Format}")
        };

        AppServiceCorsSettings IModelSerializable<AppServiceCorsSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var document = JsonDocument.Parse(data);
            return DeserializeAppServiceCorsSettings(document.RootElement);
        }

        private BinaryData SerializeBicep(ModelSerializerOptions options)
        {
            var sb = new StringBuilder();
            if (Optional.IsCollectionDefined(AllowedOrigins))
            {
                sb.AppendLine($"  allowedOrigins: [");
                foreach (var origin in AllowedOrigins)
                {
                    sb.AppendLine($"    '{origin}'");
                }
                sb.AppendLine($"  ]");
            }
            return BinaryData.FromString(sb.ToString());
        }
    }
}
