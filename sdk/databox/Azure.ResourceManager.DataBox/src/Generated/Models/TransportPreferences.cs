// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Preferences related to the shipment logistics of the sku. </summary>
    public partial class TransportPreferences
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TransportPreferences"/>. </summary>
        /// <param name="preferredShipmentType"> Indicates Shipment Logistics type that the customer preferred. </param>
        public TransportPreferences(TransportShipmentType preferredShipmentType)
        {
            PreferredShipmentType = preferredShipmentType;
        }

        /// <summary> Initializes a new instance of <see cref="TransportPreferences"/>. </summary>
        /// <param name="preferredShipmentType"> Indicates Shipment Logistics type that the customer preferred. </param>
        /// <param name="isUpdated"> Read only property which indicates whether transport preferences has been updated or not after device is prepared. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TransportPreferences(TransportShipmentType preferredShipmentType, bool? isUpdated, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PreferredShipmentType = preferredShipmentType;
            IsUpdated = isUpdated;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TransportPreferences"/> for deserialization. </summary>
        internal TransportPreferences()
        {
        }

        /// <summary> Indicates Shipment Logistics type that the customer preferred. </summary>
        public TransportShipmentType PreferredShipmentType { get; set; }
        /// <summary> Read only property which indicates whether transport preferences has been updated or not after device is prepared. </summary>
        public bool? IsUpdated { get; }
    }
}
