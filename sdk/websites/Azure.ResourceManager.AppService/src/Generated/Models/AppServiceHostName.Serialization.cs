// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceHostName : IUtf8JsonSerializable, IJsonModel<AppServiceHostName>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceHostName>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceHostName>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceHostName>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceHostName)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(SiteNames))
            {
                writer.WritePropertyName("siteNames"u8);
                writer.WriteStartArray();
                foreach (var item in SiteNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AzureResourceName))
            {
                writer.WritePropertyName("azureResourceName"u8);
                writer.WriteStringValue(AzureResourceName);
            }
            if (Optional.IsDefined(AzureResourceType))
            {
                writer.WritePropertyName("azureResourceType"u8);
                writer.WriteStringValue(AzureResourceType.Value.ToSerialString());
            }
            if (Optional.IsDefined(CustomHostNameDnsRecordType))
            {
                writer.WritePropertyName("customHostNameDnsRecordType"u8);
                writer.WriteStringValue(CustomHostNameDnsRecordType.Value.ToSerialString());
            }
            if (Optional.IsDefined(HostNameType))
            {
                writer.WritePropertyName("hostNameType"u8);
                writer.WriteStringValue(HostNameType.Value.ToSerialString());
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

        AppServiceHostName IJsonModel<AppServiceHostName>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceHostName>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceHostName)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceHostName(document.RootElement, options);
        }

        internal static AppServiceHostName DeserializeAppServiceHostName(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<string>> siteNames = default;
            Optional<string> azureResourceName = default;
            Optional<AppServiceResourceType> azureResourceType = default;
            Optional<CustomHostNameDnsRecordType> customHostNameDnsRecordType = default;
            Optional<AppServiceHostNameType> hostNameType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("siteNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    siteNames = array;
                    continue;
                }
                if (property.NameEquals("azureResourceName"u8))
                {
                    azureResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureResourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureResourceType = property.Value.GetString().ToAppServiceResourceType();
                    continue;
                }
                if (property.NameEquals("customHostNameDnsRecordType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customHostNameDnsRecordType = property.Value.GetString().ToCustomHostNameDnsRecordType();
                    continue;
                }
                if (property.NameEquals("hostNameType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostNameType = property.Value.GetString().ToAppServiceHostNameType();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceHostName(name.Value, Optional.ToList(siteNames), azureResourceName.Value, Optional.ToNullable(azureResourceType), Optional.ToNullable(customHostNameDnsRecordType), Optional.ToNullable(hostNameType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceHostName>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceHostName>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceHostName)} does not support '{options.Format}' format.");
            }
        }

        AppServiceHostName IPersistableModel<AppServiceHostName>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceHostName>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceHostName(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceHostName)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceHostName>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
