// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Dc access security code. </summary>
    public partial class DataCenterAccessSecurityCode
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataCenterAccessSecurityCode"/>. </summary>
        internal DataCenterAccessSecurityCode()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataCenterAccessSecurityCode"/>. </summary>
        /// <param name="reverseDataCenterAccessCode"> Reverse Dc access security code. </param>
        /// <param name="forwardDataCenterAccessCode"> Forward Dc access security code. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataCenterAccessSecurityCode(string reverseDataCenterAccessCode, string forwardDataCenterAccessCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReverseDataCenterAccessCode = reverseDataCenterAccessCode;
            ForwardDataCenterAccessCode = forwardDataCenterAccessCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Reverse Dc access security code. </summary>
        public string ReverseDataCenterAccessCode { get; }
        /// <summary> Forward Dc access security code. </summary>
        public string ForwardDataCenterAccessCode { get; }
    }
}
