// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.IoTOperations.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.IoTOperations.Samples
{
    public partial class Sample_BrokerAuthorizationResourceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_BrokerAuthorizationCreateOrUpdateComplex()
        {
            // Generated from example definition: 2024-11-01/BrokerAuthorization_CreateOrUpdate_Complex.json
            // this example is just showing the usage of "BrokerAuthorizationResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BrokerResource created on azure
            // for more information of creating BrokerResource, please refer to the document of BrokerResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string brokerName = "resource-name123";
            ResourceIdentifier brokerResourceId = BrokerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, brokerName);
            BrokerResource brokerResource = client.GetBrokerResource(brokerResourceId);

            // get the collection of this BrokerAuthorizationResource
            BrokerAuthorizationResourceCollection collection = brokerResource.GetBrokerAuthorizationResources();

            // invoke the operation
            string authorizationName = "resource-name123";
            BrokerAuthorizationResourceData data = new BrokerAuthorizationResourceData(new ExtendedLocation("qmbrfwcpwwhggszhrdjv", ExtendedLocationType.CustomLocation))
            {
                Properties = new BrokerAuthorizationProperties(new AuthorizationConfig
                {
                    Cache = OperationalMode.Enabled,
                    Rules = {new AuthorizationRule(new BrokerResourceRule[]
{
new BrokerResourceRule(BrokerResourceDefinitionMethod.Connect)
{
ClientIds = {"{principal.attributes.building}*"},
},
new BrokerResourceRule(BrokerResourceDefinitionMethod.Publish)
{
Topics = {"sensors/{principal.attributes.building}/{principal.clientId}/telemetry/*"},
},
new BrokerResourceRule(BrokerResourceDefinitionMethod.Subscribe)
{
Topics = {"commands/{principal.attributes.organization}"},
}
}, new PrincipalConfig
{
Attributes = {
{
["building"] = "17",
["organization"] = "contoso"
}},
Usernames = {"temperature-sensor", "humidity-sensor"},
})
                {
                    StateStoreResources = { new StateStoreResourceRule(StateStoreResourceKeyType.Pattern, new string[] { "myreadkey", "myotherkey?", "mynumerickeysuffix[0-9]", "clients:{principal.clientId}:*" }, StateStoreResourceDefinitionMethod.Read), new StateStoreResourceRule(StateStoreResourceKeyType.Binary, new string[] { "MTE2IDEwMSAxMTUgMTE2" }, StateStoreResourceDefinitionMethod.ReadWrite) },
                }
            },
        }),
};
    ArmOperation<BrokerAuthorizationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authorizationName, data);
    BrokerAuthorizationResource result = lro.Value;

    // the variable result is a resource, you could call other operations on this instance as well
    // but just for demo, we get its data from this resource instance
    BrokerAuthorizationResourceData resourceData = result.Data;
    // for demo we just print out the id
    Console.WriteLine($"Succeeded on id: {resourceData.Id}");
}

[Test]
[Ignore("Only validating compilation of examples")]
public async Task CreateOrUpdate_BrokerAuthorizationCreateOrUpdate()
{
    // Generated from example definition: 2024-11-01/BrokerAuthorization_CreateOrUpdate_MaximumSet_Gen.json
    // this example is just showing the usage of "BrokerAuthorizationResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

    // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
    TokenCredential cred = new DefaultAzureCredential();
    // authenticate your client
    Azure.ResourceManager.ArmClient client = new Azure.ResourceManager.ArmClient(cred);

    // this example assumes you already have this BrokerResource created on azure
    // for more information of creating BrokerResource, please refer to the document of BrokerResource
    string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
    string resourceGroupName = "rgiotoperations";
    string instanceName = "resource-name123";
    string brokerName = "resource-name123";
    ResourceIdentifier brokerResourceId = Azure.ResourceManager.IoTOperations.BrokerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, brokerName);
    Azure.ResourceManager.IoTOperations.BrokerResource brokerResource = client.GetBrokerResource(brokerResourceId);

    // get the collection of this BrokerAuthorizationResource
    Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceCollection collection = brokerResource.GetBrokerAuthorizationResources();

    // invoke the operation
    string authorizationName = "resource-name123";
    Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceData data = new Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceData(new ExtendedLocation("qmbrfwcpwwhggszhrdjv", ExtendedLocationType.CustomLocation))
    {
        Properties = new BrokerAuthorizationProperties(new AuthorizationConfig
        {
            Cache = OperationalMode.Enabled,
            Rules = {new AuthorizationRule(new BrokerResourceRule[]
{
new BrokerResourceRule(BrokerResourceDefinitionMethod.Connect)
{
ClientIds = {"nlc"},
Topics = {"wvuca"},
}
}, new PrincipalConfig
{
Attributes = {
{
["key5526"] = "nydhzdhbldygqcn"
}},
ClientIds = {"smopeaeddsygz"},
Usernames = {"iozngyqndrteikszkbasinzdjtm"},
})
        {
            StateStoreResources = { new StateStoreResourceRule(StateStoreResourceKeyType.Pattern, new string[] { "tkounsqtwvzyaklxjqoerpu" }, StateStoreResourceDefinitionMethod.Read) },
        }
    },
}),
};
Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IoTOperations.BrokerAuthorizationResource> lro = await collection.CreateOrUpdateAsync(Azure.WaitUntil.Completed, authorizationName, data);
Azure.ResourceManager.IoTOperations.BrokerAuthorizationResource result = lro.Value;

