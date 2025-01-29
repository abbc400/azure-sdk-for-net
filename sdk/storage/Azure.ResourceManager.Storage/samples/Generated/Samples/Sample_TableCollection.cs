// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Storage.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Storage.Samples
{
    public partial class Sample_TableCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_TableOperationPut()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/TableOperationPut.json
            // this example is just showing the usage of "Table_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TableServiceResource created on azure
            // for more information of creating TableServiceResource, please refer to the document of TableServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res3376";
            string accountName = "sto328";
            ResourceIdentifier tableServiceResourceId = TableServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            TableServiceResource tableService = client.GetTableServiceResource(tableServiceResourceId);

            // get the collection of this TableResource
            TableCollection collection = tableService.GetTables();

            // invoke the operation
            string tableName = "table6185";
            TableData data = new TableData();
            ArmOperation<TableResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, tableName, data);
            TableResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_TableOperationPutOrPatchAcls()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/TableOperationPutOrPatchAcls.json
            // this example is just showing the usage of "Table_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TableServiceResource created on azure
            // for more information of creating TableServiceResource, please refer to the document of TableServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res3376";
            string accountName = "sto328";
            ResourceIdentifier tableServiceResourceId = TableServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            TableServiceResource tableService = client.GetTableServiceResource(tableServiceResourceId);

            // get the collection of this TableResource
            TableCollection collection = tableService.GetTables();

            // invoke the operation
            string tableName = "table6185";
            TableData data = new TableData
            {
                SignedIdentifiers = {new StorageTableSignedIdentifier("MTIzNDU2Nzg5MDEyMzQ1Njc4OTAxMjM0NTY3ODkwMTI")
{
AccessPolicy = new StorageTableAccessPolicy("raud")
{
StartOn = DateTimeOffset.Parse("2022-03-17T08:49:37.0000000Z"),
ExpireOn = DateTimeOffset.Parse("2022-03-20T08:49:37.0000000Z"),
},
}, new StorageTableSignedIdentifier("PTIzNDU2Nzg5MDEyMzQ1Njc4OTAxMjM0NTY3ODklMTI")
{
AccessPolicy = new StorageTableAccessPolicy("rad")
{
StartOn = DateTimeOffset.Parse("2022-03-17T08:49:37.0000000Z"),
ExpireOn = DateTimeOffset.Parse("2022-03-20T08:49:37.0000000Z"),
},
}},
            };
            ArmOperation<TableResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, tableName, data);
            TableResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_TableOperationGet()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/TableOperationGet.json
            // this example is just showing the usage of "Table_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TableServiceResource created on azure
            // for more information of creating TableServiceResource, please refer to the document of TableServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res3376";
            string accountName = "sto328";
            ResourceIdentifier tableServiceResourceId = TableServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            TableServiceResource tableService = client.GetTableServiceResource(tableServiceResourceId);

            // get the collection of this TableResource
            TableCollection collection = tableService.GetTables();

            // invoke the operation
            string tableName = "table6185";
            TableResource result = await collection.GetAsync(tableName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_TableOperationList()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/TableOperationList.json
            // this example is just showing the usage of "Table_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TableServiceResource created on azure
            // for more information of creating TableServiceResource, please refer to the document of TableServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res9290";
            string accountName = "sto328";
            ResourceIdentifier tableServiceResourceId = TableServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            TableServiceResource tableService = client.GetTableServiceResource(tableServiceResourceId);

            // get the collection of this TableResource
            TableCollection collection = tableService.GetTables();

            // invoke the operation and iterate over the result
            await foreach (TableResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TableData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_TableOperationGet()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/TableOperationGet.json
            // this example is just showing the usage of "Table_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TableServiceResource created on azure
            // for more information of creating TableServiceResource, please refer to the document of TableServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res3376";
            string accountName = "sto328";
            ResourceIdentifier tableServiceResourceId = TableServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            TableServiceResource tableService = client.GetTableServiceResource(tableServiceResourceId);

            // get the collection of this TableResource
            TableCollection collection = tableService.GetTables();

            // invoke the operation
            string tableName = "table6185";
            bool result = await collection.ExistsAsync(tableName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_TableOperationGet()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/TableOperationGet.json
            // this example is just showing the usage of "Table_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TableServiceResource created on azure
            // for more information of creating TableServiceResource, please refer to the document of TableServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res3376";
            string accountName = "sto328";
            ResourceIdentifier tableServiceResourceId = TableServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            TableServiceResource tableService = client.GetTableServiceResource(tableServiceResourceId);

            // get the collection of this TableResource
            TableCollection collection = tableService.GetTables();

            // invoke the operation
            string tableName = "table6185";
            NullableResponse<TableResource> response = await collection.GetIfExistsAsync(tableName);
            TableResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TableData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
