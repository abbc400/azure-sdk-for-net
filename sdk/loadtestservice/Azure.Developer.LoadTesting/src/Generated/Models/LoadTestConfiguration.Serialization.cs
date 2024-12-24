// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    public partial class LoadTestConfiguration : IUtf8JsonSerializable, IJsonModel<LoadTestConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadTestConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LoadTestConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadTestConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(EngineInstances))
            {
                writer.WritePropertyName("engineInstances"u8);
                writer.WriteNumberValue(EngineInstances.Value);
            }
            if (Optional.IsDefined(SplitAllCSVs))
            {
                writer.WritePropertyName("splitAllCSVs"u8);
                writer.WriteBooleanValue(SplitAllCSVs.Value);
            }
            if (Optional.IsDefined(QuickStartTest))
            {
                writer.WritePropertyName("quickStartTest"u8);
                writer.WriteBooleanValue(QuickStartTest.Value);
            }
            if (Optional.IsDefined(OptionalLoadTestConfig))
            {
                writer.WritePropertyName("optionalLoadTestConfig"u8);
                writer.WriteObjectValue(OptionalLoadTestConfig, options);
            }
            if (Optional.IsCollectionDefined(RegionalLoadTestConfig))
            {
                writer.WritePropertyName("regionalLoadTestConfig"u8);
                writer.WriteStartArray();
                foreach (var item in RegionalLoadTestConfig)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        LoadTestConfiguration IJsonModel<LoadTestConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadTestConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadTestConfiguration(document.RootElement, options);
        }

        internal static LoadTestConfiguration DeserializeLoadTestConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? engineInstances = default;
            bool? splitAllCSVs = default;
            bool? quickStartTest = default;
            OptionalLoadTestConfig optionalLoadTestConfig = default;
            IList<RegionalConfiguration> regionalLoadTestConfig = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("engineInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    engineInstances = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("splitAllCSVs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    splitAllCSVs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("quickStartTest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quickStartTest = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("optionalLoadTestConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionalLoadTestConfig = OptionalLoadTestConfig.DeserializeOptionalLoadTestConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("regionalLoadTestConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RegionalConfiguration> array = new List<RegionalConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RegionalConfiguration.DeserializeRegionalConfiguration(item, options));
                    }
                    regionalLoadTestConfig = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LoadTestConfiguration(
                engineInstances,
                splitAllCSVs,
                quickStartTest,
                optionalLoadTestConfig,
                regionalLoadTestConfig ?? new ChangeTrackingList<RegionalConfiguration>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LoadTestConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LoadTestConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        LoadTestConfiguration IPersistableModel<LoadTestConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLoadTestConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LoadTestConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LoadTestConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LoadTestConfiguration FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLoadTestConfiguration(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
