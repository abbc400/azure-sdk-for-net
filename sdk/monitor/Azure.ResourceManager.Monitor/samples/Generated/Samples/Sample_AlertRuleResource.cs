// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Monitor.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Monitor.Samples
{
    public partial class Sample_AlertRuleResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnAlertRule()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2016-03-01/examples/getAlertRule.json
            // this example is just showing the usage of "AlertRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AlertRuleResource created on azure
            // for more information of creating AlertRuleResource, please refer to the document of AlertRuleResource
            string subscriptionId = "b67f7fec-69fc-4974-9099-a26bd6ffeda3";
            string resourceGroupName = "Rac46PostSwapRG";
            string ruleName = "chiricutin";
            ResourceIdentifier alertRuleResourceId = AlertRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ruleName);
            AlertRuleResource alertRule = client.GetAlertRuleResource(alertRuleResourceId);

            // invoke the operation
            AlertRuleResource result = await alertRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AlertRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnAlertRule()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2016-03-01/examples/deleteAlertRule.json
            // this example is just showing the usage of "AlertRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AlertRuleResource created on azure
            // for more information of creating AlertRuleResource, please refer to the document of AlertRuleResource
            string subscriptionId = "b67f7fec-69fc-4974-9099-a26bd6ffeda3";
            string resourceGroupName = "Rac46PostSwapRG";
            string ruleName = "chiricutin";
            ResourceIdentifier alertRuleResourceId = AlertRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ruleName);
            AlertRuleResource alertRule = client.GetAlertRuleResource(alertRuleResourceId);

            // invoke the operation
            await alertRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchAnAlertRule()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2016-03-01/examples/patchAlertRule.json
            // this example is just showing the usage of "AlertRules_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AlertRuleResource created on azure
            // for more information of creating AlertRuleResource, please refer to the document of AlertRuleResource
            string subscriptionId = "b67f7fec-69fc-4974-9099-a26bd6ffeda3";
            string resourceGroupName = "Rac46PostSwapRG";
            string ruleName = "chiricutin";
            ResourceIdentifier alertRuleResourceId = AlertRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ruleName);
            AlertRuleResource alertRule = client.GetAlertRuleResource(alertRuleResourceId);

            // invoke the operation
            AlertRulePatch patch = new AlertRulePatch
            {
                Tags =
{
["$type"] = "Microsoft.WindowsAzure.Management.Common.Storage.CasePreservedDictionary"
},
                Name = "chiricutin",
                Description = "Pura Vida",
                IsEnabled = true,
                Condition = new ThresholdRuleCondition(MonitorConditionOperator.GreaterThan, 3)
                {
                    WindowSize = XmlConvert.ToTimeSpan("PT5M"),
                    TimeAggregation = ThresholdRuleConditionTimeAggregationType.Total,
                    DataSource = new RuleMetricDataSource
                    {
                        MetricName = "Requests",
                        ResourceId = new ResourceIdentifier("/subscriptions/b67f7fec-69fc-4974-9099-a26bd6ffeda3/resourceGroups/Rac46PostSwapRG/providers/Microsoft.Web/sites/leoalerttest"),
                    },
                },
                Actions = { },
            };
            AlertRuleResource result = await alertRule.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AlertRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAlertRuleIncident_GetASingleAlertRuleIncident()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2016-03-01/examples/getAlertRuleIncident.json
            // this example is just showing the usage of "AlertRuleIncidents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AlertRuleResource created on azure
            // for more information of creating AlertRuleResource, please refer to the document of AlertRuleResource
            string subscriptionId = "b67f7fec-69fc-4974-9099-a26bd6ffeda3";
            string resourceGroupName = "Rac46PostSwapRG";
            string ruleName = "myRuleName";
            ResourceIdentifier alertRuleResourceId = AlertRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ruleName);
            AlertRuleResource alertRule = client.GetAlertRuleResource(alertRuleResourceId);

            // invoke the operation
            string incidentName = "Website_started";
            MonitorIncident result = await alertRule.GetAlertRuleIncidentAsync(incidentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAlertRuleIncidents_ListAlertRuleIncidents()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2016-03-01/examples/listAlertRuleIncidents.json
            // this example is just showing the usage of "AlertRuleIncidents_ListByAlertRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AlertRuleResource created on azure
            // for more information of creating AlertRuleResource, please refer to the document of AlertRuleResource
            string subscriptionId = "b67f7fec-69fc-4974-9099-a26bd6ffeda3";
            string resourceGroupName = "Rac46PostSwapRG";
            string ruleName = "myRuleName";
            ResourceIdentifier alertRuleResourceId = AlertRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ruleName);
            AlertRuleResource alertRule = client.GetAlertRuleResource(alertRuleResourceId);

            // invoke the operation and iterate over the result
            await foreach (MonitorIncident item in alertRule.GetAlertRuleIncidentsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
