// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Shipment pick up request details. </summary>
    public partial class ShipmentPickUpContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ShipmentPickUpContent"/>. </summary>
        /// <param name="startOn"> Minimum date after which the pick up should commence, this must be in local time of pick up area. </param>
        /// <param name="endOn"> Maximum date before which the pick up should commence, this must be in local time of pick up area. </param>
        /// <param name="shipmentLocation"> Shipment Location in the pickup place. Eg.front desk. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="shipmentLocation"/> is null. </exception>
        public ShipmentPickUpContent(DateTimeOffset startOn, DateTimeOffset endOn, string shipmentLocation)
        {
            Argument.AssertNotNull(shipmentLocation, nameof(shipmentLocation));

            StartOn = startOn;
            EndOn = endOn;
            ShipmentLocation = shipmentLocation;
        }

        /// <summary> Initializes a new instance of <see cref="ShipmentPickUpContent"/>. </summary>
        /// <param name="startOn"> Minimum date after which the pick up should commence, this must be in local time of pick up area. </param>
        /// <param name="endOn"> Maximum date before which the pick up should commence, this must be in local time of pick up area. </param>
        /// <param name="shipmentLocation"> Shipment Location in the pickup place. Eg.front desk. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ShipmentPickUpContent(DateTimeOffset startOn, DateTimeOffset endOn, string shipmentLocation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartOn = startOn;
            EndOn = endOn;
            ShipmentLocation = shipmentLocation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ShipmentPickUpContent"/> for deserialization. </summary>
        internal ShipmentPickUpContent()
        {
        }

        /// <summary> Minimum date after which the pick up should commence, this must be in local time of pick up area. </summary>
        public DateTimeOffset StartOn { get; }
        /// <summary> Maximum date before which the pick up should commence, this must be in local time of pick up area. </summary>
        public DateTimeOffset EndOn { get; }
        /// <summary> Shipment Location in the pickup place. Eg.front desk. </summary>
        public string ShipmentLocation { get; }
    }
}
