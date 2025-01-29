// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppConfiguration.Samples
{
    public partial class Sample_AppConfigurationKeyValueCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_KeyValuesCreateOrUpdate()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2023-03-01/examples/ConfigurationStoresCreateKeyValue.json
            // this example is just showing the usage of "KeyValues_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationStoreResource created on azure
            // for more information of creating AppConfigurationStoreResource, please refer to the document of AppConfigurationStoreResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            ResourceIdentifier appConfigurationStoreResourceId = AppConfigurationStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName);
            AppConfigurationStoreResource appConfigurationStore = client.GetAppConfigurationStoreResource(appConfigurationStoreResourceId);

            // get the collection of this AppConfigurationKeyValueResource
            AppConfigurationKeyValueCollection collection = appConfigurationStore.GetAppConfigurationKeyValues();

            // invoke the operation
            string keyValueName = "myKey$myLabel";
            AppConfigurationKeyValueData data = new AppConfigurationKeyValueData
            {
                Value = "myValue",
                Tags =
{
["tag1"] = "tagValue1",
["tag2"] = "tagValue2"
},
            };
            ArmOperation<AppConfigurationKeyValueResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, keyValueName, data);
            AppConfigurationKeyValueResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppConfigurationKeyValueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_KeyValuesGet()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2023-03-01/examples/ConfigurationStoresGetKeyValue.json
            // this example is just showing the usage of "KeyValues_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationStoreResource created on azure
            // for more information of creating AppConfigurationStoreResource, please refer to the document of AppConfigurationStoreResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            ResourceIdentifier appConfigurationStoreResourceId = AppConfigurationStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName);
            AppConfigurationStoreResource appConfigurationStore = client.GetAppConfigurationStoreResource(appConfigurationStoreResourceId);

            // get the collection of this AppConfigurationKeyValueResource
            AppConfigurationKeyValueCollection collection = appConfigurationStore.GetAppConfigurationKeyValues();

            // invoke the operation
            string keyValueName = "myKey$myLabel";
            AppConfigurationKeyValueResource result = await collection.GetAsync(keyValueName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppConfigurationKeyValueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_KeyValuesGet()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2023-03-01/examples/ConfigurationStoresGetKeyValue.json
            // this example is just showing the usage of "KeyValues_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationStoreResource created on azure
            // for more information of creating AppConfigurationStoreResource, please refer to the document of AppConfigurationStoreResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            ResourceIdentifier appConfigurationStoreResourceId = AppConfigurationStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName);
            AppConfigurationStoreResource appConfigurationStore = client.GetAppConfigurationStoreResource(appConfigurationStoreResourceId);

            // get the collection of this AppConfigurationKeyValueResource
            AppConfigurationKeyValueCollection collection = appConfigurationStore.GetAppConfigurationKeyValues();

            // invoke the operation
            string keyValueName = "myKey$myLabel";
            bool result = await collection.ExistsAsync(keyValueName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_KeyValuesGet()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2023-03-01/examples/ConfigurationStoresGetKeyValue.json
            // this example is just showing the usage of "KeyValues_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationStoreResource created on azure
            // for more information of creating AppConfigurationStoreResource, please refer to the document of AppConfigurationStoreResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            ResourceIdentifier appConfigurationStoreResourceId = AppConfigurationStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName);
            AppConfigurationStoreResource appConfigurationStore = client.GetAppConfigurationStoreResource(appConfigurationStoreResourceId);

            // get the collection of this AppConfigurationKeyValueResource
            AppConfigurationKeyValueCollection collection = appConfigurationStore.GetAppConfigurationKeyValues();

            // invoke the operation
            string keyValueName = "myKey$myLabel";
            NullableResponse<AppConfigurationKeyValueResource> response = await collection.GetIfExistsAsync(keyValueName);
            AppConfigurationKeyValueResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppConfigurationKeyValueData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
