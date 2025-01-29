// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkCloudRackResource"/> and their operations.
    /// Each <see cref="NetworkCloudRackResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="NetworkCloudRackCollection"/> instance call the GetNetworkCloudRacks method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class NetworkCloudRackCollection : ArmCollection, IEnumerable<NetworkCloudRackResource>, IAsyncEnumerable<NetworkCloudRackResource>
    {
        private readonly ClientDiagnostics _networkCloudRackRacksClientDiagnostics;
        private readonly RacksRestOperations _networkCloudRackRacksRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudRackCollection"/> class for mocking. </summary>
        protected NetworkCloudRackCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudRackCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCloudRackCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudRackRacksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", NetworkCloudRackResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkCloudRackResource.ResourceType, out string networkCloudRackRacksApiVersion);
            _networkCloudRackRacksRestClient = new RacksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudRackRacksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get properties of the provided rack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks/{rackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackName"> The name of the rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackName"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudRackResource>> GetAsync(string rackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackName, nameof(rackName));

            using var scope = _networkCloudRackRacksClientDiagnostics.CreateScope("NetworkCloudRackCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudRackRacksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, rackName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudRackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of the provided rack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks/{rackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackName"> The name of the rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackName"/> is null. </exception>
        public virtual Response<NetworkCloudRackResource> Get(string rackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackName, nameof(rackName));

            using var scope = _networkCloudRackRacksClientDiagnostics.CreateScope("NetworkCloudRackCollection.Get");
            scope.Start();
            try
            {
                var response = _networkCloudRackRacksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, rackName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudRackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of racks in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkCloudRackResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkCloudRackResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudRackRacksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudRackRacksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudRackResource(Client, NetworkCloudRackData.DeserializeNetworkCloudRackData(e)), _networkCloudRackRacksClientDiagnostics, Pipeline, "NetworkCloudRackCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of racks in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkCloudRackResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkCloudRackResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudRackRacksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudRackRacksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudRackResource(Client, NetworkCloudRackData.DeserializeNetworkCloudRackData(e)), _networkCloudRackRacksClientDiagnostics, Pipeline, "NetworkCloudRackCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks/{rackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackName"> The name of the rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string rackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackName, nameof(rackName));

            using var scope = _networkCloudRackRacksClientDiagnostics.CreateScope("NetworkCloudRackCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkCloudRackRacksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, rackName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks/{rackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackName"> The name of the rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackName"/> is null. </exception>
        public virtual Response<bool> Exists(string rackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackName, nameof(rackName));

            using var scope = _networkCloudRackRacksClientDiagnostics.CreateScope("NetworkCloudRackCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkCloudRackRacksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, rackName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks/{rackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackName"> The name of the rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkCloudRackResource>> GetIfExistsAsync(string rackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackName, nameof(rackName));

            using var scope = _networkCloudRackRacksClientDiagnostics.CreateScope("NetworkCloudRackCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkCloudRackRacksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, rackName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudRackResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudRackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks/{rackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackName"> The name of the rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackName"/> is null. </exception>
        public virtual NullableResponse<NetworkCloudRackResource> GetIfExists(string rackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackName, nameof(rackName));

            using var scope = _networkCloudRackRacksClientDiagnostics.CreateScope("NetworkCloudRackCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkCloudRackRacksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, rackName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudRackResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudRackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkCloudRackResource> IEnumerable<NetworkCloudRackResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkCloudRackResource> IAsyncEnumerable<NetworkCloudRackResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
