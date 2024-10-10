// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.StandbyPool.Models;

namespace Azure.ResourceManager.StandbyPool.Samples
{
    public partial class Sample_StandbyContainerGroupPoolCollection
    {
        // StandbyContainerGroupPools_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StandbyContainerGroupPoolsGet()
        {
            // Generated from example definition: 2024-03-01/StandbyContainerGroupPools_Get.json
            // this example is just showing the usage of "StandbyContainerGroupPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolCollection collection = resourceGroupResource.GetStandbyContainerGroupPools();

            // invoke the operation
            string standbyContainerGroupPoolName = "pool";
            StandbyContainerGroupPoolResource result = await collection.GetAsync(standbyContainerGroupPoolName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyContainerGroupPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StandbyContainerGroupPools_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_StandbyContainerGroupPoolsGet()
        {
            // Generated from example definition: 2024-03-01/StandbyContainerGroupPools_Get.json
            // this example is just showing the usage of "StandbyContainerGroupPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolCollection collection = resourceGroupResource.GetStandbyContainerGroupPools();

            // invoke the operation
            string standbyContainerGroupPoolName = "pool";
            bool result = await collection.ExistsAsync(standbyContainerGroupPoolName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // StandbyContainerGroupPools_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_StandbyContainerGroupPoolsGet()
        {
            // Generated from example definition: 2024-03-01/StandbyContainerGroupPools_Get.json
            // this example is just showing the usage of "StandbyContainerGroupPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolCollection collection = resourceGroupResource.GetStandbyContainerGroupPools();

            // invoke the operation
            string standbyContainerGroupPoolName = "pool";
            NullableResponse<StandbyContainerGroupPoolResource> response = await collection.GetIfExistsAsync(standbyContainerGroupPoolName);
            StandbyContainerGroupPoolResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StandbyContainerGroupPoolData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // StandbyContainerGroupPools_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StandbyContainerGroupPoolsCreateOrUpdate()
        {
            // Generated from example definition: 2024-03-01/StandbyContainerGroupPools_CreateOrUpdate.json
            // this example is just showing the usage of "StandbyContainerGroupPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolCollection collection = resourceGroupResource.GetStandbyContainerGroupPools();

            // invoke the operation
            string standbyContainerGroupPoolName = "pool";
            StandbyContainerGroupPoolData data = new StandbyContainerGroupPoolData(new AzureLocation("West US"))
            {
                Properties = new StandbyContainerGroupPoolProperties(new StandbyContainerGroupPoolElasticityProfile(688L)
                {
                    RefillPolicy = StandbyRefillPolicy.Always,
                }, new StandbyContainerGroupProperties(new StandbyContainerGroupProfile(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000009/resourceGroups/rgstandbypool/providers/Microsoft.ContainerInstance/containerGroupProfiles/cgProfile"))
                {
                    Revision = 1L,
                })
                {
                    SubnetIds =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000009/resourceGroups/rgstandbypool/providers/Microsoft.Network/virtualNetworks/cgSubnet/subnets/cgSubnet"),
}
},
                }),
                Tags =
{
},
            };
            ArmOperation<StandbyContainerGroupPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, standbyContainerGroupPoolName, data);
            StandbyContainerGroupPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyContainerGroupPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StandbyContainerGroupPools_ListByResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_StandbyContainerGroupPoolsListByResourceGroup()
        {
            // Generated from example definition: 2024-03-01/StandbyContainerGroupPools_ListByResourceGroup.json
            // this example is just showing the usage of "StandbyContainerGroupPoolResource_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StandbyContainerGroupPoolResource
            StandbyContainerGroupPoolCollection collection = resourceGroupResource.GetStandbyContainerGroupPools();

            // invoke the operation and iterate over the result
            await foreach (StandbyContainerGroupPoolResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StandbyContainerGroupPoolData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
