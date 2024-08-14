// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Hci
{
    public partial class HciClusterUpdateResource : IJsonModel<HciClusterUpdateData>
    {
        void IJsonModel<HciClusterUpdateData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<HciClusterUpdateData>)Data).Write(writer, options);

        HciClusterUpdateData IJsonModel<HciClusterUpdateData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<HciClusterUpdateData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<HciClusterUpdateData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        HciClusterUpdateData IPersistableModel<HciClusterUpdateData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<HciClusterUpdateData>(data, options);

        string IPersistableModel<HciClusterUpdateData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<HciClusterUpdateData>)Data).GetFormatFromOptions(options);
    }
}
