// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Authorization.Samples
{
    public partial class Sample_RoleManagementPolicyCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetRoleManagementPolicyByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/GetRoleManagementPolicyByName.json
            // this example is just showing the usage of "RoleManagementPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this RoleManagementPolicyResource
            string scope = "providers/Microsoft.Subscription/subscriptions/129ff972-28f8-46b8-a726-e497be039368";
            RoleManagementPolicyCollection collection = client.GetRoleManagementPolicies(new ResourceIdentifier(scope));

            // invoke the operation
            string roleManagementPolicyName = "570c3619-7688-4b34-b290-2b8bb3ccab2a";
            RoleManagementPolicyResource result = await collection.GetAsync(roleManagementPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleManagementPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetRoleManagementPolicyByRoleDefinitionFilter()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/GetRoleManagementPolicyByScope.json
            // this example is just showing the usage of "RoleManagementPolicies_ListForScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this RoleManagementPolicyResource
            string scope = "providers/Microsoft.Subscription/subscriptions/129ff972-28f8-46b8-a726-e497be039368";
            RoleManagementPolicyCollection collection = client.GetRoleManagementPolicies(new ResourceIdentifier(scope));

            // invoke the operation and iterate over the result
            await foreach (RoleManagementPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RoleManagementPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetRoleManagementPolicyByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/GetRoleManagementPolicyByName.json
            // this example is just showing the usage of "RoleManagementPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this RoleManagementPolicyResource
            string scope = "providers/Microsoft.Subscription/subscriptions/129ff972-28f8-46b8-a726-e497be039368";
            RoleManagementPolicyCollection collection = client.GetRoleManagementPolicies(new ResourceIdentifier(scope));

            // invoke the operation
            string roleManagementPolicyName = "570c3619-7688-4b34-b290-2b8bb3ccab2a";
            bool result = await collection.ExistsAsync(roleManagementPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetRoleManagementPolicyByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/GetRoleManagementPolicyByName.json
            // this example is just showing the usage of "RoleManagementPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this RoleManagementPolicyResource
            string scope = "providers/Microsoft.Subscription/subscriptions/129ff972-28f8-46b8-a726-e497be039368";
            RoleManagementPolicyCollection collection = client.GetRoleManagementPolicies(new ResourceIdentifier(scope));

            // invoke the operation
            string roleManagementPolicyName = "570c3619-7688-4b34-b290-2b8bb3ccab2a";
            NullableResponse<RoleManagementPolicyResource> response = await collection.GetIfExistsAsync(roleManagementPolicyName);
            RoleManagementPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RoleManagementPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
