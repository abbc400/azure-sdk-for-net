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
    /// A class representing a collection of <see cref="NetworkCloudVolumeResource"/> and their operations.
    /// Each <see cref="NetworkCloudVolumeResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="NetworkCloudVolumeCollection"/> instance call the GetNetworkCloudVolumes method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class NetworkCloudVolumeCollection : ArmCollection, IEnumerable<NetworkCloudVolumeResource>, IAsyncEnumerable<NetworkCloudVolumeResource>
    {
        private readonly ClientDiagnostics _networkCloudVolumeVolumesClientDiagnostics;
        private readonly VolumesRestOperations _networkCloudVolumeVolumesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudVolumeCollection"/> class for mocking. </summary>
        protected NetworkCloudVolumeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudVolumeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCloudVolumeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudVolumeVolumesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", NetworkCloudVolumeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkCloudVolumeResource.ResourceType, out string networkCloudVolumeVolumesApiVersion);
            _networkCloudVolumeVolumesRestClient = new VolumesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudVolumeVolumesApiVersion);
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
        /// Create a new volume or update the properties of the existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkCloudVolumeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string volumeName, NetworkCloudVolumeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudVolumeVolumesClientDiagnostics.CreateScope("NetworkCloudVolumeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkCloudVolumeVolumesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, volumeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkCloudArmOperation<NetworkCloudVolumeResource>(new NetworkCloudVolumeOperationSource(Client), _networkCloudVolumeVolumesClientDiagnostics, Pipeline, _networkCloudVolumeVolumesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, volumeName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a new volume or update the properties of the existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkCloudVolumeResource> CreateOrUpdate(WaitUntil waitUntil, string volumeName, NetworkCloudVolumeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudVolumeVolumesClientDiagnostics.CreateScope("NetworkCloudVolumeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkCloudVolumeVolumesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, volumeName, data, cancellationToken);
                var operation = new NetworkCloudArmOperation<NetworkCloudVolumeResource>(new NetworkCloudVolumeOperationSource(Client), _networkCloudVolumeVolumesClientDiagnostics, Pipeline, _networkCloudVolumeVolumesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, volumeName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of the provided volume.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudVolumeResource>> GetAsync(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _networkCloudVolumeVolumesClientDiagnostics.CreateScope("NetworkCloudVolumeCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudVolumeVolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, volumeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudVolumeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of the provided volume.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual Response<NetworkCloudVolumeResource> Get(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _networkCloudVolumeVolumesClientDiagnostics.CreateScope("NetworkCloudVolumeCollection.Get");
            scope.Start();
            try
            {
                var response = _networkCloudVolumeVolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, volumeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudVolumeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of volumes in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/volumes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkCloudVolumeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkCloudVolumeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudVolumeVolumesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudVolumeVolumesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudVolumeResource(Client, NetworkCloudVolumeData.DeserializeNetworkCloudVolumeData(e)), _networkCloudVolumeVolumesClientDiagnostics, Pipeline, "NetworkCloudVolumeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of volumes in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/volumes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkCloudVolumeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkCloudVolumeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudVolumeVolumesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudVolumeVolumesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudVolumeResource(Client, NetworkCloudVolumeData.DeserializeNetworkCloudVolumeData(e)), _networkCloudVolumeVolumesClientDiagnostics, Pipeline, "NetworkCloudVolumeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _networkCloudVolumeVolumesClientDiagnostics.CreateScope("NetworkCloudVolumeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkCloudVolumeVolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, volumeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual Response<bool> Exists(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _networkCloudVolumeVolumesClientDiagnostics.CreateScope("NetworkCloudVolumeCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkCloudVolumeVolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, volumeName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkCloudVolumeResource>> GetIfExistsAsync(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _networkCloudVolumeVolumesClientDiagnostics.CreateScope("NetworkCloudVolumeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkCloudVolumeVolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, volumeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudVolumeResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudVolumeResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual NullableResponse<NetworkCloudVolumeResource> GetIfExists(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _networkCloudVolumeVolumesClientDiagnostics.CreateScope("NetworkCloudVolumeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkCloudVolumeVolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, volumeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudVolumeResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudVolumeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkCloudVolumeResource> IEnumerable<NetworkCloudVolumeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkCloudVolumeResource> IAsyncEnumerable<NetworkCloudVolumeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
