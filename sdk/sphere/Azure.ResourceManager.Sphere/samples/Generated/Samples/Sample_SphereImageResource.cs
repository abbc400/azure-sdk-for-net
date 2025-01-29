// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Sphere.Samples
{
    public partial class Sample_SphereImageResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ImagesGet()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/GetImage.json
            // this example is just showing the usage of "Images_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereImageResource created on azure
            // for more information of creating SphereImageResource, please refer to the document of SphereImageResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            string imageName = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier sphereImageResourceId = SphereImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName, imageName);
            SphereImageResource sphereImage = client.GetSphereImageResource(sphereImageResourceId);

            // invoke the operation
            SphereImageResource result = await sphereImage.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SphereImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ImagesDelete()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/DeleteImage.json
            // this example is just showing the usage of "Images_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereImageResource created on azure
            // for more information of creating SphereImageResource, please refer to the document of SphereImageResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            string imageName = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier sphereImageResourceId = SphereImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName, imageName);
            SphereImageResource sphereImage = client.GetSphereImageResource(sphereImageResourceId);

            // invoke the operation
            await sphereImage.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ImageCreateOrUpdate()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/PutImage.json
            // this example is just showing the usage of "Images_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereImageResource created on azure
            // for more information of creating SphereImageResource, please refer to the document of SphereImageResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            string imageName = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier sphereImageResourceId = SphereImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName, imageName);
            SphereImageResource sphereImage = client.GetSphereImageResource(sphereImageResourceId);

            // invoke the operation
            SphereImageData data = new SphereImageData
            {
                Image = "bXliYXNlNjRzdHJpbmc=",
            };
            ArmOperation<SphereImageResource> lro = await sphereImage.UpdateAsync(WaitUntil.Completed, data);
            SphereImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SphereImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
