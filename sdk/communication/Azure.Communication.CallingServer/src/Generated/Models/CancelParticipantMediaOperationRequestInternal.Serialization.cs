// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer.Models
{
    internal partial class CancelParticipantMediaOperationRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("identifier");
            writer.WriteObjectValue(Identifier);
            writer.WritePropertyName("mediaOperationId");
            writer.WriteStringValue(MediaOperationId);
            writer.WriteEndObject();
        }
    }
}