// the variable result is a resource, you could call other operations on this instance as well
// but just for demo, we get its data from this resource instance
Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceData resourceData = result.Data;
// for demo we just print out the id
Console.WriteLine($"Succeeded on id: {resourceData.Id}");
}

[Test]
[Ignore("Only validating compilation of examples")]
public async Task CreateOrUpdate_BrokerAuthorizationCreateOrUpdateSimple()
{
    // Generated from example definition: 2024-11-01/BrokerAuthorization_CreateOrUpdate_Simple.json
    // this example is just showing the usage of "BrokerAuthorizationResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

    // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
    TokenCredential cred = new DefaultAzureCredential();
    // authenticate your client
    Azure.ResourceManager.ArmClient client = new Azure.ResourceManager.ArmClient(cred);

    // this example assumes you already have this BrokerResource created on azure
    // for more information of creating BrokerResource, please refer to the document of BrokerResource
    string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
    string resourceGroupName = "rgiotoperations";
    string instanceName = "resource-name123";
    string brokerName = "resource-name123";
    ResourceIdentifier brokerResourceId = Azure.ResourceManager.IoTOperations.BrokerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, brokerName);
    Azure.ResourceManager.IoTOperations.BrokerResource brokerResource = client.GetBrokerResource(brokerResourceId);

    // get the collection of this BrokerAuthorizationResource
    Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceCollection collection = brokerResource.GetBrokerAuthorizationResources();

    // invoke the operation
    string authorizationName = "resource-name123";
    Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceData data = new Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceData(new ExtendedLocation("qmbrfwcpwwhggszhrdjv", ExtendedLocationType.CustomLocation))
    {
        Properties = new BrokerAuthorizationProperties(new AuthorizationConfig
        {
            Cache = OperationalMode.Enabled,
            Rules = {new AuthorizationRule(new BrokerResourceRule[]
{
new BrokerResourceRule(BrokerResourceDefinitionMethod.Connect),
new BrokerResourceRule(BrokerResourceDefinitionMethod.Subscribe)
{
Topics = {"topic", "topic/with/wildcard/#"},
}
}, new PrincipalConfig
{
Attributes = {
{
["floor"] = "floor1",
["site"] = "site1"
}},
ClientIds = {"my-client-id"},
})
        {
            StateStoreResources = { new StateStoreResourceRule(StateStoreResourceKeyType.Pattern, new string[] { "*" }, StateStoreResourceDefinitionMethod.ReadWrite) },
        }
    },
}),
};
Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IoTOperations.BrokerAuthorizationResource> lro = await collection.CreateOrUpdateAsync(Azure.WaitUntil.Completed, authorizationName, data);
Azure.ResourceManager.IoTOperations.BrokerAuthorizationResource result = lro.Value;

// the variable result is a resource, you could call other operations on this instance as well
// but just for demo, we get its data from this resource instance
Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceData resourceData = result.Data;
// for demo we just print out the id
Console.WriteLine($"Succeeded on id: {resourceData.Id}");
}

[Test]
[Ignore("Only validating compilation of examples")]
public async Task Get_BrokerAuthorizationGet()
{
    // Generated from example definition: 2024-11-01/BrokerAuthorization_Get_MaximumSet_Gen.json
    // this example is just showing the usage of "BrokerAuthorizationResource_Get" operation, for the dependent resources, they will have to be created separately.

    // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
    TokenCredential cred = new DefaultAzureCredential();
    // authenticate your client
    Azure.ResourceManager.ArmClient client = new Azure.ResourceManager.ArmClient(cred);

    // this example assumes you already have this BrokerResource created on azure
    // for more information of creating BrokerResource, please refer to the document of BrokerResource
    string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
    string resourceGroupName = "rgiotoperations";
    string instanceName = "resource-name123";
    string brokerName = "resource-name123";
    ResourceIdentifier brokerResourceId = Azure.ResourceManager.IoTOperations.BrokerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, brokerName);
    Azure.ResourceManager.IoTOperations.BrokerResource brokerResource = client.GetBrokerResource(brokerResourceId);

    // get the collection of this BrokerAuthorizationResource
    Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceCollection collection = brokerResource.GetBrokerAuthorizationResources();

    // invoke the operation
    string authorizationName = "resource-name123";
    Azure.ResourceManager.IoTOperations.BrokerAuthorizationResource result = await collection.GetAsync(authorizationName);

    // the variable result is a resource, you could call other operations on this instance as well
    // but just for demo, we get its data from this resource instance
    Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceData resourceData = result.Data;
    // for demo we just print out the id
    Console.WriteLine($"Succeeded on id: {resourceData.Id}");
}

