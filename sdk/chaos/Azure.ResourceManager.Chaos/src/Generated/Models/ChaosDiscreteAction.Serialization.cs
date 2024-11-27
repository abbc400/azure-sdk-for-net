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
    public partial class ChaosDiscreteAction : IUtf8JsonSerializable, IJsonModel<ChaosDiscreteAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChaosDiscreteAction>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ChaosDiscreteAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosDiscreteAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosDiscreteAction)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("parameters"u8);
            writer.WriteStartArray();
            foreach (var item in Parameters)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("selectorId"u8);
            writer.WriteStringValue(SelectorId);
        }

        ChaosDiscreteAction IJsonModel<ChaosDiscreteAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosDiscreteAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosDiscreteAction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChaosDiscreteAction(document.RootElement, options);
        }

        internal static ChaosDiscreteAction DeserializeChaosDiscreteAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ChaosKeyValuePair> parameters = default;
            string selectorId = default;
            string name = default;
            ExperimentActionType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    List<ChaosKeyValuePair> array = new List<ChaosKeyValuePair>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChaosKeyValuePair.DeserializeChaosKeyValuePair(item, options));
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("selectorId"u8))
                {
                    selectorId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ExperimentActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ChaosDiscreteAction(name, type, serializedAdditionalRawData, parameters, selectorId);
        }

        BinaryData IPersistableModel<ChaosDiscreteAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosDiscreteAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChaosDiscreteAction)} does not support writing '{options.Format}' format.");
            }
        }

        ChaosDiscreteAction IPersistableModel<ChaosDiscreteAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosDiscreteAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChaosDiscreteAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChaosDiscreteAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChaosDiscreteAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
