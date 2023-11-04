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
    public partial class DataBoxJobDetails : IUtf8JsonSerializable, IJsonModel<DataBoxJobDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxJobDetails>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DataBoxJobDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(CopyProgress))
                {
                    writer.WritePropertyName("copyProgress"u8);
                    writer.WriteStartArray();
                    foreach (var item in CopyProgress)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (Optional.IsDefined(DevicePassword))
            {
                writer.WritePropertyName("devicePassword"u8);
                writer.WriteStringValue(DevicePassword);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(JobStages))
                {
                    writer.WritePropertyName("jobStages"u8);
                    writer.WriteStartArray();
                    foreach (var item in JobStages)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            writer.WritePropertyName("contactDetails"u8);
            writer.WriteObjectValue(ContactDetails);
            if (Optional.IsDefined(ShippingAddress))
            {
                writer.WritePropertyName("shippingAddress"u8);
                writer.WriteObjectValue(ShippingAddress);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DeliveryPackage))
                {
                    writer.WritePropertyName("deliveryPackage"u8);
                    writer.WriteObjectValue(DeliveryPackage);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ReturnPackage))
                {
                    writer.WritePropertyName("returnPackage"u8);
                    writer.WriteObjectValue(ReturnPackage);
                }
            }
            if (Optional.IsCollectionDefined(DataImportDetails))
            {
                writer.WritePropertyName("dataImportDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DataImportDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DataExportDetails))
            {
                writer.WritePropertyName("dataExportDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DataExportDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("jobDetailsType"u8);
            writer.WriteStringValue(JobDetailsType.ToSerialString());
            if (Optional.IsDefined(Preferences))
            {
                writer.WritePropertyName("preferences"u8);
                writer.WriteObjectValue(Preferences);
            }
            if (Optional.IsDefined(ReverseShippingDetails))
            {
                writer.WritePropertyName("reverseShippingDetails"u8);
                writer.WriteObjectValue(ReverseShippingDetails);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(CopyLogDetails))
                {
                    writer.WritePropertyName("copyLogDetails"u8);
                    writer.WriteStartArray();
                    foreach (var item in CopyLogDetails)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ReverseShipmentLabelSasKey))
                {
                    writer.WritePropertyName("reverseShipmentLabelSasKey"u8);
                    writer.WriteStringValue(ReverseShipmentLabelSasKey);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ChainOfCustodySasKey))
                {
                    writer.WritePropertyName("chainOfCustodySasKey"u8);
                    writer.WriteStringValue(ChainOfCustodySasKey);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DeviceErasureDetails))
                {
                    writer.WritePropertyName("deviceErasureDetails"u8);
                    writer.WriteObjectValue(DeviceErasureDetails);
                }
            }
            if (Optional.IsDefined(KeyEncryptionKey))
            {
                writer.WritePropertyName("keyEncryptionKey"u8);
                writer.WriteObjectValue(KeyEncryptionKey);
            }
            if (Optional.IsDefined(ExpectedDataSizeInTerabytes))
            {
                writer.WritePropertyName("expectedDataSizeInTeraBytes"u8);
                writer.WriteNumberValue(ExpectedDataSizeInTerabytes.Value);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(Actions))
                {
                    writer.WritePropertyName("actions"u8);
                    writer.WriteStartArray();
                    foreach (var item in Actions)
                    {
                        writer.WriteStringValue(item.ToSerialString());
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(LastMitigationActionOnJob))
                {
                    writer.WritePropertyName("lastMitigationActionOnJob"u8);
                    writer.WriteObjectValue(LastMitigationActionOnJob);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DataCenterAddress))
                {
                    writer.WritePropertyName("datacenterAddress"u8);
                    writer.WriteObjectValue(DataCenterAddress);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DataCenterCode))
                {
                    writer.WritePropertyName("dataCenterCode"u8);
                    writer.WriteStringValue(DataCenterCode.Value.ToString());
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

        DataBoxJobDetails IJsonModel<DataBoxJobDetails>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxJobDetails(document.RootElement, options);
        }

        internal static DataBoxJobDetails DeserializeDataBoxJobDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DataBoxCopyProgress>> copyProgress = default;
            Optional<string> devicePassword = default;
            Optional<IReadOnlyList<DataBoxJobStage>> jobStages = default;
            DataBoxContactDetails contactDetails = default;
            Optional<DataBoxShippingAddress> shippingAddress = default;
            Optional<PackageShippingDetails> deliveryPackage = default;
            Optional<PackageShippingDetails> returnPackage = default;
            Optional<IList<DataImportDetails>> dataImportDetails = default;
            Optional<IList<DataExportDetails>> dataExportDetails = default;
            DataBoxOrderType jobDetailsType = default;
            Optional<DataBoxOrderPreferences> preferences = default;
            Optional<ReverseShippingDetails> reverseShippingDetails = default;
            Optional<IReadOnlyList<CopyLogDetails>> copyLogDetails = default;
            Optional<string> reverseShipmentLabelSasKey = default;
            Optional<string> chainOfCustodySasKey = default;
            Optional<DeviceErasureDetails> deviceErasureDetails = default;
            Optional<DataBoxKeyEncryptionKey> keyEncryptionKey = default;
            Optional<int> expectedDataSizeInTerabytes = default;
            Optional<IReadOnlyList<CustomerResolutionCode>> actions = default;
            Optional<LastMitigationActionOnJob> lastMitigationActionOnJob = default;
            Optional<DataCenterAddressResult> dataCenterAddress = default;
            Optional<DataCenterCode> dataCenterCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyProgress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxCopyProgress> array = new List<DataBoxCopyProgress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxCopyProgress.DeserializeDataBoxCopyProgress(item));
                    }
                    copyProgress = array;
                    continue;
                }
                if (property.NameEquals("devicePassword"u8))
                {
                    devicePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobStages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxJobStage> array = new List<DataBoxJobStage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxJobStage.DeserializeDataBoxJobStage(item));
                    }
                    jobStages = array;
                    continue;
                }
                if (property.NameEquals("contactDetails"u8))
                {
                    contactDetails = DataBoxContactDetails.DeserializeDataBoxContactDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("shippingAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shippingAddress = DataBoxShippingAddress.DeserializeDataBoxShippingAddress(property.Value);
                    continue;
                }
                if (property.NameEquals("deliveryPackage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deliveryPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("returnPackage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    returnPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("dataImportDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataImportDetails> array = new List<DataImportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataImportDetails.DeserializeDataImportDetails(item));
                    }
                    dataImportDetails = array;
                    continue;
                }
                if (property.NameEquals("dataExportDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataExportDetails> array = new List<DataExportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataExportDetails.DeserializeDataExportDetails(item));
                    }
                    dataExportDetails = array;
                    continue;
                }
                if (property.NameEquals("jobDetailsType"u8))
                {
                    jobDetailsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (property.NameEquals("preferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferences = DataBoxOrderPreferences.DeserializeDataBoxOrderPreferences(property.Value);
                    continue;
                }
                if (property.NameEquals("reverseShippingDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reverseShippingDetails = ReverseShippingDetails.DeserializeReverseShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("copyLogDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CopyLogDetails> array = new List<CopyLogDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.CopyLogDetails.DeserializeCopyLogDetails(item));
                    }
                    copyLogDetails = array;
                    continue;
                }
                if (property.NameEquals("reverseShipmentLabelSasKey"u8))
                {
                    reverseShipmentLabelSasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("chainOfCustodySasKey"u8))
                {
                    chainOfCustodySasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceErasureDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceErasureDetails = DeviceErasureDetails.DeserializeDeviceErasureDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("keyEncryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKey = DataBoxKeyEncryptionKey.DeserializeDataBoxKeyEncryptionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("expectedDataSizeInTeraBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expectedDataSizeInTerabytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomerResolutionCode> array = new List<CustomerResolutionCode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToCustomerResolutionCode());
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("lastMitigationActionOnJob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastMitigationActionOnJob = LastMitigationActionOnJob.DeserializeLastMitigationActionOnJob(property.Value);
                    continue;
                }
                if (property.NameEquals("datacenterAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAddress = DataCenterAddressResult.DeserializeDataCenterAddressResult(property.Value);
                    continue;
                }
                if (property.NameEquals("dataCenterCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterCode = new DataCenterCode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxJobDetails(Optional.ToList(jobStages), contactDetails, shippingAddress.Value, deliveryPackage.Value, returnPackage.Value, Optional.ToList(dataImportDetails), Optional.ToList(dataExportDetails), jobDetailsType, preferences.Value, reverseShippingDetails.Value, Optional.ToList(copyLogDetails), reverseShipmentLabelSasKey.Value, chainOfCustodySasKey.Value, deviceErasureDetails.Value, keyEncryptionKey.Value, Optional.ToNullable(expectedDataSizeInTerabytes), Optional.ToList(actions), lastMitigationActionOnJob.Value, dataCenterAddress.Value, Optional.ToNullable(dataCenterCode), serializedAdditionalRawData, Optional.ToList(copyProgress), devicePassword.Value);
        }

        BinaryData IModel<DataBoxJobDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataBoxJobDetails IModel<DataBoxJobDetails>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataBoxJobDetails(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DataBoxJobDetails>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
