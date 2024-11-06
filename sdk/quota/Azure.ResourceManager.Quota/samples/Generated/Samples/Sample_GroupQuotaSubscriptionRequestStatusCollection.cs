// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Quota.Samples
{
    public partial class Sample_GroupQuotaSubscriptionRequestStatusCollection
    {
        // GroupQuotaSubscriptionRequests_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GroupQuotaSubscriptionRequestsList()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2024-10-15-preview/examples/SubscriptionRequests/SubscriptionRequests_List.json
            // this example is just showing the usage of "GroupQuotaSubscriptionRequests_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GroupQuotaEntityResource created on azure
            // for more information of creating GroupQuotaEntityResource, please refer to the document of GroupQuotaEntityResource
            string managementGroupId = "E7EC67B3-7657-4966-BFFC-41EFD36BAA09";
            string groupQuotaName = "groupquota1";
            ResourceIdentifier groupQuotaEntityResourceId = GroupQuotaEntityResource.CreateResourceIdentifier(managementGroupId, groupQuotaName);
            GroupQuotaEntityResource groupQuotaEntity = client.GetGroupQuotaEntityResource(groupQuotaEntityResourceId);

            // get the collection of this GroupQuotaSubscriptionRequestStatusResource
            GroupQuotaSubscriptionRequestStatusCollection collection = groupQuotaEntity.GetGroupQuotaSubscriptionRequestStatuses();

            // invoke the operation and iterate over the result
            await foreach (GroupQuotaSubscriptionRequestStatusResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GroupQuotaSubscriptionRequestStatusData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GroupQuotaSubscriptionRequests_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GroupQuotaSubscriptionRequestsGet()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2024-10-15-preview/examples/SubscriptionRequests/SubscriptionRequests_Get.json
            // this example is just showing the usage of "GroupQuotaSubscriptionRequests_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GroupQuotaEntityResource created on azure
            // for more information of creating GroupQuotaEntityResource, please refer to the document of GroupQuotaEntityResource
            string managementGroupId = "E7EC67B3-7657-4966-BFFC-41EFD36BAA09";
            string groupQuotaName = "groupquota1";
            ResourceIdentifier groupQuotaEntityResourceId = GroupQuotaEntityResource.CreateResourceIdentifier(managementGroupId, groupQuotaName);
            GroupQuotaEntityResource groupQuotaEntity = client.GetGroupQuotaEntityResource(groupQuotaEntityResourceId);

            // get the collection of this GroupQuotaSubscriptionRequestStatusResource
            GroupQuotaSubscriptionRequestStatusCollection collection = groupQuotaEntity.GetGroupQuotaSubscriptionRequestStatuses();

            // invoke the operation
            string requestId = "00000000-0000-0000-0000-000000000000";
            GroupQuotaSubscriptionRequestStatusResource result = await collection.GetAsync(requestId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GroupQuotaSubscriptionRequestStatusData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GroupQuotaSubscriptionRequests_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GroupQuotaSubscriptionRequestsGet()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2024-10-15-preview/examples/SubscriptionRequests/SubscriptionRequests_Get.json
            // this example is just showing the usage of "GroupQuotaSubscriptionRequests_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GroupQuotaEntityResource created on azure
            // for more information of creating GroupQuotaEntityResource, please refer to the document of GroupQuotaEntityResource
            string managementGroupId = "E7EC67B3-7657-4966-BFFC-41EFD36BAA09";
            string groupQuotaName = "groupquota1";
            ResourceIdentifier groupQuotaEntityResourceId = GroupQuotaEntityResource.CreateResourceIdentifier(managementGroupId, groupQuotaName);
            GroupQuotaEntityResource groupQuotaEntity = client.GetGroupQuotaEntityResource(groupQuotaEntityResourceId);

            // get the collection of this GroupQuotaSubscriptionRequestStatusResource
            GroupQuotaSubscriptionRequestStatusCollection collection = groupQuotaEntity.GetGroupQuotaSubscriptionRequestStatuses();

            // invoke the operation
            string requestId = "00000000-0000-0000-0000-000000000000";
            bool result = await collection.ExistsAsync(requestId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GroupQuotaSubscriptionRequests_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GroupQuotaSubscriptionRequestsGet()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2024-10-15-preview/examples/SubscriptionRequests/SubscriptionRequests_Get.json
            // this example is just showing the usage of "GroupQuotaSubscriptionRequests_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GroupQuotaEntityResource created on azure
            // for more information of creating GroupQuotaEntityResource, please refer to the document of GroupQuotaEntityResource
            string managementGroupId = "E7EC67B3-7657-4966-BFFC-41EFD36BAA09";
            string groupQuotaName = "groupquota1";
            ResourceIdentifier groupQuotaEntityResourceId = GroupQuotaEntityResource.CreateResourceIdentifier(managementGroupId, groupQuotaName);
            GroupQuotaEntityResource groupQuotaEntity = client.GetGroupQuotaEntityResource(groupQuotaEntityResourceId);

            // get the collection of this GroupQuotaSubscriptionRequestStatusResource
            GroupQuotaSubscriptionRequestStatusCollection collection = groupQuotaEntity.GetGroupQuotaSubscriptionRequestStatuses();

            // invoke the operation
            string requestId = "00000000-0000-0000-0000-000000000000";
            NullableResponse<GroupQuotaSubscriptionRequestStatusResource> response = await collection.GetIfExistsAsync(requestId);
            GroupQuotaSubscriptionRequestStatusResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GroupQuotaSubscriptionRequestStatusData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
