// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaServicesAccountPatch : IUtf8JsonSerializable, IJsonModel<MediaServicesAccountPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaServicesAccountPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaServicesAccountPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaServicesAccountPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaServicesAccountPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(MediaServiceId))
            {
                writer.WritePropertyName("mediaServiceId"u8);
                writer.WriteStringValue(MediaServiceId.Value);
            }
            if (Optional.IsCollectionDefined(StorageAccounts))
            {
                writer.WritePropertyName("storageAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in StorageAccounts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StorageAuthentication))
            {
                if (StorageAuthentication != null)
                {
                    writer.WritePropertyName("storageAuthentication"u8);
                    writer.WriteStringValue(StorageAuthentication.Value.ToString());
                }
                else
                {
                    writer.WriteNull("storageAuthentication");
                }
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(KeyDelivery))
            {
                writer.WritePropertyName("keyDelivery"u8);
                writer.WriteObjectValue(KeyDelivery);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                if (PublicNetworkAccess != null)
                {
                    writer.WritePropertyName("publicNetworkAccess"u8);
                    writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
                }
                else
                {
                    writer.WriteNull("publicNetworkAccess");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MediaServicesAccountPatch IJsonModel<MediaServicesAccountPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaServicesAccountPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaServicesAccountPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaServicesAccountPatch(document.RootElement, options);
        }

        internal static MediaServicesAccountPatch DeserializeMediaServicesAccountPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<Guid> mediaServiceId = default;
            Optional<IList<MediaServicesStorageAccount>> storageAccounts = default;
            Optional<MediaStorageAuthentication?> storageAuthentication = default;
            Optional<AccountEncryption> encryption = default;
            Optional<MediaKeyDelivery> keyDelivery = default;
            Optional<MediaServicesPublicNetworkAccess?> publicNetworkAccess = default;
            Optional<MediaServicesProvisioningState> provisioningState = default;
            Optional<IReadOnlyList<MediaServicesPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<MediaServicesMinimumTlsVersion> minimumTlsVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("mediaServiceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mediaServiceId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("storageAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MediaServicesStorageAccount> array = new List<MediaServicesStorageAccount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MediaServicesStorageAccount.DeserializeMediaServicesStorageAccount(item));
                            }
                            storageAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("storageAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                storageAuthentication = null;
                                continue;
                            }
                            storageAuthentication = new MediaStorageAuthentication(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = AccountEncryption.DeserializeAccountEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("keyDelivery"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyDelivery = MediaKeyDelivery.DeserializeMediaKeyDelivery(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                publicNetworkAccess = null;
                                continue;
                            }
                            publicNetworkAccess = new MediaServicesPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MediaServicesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MediaServicesPrivateEndpointConnectionData> array = new List<MediaServicesPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MediaServicesPrivateEndpointConnectionData.DeserializeMediaServicesPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTlsVersion = new MediaServicesMinimumTlsVersion(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaServicesAccountPatch(Optional.ToDictionary(tags), identity, Optional.ToNullable(mediaServiceId), Optional.ToList(storageAccounts), Optional.ToNullable(storageAuthentication), encryption.Value, keyDelivery.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(provisioningState), Optional.ToList(privateEndpointConnections), Optional.ToNullable(minimumTlsVersion), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaServicesAccountPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaServicesAccountPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaServicesAccountPatch)} does not support '{options.Format}' format.");
            }
        }

        MediaServicesAccountPatch IPersistableModel<MediaServicesAccountPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaServicesAccountPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaServicesAccountPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaServicesAccountPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaServicesAccountPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
