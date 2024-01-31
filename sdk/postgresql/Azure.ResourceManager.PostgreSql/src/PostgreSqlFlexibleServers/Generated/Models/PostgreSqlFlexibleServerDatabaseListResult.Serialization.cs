// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PostgreSql.FlexibleServers;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    internal partial class PostgreSqlFlexibleServerDatabaseListResult : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerDatabaseListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerDatabaseListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlFlexibleServerDatabaseListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerDatabaseListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDatabaseListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink.AbsoluteUri);
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

        PostgreSqlFlexibleServerDatabaseListResult IJsonModel<PostgreSqlFlexibleServerDatabaseListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerDatabaseListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDatabaseListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerDatabaseListResult(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerDatabaseListResult DeserializePostgreSqlFlexibleServerDatabaseListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PostgreSqlFlexibleServerDatabaseData>> value = default;
            Optional<Uri> nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerDatabaseData> array = new List<PostgreSqlFlexibleServerDatabaseData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerDatabaseData.DeserializePostgreSqlFlexibleServerDatabaseData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlFlexibleServerDatabaseListResult(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerDatabaseListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerDatabaseListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDatabaseListResult)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerDatabaseListResult IPersistableModel<PostgreSqlFlexibleServerDatabaseListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerDatabaseListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlFlexibleServerDatabaseListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDatabaseListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerDatabaseListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
