// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Model.Inheritance.NotDiscriminated.Models
{
    public partial class Pet : IJsonModel<Pet>
    {
        void IJsonModel<Pet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        Pet IJsonModel<Pet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual Pet JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<Pet>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        Pet IPersistableModel<Pet>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual Pet PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<Pet>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="pet"> The <see cref="Pet"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(Pet pet) => throw null;

        public static explicit operator Pet(Response result) => throw null;
    }
}
