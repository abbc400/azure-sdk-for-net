// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableQuotaArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableQuotaArmClient"/> class for mocking. </summary>
        protected MockableQuotaArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableQuotaArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableQuotaArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableQuotaArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of CurrentUsagesBaseResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of CurrentUsagesBaseResources and their operations over a CurrentUsagesBaseResource. </returns>
        public virtual CurrentUsagesBaseCollection GetCurrentUsagesBases(ResourceIdentifier scope)
        {
            return new CurrentUsagesBaseCollection(Client, scope);
        }

        /// <summary>
        /// Get the current usage of a resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/usages/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentUsagesBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CurrentUsagesBaseResource>> GetCurrentUsagesBaseAsync(ResourceIdentifier scope, string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetCurrentUsagesBases(scope).GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the current usage of a resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/usages/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentUsagesBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<CurrentUsagesBaseResource> GetCurrentUsagesBase(ResourceIdentifier scope, string resourceName, CancellationToken cancellationToken = default)
        {
            return GetCurrentUsagesBases(scope).Get(resourceName, cancellationToken);
        }

        /// <summary> Gets a collection of CurrentQuotaLimitBaseResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of CurrentQuotaLimitBaseResources and their operations over a CurrentQuotaLimitBaseResource. </returns>
        public virtual CurrentQuotaLimitBaseCollection GetCurrentQuotaLimitBases(ResourceIdentifier scope)
        {
            return new CurrentQuotaLimitBaseCollection(Client, scope);
        }

        /// <summary>
        /// Get the quota limit of a resource. The response can be used to determine the remaining quota to calculate a new quota limit that can be submitted with a PUT request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotas/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentQuotaLimitBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CurrentQuotaLimitBaseResource>> GetCurrentQuotaLimitBaseAsync(ResourceIdentifier scope, string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetCurrentQuotaLimitBases(scope).GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the quota limit of a resource. The response can be used to determine the remaining quota to calculate a new quota limit that can be submitted with a PUT request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotas/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentQuotaLimitBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<CurrentQuotaLimitBaseResource> GetCurrentQuotaLimitBase(ResourceIdentifier scope, string resourceName, CancellationToken cancellationToken = default)
        {
            return GetCurrentQuotaLimitBases(scope).Get(resourceName, cancellationToken);
        }

        /// <summary> Gets a collection of QuotaRequestDetailResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of QuotaRequestDetailResources and their operations over a QuotaRequestDetailResource. </returns>
        public virtual QuotaRequestDetailCollection GetQuotaRequestDetails(ResourceIdentifier scope)
        {
            return new QuotaRequestDetailCollection(Client, scope);
        }

        /// <summary>
        /// Get the quota request details and status by quota request ID for the resources of the resource provider at a specific location. The quota request ID **id** is returned in the response of the PUT operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaRequestDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<QuotaRequestDetailResource>> GetQuotaRequestDetailAsync(ResourceIdentifier scope, string id, CancellationToken cancellationToken = default)
        {
            return await GetQuotaRequestDetails(scope).GetAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the quota request details and status by quota request ID for the resources of the resource provider at a specific location. The quota request ID **id** is returned in the response of the PUT operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaRequestDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<QuotaRequestDetailResource> GetQuotaRequestDetail(ResourceIdentifier scope, string id, CancellationToken cancellationToken = default)
        {
            return GetQuotaRequestDetails(scope).Get(id, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GroupQuotaEntityResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GroupQuotaEntityResource.CreateResourceIdentifier" /> to create a <see cref="GroupQuotaEntityResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GroupQuotaEntityResource"/> object. </returns>
        public virtual GroupQuotaEntityResource GetGroupQuotaEntityResource(ResourceIdentifier id)
        {
            GroupQuotaEntityResource.ValidateResourceId(id);
            return new GroupQuotaEntityResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GroupQuotaSubscriptionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GroupQuotaSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="GroupQuotaSubscriptionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GroupQuotaSubscriptionResource"/> object. </returns>
        public virtual GroupQuotaSubscriptionResource GetGroupQuotaSubscriptionResource(ResourceIdentifier id)
        {
            GroupQuotaSubscriptionResource.ValidateResourceId(id);
            return new GroupQuotaSubscriptionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GroupQuotaSubscriptionRequestStatusResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GroupQuotaSubscriptionRequestStatusResource.CreateResourceIdentifier" /> to create a <see cref="GroupQuotaSubscriptionRequestStatusResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GroupQuotaSubscriptionRequestStatusResource"/> object. </returns>
        public virtual GroupQuotaSubscriptionRequestStatusResource GetGroupQuotaSubscriptionRequestStatusResource(ResourceIdentifier id)
        {
            GroupQuotaSubscriptionRequestStatusResource.ValidateResourceId(id);
            return new GroupQuotaSubscriptionRequestStatusResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GroupQuotaLimitListResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GroupQuotaLimitListResource.CreateResourceIdentifier" /> to create a <see cref="GroupQuotaLimitListResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GroupQuotaLimitListResource"/> object. </returns>
        public virtual GroupQuotaLimitListResource GetGroupQuotaLimitListResource(ResourceIdentifier id)
        {
            GroupQuotaLimitListResource.ValidateResourceId(id);
            return new GroupQuotaLimitListResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GroupQuotaRequestStatusResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GroupQuotaRequestStatusResource.CreateResourceIdentifier" /> to create a <see cref="GroupQuotaRequestStatusResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GroupQuotaRequestStatusResource"/> object. </returns>
        public virtual GroupQuotaRequestStatusResource GetGroupQuotaRequestStatusResource(ResourceIdentifier id)
        {
            GroupQuotaRequestStatusResource.ValidateResourceId(id);
            return new GroupQuotaRequestStatusResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SubscriptionQuotaAllocationsListResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SubscriptionQuotaAllocationsListResource.CreateResourceIdentifier" /> to create a <see cref="SubscriptionQuotaAllocationsListResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubscriptionQuotaAllocationsListResource"/> object. </returns>
        public virtual SubscriptionQuotaAllocationsListResource GetSubscriptionQuotaAllocationsListResource(ResourceIdentifier id)
        {
            SubscriptionQuotaAllocationsListResource.ValidateResourceId(id);
            return new SubscriptionQuotaAllocationsListResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="QuotaAllocationRequestStatusResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="QuotaAllocationRequestStatusResource.CreateResourceIdentifier" /> to create a <see cref="QuotaAllocationRequestStatusResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="QuotaAllocationRequestStatusResource"/> object. </returns>
        public virtual QuotaAllocationRequestStatusResource GetQuotaAllocationRequestStatusResource(ResourceIdentifier id)
        {
            QuotaAllocationRequestStatusResource.ValidateResourceId(id);
            return new QuotaAllocationRequestStatusResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GroupQuotaEnforcementResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GroupQuotaEnforcementResource.CreateResourceIdentifier" /> to create a <see cref="GroupQuotaEnforcementResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GroupQuotaEnforcementResource"/> object. </returns>
        public virtual GroupQuotaEnforcementResource GetGroupQuotaEnforcementResource(ResourceIdentifier id)
        {
            GroupQuotaEnforcementResource.ValidateResourceId(id);
            return new GroupQuotaEnforcementResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CurrentUsagesBaseResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CurrentUsagesBaseResource.CreateResourceIdentifier" /> to create a <see cref="CurrentUsagesBaseResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CurrentUsagesBaseResource"/> object. </returns>
        public virtual CurrentUsagesBaseResource GetCurrentUsagesBaseResource(ResourceIdentifier id)
        {
            CurrentUsagesBaseResource.ValidateResourceId(id);
            return new CurrentUsagesBaseResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CurrentQuotaLimitBaseResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CurrentQuotaLimitBaseResource.CreateResourceIdentifier" /> to create a <see cref="CurrentQuotaLimitBaseResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CurrentQuotaLimitBaseResource"/> object. </returns>
        public virtual CurrentQuotaLimitBaseResource GetCurrentQuotaLimitBaseResource(ResourceIdentifier id)
        {
            CurrentQuotaLimitBaseResource.ValidateResourceId(id);
            return new CurrentQuotaLimitBaseResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="QuotaRequestDetailResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="QuotaRequestDetailResource.CreateResourceIdentifier" /> to create a <see cref="QuotaRequestDetailResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="QuotaRequestDetailResource"/> object. </returns>
        public virtual QuotaRequestDetailResource GetQuotaRequestDetailResource(ResourceIdentifier id)
        {
            QuotaRequestDetailResource.ValidateResourceId(id);
            return new QuotaRequestDetailResource(Client, id);
        }
    }
}
