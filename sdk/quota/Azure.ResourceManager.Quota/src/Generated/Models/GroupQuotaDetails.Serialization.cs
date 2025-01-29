// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Models
{
    public partial class GroupQuotaDetails : IUtf8JsonSerializable, IJsonModel<GroupQuotaDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GroupQuotaDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GroupQuotaDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupQuotaDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GroupQuotaDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ResourceName))
            {
                writer.WritePropertyName("resourceName"u8);
                writer.WriteStringValue(ResourceName);
            }
            if (Optional.IsDefined(Limit))
            {
                writer.WritePropertyName("limit"u8);
                writer.WriteNumberValue(Limit.Value);
            }
            if (Optional.IsDefined(Comment))
            {
                writer.WritePropertyName("comment"u8);
                writer.WriteStringValue(Comment);
            }
            if (options.Format != "W" && Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (options.Format != "W" && Optional.IsDefined(AvailableLimit))
            {
                writer.WritePropertyName("availableLimit"u8);
                writer.WriteNumberValue(AvailableLimit.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AllocatedToSubscriptions))
            {
                writer.WritePropertyName("allocatedToSubscriptions"u8);
                writer.WriteObjectValue(AllocatedToSubscriptions, options);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LocalizedValue))
            {
                writer.WritePropertyName("localizedValue"u8);
                writer.WriteStringValue(LocalizedValue);
            }
            writer.WriteEndObject();
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

        GroupQuotaDetails IJsonModel<GroupQuotaDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupQuotaDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GroupQuotaDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGroupQuotaDetails(document.RootElement, options);
        }

        internal static GroupQuotaDetails DeserializeGroupQuotaDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceName = default;
            long? limit = default;
            string comment = default;
            string unit = default;
            long? availableLimit = default;
            AllocatedQuotaToSubscriptionList allocatedToSubscriptions = default;
            string value = default;
            string localizedValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceName"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("comment"u8))
                {
                    comment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availableLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableLimit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("allocatedToSubscriptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocatedToSubscriptions = AllocatedQuotaToSubscriptionList.DeserializeAllocatedQuotaToSubscriptionList(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("value"u8))
                        {
                            value = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("localizedValue"u8))
                        {
                            localizedValue = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GroupQuotaDetails(
                resourceName,
                limit,
                comment,
                unit,
                availableLimit,
                allocatedToSubscriptions,
                value,
                localizedValue,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  resourceName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceName))
                {
                    builder.Append("  resourceName: ");
                    if (ResourceName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ResourceName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ResourceName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Limit), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  limit: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Limit))
                {
                    builder.Append("  limit: ");
                    builder.AppendLine($"'{Limit.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Comment), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  comment: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Comment))
                {
                    builder.Append("  comment: ");
                    if (Comment.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Comment}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Comment}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Unit), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  unit: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Unit))
                {
                    builder.Append("  unit: ");
                    if (Unit.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Unit}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Unit}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AvailableLimit), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  availableLimit: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AvailableLimit))
                {
                    builder.Append("  availableLimit: ");
                    builder.AppendLine($"'{AvailableLimit.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("AllocatedToSubscriptionsValue", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  allocatedToSubscriptions: ");
                builder.AppendLine("{");
                builder.Append("    value: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(AllocatedToSubscriptions))
                {
                    builder.Append("  allocatedToSubscriptions: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AllocatedToSubscriptions, options, 2, false, "  allocatedToSubscriptions: ");
                }
            }

            builder.Append("  name:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Value), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    value: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Value))
                {
                    builder.Append("    value: ");
                    if (Value.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Value}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Value}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LocalizedValue), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    localizedValue: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LocalizedValue))
                {
                    builder.Append("    localizedValue: ");
                    if (LocalizedValue.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LocalizedValue}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LocalizedValue}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<GroupQuotaDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupQuotaDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(GroupQuotaDetails)} does not support writing '{options.Format}' format.");
            }
        }

        GroupQuotaDetails IPersistableModel<GroupQuotaDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupQuotaDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGroupQuotaDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GroupQuotaDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GroupQuotaDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
