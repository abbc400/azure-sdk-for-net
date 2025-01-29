// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetProperties : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualMachineScaleSetProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(UpgradePolicy))
            {
                writer.WritePropertyName("upgradePolicy"u8);
                writer.WriteObjectValue(UpgradePolicy, options);
            }
            if (Optional.IsDefined(ScheduledEventsPolicy))
            {
                writer.WritePropertyName("scheduledEventsPolicy"u8);
                writer.WriteObjectValue(ScheduledEventsPolicy, options);
            }
            if (Optional.IsDefined(AutomaticRepairsPolicy))
            {
                writer.WritePropertyName("automaticRepairsPolicy"u8);
                writer.WriteObjectValue(AutomaticRepairsPolicy, options);
            }
            if (Optional.IsDefined(VirtualMachineProfile))
            {
                writer.WritePropertyName("virtualMachineProfile"u8);
                writer.WriteObjectValue(VirtualMachineProfile, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(Overprovision))
            {
                writer.WritePropertyName("overprovision"u8);
                writer.WriteBooleanValue(Overprovision.Value);
            }
            if (Optional.IsDefined(DoNotRunExtensionsOnOverprovisionedVms))
            {
                writer.WritePropertyName("doNotRunExtensionsOnOverprovisionedVMs"u8);
                writer.WriteBooleanValue(DoNotRunExtensionsOnOverprovisionedVms.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(UniqueId))
            {
                writer.WritePropertyName("uniqueId"u8);
                writer.WriteStringValue(UniqueId);
            }
            if (Optional.IsDefined(SinglePlacementGroup))
            {
                writer.WritePropertyName("singlePlacementGroup"u8);
                writer.WriteBooleanValue(SinglePlacementGroup.Value);
            }
            if (Optional.IsDefined(ZoneBalance))
            {
                writer.WritePropertyName("zoneBalance"u8);
                writer.WriteBooleanValue(ZoneBalance.Value);
            }
            if (Optional.IsDefined(PlatformFaultDomainCount))
            {
                writer.WritePropertyName("platformFaultDomainCount"u8);
                writer.WriteNumberValue(PlatformFaultDomainCount.Value);
            }
            if (Optional.IsDefined(ProximityPlacementGroup))
            {
                writer.WritePropertyName("proximityPlacementGroup"u8);
                JsonSerializer.Serialize(writer, ProximityPlacementGroup);
            }
            if (Optional.IsDefined(HostGroup))
            {
                writer.WritePropertyName("hostGroup"u8);
                JsonSerializer.Serialize(writer, HostGroup);
            }
            if (Optional.IsDefined(AdditionalCapabilities))
            {
                writer.WritePropertyName("additionalCapabilities"u8);
                writer.WriteObjectValue(AdditionalCapabilities, options);
            }
            if (Optional.IsDefined(ScaleInPolicy))
            {
                writer.WritePropertyName("scaleInPolicy"u8);
                writer.WriteObjectValue(ScaleInPolicy, options);
            }
            if (Optional.IsDefined(OrchestrationMode))
            {
                writer.WritePropertyName("orchestrationMode"u8);
                writer.WriteStringValue(OrchestrationMode.Value.ToString());
            }
            if (Optional.IsDefined(SpotRestorePolicy))
            {
                writer.WritePropertyName("spotRestorePolicy"u8);
                writer.WriteObjectValue(SpotRestorePolicy, options);
            }
            if (Optional.IsDefined(PriorityMixPolicy))
            {
                writer.WritePropertyName("priorityMixPolicy"u8);
                writer.WriteObjectValue(PriorityMixPolicy, options);
            }
            if (options.Format != "W" && Optional.IsDefined(TimeCreated))
            {
                writer.WritePropertyName("timeCreated"u8);
                writer.WriteStringValue(TimeCreated.Value, "O");
            }
            if (Optional.IsDefined(IsMaximumCapacityConstrained))
            {
                writer.WritePropertyName("constrainedMaximumCapacity"u8);
                writer.WriteBooleanValue(IsMaximumCapacityConstrained.Value);
            }
            if (Optional.IsDefined(ResiliencyPolicy))
            {
                writer.WritePropertyName("resiliencyPolicy"u8);
                writer.WriteObjectValue(ResiliencyPolicy, options);
            }
            if (Optional.IsDefined(ZonalPlatformFaultDomainAlignMode))
            {
                writer.WritePropertyName("zonalPlatformFaultDomainAlignMode"u8);
                writer.WriteStringValue(ZonalPlatformFaultDomainAlignMode.Value.ToString());
            }
            if (Optional.IsDefined(SkuProfile))
            {
                writer.WritePropertyName("skuProfile"u8);
                writer.WriteObjectValue(SkuProfile, options);
            }
            foreach (var item in AdditionalProperties)
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

        VirtualMachineScaleSetProperties IJsonModel<VirtualMachineScaleSetProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetProperties(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetProperties DeserializeVirtualMachineScaleSetProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VirtualMachineScaleSetUpgradePolicy upgradePolicy = default;
            ScheduledEventsPolicy scheduledEventsPolicy = default;
            AutomaticRepairsPolicy automaticRepairsPolicy = default;
            VirtualMachineScaleSetVmProfile virtualMachineProfile = default;
            string provisioningState = default;
            bool? overprovision = default;
            bool? doNotRunExtensionsOnOverprovisionedVms = default;
            string uniqueId = default;
            bool? singlePlacementGroup = default;
            bool? zoneBalance = default;
            int? platformFaultDomainCount = default;
            WritableSubResource proximityPlacementGroup = default;
            WritableSubResource hostGroup = default;
            AdditionalCapabilities additionalCapabilities = default;
            ScaleInPolicy scaleInPolicy = default;
            OrchestrationMode? orchestrationMode = default;
            SpotRestorePolicy spotRestorePolicy = default;
            VirtualMachineScaleSetPriorityMixPolicy priorityMixPolicy = default;
            DateTimeOffset? timeCreated = default;
            bool? constrainedMaximumCapacity = default;
            ResiliencyPolicy resiliencyPolicy = default;
            ZonalPlatformFaultDomainAlignMode? zonalPlatformFaultDomainAlignMode = default;
            ComputeSkuProfile skuProfile = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("upgradePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradePolicy = VirtualMachineScaleSetUpgradePolicy.DeserializeVirtualMachineScaleSetUpgradePolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scheduledEventsPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledEventsPolicy = ScheduledEventsPolicy.DeserializeScheduledEventsPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("automaticRepairsPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automaticRepairsPolicy = AutomaticRepairsPolicy.DeserializeAutomaticRepairsPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("virtualMachineProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineProfile = VirtualMachineScaleSetVmProfile.DeserializeVirtualMachineScaleSetVmProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("overprovision"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    overprovision = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("doNotRunExtensionsOnOverprovisionedVMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    doNotRunExtensionsOnOverprovisionedVms = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("uniqueId"u8))
                {
                    uniqueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("singlePlacementGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    singlePlacementGroup = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("zoneBalance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneBalance = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("platformFaultDomainCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    platformFaultDomainCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("proximityPlacementGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    proximityPlacementGroup = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("hostGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostGroup = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("additionalCapabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalCapabilities = AdditionalCapabilities.DeserializeAdditionalCapabilities(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scaleInPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleInPolicy = ScaleInPolicy.DeserializeScaleInPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("orchestrationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    orchestrationMode = new OrchestrationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("spotRestorePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spotRestorePolicy = SpotRestorePolicy.DeserializeSpotRestorePolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("priorityMixPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priorityMixPolicy = VirtualMachineScaleSetPriorityMixPolicy.DeserializeVirtualMachineScaleSetPriorityMixPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("timeCreated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeCreated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("constrainedMaximumCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    constrainedMaximumCapacity = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resiliencyPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resiliencyPolicy = ResiliencyPolicy.DeserializeResiliencyPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("zonalPlatformFaultDomainAlignMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zonalPlatformFaultDomainAlignMode = new ZonalPlatformFaultDomainAlignMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("skuProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skuProfile = ComputeSkuProfile.DeserializeComputeSkuProfile(property.Value, options);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new VirtualMachineScaleSetProperties(
                upgradePolicy,
                scheduledEventsPolicy,
                automaticRepairsPolicy,
                virtualMachineProfile,
                provisioningState,
                overprovision,
                doNotRunExtensionsOnOverprovisionedVms,
                uniqueId,
                singlePlacementGroup,
                zoneBalance,
                platformFaultDomainCount,
                proximityPlacementGroup,
                hostGroup,
                additionalCapabilities,
                scaleInPolicy,
                orchestrationMode,
                spotRestorePolicy,
                priorityMixPolicy,
                timeCreated,
                constrainedMaximumCapacity,
                resiliencyPolicy,
                zonalPlatformFaultDomainAlignMode,
                skuProfile,
                additionalProperties);
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetProperties)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetProperties IPersistableModel<VirtualMachineScaleSetProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
