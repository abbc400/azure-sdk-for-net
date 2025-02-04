﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.ClientModel.Tests.Client;
using System.ClientModel.Tests.Client.Models.ResourceManager.Compute;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using NUnit.Framework;

namespace System.ClientModel.Tests.ModelReaderWriterTests.Models
{
    public class AvailabilitySetDataListOfDictionariesTests
    {
        private static readonly string s_payload = File.ReadAllText(TestData.GetLocation("AvailabilitySetData/AvailabilitySetDataListOfDictionaries.json")).TrimEnd();
        private static readonly BinaryData s_data = new BinaryData(Encoding.UTF8.GetBytes(s_payload));
        private static readonly IList<Dictionary<string, AvailabilitySetData>> s_availabilitySets = ModelReaderWriter.Read<List<Dictionary<string, AvailabilitySetData>>>(s_data)!;
        private static readonly string s_collapsedPayload = GetCollapsedPayload();

        private static string GetCollapsedPayload()
        {
            var jsonObject = JsonSerializer.Deserialize<object>(s_payload);
            return JsonSerializer.Serialize(jsonObject);
        }

        [Test]
        public void ReadDictionaryGeneric()
        {
            var asetList = ModelReaderWriter.Read<List<Dictionary<string, AvailabilitySetData>>>(s_data);
            Assert.IsNotNull(asetList);

            Assert.AreEqual(2, asetList!.Count);
            var dictionary1 = asetList[0];
            Assert.AreEqual(2, dictionary1.Count);
            Assert.IsTrue(dictionary1.ContainsKey("testAS-3375"));
            Assert.IsTrue(dictionary1["testAS-3375"].Name!.Equals("testAS-3375"));
            Assert.IsTrue(dictionary1.ContainsKey("testAS-3376"));
            Assert.IsTrue(dictionary1["testAS-3376"].Name!.Equals("testAS-3376"));
            var dictionary2 = asetList[1];
            Assert.AreEqual(2, dictionary2.Count);
            Assert.IsTrue(dictionary2.ContainsKey("testAS-3377"));
            Assert.IsTrue(dictionary2["testAS-3377"].Name!.Equals("testAS-3377"));
            Assert.IsTrue(dictionary2.ContainsKey("testAS-3378"));
            Assert.IsTrue(dictionary2["testAS-3378"].Name!.Equals("testAS-3378"));
        }

        [Test]
        public void ReadDictionary()
        {
            var asetList = ModelReaderWriter.Read(s_data, typeof(List<Dictionary<string, AvailabilitySetData>>));
            Assert.IsNotNull(asetList);

            List<Dictionary<string, AvailabilitySetData>>? asetList2 = asetList! as List<Dictionary<string, AvailabilitySetData>>;
            Assert.IsNotNull(asetList2);

            Assert.AreEqual(2, asetList2!.Count);
            var dictionary1 = asetList2[0];
            Assert.AreEqual(2, dictionary1.Count);
            Assert.IsTrue(dictionary1.ContainsKey("testAS-3375"));
            Assert.IsTrue(dictionary1["testAS-3375"].Name!.Equals("testAS-3375"));
            Assert.IsTrue(dictionary1.ContainsKey("testAS-3376"));
            Assert.IsTrue(dictionary1["testAS-3376"].Name!.Equals("testAS-3376"));
            var dictionary2 = asetList2[1];
            Assert.AreEqual(2, dictionary2.Count);
            Assert.IsTrue(dictionary2.ContainsKey("testAS-3377"));
            Assert.IsTrue(dictionary2["testAS-3377"].Name!.Equals("testAS-3377"));
            Assert.IsTrue(dictionary2.ContainsKey("testAS-3378"));
            Assert.IsTrue(dictionary2["testAS-3378"].Name!.Equals("testAS-3378"));
        }

        [Test]
        public void WriteDictionary()
        {
            BinaryData data = ModelReaderWriter.Write(s_availabilitySets);
            Assert.IsNotNull(data);
            Assert.AreEqual(s_collapsedPayload, data.ToString());
        }
    }
}
