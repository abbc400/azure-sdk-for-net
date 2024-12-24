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
    public partial class TestRunFileInfo : IUtf8JsonSerializable, IJsonModel<TestRunFileInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TestRunFileInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TestRunFileInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestRunFileInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TestRunFileInfo)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("fileName"u8);
            writer.WriteStringValue(FileName);
            if (options.Format != "W" && Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(FileType))
            {
                writer.WritePropertyName("fileType"u8);
                writer.WriteStringValue(FileType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireDateTime))
            {
                writer.WritePropertyName("expireDateTime"u8);
                writer.WriteStringValue(ExpireDateTime.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ValidationStatus))
            {
                writer.WritePropertyName("validationStatus"u8);
                writer.WriteStringValue(ValidationStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ValidationFailureDetails))
            {
                writer.WritePropertyName("validationFailureDetails"u8);
                writer.WriteStringValue(ValidationFailureDetails);
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

        TestRunFileInfo IJsonModel<TestRunFileInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestRunFileInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TestRunFileInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTestRunFileInfo(document.RootElement, options);
        }

        internal static TestRunFileInfo DeserializeTestRunFileInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fileName = default;
            Uri url = default;
            FileType? fileType = default;
            DateTimeOffset? expireDateTime = default;
            FileStatus? validationStatus = default;
            string validationFailureDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileName"u8))
                {
                    fileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fileType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileType = new FileType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expireDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expireDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("validationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationStatus = new FileStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("validationFailureDetails"u8))
                {
                    validationFailureDetails = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TestRunFileInfo(
                fileName,
                url,
                fileType,
                expireDateTime,
                validationStatus,
                validationFailureDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TestRunFileInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestRunFileInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TestRunFileInfo)} does not support writing '{options.Format}' format.");
            }
        }

        TestRunFileInfo IPersistableModel<TestRunFileInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestRunFileInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTestRunFileInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TestRunFileInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TestRunFileInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TestRunFileInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTestRunFileInfo(document.RootElement);
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
