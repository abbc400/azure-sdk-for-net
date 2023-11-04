// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The available skus operation response. </summary>
    internal partial class AvailableSkusResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AvailableSkusResult"/>. </summary>
        internal AvailableSkusResult()
        {
            Value = new ChangeTrackingList<DataBoxSkuInformation>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailableSkusResult"/>. </summary>
        /// <param name="value"> List of available skus. </param>
        /// <param name="nextLink"> Link for the next set of skus. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableSkusResult(IReadOnlyList<DataBoxSkuInformation> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of available skus. </summary>
        public IReadOnlyList<DataBoxSkuInformation> Value { get; }
        /// <summary> Link for the next set of skus. </summary>
        public string NextLink { get; }
    }
}
