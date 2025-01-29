// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventHubs.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.EventHubs.Samples
{
    public partial class Sample_EventHubsSchemaGroupResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SchemaRegistryGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/SchemaRegistry/SchemaRegistryGet.json
            // this example is just showing the usage of "SchemaRegistry_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsSchemaGroupResource created on azure
            // for more information of creating EventHubsSchemaGroupResource, please refer to the document of EventHubsSchemaGroupResource
            string subscriptionId = "e8baea74-64ce-459b-bee3-5aa4c47b3ae3";
            string resourceGroupName = "alitest";
            string namespaceName = "ali-ua-test-eh-system-1";
            string schemaGroupName = "testSchemaGroup1";
            ResourceIdentifier eventHubsSchemaGroupResourceId = EventHubsSchemaGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, schemaGroupName);
            EventHubsSchemaGroupResource eventHubsSchemaGroup = client.GetEventHubsSchemaGroupResource(eventHubsSchemaGroupResourceId);

            // invoke the operation
            EventHubsSchemaGroupResource result = await eventHubsSchemaGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsSchemaGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_SchemaRegistryDelete()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/SchemaRegistry/SchemaRegistryDelete.json
            // this example is just showing the usage of "SchemaRegistry_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsSchemaGroupResource created on azure
            // for more information of creating EventHubsSchemaGroupResource, please refer to the document of EventHubsSchemaGroupResource
            string subscriptionId = "e8baea74-64ce-459b-bee3-5aa4c47b3ae3";
            string resourceGroupName = "alitest";
            string namespaceName = "ali-ua-test-eh-system-1";
            string schemaGroupName = "testSchemaGroup1";
            ResourceIdentifier eventHubsSchemaGroupResourceId = EventHubsSchemaGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, schemaGroupName);
            EventHubsSchemaGroupResource eventHubsSchemaGroup = client.GetEventHubsSchemaGroupResource(eventHubsSchemaGroupResourceId);

            // invoke the operation
            await eventHubsSchemaGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SchemaRegistryCreate()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/SchemaRegistry/SchemaRegistryCreate.json
            // this example is just showing the usage of "SchemaRegistry_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsSchemaGroupResource created on azure
            // for more information of creating EventHubsSchemaGroupResource, please refer to the document of EventHubsSchemaGroupResource
            string subscriptionId = "e8baea74-64ce-459b-bee3-5aa4c47b3ae3";
            string resourceGroupName = "alitest";
            string namespaceName = "ali-ua-test-eh-system-1";
            string schemaGroupName = "testSchemaGroup1";
            ResourceIdentifier eventHubsSchemaGroupResourceId = EventHubsSchemaGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, schemaGroupName);
            EventHubsSchemaGroupResource eventHubsSchemaGroup = client.GetEventHubsSchemaGroupResource(eventHubsSchemaGroupResourceId);

            // invoke the operation
            EventHubsSchemaGroupData data = new EventHubsSchemaGroupData
            {
                GroupProperties = { },
                SchemaCompatibility = EventHubsSchemaCompatibility.Forward,
                SchemaType = EventHubsSchemaType.Avro,
            };
            ArmOperation<EventHubsSchemaGroupResource> lro = await eventHubsSchemaGroup.UpdateAsync(WaitUntil.Completed, data);
            EventHubsSchemaGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsSchemaGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
