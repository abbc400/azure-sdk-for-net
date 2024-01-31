// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> The authentication options for Azure OpenAI On Your Data when using an Elasticsearch key and key ID pair. </summary>
    public partial class OnYourDataKeyAndKeyIdAuthenticationOptions : OnYourDataAuthenticationOptions
    {
        /// <summary> Initializes a new instance of <see cref="OnYourDataKeyAndKeyIdAuthenticationOptions"/>. </summary>
        /// <param name="key"> The key to use for authentication. </param>
        /// <param name="keyId"> The key ID to use for authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="keyId"/> is null. </exception>
        public OnYourDataKeyAndKeyIdAuthenticationOptions(string key, string keyId)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(keyId, nameof(keyId));

            Type = OnYourDataAuthenticationType.KeyAndKeyId;
            Key = key;
            KeyId = keyId;
        }

        /// <summary> Initializes a new instance of <see cref="OnYourDataKeyAndKeyIdAuthenticationOptions"/>. </summary>
        /// <param name="type"> The authentication type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="key"> The key to use for authentication. </param>
        /// <param name="keyId"> The key ID to use for authentication. </param>
        internal OnYourDataKeyAndKeyIdAuthenticationOptions(OnYourDataAuthenticationType type, IDictionary<string, BinaryData> serializedAdditionalRawData, string key, string keyId) : base(type, serializedAdditionalRawData)
        {
            Key = key;
            KeyId = keyId;
        }

        /// <summary> Initializes a new instance of <see cref="OnYourDataKeyAndKeyIdAuthenticationOptions"/> for deserialization. </summary>
        internal OnYourDataKeyAndKeyIdAuthenticationOptions()
        {
        }

        /// <summary> The key to use for authentication. </summary>
        public string Key { get; }
        /// <summary> The key ID to use for authentication. </summary>
        public string KeyId { get; }
    }
}
