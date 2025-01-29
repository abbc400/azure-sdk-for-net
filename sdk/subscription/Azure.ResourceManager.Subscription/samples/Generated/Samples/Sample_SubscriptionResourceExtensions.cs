// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Subscription.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Subscription.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CancelSubscription_CancelSubscription()
        {
            // Generated from example definition: specification/subscription/resource-manager/Microsoft.Subscription/stable/2021-10-01/examples/cancelSubscription.json
            // this example is just showing the usage of "Subscription_Cancel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "83aa47df-e3e9-49ff-877b-94304bf3d3ad";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            CanceledSubscriptionId result = await subscriptionResource.CancelSubscriptionAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RenameSubscription_RenameSubscription()
        {
            // Generated from example definition: specification/subscription/resource-manager/Microsoft.Subscription/stable/2021-10-01/examples/renameSubscription.json
            // this example is just showing the usage of "Subscription_Rename" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "83aa47df-e3e9-49ff-877b-94304bf3d3ad";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            SubscriptionName body = new SubscriptionName
            {
                SubscriptionNameValue = "Test Sub",
            };
            RenamedSubscriptionId result = await subscriptionResource.RenameSubscriptionAsync(body);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task EnableSubscription_EnableSubscription()
        {
            // Generated from example definition: specification/subscription/resource-manager/Microsoft.Subscription/stable/2021-10-01/examples/enableSubscription.json
            // this example is just showing the usage of "Subscription_Enable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "7948bcee-488c-47ce-941c-38e20ede803d";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            EnabledSubscriptionId result = await subscriptionResource.EnableSubscriptionAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
