// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataBox.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBox
{
    /// <summary>
    /// A class representing the DataBoxJob data model.
    /// Job Resource.
    /// </summary>
    public partial class DataBoxJobData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxJobData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="transferType"> Type of the data transfer. </param>
        /// <param name="sku"> The sku type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public DataBoxJobData(AzureLocation location, DataBoxJobTransferType transferType, DataBoxSku sku) : base(location)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            TransferType = transferType;
            Sku = sku;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxJobData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="transferType"> Type of the data transfer. </param>
        /// <param name="isCancellable"> Describes whether the job is cancellable or not. </param>
        /// <param name="isDeletable"> Describes whether the job is deletable or not. </param>
        /// <param name="isShippingAddressEditable"> Describes whether the shipping address is editable or not. </param>
        /// <param name="reverseShippingDetailsUpdate"> The Editable status for Reverse Shipping Address and Contact Info. </param>
        /// <param name="reverseTransportPreferenceUpdate"> The Editable status for Reverse Transport preferences. </param>
        /// <param name="isPrepareToShipEnabled"> Is Prepare To Ship Enabled on this job. </param>
        /// <param name="status"> Name of the stage which is in progress. </param>
        /// <param name="startOn"> Time at which the job was started in UTC ISO 8601 format. </param>
        /// <param name="error"> Top level error for the job. </param>
        /// <param name="details">
        /// Details of a job run. This field will only be sent for expand details filter.
        /// Please note <see cref="DataBoxBasicJobDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataBoxJobDetails"/>, <see cref="DataBoxCustomerDiskJobDetails"/>, <see cref="DataBoxDiskJobDetails"/> and <see cref="DataBoxHeavyJobDetails"/>.
        /// </param>
        /// <param name="cancellationReason"> Reason for cancellation. </param>
        /// <param name="deliveryType"> Delivery type of Job. </param>
        /// <param name="deliveryInfo"> Delivery Info of Job. </param>
        /// <param name="isCancellableWithoutFee"> Flag to indicate cancellation of scheduled job. </param>
        /// <param name="sku"> The sku type. </param>
        /// <param name="identity"> Msi identity of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DataBoxJobTransferType transferType, bool? isCancellable, bool? isDeletable, bool? isShippingAddressEditable, ReverseShippingDetailsEditStatus? reverseShippingDetailsUpdate, ReverseTransportPreferenceEditStatus? reverseTransportPreferenceUpdate, bool? isPrepareToShipEnabled, DataBoxStageName? status, DateTimeOffset? startOn, ResponseError error, DataBoxBasicJobDetails details, string cancellationReason, JobDeliveryType? deliveryType, JobDeliveryInfo deliveryInfo, bool? isCancellableWithoutFee, DataBoxSku sku, ManagedServiceIdentity identity, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            TransferType = transferType;
            IsCancellable = isCancellable;
            IsDeletable = isDeletable;
            IsShippingAddressEditable = isShippingAddressEditable;
            ReverseShippingDetailsUpdate = reverseShippingDetailsUpdate;
            ReverseTransportPreferenceUpdate = reverseTransportPreferenceUpdate;
            IsPrepareToShipEnabled = isPrepareToShipEnabled;
            Status = status;
            StartOn = startOn;
            Error = error;
            Details = details;
            CancellationReason = cancellationReason;
            DeliveryType = deliveryType;
            DeliveryInfo = deliveryInfo;
            IsCancellableWithoutFee = isCancellableWithoutFee;
            Sku = sku;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxJobData"/> for deserialization. </summary>
        internal DataBoxJobData()
        {
        }

        /// <summary> Type of the data transfer. </summary>
        public DataBoxJobTransferType TransferType { get; set; }
        /// <summary> Describes whether the job is cancellable or not. </summary>
        public bool? IsCancellable { get; }
        /// <summary> Describes whether the job is deletable or not. </summary>
        public bool? IsDeletable { get; }
        /// <summary> Describes whether the shipping address is editable or not. </summary>
        public bool? IsShippingAddressEditable { get; }
        /// <summary> The Editable status for Reverse Shipping Address and Contact Info. </summary>
        public ReverseShippingDetailsEditStatus? ReverseShippingDetailsUpdate { get; }
        /// <summary> The Editable status for Reverse Transport preferences. </summary>
        public ReverseTransportPreferenceEditStatus? ReverseTransportPreferenceUpdate { get; }
        /// <summary> Is Prepare To Ship Enabled on this job. </summary>
        public bool? IsPrepareToShipEnabled { get; }
        /// <summary> Name of the stage which is in progress. </summary>
        public DataBoxStageName? Status { get; }
        /// <summary> Time at which the job was started in UTC ISO 8601 format. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Top level error for the job. </summary>
        public ResponseError Error { get; }
        /// <summary>
        /// Details of a job run. This field will only be sent for expand details filter.
        /// Please note <see cref="DataBoxBasicJobDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataBoxJobDetails"/>, <see cref="DataBoxCustomerDiskJobDetails"/>, <see cref="DataBoxDiskJobDetails"/> and <see cref="DataBoxHeavyJobDetails"/>.
        /// </summary>
        public DataBoxBasicJobDetails Details { get; set; }
        /// <summary> Reason for cancellation. </summary>
        public string CancellationReason { get; }
        /// <summary> Delivery type of Job. </summary>
        public JobDeliveryType? DeliveryType { get; set; }
        /// <summary> Delivery Info of Job. </summary>
        internal JobDeliveryInfo DeliveryInfo { get; set; }
        /// <summary> Scheduled date time. </summary>
        public DateTimeOffset? DeliveryInfoScheduledOn
        {
            get => DeliveryInfo is null ? default : DeliveryInfo.ScheduledOn;
            set
            {
                if (DeliveryInfo is null)
                    DeliveryInfo = new JobDeliveryInfo();
                DeliveryInfo.ScheduledOn = value;
            }
        }

        /// <summary> Flag to indicate cancellation of scheduled job. </summary>
        public bool? IsCancellableWithoutFee { get; }
        /// <summary> The sku type. </summary>
        public DataBoxSku Sku { get; set; }
        /// <summary> Msi identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
