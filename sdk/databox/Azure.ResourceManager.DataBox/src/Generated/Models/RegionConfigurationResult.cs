// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Configuration response specific to a region. </summary>
    public partial class RegionConfigurationResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RegionConfigurationResult"/>. </summary>
        internal RegionConfigurationResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RegionConfigurationResult"/>. </summary>
        /// <param name="scheduleAvailabilityResponse"> Schedule availability for given sku in a region. </param>
        /// <param name="transportAvailabilityResponse"> Transport options available for given sku in a region. </param>
        /// <param name="dataCenterAddressResponse">
        /// Datacenter address for given sku in a region.
        /// Please note <see cref="DataCenterAddressResult"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataCenterAddressInstructionResult"/> and <see cref="DataCenterAddressLocationResult"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RegionConfigurationResult(ScheduleAvailabilityResponse scheduleAvailabilityResponse, TransportAvailabilityResponse transportAvailabilityResponse, DataCenterAddressResult dataCenterAddressResponse, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ScheduleAvailabilityResponse = scheduleAvailabilityResponse;
            TransportAvailabilityResponse = transportAvailabilityResponse;
            DataCenterAddressResponse = dataCenterAddressResponse;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Schedule availability for given sku in a region. </summary>
        internal ScheduleAvailabilityResponse ScheduleAvailabilityResponse { get; }
        /// <summary> List of dates available to schedule. </summary>
        public IReadOnlyList<DateTimeOffset> ScheduleAvailabilityResponseAvailableDates
        {
            get => ScheduleAvailabilityResponse?.AvailableDates;
        }

        /// <summary> Transport options available for given sku in a region. </summary>
        internal TransportAvailabilityResponse TransportAvailabilityResponse { get; }
        /// <summary> List of transport availability details for given region. </summary>
        public IReadOnlyList<TransportAvailabilityDetails> TransportAvailabilityDetails
        {
            get => TransportAvailabilityResponse?.TransportAvailabilityDetails;
        }

        /// <summary>
        /// Datacenter address for given sku in a region.
        /// Please note <see cref="DataCenterAddressResult"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataCenterAddressInstructionResult"/> and <see cref="DataCenterAddressLocationResult"/>.
        /// </summary>
        public DataCenterAddressResult DataCenterAddressResponse { get; }
    }
}
