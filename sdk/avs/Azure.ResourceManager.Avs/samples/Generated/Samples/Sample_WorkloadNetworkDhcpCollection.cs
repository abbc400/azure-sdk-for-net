// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Avs.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_WorkloadNetworkDhcpCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_WorkloadNetworksCreateDhcp()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_CreateDhcp.json
            // this example is just showing the usage of "WorkloadNetworks_CreateDhcp" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkDhcpResource
            WorkloadNetworkDhcpCollection collection = workloadNetwork.GetWorkloadNetworkDhcps();

            // invoke the operation
            string dhcpId = "dhcp1";
            WorkloadNetworkDhcpData data = new WorkloadNetworkDhcpData
            {
                Properties = new WorkloadNetworkDhcpServer
                {
                    ServerAddress = "40.1.5.1/24",
                    LeaseTime = 86400L,
                    DisplayName = "dhcpConfigurations1",
                    Revision = 1L,
                },
            };
            ArmOperation<WorkloadNetworkDhcpResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dhcpId, data);
            WorkloadNetworkDhcpResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkDhcpData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_WorkloadNetworksGetDhcp()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_GetDhcp.json
            // this example is just showing the usage of "WorkloadNetworks_GetDhcp" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkDhcpResource
            WorkloadNetworkDhcpCollection collection = workloadNetwork.GetWorkloadNetworkDhcps();

            // invoke the operation
            string dhcpId = "dhcp1";
            WorkloadNetworkDhcpResource result = await collection.GetAsync(dhcpId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkDhcpData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_WorkloadNetworksListDhcp()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_ListDhcp.json
            // this example is just showing the usage of "WorkloadNetworks_ListDhcp" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkDhcpResource
            WorkloadNetworkDhcpCollection collection = workloadNetwork.GetWorkloadNetworkDhcps();

            // invoke the operation and iterate over the result
            await foreach (WorkloadNetworkDhcpResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkloadNetworkDhcpData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_WorkloadNetworksGetDhcp()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_GetDhcp.json
            // this example is just showing the usage of "WorkloadNetworks_GetDhcp" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkDhcpResource
            WorkloadNetworkDhcpCollection collection = workloadNetwork.GetWorkloadNetworkDhcps();

            // invoke the operation
            string dhcpId = "dhcp1";
            bool result = await collection.ExistsAsync(dhcpId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_WorkloadNetworksGetDhcp()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_GetDhcp.json
            // this example is just showing the usage of "WorkloadNetworks_GetDhcp" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkDhcpResource
            WorkloadNetworkDhcpCollection collection = workloadNetwork.GetWorkloadNetworkDhcps();

            // invoke the operation
            string dhcpId = "dhcp1";
            NullableResponse<WorkloadNetworkDhcpResource> response = await collection.GetIfExistsAsync(dhcpId);
            WorkloadNetworkDhcpResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkloadNetworkDhcpData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
