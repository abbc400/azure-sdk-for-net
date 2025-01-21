// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_GalleryInVmAccessControlProfileVersionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAGalleryInVMAccessControlProfileVersion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2024-03-03/examples/galleryResourceProfileExamples/GalleryInVMAccessControlProfileVersion_Get.json
            // this example is just showing the usage of "GalleryInVMAccessControlProfileVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryInVmAccessControlProfileVersionResource created on azure
            // for more information of creating GalleryInVmAccessControlProfileVersionResource, please refer to the document of GalleryInVmAccessControlProfileVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string inVmAccessControlProfileName = "myInVMAccessControlProfileName";
            string inVmAccessControlProfileVersionName = "1.0.0";
            ResourceIdentifier galleryInVmAccessControlProfileVersionResourceId = GalleryInVmAccessControlProfileVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, inVmAccessControlProfileName, inVmAccessControlProfileVersionName);
            GalleryInVmAccessControlProfileVersionResource galleryInVmAccessControlProfileVersion = client.GetGalleryInVmAccessControlProfileVersionResource(galleryInVmAccessControlProfileVersionResourceId);

            // invoke the operation
            GalleryInVmAccessControlProfileVersionResource result = await galleryInVmAccessControlProfileVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryInVmAccessControlProfileVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAGalleryInVMAccessControlProfileVersion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2024-03-03/examples/galleryResourceProfileExamples/GalleryInVMAccessControlProfileVersion_Delete.json
            // this example is just showing the usage of "GalleryInVMAccessControlProfileVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryInVmAccessControlProfileVersionResource created on azure
            // for more information of creating GalleryInVmAccessControlProfileVersionResource, please refer to the document of GalleryInVmAccessControlProfileVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string inVmAccessControlProfileName = "myInVMAccessControlProfileName";
            string inVmAccessControlProfileVersionName = "1.0.0";
            ResourceIdentifier galleryInVmAccessControlProfileVersionResourceId = GalleryInVmAccessControlProfileVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, inVmAccessControlProfileName, inVmAccessControlProfileVersionName);
            GalleryInVmAccessControlProfileVersionResource galleryInVmAccessControlProfileVersion = client.GetGalleryInVmAccessControlProfileVersionResource(galleryInVmAccessControlProfileVersionResourceId);

            // invoke the operation
            await galleryInVmAccessControlProfileVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAGalleryInVMAccessControlProfileVersion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2024-03-03/examples/galleryResourceProfileExamples/GalleryInVMAccessControlProfileVersion_Update.json
            // this example is just showing the usage of "GalleryInVMAccessControlProfileVersions_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryInVmAccessControlProfileVersionResource created on azure
            // for more information of creating GalleryInVmAccessControlProfileVersionResource, please refer to the document of GalleryInVmAccessControlProfileVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string inVmAccessControlProfileName = "myInVMAccessControlProfileName";
            string inVmAccessControlProfileVersionName = "1.0.0";
            ResourceIdentifier galleryInVmAccessControlProfileVersionResourceId = GalleryInVmAccessControlProfileVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, inVmAccessControlProfileName, inVmAccessControlProfileVersionName);
            GalleryInVmAccessControlProfileVersionResource galleryInVmAccessControlProfileVersion = client.GetGalleryInVmAccessControlProfileVersionResource(galleryInVmAccessControlProfileVersionResourceId);

            // invoke the operation
            GalleryInVmAccessControlProfileVersionPatch patch = new GalleryInVmAccessControlProfileVersionPatch
            {
                TargetLocations = { new TargetRegion("West US"), new TargetRegion("South Central US"), new TargetRegion("East US") },
                ExcludeFromLatest = false,
                Mode = GalleryInVmAccessControlRulesMode.Audit,
                DefaultAccess = ComputeGalleryEndpointAccess.Allow,
            };
            ArmOperation<GalleryInVmAccessControlProfileVersionResource> lro = await galleryInVmAccessControlProfileVersion.UpdateAsync(WaitUntil.Completed, patch);
            GalleryInVmAccessControlProfileVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryInVmAccessControlProfileVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
