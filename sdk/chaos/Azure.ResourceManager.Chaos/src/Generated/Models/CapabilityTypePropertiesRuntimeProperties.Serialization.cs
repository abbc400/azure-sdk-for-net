// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    internal partial class CapabilityTypePropertiesRuntimeProperties : IUtf8JsonSerializable, IJsonModel<CapabilityTypePropertiesRuntimeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CapabilityTypePropertiesRuntimeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CapabilityTypePropertiesRuntimeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapabilityTypePropertiesRuntimeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CapabilityTypePropertiesRuntimeProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
        }

        CapabilityTypePropertiesRuntimeProperties IJsonModel<CapabilityTypePropertiesRuntimeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapabilityTypePropertiesRuntimeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CapabilityTypePropertiesRuntimeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCapabilityTypePropertiesRuntimeProperties(document.RootElement, options);
        }

        internal static CapabilityTypePropertiesRuntimeProperties DeserializeCapabilityTypePropertiesRuntimeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CapabilityTypePropertiesRuntimeProperties(kind, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CapabilityTypePropertiesRuntimeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapabilityTypePropertiesRuntimeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CapabilityTypePropertiesRuntimeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        CapabilityTypePropertiesRuntimeProperties IPersistableModel<CapabilityTypePropertiesRuntimeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapabilityTypePropertiesRuntimeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCapabilityTypePropertiesRuntimeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CapabilityTypePropertiesRuntimeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CapabilityTypePropertiesRuntimeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
