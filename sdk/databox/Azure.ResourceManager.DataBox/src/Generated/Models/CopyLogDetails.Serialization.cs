// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    [ModelReaderProxy(typeof(UnknownCopyLogDetails))]
    public partial class CopyLogDetails : IUtf8JsonSerializable, IJsonModel<CopyLogDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CopyLogDetails>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<CopyLogDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("copyLogDetailsType"u8);
            writer.WriteStringValue(CopyLogDetailsType.ToSerialString());
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

        CopyLogDetails IJsonModel<CopyLogDetails>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCopyLogDetails(document.RootElement, options);
        }

        internal static CopyLogDetails DeserializeCopyLogDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("copyLogDetailsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DataBox": return DataBoxAccountCopyLogDetails.DeserializeDataBoxAccountCopyLogDetails(element);
                    case "DataBoxCustomerDisk": return DataBoxCustomerDiskCopyLogDetails.DeserializeDataBoxCustomerDiskCopyLogDetails(element);
                    case "DataBoxDisk": return DataBoxDiskCopyLogDetails.DeserializeDataBoxDiskCopyLogDetails(element);
                    case "DataBoxHeavy": return DataBoxHeavyAccountCopyLogDetails.DeserializeDataBoxHeavyAccountCopyLogDetails(element);
                }
            }
            return UnknownCopyLogDetails.DeserializeUnknownCopyLogDetails(element);
        }

        BinaryData IModel<CopyLogDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        CopyLogDetails IModel<CopyLogDetails>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeCopyLogDetails(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<CopyLogDetails>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
