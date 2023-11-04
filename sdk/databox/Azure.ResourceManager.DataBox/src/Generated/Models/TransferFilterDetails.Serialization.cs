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
    public partial class TransferFilterDetails : IUtf8JsonSerializable, IJsonModel<TransferFilterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TransferFilterDetails>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<TransferFilterDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataAccountType"u8);
            writer.WriteStringValue(DataAccountType.ToSerialString());
            if (Optional.IsDefined(BlobFilterDetails))
            {
                writer.WritePropertyName("blobFilterDetails"u8);
                writer.WriteObjectValue(BlobFilterDetails);
            }
            if (Optional.IsDefined(AzureFileFilterDetails))
            {
                writer.WritePropertyName("azureFileFilterDetails"u8);
                writer.WriteObjectValue(AzureFileFilterDetails);
            }
            if (Optional.IsCollectionDefined(FilterFileDetails))
            {
                writer.WritePropertyName("filterFileDetails"u8);
                writer.WriteStartArray();
                foreach (var item in FilterFileDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        TransferFilterDetails IJsonModel<TransferFilterDetails>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTransferFilterDetails(document.RootElement, options);
        }

        internal static TransferFilterDetails DeserializeTransferFilterDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataAccountType dataAccountType = default;
            Optional<BlobFilterDetails> blobFilterDetails = default;
            Optional<AzureFileFilterDetails> azureFileFilterDetails = default;
            Optional<IList<FilterFileDetails>> filterFileDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataAccountType"u8))
                {
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("blobFilterDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobFilterDetails = BlobFilterDetails.DeserializeBlobFilterDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("azureFileFilterDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureFileFilterDetails = AzureFileFilterDetails.DeserializeAzureFileFilterDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("filterFileDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FilterFileDetails> array = new List<FilterFileDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.FilterFileDetails.DeserializeFilterFileDetails(item));
                    }
                    filterFileDetails = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TransferFilterDetails(dataAccountType, blobFilterDetails.Value, azureFileFilterDetails.Value, Optional.ToList(filterFileDetails), serializedAdditionalRawData);
        }

        BinaryData IModel<TransferFilterDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        TransferFilterDetails IModel<TransferFilterDetails>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeTransferFilterDetails(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<TransferFilterDetails>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
