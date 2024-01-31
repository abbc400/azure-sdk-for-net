// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorItsmReceiver : IUtf8JsonSerializable, IJsonModel<MonitorItsmReceiver>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorItsmReceiver>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorItsmReceiver>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorItsmReceiver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorItsmReceiver)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("workspaceId"u8);
            writer.WriteStringValue(WorkspaceId);
            writer.WritePropertyName("connectionId"u8);
            writer.WriteStringValue(ConnectionId);
            writer.WritePropertyName("ticketConfiguration"u8);
            writer.WriteStringValue(TicketConfiguration);
            writer.WritePropertyName("region"u8);
            writer.WriteStringValue(Region);
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

        MonitorItsmReceiver IJsonModel<MonitorItsmReceiver>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorItsmReceiver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorItsmReceiver)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorItsmReceiver(document.RootElement, options);
        }

        internal static MonitorItsmReceiver DeserializeMonitorItsmReceiver(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string workspaceId = default;
            string connectionId = default;
            string ticketConfiguration = default;
            AzureLocation region = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionId"u8))
                {
                    connectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ticketConfiguration"u8))
                {
                    ticketConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorItsmReceiver(name, workspaceId, connectionId, ticketConfiguration, region, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorItsmReceiver>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorItsmReceiver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorItsmReceiver)} does not support '{options.Format}' format.");
            }
        }

        MonitorItsmReceiver IPersistableModel<MonitorItsmReceiver>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorItsmReceiver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorItsmReceiver(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorItsmReceiver)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorItsmReceiver>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
