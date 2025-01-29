// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Monitor.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Monitor.Samples
{
    public partial class Sample_DataCollectionRuleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateDataCollectionRule()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/examples/DataCollectionRulesCreate.json
            // this example is just showing the usage of "DataCollectionRules_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "703362b3-f278-4e4b-9179-c76eaf41ffc2";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DataCollectionRuleResource
            DataCollectionRuleCollection collection = resourceGroupResource.GetDataCollectionRules();

            // invoke the operation
            string dataCollectionRuleName = "myCollectionRule";
            DataCollectionRuleData data = new DataCollectionRuleData(new AzureLocation("eastus"))
            {
                DataSources = new DataCollectionRuleDataSources
                {
                    PerformanceCounters = {new PerfCounterDataSource
{
Streams = {PerfCounterDataSourceStream.MicrosoftPerf},
SamplingFrequencyInSeconds = 15,
CounterSpecifiers = {"\\Processor(_Total)\\% Processor Time", "\\Memory\\Committed Bytes", "\\LogicalDisk(_Total)\\Free Megabytes", "\\PhysicalDisk(_Total)\\Avg. Disk Queue Length"},
Name = "cloudTeamCoreCounters",
}, new PerfCounterDataSource
{
Streams = {PerfCounterDataSourceStream.MicrosoftPerf},
SamplingFrequencyInSeconds = 30,
CounterSpecifiers = {"\\Process(_Total)\\Thread Count"},
Name = "appTeamExtraCounters",
}},
                    WindowsEventLogs = {new WindowsEventLogDataSource
{
Streams = {WindowsEventLogDataSourceStream.MicrosoftWindowsEvent},
XPathQueries = {"Security!"},
Name = "cloudSecurityTeamEvents",
}, new WindowsEventLogDataSource
{
Streams = {WindowsEventLogDataSourceStream.MicrosoftWindowsEvent},
XPathQueries = {"System![System[(Level = 1 or Level = 2 or Level = 3)]]", "Application!*[System[(Level = 1 or Level = 2 or Level = 3)]]"},
Name = "appTeam1AppEvents",
}},
                    Syslog = {new SyslogDataSource
{
Streams = {SyslogDataSourceStream.MicrosoftSyslog},
FacilityNames = {SyslogDataSourceFacilityName.Cron},
LogLevels = {SyslogDataSourceLogLevel.Debug, SyslogDataSourceLogLevel.Critical, SyslogDataSourceLogLevel.Emergency},
Name = "cronSyslog",
}, new SyslogDataSource
{
Streams = {SyslogDataSourceStream.MicrosoftSyslog},
FacilityNames = {SyslogDataSourceFacilityName.Syslog},
LogLevels = {SyslogDataSourceLogLevel.Alert, SyslogDataSourceLogLevel.Critical, SyslogDataSourceLogLevel.Emergency},
Name = "syslogBase",
}},
                },
                Destinations = new DataCollectionRuleDestinations
                {
                    LogAnalytics = {new LogAnalyticsDestination
{
WorkspaceResourceId = new ResourceIdentifier("/subscriptions/703362b3-f278-4e4b-9179-c76eaf41ffc2/resourceGroups/myResourceGroup/providers/Microsoft.OperationalInsights/workspaces/centralTeamWorkspace"),
Name = "centralWorkspace",
}},
                },
                DataFlows = {new DataFlow
{
Streams = {DataFlowStream.MicrosoftPerf, DataFlowStream.MicrosoftSyslog, DataFlowStream.MicrosoftWindowsEvent},
Destinations = {"centralWorkspace"},
}},
            };
            ArmOperation<DataCollectionRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataCollectionRuleName, data);
            DataCollectionRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataCollectionRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDataCollectionRule()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/examples/DataCollectionRulesGet.json
            // this example is just showing the usage of "DataCollectionRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "703362b3-f278-4e4b-9179-c76eaf41ffc2";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DataCollectionRuleResource
            DataCollectionRuleCollection collection = resourceGroupResource.GetDataCollectionRules();

            // invoke the operation
            string dataCollectionRuleName = "myCollectionRule";
            DataCollectionRuleResource result = await collection.GetAsync(dataCollectionRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataCollectionRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListDataCollectionRulesByResourceGroup()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/examples/DataCollectionRulesListByResourceGroup.json
            // this example is just showing the usage of "DataCollectionRules_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "703362b3-f278-4e4b-9179-c76eaf41ffc2";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DataCollectionRuleResource
            DataCollectionRuleCollection collection = resourceGroupResource.GetDataCollectionRules();

            // invoke the operation and iterate over the result
            await foreach (DataCollectionRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataCollectionRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetDataCollectionRule()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/examples/DataCollectionRulesGet.json
            // this example is just showing the usage of "DataCollectionRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "703362b3-f278-4e4b-9179-c76eaf41ffc2";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DataCollectionRuleResource
            DataCollectionRuleCollection collection = resourceGroupResource.GetDataCollectionRules();

            // invoke the operation
            string dataCollectionRuleName = "myCollectionRule";
            bool result = await collection.ExistsAsync(dataCollectionRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetDataCollectionRule()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/examples/DataCollectionRulesGet.json
            // this example is just showing the usage of "DataCollectionRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "703362b3-f278-4e4b-9179-c76eaf41ffc2";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DataCollectionRuleResource
            DataCollectionRuleCollection collection = resourceGroupResource.GetDataCollectionRules();

            // invoke the operation
            string dataCollectionRuleName = "myCollectionRule";
            NullableResponse<DataCollectionRuleResource> response = await collection.GetIfExistsAsync(dataCollectionRuleName);
            DataCollectionRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataCollectionRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
