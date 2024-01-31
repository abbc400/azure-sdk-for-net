// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class RangeBasedItemLevelRestoreCriteria : IUtf8JsonSerializable, IJsonModel<RangeBasedItemLevelRestoreCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RangeBasedItemLevelRestoreCriteria>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RangeBasedItemLevelRestoreCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RangeBasedItemLevelRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RangeBasedItemLevelRestoreCriteria)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MinMatchingValue))
            {
                writer.WritePropertyName("minMatchingValue"u8);
                writer.WriteStringValue(MinMatchingValue);
            }
            if (Optional.IsDefined(MaxMatchingValue))
            {
                writer.WritePropertyName("maxMatchingValue"u8);
                writer.WriteStringValue(MaxMatchingValue);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        RangeBasedItemLevelRestoreCriteria IJsonModel<RangeBasedItemLevelRestoreCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RangeBasedItemLevelRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RangeBasedItemLevelRestoreCriteria)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRangeBasedItemLevelRestoreCriteria(document.RootElement, options);
        }

        internal static RangeBasedItemLevelRestoreCriteria DeserializeRangeBasedItemLevelRestoreCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> minMatchingValue = default;
            Optional<string> maxMatchingValue = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minMatchingValue"u8))
                {
                    minMatchingValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxMatchingValue"u8))
                {
                    maxMatchingValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RangeBasedItemLevelRestoreCriteria(objectType, serializedAdditionalRawData, minMatchingValue.Value, maxMatchingValue.Value);
        }

        BinaryData IPersistableModel<RangeBasedItemLevelRestoreCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RangeBasedItemLevelRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RangeBasedItemLevelRestoreCriteria)} does not support '{options.Format}' format.");
            }
        }

        RangeBasedItemLevelRestoreCriteria IPersistableModel<RangeBasedItemLevelRestoreCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RangeBasedItemLevelRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRangeBasedItemLevelRestoreCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RangeBasedItemLevelRestoreCriteria)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RangeBasedItemLevelRestoreCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
