// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The Sku. </summary>
    public partial class DataBoxSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxSku"/>. </summary>
        /// <param name="name"> The sku name. </param>
        public DataBoxSku(DataBoxSkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxSku"/>. </summary>
        /// <param name="name"> The sku name. </param>
        /// <param name="displayName"> The display name of the sku. </param>
        /// <param name="family"> The sku family. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxSku(DataBoxSkuName name, string displayName, string family, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            DisplayName = displayName;
            Family = family;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxSku"/> for deserialization. </summary>
        internal DataBoxSku()
        {
        }

        /// <summary> The sku name. </summary>
        public DataBoxSkuName Name { get; set; }
        /// <summary> The display name of the sku. </summary>
        public string DisplayName { get; set; }
        /// <summary> The sku family. </summary>
        public string Family { get; set; }
    }
}
