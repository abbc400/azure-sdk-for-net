// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Reason for cancellation. </summary>
    public partial class DataBoxJobCancellationReason
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxJobCancellationReason"/>. </summary>
        /// <param name="reason"> Reason for cancellation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reason"/> is null. </exception>
        public DataBoxJobCancellationReason(string reason)
        {
            Argument.AssertNotNull(reason, nameof(reason));

            Reason = reason;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxJobCancellationReason"/>. </summary>
        /// <param name="reason"> Reason for cancellation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxJobCancellationReason(string reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxJobCancellationReason"/> for deserialization. </summary>
        internal DataBoxJobCancellationReason()
        {
        }

        /// <summary> Reason for cancellation. </summary>
        public string Reason { get; }
    }
}
