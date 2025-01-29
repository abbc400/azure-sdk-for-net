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

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="GalleryInVmAccessControlProfileVersionResource"/> and their operations.
    /// Each <see cref="GalleryInVmAccessControlProfileVersionResource"/> in the collection will belong to the same instance of <see cref="GalleryInVmAccessControlProfileResource"/>.
    /// To get a <see cref="GalleryInVmAccessControlProfileVersionCollection"/> instance call the GetGalleryInVmAccessControlProfileVersions method from an instance of <see cref="GalleryInVmAccessControlProfileResource"/>.
    /// </summary>
    public partial class GalleryInVmAccessControlProfileVersionCollection : ArmCollection, IEnumerable<GalleryInVmAccessControlProfileVersionResource>, IAsyncEnumerable<GalleryInVmAccessControlProfileVersionResource>
    {
        private readonly ClientDiagnostics _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics;
        private readonly GalleryInVMAccessControlProfileVersionsRestOperations _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="GalleryInVmAccessControlProfileVersionCollection"/> class for mocking. </summary>
        protected GalleryInVmAccessControlProfileVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GalleryInVmAccessControlProfileVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GalleryInVmAccessControlProfileVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", GalleryInVmAccessControlProfileVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GalleryInVmAccessControlProfileVersionResource.ResourceType, out string galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsApiVersion);
            _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient = new GalleryInVMAccessControlProfileVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != GalleryInVmAccessControlProfileResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, GalleryInVmAccessControlProfileResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a gallery inVMAccessControlProfile version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/inVMAccessControlProfiles/{inVMAccessControlProfileName}/versions/{inVMAccessControlProfileVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryInVMAccessControlProfileVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryInVmAccessControlProfileVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inVmAccessControlProfileVersionName"> The name of the gallery inVMAccessControlProfile version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="data"> Parameters supplied to the create or update gallery inVMAccessControlProfile version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inVmAccessControlProfileVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inVmAccessControlProfileVersionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GalleryInVmAccessControlProfileVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string inVmAccessControlProfileVersionName, GalleryInVmAccessControlProfileVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inVmAccessControlProfileVersionName, nameof(inVmAccessControlProfileVersionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics.CreateScope("GalleryInVmAccessControlProfileVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, inVmAccessControlProfileVersionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<GalleryInVmAccessControlProfileVersionResource>(new GalleryInVmAccessControlProfileVersionOperationSource(Client), _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics, Pipeline, _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, inVmAccessControlProfileVersionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a gallery inVMAccessControlProfile version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/inVMAccessControlProfiles/{inVMAccessControlProfileName}/versions/{inVMAccessControlProfileVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryInVMAccessControlProfileVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryInVmAccessControlProfileVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inVmAccessControlProfileVersionName"> The name of the gallery inVMAccessControlProfile version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="data"> Parameters supplied to the create or update gallery inVMAccessControlProfile version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inVmAccessControlProfileVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inVmAccessControlProfileVersionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GalleryInVmAccessControlProfileVersionResource> CreateOrUpdate(WaitUntil waitUntil, string inVmAccessControlProfileVersionName, GalleryInVmAccessControlProfileVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inVmAccessControlProfileVersionName, nameof(inVmAccessControlProfileVersionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics.CreateScope("GalleryInVmAccessControlProfileVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, inVmAccessControlProfileVersionName, data, cancellationToken);
                var operation = new ComputeArmOperation<GalleryInVmAccessControlProfileVersionResource>(new GalleryInVmAccessControlProfileVersionOperationSource(Client), _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics, Pipeline, _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, inVmAccessControlProfileVersionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves information about a gallery inVMAccessControlProfile version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/inVMAccessControlProfiles/{inVMAccessControlProfileName}/versions/{inVMAccessControlProfileVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryInVMAccessControlProfileVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryInVmAccessControlProfileVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inVmAccessControlProfileVersionName"> The name of the gallery inVMAccessControlProfile version to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inVmAccessControlProfileVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inVmAccessControlProfileVersionName"/> is null. </exception>
        public virtual async Task<Response<GalleryInVmAccessControlProfileVersionResource>> GetAsync(string inVmAccessControlProfileVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inVmAccessControlProfileVersionName, nameof(inVmAccessControlProfileVersionName));

            using var scope = _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics.CreateScope("GalleryInVmAccessControlProfileVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, inVmAccessControlProfileVersionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryInVmAccessControlProfileVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about a gallery inVMAccessControlProfile version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/inVMAccessControlProfiles/{inVMAccessControlProfileName}/versions/{inVMAccessControlProfileVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryInVMAccessControlProfileVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryInVmAccessControlProfileVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inVmAccessControlProfileVersionName"> The name of the gallery inVMAccessControlProfile version to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inVmAccessControlProfileVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inVmAccessControlProfileVersionName"/> is null. </exception>
        public virtual Response<GalleryInVmAccessControlProfileVersionResource> Get(string inVmAccessControlProfileVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inVmAccessControlProfileVersionName, nameof(inVmAccessControlProfileVersionName));

            using var scope = _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics.CreateScope("GalleryInVmAccessControlProfileVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, inVmAccessControlProfileVersionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryInVmAccessControlProfileVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List gallery inVMAccessControlProfile versions in a gallery inVMAccessControlProfile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/inVMAccessControlProfiles/{inVMAccessControlProfileName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryInVMAccessControlProfileVersions_ListByGalleryInVmAccessControlProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryInVmAccessControlProfileVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryInVmAccessControlProfileVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GalleryInVmAccessControlProfileVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.CreateListByGalleryInVmAccessControlProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.CreateListByGalleryInVmAccessControlProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new GalleryInVmAccessControlProfileVersionResource(Client, GalleryInVmAccessControlProfileVersionData.DeserializeGalleryInVmAccessControlProfileVersionData(e)), _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics, Pipeline, "GalleryInVmAccessControlProfileVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List gallery inVMAccessControlProfile versions in a gallery inVMAccessControlProfile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/inVMAccessControlProfiles/{inVMAccessControlProfileName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryInVMAccessControlProfileVersions_ListByGalleryInVmAccessControlProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryInVmAccessControlProfileVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryInVmAccessControlProfileVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GalleryInVmAccessControlProfileVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.CreateListByGalleryInVmAccessControlProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.CreateListByGalleryInVmAccessControlProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new GalleryInVmAccessControlProfileVersionResource(Client, GalleryInVmAccessControlProfileVersionData.DeserializeGalleryInVmAccessControlProfileVersionData(e)), _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics, Pipeline, "GalleryInVmAccessControlProfileVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/inVMAccessControlProfiles/{inVMAccessControlProfileName}/versions/{inVMAccessControlProfileVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryInVMAccessControlProfileVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryInVmAccessControlProfileVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inVmAccessControlProfileVersionName"> The name of the gallery inVMAccessControlProfile version to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inVmAccessControlProfileVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inVmAccessControlProfileVersionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string inVmAccessControlProfileVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inVmAccessControlProfileVersionName, nameof(inVmAccessControlProfileVersionName));

            using var scope = _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics.CreateScope("GalleryInVmAccessControlProfileVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, inVmAccessControlProfileVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/inVMAccessControlProfiles/{inVMAccessControlProfileName}/versions/{inVMAccessControlProfileVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryInVMAccessControlProfileVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryInVmAccessControlProfileVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inVmAccessControlProfileVersionName"> The name of the gallery inVMAccessControlProfile version to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inVmAccessControlProfileVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inVmAccessControlProfileVersionName"/> is null. </exception>
        public virtual Response<bool> Exists(string inVmAccessControlProfileVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inVmAccessControlProfileVersionName, nameof(inVmAccessControlProfileVersionName));

            using var scope = _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics.CreateScope("GalleryInVmAccessControlProfileVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, inVmAccessControlProfileVersionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/inVMAccessControlProfiles/{inVMAccessControlProfileName}/versions/{inVMAccessControlProfileVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryInVMAccessControlProfileVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryInVmAccessControlProfileVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inVmAccessControlProfileVersionName"> The name of the gallery inVMAccessControlProfile version to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inVmAccessControlProfileVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inVmAccessControlProfileVersionName"/> is null. </exception>
        public virtual async Task<NullableResponse<GalleryInVmAccessControlProfileVersionResource>> GetIfExistsAsync(string inVmAccessControlProfileVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inVmAccessControlProfileVersionName, nameof(inVmAccessControlProfileVersionName));

            using var scope = _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics.CreateScope("GalleryInVmAccessControlProfileVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, inVmAccessControlProfileVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<GalleryInVmAccessControlProfileVersionResource>(response.GetRawResponse());
                return Response.FromValue(new GalleryInVmAccessControlProfileVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/inVMAccessControlProfiles/{inVMAccessControlProfileName}/versions/{inVMAccessControlProfileVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryInVMAccessControlProfileVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryInVmAccessControlProfileVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inVmAccessControlProfileVersionName"> The name of the gallery inVMAccessControlProfile version to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inVmAccessControlProfileVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inVmAccessControlProfileVersionName"/> is null. </exception>
        public virtual NullableResponse<GalleryInVmAccessControlProfileVersionResource> GetIfExists(string inVmAccessControlProfileVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inVmAccessControlProfileVersionName, nameof(inVmAccessControlProfileVersionName));

            using var scope = _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsClientDiagnostics.CreateScope("GalleryInVmAccessControlProfileVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _galleryInVmAccessControlProfileVersionGalleryInVmAccessControlProfileVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, inVmAccessControlProfileVersionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<GalleryInVmAccessControlProfileVersionResource>(response.GetRawResponse());
                return Response.FromValue(new GalleryInVmAccessControlProfileVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GalleryInVmAccessControlProfileVersionResource> IEnumerable<GalleryInVmAccessControlProfileVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GalleryInVmAccessControlProfileVersionResource> IAsyncEnumerable<GalleryInVmAccessControlProfileVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
