// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ManagementGroups;

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A Class representing a SubscriptionQuotaAllocationsList along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SubscriptionQuotaAllocationsListResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSubscriptionQuotaAllocationsListResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagementGroupResource"/> using the GetSubscriptionQuotaAllocationsList method.
    /// </summary>
    public partial class SubscriptionQuotaAllocationsListResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionQuotaAllocationsListResource"/> instance. </summary>
        /// <param name="managementGroupId"> The managementGroupId. </param>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="groupQuotaName"> The groupQuotaName. </param>
        /// <param name="resourceProviderName"> The resourceProviderName. </param>
        /// <param name="location"> The location. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, AzureLocation location)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocations/{location}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationClientDiagnostics;
        private readonly GroupQuotaSubscriptionAllocationRestOperations _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRestClient;
        private readonly ClientDiagnostics _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestClientDiagnostics;
        private readonly GroupQuotaSubscriptionAllocationRequestRestOperations _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestRestClient;
        private readonly SubscriptionQuotaAllocationsListData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Quota/groupQuotas/resourceProviders/quotaAllocations";

        /// <summary> Initializes a new instance of the <see cref="SubscriptionQuotaAllocationsListResource"/> class for mocking. </summary>
        protected SubscriptionQuotaAllocationsListResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionQuotaAllocationsListResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionQuotaAllocationsListResource(ArmClient client, SubscriptionQuotaAllocationsListData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionQuotaAllocationsListResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionQuotaAllocationsListResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationApiVersion);
            _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRestClient = new GroupQuotaSubscriptionAllocationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationApiVersion);
            _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestApiVersion);
            _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestRestClient = new GroupQuotaSubscriptionAllocationRequestRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SubscriptionQuotaAllocationsListData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets all the quota allocated to a subscription for the specified resource provider and location for resource names passed in $filter=resourceName eq {SKU}. This will include the GroupQuota and total quota allocated to the subscription. Only the Group quota allocated to the subscription can be allocated back to the MG Group Quota.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocations/{location}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocation_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionQuotaAllocationsListResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionQuotaAllocationsListResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationClientDiagnostics.CreateScope("SubscriptionQuotaAllocationsListResource.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRestClient.ListAsync(Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, new AzureLocation(Id.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionQuotaAllocationsListResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the quota allocated to a subscription for the specified resource provider and location for resource names passed in $filter=resourceName eq {SKU}. This will include the GroupQuota and total quota allocated to the subscription. Only the Group quota allocated to the subscription can be allocated back to the MG Group Quota.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocations/{location}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocation_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionQuotaAllocationsListResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionQuotaAllocationsListResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationClientDiagnostics.CreateScope("SubscriptionQuotaAllocationsListResource.Get");
            scope.Start();
            try
            {
                var response = _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRestClient.List(Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, new AzureLocation(Id.Name), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionQuotaAllocationsListResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request to assign quota from group quota to a specific Subscription. The assign GroupQuota to subscriptions or reduce the quota allocated to subscription to give back the unused quota ( quota &gt;= usages) to the groupQuota. So, this API can be used to assign Quota to subscriptions and assign back unused quota to group quota, which can be assigned to another subscriptions in the GroupQuota. User can collect unused quotas from multiple subscriptions within the groupQuota and assign the groupQuota to the subscription, where it's needed.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocations/{location}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocationRequest_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionQuotaAllocationsListResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Quota requests payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SubscriptionQuotaAllocationsListResource>> UpdateAsync(WaitUntil waitUntil, SubscriptionQuotaAllocationsListData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestClientDiagnostics.CreateScope("SubscriptionQuotaAllocationsListResource.Update");
            scope.Start();
            try
            {
                var response = await _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestRestClient.UpdateAsync(Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, new AzureLocation(Id.Name), data, cancellationToken).ConfigureAwait(false);
                var operation = new QuotaArmOperation<SubscriptionQuotaAllocationsListResource>(new SubscriptionQuotaAllocationsListOperationSource(Client), _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestClientDiagnostics, Pipeline, _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestRestClient.CreateUpdateRequest(Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, new AzureLocation(Id.Name), data).Request, response, OperationFinalStateVia.Location);
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
        /// Request to assign quota from group quota to a specific Subscription. The assign GroupQuota to subscriptions or reduce the quota allocated to subscription to give back the unused quota ( quota &gt;= usages) to the groupQuota. So, this API can be used to assign Quota to subscriptions and assign back unused quota to group quota, which can be assigned to another subscriptions in the GroupQuota. User can collect unused quotas from multiple subscriptions within the groupQuota and assign the groupQuota to the subscription, where it's needed.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocations/{location}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocationRequest_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionQuotaAllocationsListResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Quota requests payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SubscriptionQuotaAllocationsListResource> Update(WaitUntil waitUntil, SubscriptionQuotaAllocationsListData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestClientDiagnostics.CreateScope("SubscriptionQuotaAllocationsListResource.Update");
            scope.Start();
            try
            {
                var response = _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestRestClient.Update(Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, new AzureLocation(Id.Name), data, cancellationToken);
                var operation = new QuotaArmOperation<SubscriptionQuotaAllocationsListResource>(new SubscriptionQuotaAllocationsListOperationSource(Client), _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestClientDiagnostics, Pipeline, _subscriptionQuotaAllocationsListGroupQuotaSubscriptionAllocationRequestRestClient.CreateUpdateRequest(Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, new AzureLocation(Id.Name), data).Request, response, OperationFinalStateVia.Location);
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
    }
}