[Test]
[Ignore("Only validating compilation of examples")]
public async Task GetAll_BrokerAuthorizationListByResourceGroup()
{
    // Generated from example definition: 2024-11-01/BrokerAuthorization_ListByResourceGroup_MaximumSet_Gen.json
    // this example is just showing the usage of "BrokerAuthorizationResource_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

    // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
    TokenCredential cred = new DefaultAzureCredential();
    // authenticate your client
    Azure.ResourceManager.ArmClient client = new Azure.ResourceManager.ArmClient(cred);

    // this example assumes you already have this BrokerResource created on azure
    // for more information of creating BrokerResource, please refer to the document of BrokerResource
    string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
    string resourceGroupName = "rgiotoperations";
    string instanceName = "resource-name123";
    string brokerName = "resource-name123";
    ResourceIdentifier brokerResourceId = Azure.ResourceManager.IoTOperations.BrokerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, brokerName);
    Azure.ResourceManager.IoTOperations.BrokerResource brokerResource = client.GetBrokerResource(brokerResourceId);

    // get the collection of this BrokerAuthorizationResource
    Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceCollection collection = brokerResource.GetBrokerAuthorizationResources();

    // invoke the operation and iterate over the result
    await foreach (Azure.ResourceManager.IoTOperations.BrokerAuthorizationResource item in collection.GetAllAsync())
    {
        // the variable item is a resource, you could call other operations on this instance as well
        // but just for demo, we get its data from this resource instance
        Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceData resourceData = item.Data;
        // for demo we just print out the id
        Console.WriteLine($"Succeeded on id: {resourceData.Id}");
    }

    Console.WriteLine("Succeeded");
}

[Test]
[Ignore("Only validating compilation of examples")]
public async Task Exists_BrokerAuthorizationGet()
{
    // Generated from example definition: 2024-11-01/BrokerAuthorization_Get_MaximumSet_Gen.json
    // this example is just showing the usage of "BrokerAuthorizationResource_Get" operation, for the dependent resources, they will have to be created separately.

    // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
    TokenCredential cred = new DefaultAzureCredential();
    // authenticate your client
    Azure.ResourceManager.ArmClient client = new Azure.ResourceManager.ArmClient(cred);

    // this example assumes you already have this BrokerResource created on azure
    // for more information of creating BrokerResource, please refer to the document of BrokerResource
    string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
    string resourceGroupName = "rgiotoperations";
    string instanceName = "resource-name123";
    string brokerName = "resource-name123";
    ResourceIdentifier brokerResourceId = Azure.ResourceManager.IoTOperations.BrokerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, brokerName);
    Azure.ResourceManager.IoTOperations.BrokerResource brokerResource = client.GetBrokerResource(brokerResourceId);

    // get the collection of this BrokerAuthorizationResource
    Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceCollection collection = brokerResource.GetBrokerAuthorizationResources();

    // invoke the operation
    string authorizationName = "resource-name123";
    bool result = await collection.ExistsAsync(authorizationName);

    Console.WriteLine($"Succeeded: {result}");
}

[Test]
[Ignore("Only validating compilation of examples")]
public async Task GetIfExists_BrokerAuthorizationGet()
{
    // Generated from example definition: 2024-11-01/BrokerAuthorization_Get_MaximumSet_Gen.json
    // this example is just showing the usage of "BrokerAuthorizationResource_Get" operation, for the dependent resources, they will have to be created separately.

    // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
    TokenCredential cred = new DefaultAzureCredential();
    // authenticate your client
    Azure.ResourceManager.ArmClient client = new Azure.ResourceManager.ArmClient(cred);

    // this example assumes you already have this BrokerResource created on azure
    // for more information of creating BrokerResource, please refer to the document of BrokerResource
    string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
    string resourceGroupName = "rgiotoperations";
    string instanceName = "resource-name123";
    string brokerName = "resource-name123";
    ResourceIdentifier brokerResourceId = Azure.ResourceManager.IoTOperations.BrokerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, brokerName);
    Azure.ResourceManager.IoTOperations.BrokerResource brokerResource = client.GetBrokerResource(brokerResourceId);

    // get the collection of this BrokerAuthorizationResource
    Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceCollection collection = brokerResource.GetBrokerAuthorizationResources();

    // invoke the operation
    string authorizationName = "resource-name123";
    Azure.NullableResponse<Azure.ResourceManager.IoTOperations.BrokerAuthorizationResource> response = await collection.GetIfExistsAsync(authorizationName);
    Azure.ResourceManager.IoTOperations.BrokerAuthorizationResource result = response.HasValue ? response.Value : null;

    if (result == null)
    {
        Console.WriteLine("Succeeded with null as result");
    }
    else
    {
        // the variable result is a resource, you could call other operations on this instance as well
        // but just for demo, we get its data from this resource instance
        Azure.ResourceManager.IoTOperations.BrokerAuthorizationResourceData resourceData = result.Data;
        // for demo we just print out the id
        Console.WriteLine($"Succeeded on id: {resourceData.Id}");
    }
}
}
}
