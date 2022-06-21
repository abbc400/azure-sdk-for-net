// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Rooms
{
    public partial class CommunicationIdentifierModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RawId))
            {
                writer.WritePropertyName("rawId");
                writer.WriteStringValue(RawId);
            }
            if (Optional.IsDefined(CommunicationUser))
            {
                writer.WritePropertyName("communicationUser");
                writer.WriteObjectValue(CommunicationUser);
            }
            writer.WriteEndObject();
        }

        internal static CommunicationIdentifierModel DeserializeCommunicationIdentifierModel(JsonElement element)
        {
            Optional<string> rawId = default;
            Optional<CommunicationUserIdentifierModel> communicationUser = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rawId"))
                {
                    rawId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communicationUser"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    communicationUser = CommunicationUserIdentifierModel.DeserializeCommunicationUserIdentifierModel(property.Value);
                    continue;
                }
            }
            return new CommunicationIdentifierModel(rawId.Value, communicationUser.Value);
        }
    }
}
