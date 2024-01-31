// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class ImportRedisEnterpriseDatabaseContent : IUtf8JsonSerializable, IJsonModel<ImportRedisEnterpriseDatabaseContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImportRedisEnterpriseDatabaseContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImportRedisEnterpriseDatabaseContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportRedisEnterpriseDatabaseContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImportRedisEnterpriseDatabaseContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sasUris"u8);
            writer.WriteStartArray();
            foreach (var item in SasUris)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item.AbsoluteUri);
            }
            writer.WriteEndArray();
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

        ImportRedisEnterpriseDatabaseContent IJsonModel<ImportRedisEnterpriseDatabaseContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportRedisEnterpriseDatabaseContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImportRedisEnterpriseDatabaseContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImportRedisEnterpriseDatabaseContent(document.RootElement, options);
        }

        internal static ImportRedisEnterpriseDatabaseContent DeserializeImportRedisEnterpriseDatabaseContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<Uri> sasUris = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUris"u8))
                {
                    List<Uri> array = new List<Uri>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new Uri(item.GetString()));
                        }
                    }
                    sasUris = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImportRedisEnterpriseDatabaseContent(sasUris, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImportRedisEnterpriseDatabaseContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportRedisEnterpriseDatabaseContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImportRedisEnterpriseDatabaseContent)} does not support '{options.Format}' format.");
            }
        }

        ImportRedisEnterpriseDatabaseContent IPersistableModel<ImportRedisEnterpriseDatabaseContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportRedisEnterpriseDatabaseContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImportRedisEnterpriseDatabaseContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImportRedisEnterpriseDatabaseContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImportRedisEnterpriseDatabaseContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
