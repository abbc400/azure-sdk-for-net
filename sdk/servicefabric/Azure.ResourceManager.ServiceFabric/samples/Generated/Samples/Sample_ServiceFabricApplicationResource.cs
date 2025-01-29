// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ServiceFabric.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceFabric.Samples
{
    public partial class Sample_ServiceFabricApplicationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnApplication()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ApplicationGetOperation_example.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricApplicationResource created on azure
            // for more information of creating ServiceFabricApplicationResource, please refer to the document of ServiceFabricApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricApplicationResourceId = ServiceFabricApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricApplicationResource serviceFabricApplication = client.GetServiceFabricApplicationResource(serviceFabricApplicationResourceId);

            // invoke the operation
            ServiceFabricApplicationResource result = await serviceFabricApplication.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnApplication()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ApplicationDeleteOperation_example.json
            // this example is just showing the usage of "Applications_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricApplicationResource created on azure
            // for more information of creating ServiceFabricApplicationResource, please refer to the document of ServiceFabricApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricApplicationResourceId = ServiceFabricApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricApplicationResource serviceFabricApplication = client.GetServiceFabricApplicationResource(serviceFabricApplicationResourceId);

            // invoke the operation
            await serviceFabricApplication.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchAnApplication()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ApplicationPatchOperation_example.json
            // this example is just showing the usage of "Applications_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricApplicationResource created on azure
            // for more information of creating ServiceFabricApplicationResource, please refer to the document of ServiceFabricApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricApplicationResourceId = ServiceFabricApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricApplicationResource serviceFabricApplication = client.GetServiceFabricApplicationResource(serviceFabricApplicationResourceId);

            // invoke the operation
            ServiceFabricApplicationPatch patch = new ServiceFabricApplicationPatch(new AzureLocation("eastus"))
            {
                TypeVersion = "1.0",
                RemoveApplicationCapacity = false,
                Metrics = {new ApplicationMetricDescription
{
Name = "metric1",
MaximumCapacity = 3L,
ReservationCapacity = 1L,
TotalApplicationCapacity = 5L,
}},
                Tags = { },
            };
            ArmOperation<ServiceFabricApplicationResource> lro = await serviceFabricApplication.UpdateAsync(WaitUntil.Completed, patch);
            ServiceFabricApplicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
