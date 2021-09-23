// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class PlayAudioRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AudioFileUri))
            {
                writer.WritePropertyName("audioFileUri");
                writer.WriteStringValue(AudioFileUri);
            }
            writer.WritePropertyName("loop");
            writer.WriteBooleanValue(Loop);
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext");
                writer.WriteStringValue(OperationContext);
            }
            if (Optional.IsDefined(AudioFileId))
            {
                writer.WritePropertyName("audioFileId");
                writer.WriteStringValue(AudioFileId);
            }
            if (Optional.IsDefined(CallbackUri))
            {
                writer.WritePropertyName("callbackUri");
                writer.WriteStringValue(CallbackUri);
            }
            writer.WriteEndObject();
        }
    }
}
