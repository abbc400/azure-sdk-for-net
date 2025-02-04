﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.ClientModel.Tests.Client;
using System.ClientModel.Tests.Client.Models.ResourceManager.Compute;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using NUnit.Framework;

namespace System.ClientModel.Tests.ModelReaderWriterTests.Models
{
    public class AvailabilitySetDataListTests
    {
        private static readonly string s_payload = File.ReadAllText(TestData.GetLocation("AvailabilitySetData/AvailabilitySetDataList.json")).TrimEnd();
        private static readonly BinaryData s_data = new BinaryData(Encoding.UTF8.GetBytes(s_payload));
        private static readonly IList<AvailabilitySetData> s_availabilitySets = ModelReaderWriter.Read<List<AvailabilitySetData>>(s_data)!;
        private static readonly string s_collapsedPayload = GetCollapsedPayload();

        private static string GetCollapsedPayload()
        {
            var jsonObject = JsonSerializer.Deserialize<object>(s_payload);
            return JsonSerializer.Serialize(jsonObject);
        }

        private class AvailabilitySetDataComparer : IComparer<AvailabilitySetData>
        {
            public int Compare(AvailabilitySetData? x, AvailabilitySetData? y)
            {
                if (x == null && y == null)
                {
                    return 0;
                }
                else if (x == null)
                {
                    return -1;
                }
                else if (y == null)
                {
                    return 1;
                }
                else
                {
                    return x.Id!.CompareTo(y.Id);
                }
            }
        }

        private static readonly List<object> s_collections =
        [
            new List<AvailabilitySetData>(s_availabilitySets),
            new AvailabilitySetData[] { s_availabilitySets[0], s_availabilitySets[1] },
            new Collection<AvailabilitySetData> (s_availabilitySets),
            new ObservableCollection<AvailabilitySetData> (s_availabilitySets),
            new HashSet<AvailabilitySetData> (s_availabilitySets),
            new Queue<AvailabilitySetData> (s_availabilitySets),
            new Stack<AvailabilitySetData> (s_availabilitySets.Reverse()), //stack has the order flipped
            new LinkedList<AvailabilitySetData> (s_availabilitySets),
            new SortedSet<AvailabilitySetData> (s_availabilitySets, new AvailabilitySetDataComparer()),
            new ArrayList (new Collection<AvailabilitySetData>(s_availabilitySets)),
        ];

        [Test]
        public void ReadListGeneric()
        {
            var asetList = ModelReaderWriter.Read<List<AvailabilitySetData>>(s_data);
            Assert.IsNotNull(asetList);

            Assert.AreEqual(2, asetList!.Count);
            Assert.IsTrue(asetList[0].Name!.Equals("testAS-3375"));
            Assert.IsTrue(asetList[1].Name!.Equals("testAS-3376"));
        }

        [Test]
        public void ReadList()
        {
            var asetList = ModelReaderWriter.Read(s_data, typeof(List<AvailabilitySetData>));
            Assert.IsNotNull(asetList);

            List<AvailabilitySetData>? asetList2 = asetList! as List<AvailabilitySetData>;
            Assert.IsNotNull(asetList2);

            Assert.AreEqual(2, asetList2!.Count);
            Assert.IsTrue(asetList2[0].Name!.Equals("testAS-3375"));
            Assert.IsTrue(asetList2[1].Name!.Equals("testAS-3376"));
        }

        [TestCaseSource(nameof(s_collections))]
        public void WriteCollection(object collection)
        {
            BinaryData data = ModelReaderWriter.Write(collection);
            Assert.IsNotNull(data);
            Assert.AreEqual(s_collapsedPayload, data.ToString());
        }
    }
}
