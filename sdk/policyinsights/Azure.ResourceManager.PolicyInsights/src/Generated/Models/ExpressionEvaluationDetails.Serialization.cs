// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class ExpressionEvaluationDetails : IUtf8JsonSerializable, IJsonModel<ExpressionEvaluationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressionEvaluationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExpressionEvaluationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressionEvaluationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressionEvaluationDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Result))
            {
                writer.WritePropertyName("result"u8);
                writer.WriteStringValue(Result);
            }
            if (Optional.IsDefined(Expression))
            {
                writer.WritePropertyName("expression"u8);
                writer.WriteStringValue(Expression);
            }
            if (options.Format != "W" && Optional.IsDefined(ExpressionKind))
            {
                writer.WritePropertyName("expressionKind"u8);
                writer.WriteStringValue(ExpressionKind);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(ExpressionValue))
            {
                writer.WritePropertyName("expressionValue"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ExpressionValue);
#else
                using (JsonDocument document = JsonDocument.Parse(ExpressionValue))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(TargetValue))
            {
                writer.WritePropertyName("targetValue"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TargetValue);
#else
                using (JsonDocument document = JsonDocument.Parse(TargetValue))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator"u8);
                writer.WriteStringValue(Operator);
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

        ExpressionEvaluationDetails IJsonModel<ExpressionEvaluationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressionEvaluationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressionEvaluationDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressionEvaluationDetails(document.RootElement, options);
        }

        internal static ExpressionEvaluationDetails DeserializeExpressionEvaluationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> result = default;
            Optional<string> expression = default;
            Optional<string> expressionKind = default;
            Optional<string> path = default;
            Optional<BinaryData> expressionValue = default;
            Optional<BinaryData> targetValue = default;
            Optional<string> @operator = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("result"u8))
                {
                    result = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expressionKind"u8))
                {
                    expressionKind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expressionValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expressionValue = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("targetValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetValue = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    @operator = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExpressionEvaluationDetails(result.Value, expression.Value, expressionKind.Value, path.Value, expressionValue.Value, targetValue.Value, @operator.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpressionEvaluationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressionEvaluationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExpressionEvaluationDetails)} does not support '{options.Format}' format.");
            }
        }

        ExpressionEvaluationDetails IPersistableModel<ExpressionEvaluationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressionEvaluationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExpressionEvaluationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressionEvaluationDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressionEvaluationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
