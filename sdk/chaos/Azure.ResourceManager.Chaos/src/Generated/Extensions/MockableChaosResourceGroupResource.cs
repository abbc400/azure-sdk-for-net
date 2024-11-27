// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableChaosResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableChaosResourceGroupResource"/> class for mocking. </summary>
        protected MockableChaosResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableChaosResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableChaosResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ChaosTargetResources in the ResourceGroupResource. </summary>
        /// <param name="parentProviderNamespace"> The parent resource provider namespace. </param>
        /// <param name="parentResourceType"> The parent resource type. </param>
        /// <param name="parentResourceName"> The parent resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/> or <paramref name="parentResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/> or <paramref name="parentResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of ChaosTargetResources and their operations over a ChaosTargetResource. </returns>
        public virtual ChaosTargetCollection GetChaosTargets(string parentProviderNamespace, string parentResourceType, string parentResourceName)
        {
            return new ChaosTargetCollection(Client, Id, parentProviderNamespace, parentResourceType, parentResourceName);
        }

        /// <summary>
        /// Get a Target resource that extends a tracked regional resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Target_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="parentProviderNamespace"> The parent resource provider namespace. </param>
        /// <param name="parentResourceType"> The parent resource type. </param>
        /// <param name="parentResourceName"> The parent resource name. </param>
        /// <param name="targetName"> String that represents a Target resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/>, <paramref name="parentResourceName"/> or <paramref name="targetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/>, <paramref name="parentResourceName"/> or <paramref name="targetName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ChaosTargetResource>> GetChaosTargetAsync(string parentProviderNamespace, string parentResourceType, string parentResourceName, string targetName, CancellationToken cancellationToken = default)
        {
            return await GetChaosTargets(parentProviderNamespace, parentResourceType, parentResourceName).GetAsync(targetName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Target resource that extends a tracked regional resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Target_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="parentProviderNamespace"> The parent resource provider namespace. </param>
        /// <param name="parentResourceType"> The parent resource type. </param>
        /// <param name="parentResourceName"> The parent resource name. </param>
        /// <param name="targetName"> String that represents a Target resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/>, <paramref name="parentResourceName"/> or <paramref name="targetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/>, <paramref name="parentResourceName"/> or <paramref name="targetName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ChaosTargetResource> GetChaosTarget(string parentProviderNamespace, string parentResourceType, string parentResourceName, string targetName, CancellationToken cancellationToken = default)
        {
            return GetChaosTargets(parentProviderNamespace, parentResourceType, parentResourceName).Get(targetName, cancellationToken);
        }

        /// <summary> Gets a collection of ChaosExperimentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ChaosExperimentResources and their operations over a ChaosExperimentResource. </returns>
        public virtual ChaosExperimentCollection GetChaosExperiments()
        {
            return GetCachedClient(client => new ChaosExperimentCollection(client, Id));
        }

        /// <summary>
        /// Get a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiment_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ChaosExperimentResource>> GetChaosExperimentAsync(string experimentName, CancellationToken cancellationToken = default)
        {
            return await GetChaosExperiments().GetAsync(experimentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiment_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ChaosExperimentResource> GetChaosExperiment(string experimentName, CancellationToken cancellationToken = default)
        {
            return GetChaosExperiments().Get(experimentName, cancellationToken);
        }

        /// <summary> Gets a collection of PrivateAccessResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of PrivateAccessResources and their operations over a PrivateAccessResource. </returns>
        public virtual PrivateAccessCollection GetPrivateAccesses()
        {
            return GetCachedClient(client => new PrivateAccessCollection(client, Id));
        }

        /// <summary>
        /// Get a private access resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/privateAccesses/{privateAccessName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateAccess_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateAccessResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateAccessName"> The name of the private access resource that is being created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateAccessName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="privateAccessName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PrivateAccessResource>> GetPrivateAccessAsync(string privateAccessName, CancellationToken cancellationToken = default)
        {
            return await GetPrivateAccesses().GetAsync(privateAccessName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a private access resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/privateAccesses/{privateAccessName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateAccess_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateAccessResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateAccessName"> The name of the private access resource that is being created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateAccessName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="privateAccessName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<PrivateAccessResource> GetPrivateAccess(string privateAccessName, CancellationToken cancellationToken = default)
        {
            return GetPrivateAccesses().Get(privateAccessName, cancellationToken);
        }
    }
}
