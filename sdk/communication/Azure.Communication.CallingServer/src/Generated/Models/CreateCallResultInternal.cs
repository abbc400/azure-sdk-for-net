// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer.Models
{
    /// <summary> The response payload of the create call operation. </summary>
    internal partial class CreateCallResultInternal
    {
        /// <summary> Initializes a new instance of CreateCallResultInternal. </summary>
        internal CreateCallResultInternal()
        {
        }

        /// <summary> Initializes a new instance of CreateCallResultInternal. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        internal CreateCallResultInternal(string callConnectionId)
        {
            CallConnectionId = callConnectionId;
        }

        /// <summary> The call connection id. </summary>
        public string CallConnectionId { get; }
    }
}
