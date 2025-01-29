// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.AppConfiguration.Mocking;
using Azure.ResourceManager.AppConfiguration.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.AppConfiguration. </summary>
    public static partial class AppConfigurationExtensions
    {
        private static MockableAppConfigurationArmClient GetMockableAppConfigurationArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableAppConfigurationArmClient(client0));
        }

        private static MockableAppConfigurationResourceGroupResource GetMockableAppConfigurationResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableAppConfigurationResourceGroupResource(client, resource.Id));
        }

        private static MockableAppConfigurationSubscriptionResource GetMockableAppConfigurationSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableAppConfigurationSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppConfigurationStoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppConfigurationStoreResource.CreateResourceIdentifier" /> to create an <see cref="AppConfigurationStoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationArmClient.GetAppConfigurationStoreResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AppConfigurationStoreResource"/> object. </returns>
        public static AppConfigurationStoreResource GetAppConfigurationStoreResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAppConfigurationArmClient(client).GetAppConfigurationStoreResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeletedAppConfigurationStoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeletedAppConfigurationStoreResource.CreateResourceIdentifier" /> to create a <see cref="DeletedAppConfigurationStoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationArmClient.GetDeletedAppConfigurationStoreResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DeletedAppConfigurationStoreResource"/> object. </returns>
        public static DeletedAppConfigurationStoreResource GetDeletedAppConfigurationStoreResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAppConfigurationArmClient(client).GetDeletedAppConfigurationStoreResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppConfigurationPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppConfigurationPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="AppConfigurationPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationArmClient.GetAppConfigurationPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AppConfigurationPrivateEndpointConnectionResource"/> object. </returns>
        public static AppConfigurationPrivateEndpointConnectionResource GetAppConfigurationPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAppConfigurationArmClient(client).GetAppConfigurationPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppConfigurationPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppConfigurationPrivateLinkResource.CreateResourceIdentifier" /> to create an <see cref="AppConfigurationPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationArmClient.GetAppConfigurationPrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AppConfigurationPrivateLinkResource"/> object. </returns>
        public static AppConfigurationPrivateLinkResource GetAppConfigurationPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAppConfigurationArmClient(client).GetAppConfigurationPrivateLinkResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppConfigurationKeyValueResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppConfigurationKeyValueResource.CreateResourceIdentifier" /> to create an <see cref="AppConfigurationKeyValueResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationArmClient.GetAppConfigurationKeyValueResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AppConfigurationKeyValueResource"/> object. </returns>
        public static AppConfigurationKeyValueResource GetAppConfigurationKeyValueResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAppConfigurationArmClient(client).GetAppConfigurationKeyValueResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppConfigurationReplicaResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppConfigurationReplicaResource.CreateResourceIdentifier" /> to create an <see cref="AppConfigurationReplicaResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationArmClient.GetAppConfigurationReplicaResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AppConfigurationReplicaResource"/> object. </returns>
        public static AppConfigurationReplicaResource GetAppConfigurationReplicaResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAppConfigurationArmClient(client).GetAppConfigurationReplicaResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppConfigurationSnapshotResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppConfigurationSnapshotResource.CreateResourceIdentifier" /> to create an <see cref="AppConfigurationSnapshotResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationArmClient.GetAppConfigurationSnapshotResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AppConfigurationSnapshotResource"/> object. </returns>
        public static AppConfigurationSnapshotResource GetAppConfigurationSnapshotResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAppConfigurationArmClient(client).GetAppConfigurationSnapshotResource(id);
        }

        /// <summary>
        /// Gets a collection of AppConfigurationStoreResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationResourceGroupResource.GetAppConfigurationStores()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of AppConfigurationStoreResources and their operations over a AppConfigurationStoreResource. </returns>
        public static AppConfigurationStoreCollection GetAppConfigurationStores(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableAppConfigurationResourceGroupResource(resourceGroupResource).GetAppConfigurationStores();
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationStoreResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationResourceGroupResource.GetAppConfigurationStoreAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="configStoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AppConfigurationStoreResource>> GetAppConfigurationStoreAsync(this ResourceGroupResource resourceGroupResource, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableAppConfigurationResourceGroupResource(resourceGroupResource).GetAppConfigurationStoreAsync(configStoreName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationStoreResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationResourceGroupResource.GetAppConfigurationStore(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="configStoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<AppConfigurationStoreResource> GetAppConfigurationStore(this ResourceGroupResource resourceGroupResource, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableAppConfigurationResourceGroupResource(resourceGroupResource).GetAppConfigurationStore(configStoreName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of DeletedAppConfigurationStoreResources in the SubscriptionResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationSubscriptionResource.GetDeletedAppConfigurationStores()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An object representing collection of DeletedAppConfigurationStoreResources and their operations over a DeletedAppConfigurationStoreResource. </returns>
        public static DeletedAppConfigurationStoreCollection GetDeletedAppConfigurationStores(this SubscriptionResource subscriptionResource)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableAppConfigurationSubscriptionResource(subscriptionResource).GetDeletedAppConfigurationStores();
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedAppConfigurationStoreResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationSubscriptionResource.GetDeletedAppConfigurationStoreAsync(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="configStoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DeletedAppConfigurationStoreResource>> GetDeletedAppConfigurationStoreAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableAppConfigurationSubscriptionResource(subscriptionResource).GetDeletedAppConfigurationStoreAsync(location, configStoreName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedAppConfigurationStoreResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationSubscriptionResource.GetDeletedAppConfigurationStore(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="configStoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DeletedAppConfigurationStoreResource> GetDeletedAppConfigurationStore(this SubscriptionResource subscriptionResource, AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableAppConfigurationSubscriptionResource(subscriptionResource).GetDeletedAppConfigurationStore(location, configStoreName, cancellationToken);
        }

        /// <summary>
        /// Lists the configuration stores for a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/configurationStores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationStoreResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationSubscriptionResource.GetAppConfigurationStores(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="AppConfigurationStoreResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AppConfigurationStoreResource> GetAppConfigurationStoresAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableAppConfigurationSubscriptionResource(subscriptionResource).GetAppConfigurationStoresAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists the configuration stores for a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/configurationStores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationStoreResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationSubscriptionResource.GetAppConfigurationStores(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="AppConfigurationStoreResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AppConfigurationStoreResource> GetAppConfigurationStores(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableAppConfigurationSubscriptionResource(subscriptionResource).GetAppConfigurationStores(skipToken, cancellationToken);
        }

        /// <summary>
        /// Checks whether the configuration store name is available for use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckAppConfigurationNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationSubscriptionResource.CheckAppConfigurationNameAvailability(AppConfigurationNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<AppConfigurationNameAvailabilityResult>> CheckAppConfigurationNameAvailabilityAsync(this SubscriptionResource subscriptionResource, AppConfigurationNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableAppConfigurationSubscriptionResource(subscriptionResource).CheckAppConfigurationNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks whether the configuration store name is available for use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckAppConfigurationNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAppConfigurationSubscriptionResource.CheckAppConfigurationNameAvailability(AppConfigurationNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<AppConfigurationNameAvailabilityResult> CheckAppConfigurationNameAvailability(this SubscriptionResource subscriptionResource, AppConfigurationNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableAppConfigurationSubscriptionResource(subscriptionResource).CheckAppConfigurationNameAvailability(content, cancellationToken);
        }
    }
}
