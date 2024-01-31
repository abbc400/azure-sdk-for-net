// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapAvailabilityZonePair : IUtf8JsonSerializable, IJsonModel<SapAvailabilityZonePair>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapAvailabilityZonePair>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SapAvailabilityZonePair>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapAvailabilityZonePair>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapAvailabilityZonePair)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ZoneA))
            {
                writer.WritePropertyName("zoneA"u8);
                writer.WriteNumberValue(ZoneA.Value);
            }
            if (Optional.IsDefined(ZoneB))
            {
                writer.WritePropertyName("zoneB"u8);
                writer.WriteNumberValue(ZoneB.Value);
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
            writer.WriteEndObject();
        }

        SapAvailabilityZonePair IJsonModel<SapAvailabilityZonePair>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapAvailabilityZonePair>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapAvailabilityZonePair)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapAvailabilityZonePair(document.RootElement, options);
        }

        internal static SapAvailabilityZonePair DeserializeSapAvailabilityZonePair(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> zoneA = default;
            Optional<long> zoneB = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zoneA"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneA = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("zoneB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneB = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SapAvailabilityZonePair(Optional.ToNullable(zoneA), Optional.ToNullable(zoneB), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapAvailabilityZonePair>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapAvailabilityZonePair>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SapAvailabilityZonePair)} does not support '{options.Format}' format.");
            }
        }

        SapAvailabilityZonePair IPersistableModel<SapAvailabilityZonePair>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapAvailabilityZonePair>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapAvailabilityZonePair(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapAvailabilityZonePair)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapAvailabilityZonePair>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
