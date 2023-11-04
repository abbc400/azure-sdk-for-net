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
    public partial class RegionConfigurationResult : IUtf8JsonSerializable, IJsonModel<RegionConfigurationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RegionConfigurationResult>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RegionConfigurationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ScheduleAvailabilityResponse))
                {
                    writer.WritePropertyName("scheduleAvailabilityResponse"u8);
                    writer.WriteObjectValue(ScheduleAvailabilityResponse);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(TransportAvailabilityResponse))
                {
                    writer.WritePropertyName("transportAvailabilityResponse"u8);
                    writer.WriteObjectValue(TransportAvailabilityResponse);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DataCenterAddressResponse))
                {
                    writer.WritePropertyName("datacenterAddressResponse"u8);
                    writer.WriteObjectValue(DataCenterAddressResponse);
                }
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

        RegionConfigurationResult IJsonModel<RegionConfigurationResult>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRegionConfigurationResult(document.RootElement, options);
        }

        internal static RegionConfigurationResult DeserializeRegionConfigurationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ScheduleAvailabilityResponse> scheduleAvailabilityResponse = default;
            Optional<TransportAvailabilityResponse> transportAvailabilityResponse = default;
            Optional<DataCenterAddressResult> dataCenterAddressResponse = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleAvailabilityResponse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleAvailabilityResponse = ScheduleAvailabilityResponse.DeserializeScheduleAvailabilityResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("transportAvailabilityResponse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transportAvailabilityResponse = TransportAvailabilityResponse.DeserializeTransportAvailabilityResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("datacenterAddressResponse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAddressResponse = DataCenterAddressResult.DeserializeDataCenterAddressResult(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RegionConfigurationResult(scheduleAvailabilityResponse.Value, transportAvailabilityResponse.Value, dataCenterAddressResponse.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<RegionConfigurationResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RegionConfigurationResult IModel<RegionConfigurationResult>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRegionConfigurationResult(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RegionConfigurationResult>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
