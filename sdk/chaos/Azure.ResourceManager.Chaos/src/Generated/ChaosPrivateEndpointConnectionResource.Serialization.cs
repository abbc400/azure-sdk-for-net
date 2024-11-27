// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Chaos
{
    public partial class ChaosPrivateEndpointConnectionResource : IJsonModel<ChaosPrivateEndpointConnectionData>
    {
        void IJsonModel<ChaosPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ChaosPrivateEndpointConnectionData>)Data).Write(writer, options);

        ChaosPrivateEndpointConnectionData IJsonModel<ChaosPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ChaosPrivateEndpointConnectionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ChaosPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ChaosPrivateEndpointConnectionData IPersistableModel<ChaosPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ChaosPrivateEndpointConnectionData>(data, options);

        string IPersistableModel<ChaosPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ChaosPrivateEndpointConnectionData>)Data).GetFormatFromOptions(options);
    }
}
