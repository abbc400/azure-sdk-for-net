// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_ManagedInstancePrivateEndpointConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApproveOrRejectAPrivateEndpointConnectionWithAGivenName()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstancePrivateEndpointConnectionUpdate.json
            // this example is just showing the usage of "ManagedInstancePrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string managedInstanceName = "test-cl";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstancePrivateEndpointConnectionResource
            ManagedInstancePrivateEndpointConnectionCollection collection = managedInstance.GetManagedInstancePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "private-endpoint-connection-name";
            ManagedInstancePrivateEndpointConnectionData data = new ManagedInstancePrivateEndpointConnectionData
            {
                ConnectionState = new ManagedInstancePrivateLinkServiceConnectionStateProperty("Approved", "Approved by johndoe@contoso.com"),
            };
            ArmOperation<ManagedInstancePrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            ManagedInstancePrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedInstancePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsPrivateEndpointConnection()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstancePrivateEndpointConnectionGet.json
            // this example is just showing the usage of "ManagedInstancePrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string managedInstanceName = "test-cl";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstancePrivateEndpointConnectionResource
            ManagedInstancePrivateEndpointConnectionCollection collection = managedInstance.GetManagedInstancePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "private-endpoint-connection-name";
            ManagedInstancePrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedInstancePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetsListOfPrivateEndpointConnectionsOnAServer()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstancePrivateEndpointConnectionList.json
            // this example is just showing the usage of "ManagedInstancePrivateEndpointConnections_ListByManagedInstance" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string managedInstanceName = "test-cl";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstancePrivateEndpointConnectionResource
            ManagedInstancePrivateEndpointConnectionCollection collection = managedInstance.GetManagedInstancePrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (ManagedInstancePrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedInstancePrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetsPrivateEndpointConnection()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstancePrivateEndpointConnectionGet.json
            // this example is just showing the usage of "ManagedInstancePrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string managedInstanceName = "test-cl";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstancePrivateEndpointConnectionResource
            ManagedInstancePrivateEndpointConnectionCollection collection = managedInstance.GetManagedInstancePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "private-endpoint-connection-name";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetsPrivateEndpointConnection()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstancePrivateEndpointConnectionGet.json
            // this example is just showing the usage of "ManagedInstancePrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string managedInstanceName = "test-cl";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstancePrivateEndpointConnectionResource
            ManagedInstancePrivateEndpointConnectionCollection collection = managedInstance.GetManagedInstancePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "private-endpoint-connection-name";
            NullableResponse<ManagedInstancePrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            ManagedInstancePrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedInstancePrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
