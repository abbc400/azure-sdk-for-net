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

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class IdentityAccessPermissions : IModelJsonSerializable<IdentityAccessPermissions>
    {
        void IModelJsonSerializable<IdentityAccessPermissions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => ((IUtf8JsonSerializable)this).Write(writer);

        IdentityAccessPermissions IModelJsonSerializable<IdentityAccessPermissions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            return DeserializeIdentityAccessPermissions(document.RootElement);
        }

        BinaryData IModelSerializable<IdentityAccessPermissions>.Serialize(ModelSerializerOptions options) => (options.Format.ToString()) switch
        {
            "J" or "W" => ModelSerializer.SerializeCore(this, options),
            "bicep" => SerializeBicep(options),
            _ => throw new FormatException($"Unsupported format {options.Format}")
        };

        IdentityAccessPermissions IModelSerializable<IdentityAccessPermissions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var document = JsonDocument.Parse(data);
            return DeserializeIdentityAccessPermissions(document.RootElement);
        }

        private BinaryData SerializeBicep(ModelSerializerOptions options)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{{");
            sb.AppendLine($"  secrets: [");
            foreach (var item in Secrets)
            {
                sb.AppendLine($"    '{item}'");
            }
            sb.AppendLine($"  ]");
            sb.AppendLine($"}}");
            return BinaryData.FromString(sb.ToString());
        }
    }
}
