// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxHeavySecret : IUtf8JsonSerializable, IJsonModel<DataBoxHeavySecret>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxHeavySecret>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DataBoxHeavySecret>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DeviceSerialNumber))
                {
                    writer.WritePropertyName("deviceSerialNumber"u8);
                    writer.WriteStringValue(DeviceSerialNumber);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DevicePassword))
                {
                    writer.WritePropertyName("devicePassword"u8);
                    writer.WriteStringValue(DevicePassword);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(NetworkConfigurations))
                {
                    writer.WritePropertyName("networkConfigurations"u8);
                    writer.WriteStartArray();
                    foreach (var item in NetworkConfigurations)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(EncodedValidationCertPubKey))
                {
                    writer.WritePropertyName("encodedValidationCertPubKey"u8);
                    writer.WriteStringValue(EncodedValidationCertPubKey);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(AccountCredentialDetails))
                {
                    writer.WritePropertyName("accountCredentialDetails"u8);
                    writer.WriteStartArray();
                    foreach (var item in AccountCredentialDetails)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        DataBoxHeavySecret IJsonModel<DataBoxHeavySecret>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxHeavySecret(document.RootElement, options);
        }

        internal static DataBoxHeavySecret DeserializeDataBoxHeavySecret(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deviceSerialNumber = default;
            Optional<string> devicePassword = default;
            Optional<IReadOnlyList<ApplianceNetworkConfiguration>> networkConfigurations = default;
            Optional<string> encodedValidationCertPubKey = default;
            Optional<IReadOnlyList<DataBoxAccountCredentialDetails>> accountCredentialDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceSerialNumber"u8))
                {
                    deviceSerialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("devicePassword"u8))
                {
                    devicePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplianceNetworkConfiguration> array = new List<ApplianceNetworkConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplianceNetworkConfiguration.DeserializeApplianceNetworkConfiguration(item));
                    }
                    networkConfigurations = array;
                    continue;
                }
                if (property.NameEquals("encodedValidationCertPubKey"u8))
                {
                    encodedValidationCertPubKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountCredentialDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxAccountCredentialDetails> array = new List<DataBoxAccountCredentialDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxAccountCredentialDetails.DeserializeDataBoxAccountCredentialDetails(item));
                    }
                    accountCredentialDetails = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxHeavySecret(deviceSerialNumber.Value, devicePassword.Value, Optional.ToList(networkConfigurations), encodedValidationCertPubKey.Value, Optional.ToList(accountCredentialDetails), serializedAdditionalRawData);
        }

        BinaryData IModel<DataBoxHeavySecret>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataBoxHeavySecret IModel<DataBoxHeavySecret>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataBoxHeavySecret(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DataBoxHeavySecret>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
