// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_WorkloadNetworkDnsZoneResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_WorkloadNetworksGetDnsZone()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_GetDnsZone.json
            // this example is just showing the usage of "WorkloadNetworks_GetDnsZone" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkDnsZoneResource created on azure
            // for more information of creating WorkloadNetworkDnsZoneResource, please refer to the document of WorkloadNetworkDnsZoneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string dnsZoneId = "dnsZone1";
            ResourceIdentifier workloadNetworkDnsZoneResourceId = WorkloadNetworkDnsZoneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, dnsZoneId);
            WorkloadNetworkDnsZoneResource workloadNetworkDnsZone = client.GetWorkloadNetworkDnsZoneResource(workloadNetworkDnsZoneResourceId);

            // invoke the operation
            WorkloadNetworkDnsZoneResource result = await workloadNetworkDnsZone.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkDnsZoneData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_WorkloadNetworksDeleteDnsZone()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_DeleteDnsZone.json
            // this example is just showing the usage of "WorkloadNetworks_DeleteDnsZone" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkDnsZoneResource created on azure
            // for more information of creating WorkloadNetworkDnsZoneResource, please refer to the document of WorkloadNetworkDnsZoneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string dnsZoneId = "dnsZone1";
            ResourceIdentifier workloadNetworkDnsZoneResourceId = WorkloadNetworkDnsZoneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, dnsZoneId);
            WorkloadNetworkDnsZoneResource workloadNetworkDnsZone = client.GetWorkloadNetworkDnsZoneResource(workloadNetworkDnsZoneResourceId);

            // invoke the operation
            await workloadNetworkDnsZone.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_WorkloadNetworksUpdateDnsZone()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_UpdateDnsZone.json
            // this example is just showing the usage of "WorkloadNetworks_UpdateDnsZone" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkDnsZoneResource created on azure
            // for more information of creating WorkloadNetworkDnsZoneResource, please refer to the document of WorkloadNetworkDnsZoneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string dnsZoneId = "dnsZone1";
            ResourceIdentifier workloadNetworkDnsZoneResourceId = WorkloadNetworkDnsZoneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, dnsZoneId);
            WorkloadNetworkDnsZoneResource workloadNetworkDnsZone = client.GetWorkloadNetworkDnsZoneResource(workloadNetworkDnsZoneResourceId);

            // invoke the operation
            WorkloadNetworkDnsZoneData data = new WorkloadNetworkDnsZoneData
            {
                DisplayName = "dnsZone1",
                Domain = { },
                DnsServerIPs = { IPAddress.Parse("1.1.1.1") },
                SourceIP = IPAddress.Parse("8.8.8.8"),
                Revision = 1L,
            };
            ArmOperation<WorkloadNetworkDnsZoneResource> lro = await workloadNetworkDnsZone.UpdateAsync(WaitUntil.Completed, data);
            WorkloadNetworkDnsZoneResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkDnsZoneData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
