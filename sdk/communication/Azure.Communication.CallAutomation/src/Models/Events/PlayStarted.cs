﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// The play started event.
    /// </summary>
    [CodeGenModel("PlayStarted", Usage = new string[] { "output" }, Formats = new string[] { "json" })]
    public partial class PlayStarted : CallAutomationEventBase
    {
        /// <summary>
        /// Reason code.
        /// </summary>
        public MediaEventReasonCode ReasonCode { get; internal set; }

        /// <summary> Initializes a new instance of <see cref="PlayStarted"/>. </summary>
        /// <param name="operationContext"></param>
        /// <param name="resultInformation"></param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        internal PlayStarted(string operationContext, ResultInformation resultInformation, string callConnectionId, string serverCallId, string correlationId)
        {
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            ReasonCode = new MediaEventReasonCode(resultInformation.SubCode.ToString());
        }

        /// <summary>
        /// Deserialize <see cref="PlayStarted"/> event.
        /// </summary>
        /// <param name="content">The json content.</param>
        /// <returns>The new <see cref="PlayStarted"/> object.</returns>
        public static PlayStarted Deserialize(string content)
        {
            using var document = JsonDocument.Parse(content);
            JsonElement element = document.RootElement;

            return DeserializePlayStarted(element);
        }
    }
}
