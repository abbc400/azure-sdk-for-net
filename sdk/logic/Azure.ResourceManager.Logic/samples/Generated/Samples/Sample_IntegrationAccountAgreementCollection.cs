// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Logic.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Logic.Samples
{
    public partial class Sample_IntegrationAccountAgreementCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAnAgreement()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountAgreements_CreateOrUpdate.json
            // this example is just showing the usage of "IntegrationAccountAgreements_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountAgreementResource
            IntegrationAccountAgreementCollection collection = integrationAccount.GetIntegrationAccountAgreements();

            // invoke the operation
            string agreementName = "testAgreement";
            IntegrationAccountAgreementData data = new IntegrationAccountAgreementData(
                new AzureLocation("westus"),
                IntegrationAccountAgreementType.AS2,
                "HostPartner",
                "GuestPartner",
                new IntegrationAccountBusinessIdentity("ZZ", "ZZ"),
                new IntegrationAccountBusinessIdentity("AA", "AA"),
                new IntegrationAccountAgreementContent
                {
                    AS2 = new AS2AgreementContent(new AS2OneWayAgreement(new IntegrationAccountBusinessIdentity("AA", "AA"), new IntegrationAccountBusinessIdentity("ZZ", "ZZ"), new AS2ProtocolSettings(
                new AS2MessageConnectionSettings(true, true, true, true),
                new AS2AcknowledgementConnectionSettings(true, true, true, true),
                new AS2MdnSettings(
                true,
                true,
                true,
                true,
                true,
                AS2HashingAlgorithm.Sha1)
                {
                    ReceiptDeliveryUri = new Uri("http://tempuri.org"),
                    DispositionNotificationTo = "http://tempuri.org",
                    MdnText = "Sample",
                },
                new AS2SecuritySettings(
                false,
                true,
                true,
                true,
                true,
                true,
                true),
                new AS2ValidationSettings(
                true,
                false,
                false,
                true,
                true,
                100,
                true,
                true,
                AS2EncryptionAlgorithm.Aes128),
                new AS2EnvelopeSettings(new ContentType("text/plain"), true, "Test", true, true),
                new AS2ErrorSettings(true, true))), new AS2OneWayAgreement(new IntegrationAccountBusinessIdentity("ZZ", "ZZ"), new IntegrationAccountBusinessIdentity("AA", "AA"), new AS2ProtocolSettings(
                new AS2MessageConnectionSettings(true, true, true, true),
                new AS2AcknowledgementConnectionSettings(true, true, true, true),
                new AS2MdnSettings(
                true,
                true,
                true,
                true,
                true,
                AS2HashingAlgorithm.Sha1)
                {
                    ReceiptDeliveryUri = new Uri("http://tempuri.org"),
                    DispositionNotificationTo = "http://tempuri.org",
                    MdnText = "Sample",
                },
                new AS2SecuritySettings(
                false,
                true,
                true,
                true,
                true,
                true,
                true),
                new AS2ValidationSettings(
                true,
                false,
                false,
                true,
                true,
                100,
                true,
                true,
                AS2EncryptionAlgorithm.Aes128),
                new AS2EnvelopeSettings(new ContentType("text/plain"), true, "Test", true, true),
                new AS2ErrorSettings(true, true)))),
                })
            {
                Metadata = BinaryData.FromObjectAsJson(new object()),
                Tags =
{
["IntegrationAccountAgreement"] = "<IntegrationAccountAgreementName>"
},
            };
            ArmOperation<IntegrationAccountAgreementResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, agreementName, data);
            IntegrationAccountAgreementResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountAgreementData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAgreementByName()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountAgreements_Get.json
            // this example is just showing the usage of "IntegrationAccountAgreements_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountAgreementResource
            IntegrationAccountAgreementCollection collection = integrationAccount.GetIntegrationAccountAgreements();

            // invoke the operation
            string agreementName = "testAgreement";
            IntegrationAccountAgreementResource result = await collection.GetAsync(agreementName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountAgreementData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetAgreementsByIntegrationAccountName()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountAgreements_List.json
            // this example is just showing the usage of "IntegrationAccountAgreements_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountAgreementResource
            IntegrationAccountAgreementCollection collection = integrationAccount.GetIntegrationAccountAgreements();

            // invoke the operation and iterate over the result
            await foreach (IntegrationAccountAgreementResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IntegrationAccountAgreementData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAgreementByName()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountAgreements_Get.json
            // this example is just showing the usage of "IntegrationAccountAgreements_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountAgreementResource
            IntegrationAccountAgreementCollection collection = integrationAccount.GetIntegrationAccountAgreements();

            // invoke the operation
            string agreementName = "testAgreement";
            bool result = await collection.ExistsAsync(agreementName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAgreementByName()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountAgreements_Get.json
            // this example is just showing the usage of "IntegrationAccountAgreements_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountAgreementResource
            IntegrationAccountAgreementCollection collection = integrationAccount.GetIntegrationAccountAgreements();

            // invoke the operation
            string agreementName = "testAgreement";
            NullableResponse<IntegrationAccountAgreementResource> response = await collection.GetIfExistsAsync(agreementName);
            IntegrationAccountAgreementResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IntegrationAccountAgreementData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
