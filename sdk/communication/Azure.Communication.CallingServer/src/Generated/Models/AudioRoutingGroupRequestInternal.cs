// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication;
using Azure.Communication.CallingServer;

namespace Azure.Communication.CallingServer.Models
{
    /// <summary> The audio routing group request. </summary>
    internal partial class AudioRoutingGroupRequestInternal
    {
        /// <summary> Initializes a new instance of AudioRoutingGroupRequestInternal. </summary>
        /// <param name="audioRoutingMode"> The audio routing mode. </param>
        /// <param name="targets"> The target identities that would be receivers in the audio routing group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targets"/> is null. </exception>
        public AudioRoutingGroupRequestInternal(AudioRoutingMode audioRoutingMode, IEnumerable<CommunicationIdentifierModel> targets)
        {
            if (targets == null)
            {
                throw new ArgumentNullException(nameof(targets));
            }

            AudioRoutingMode = audioRoutingMode;
            Targets = targets.ToList();
        }

        /// <summary> The audio routing mode. </summary>
        public AudioRoutingMode AudioRoutingMode { get; }
        /// <summary> The target identities that would be receivers in the audio routing group. </summary>
        public IList<CommunicationIdentifierModel> Targets { get; }
    }
}
