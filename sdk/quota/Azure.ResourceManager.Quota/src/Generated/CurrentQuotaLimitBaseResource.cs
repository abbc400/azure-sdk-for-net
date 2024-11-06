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

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A Class representing a CurrentQuotaLimitBase along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="CurrentQuotaLimitBaseResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetCurrentQuotaLimitBaseResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetCurrentQuotaLimitBase method.
    /// </summary>
    public partial class CurrentQuotaLimitBaseResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CurrentQuotaLimitBaseResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="resourceName"> The resourceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string resourceName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Quota/quotas/{resourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _currentQuotaLimitBaseQuotaClientDiagnostics;
        private readonly QuotaRestOperations _currentQuotaLimitBaseQuotaRestClient;
        private readonly CurrentQuotaLimitBaseData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Quota/quotas";

        /// <summary> Initializes a new instance of the <see cref="CurrentQuotaLimitBaseResource"/> class for mocking. </summary>
        protected CurrentQuotaLimitBaseResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CurrentQuotaLimitBaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CurrentQuotaLimitBaseResource(ArmClient client, CurrentQuotaLimitBaseData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CurrentQuotaLimitBaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CurrentQuotaLimitBaseResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _currentQuotaLimitBaseQuotaClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string currentQuotaLimitBaseQuotaApiVersion);
            _currentQuotaLimitBaseQuotaRestClient = new QuotaRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, currentQuotaLimitBaseQuotaApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CurrentQuotaLimitBaseData Data
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CurrentQuotaLimitBaseResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseResource.Get");
            scope.Start();
            try
            {
                var response = await _currentQuotaLimitBaseQuotaRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CurrentQuotaLimitBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CurrentQuotaLimitBaseResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseResource.Get");
            scope.Start();
            try
            {
                var response = _currentQuotaLimitBaseQuotaRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CurrentQuotaLimitBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the quota limit for a specific resource to the specified value:
        /// 1. Use the Usages-GET and Quota-GET operations to determine the remaining quota for the specific resource and to calculate the new quota limit. These steps are detailed in [this example](https://techcommunity.microsoft.com/t5/azure-governance-and-management/using-the-new-quota-rest-api/ba-p/2183670).
        /// 2. Use this PUT operation to update the quota limit. Please check the URI in location header for the detailed status of the request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotas/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Update</description>
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
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Quota requests payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CurrentQuotaLimitBaseResource>> UpdateAsync(WaitUntil waitUntil, CurrentQuotaLimitBaseData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseResource.Update");
            scope.Start();
            try
            {
                var response = await _currentQuotaLimitBaseQuotaRestClient.UpdateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new QuotaArmOperation<CurrentQuotaLimitBaseResource>(new CurrentQuotaLimitBaseOperationSource(Client), _currentQuotaLimitBaseQuotaClientDiagnostics, Pipeline, _currentQuotaLimitBaseQuotaRestClient.CreateUpdateRequest(Id.Parent, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Update the quota limit for a specific resource to the specified value:
        /// 1. Use the Usages-GET and Quota-GET operations to determine the remaining quota for the specific resource and to calculate the new quota limit. These steps are detailed in [this example](https://techcommunity.microsoft.com/t5/azure-governance-and-management/using-the-new-quota-rest-api/ba-p/2183670).
        /// 2. Use this PUT operation to update the quota limit. Please check the URI in location header for the detailed status of the request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotas/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Update</description>
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
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Quota requests payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CurrentQuotaLimitBaseResource> Update(WaitUntil waitUntil, CurrentQuotaLimitBaseData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseResource.Update");
            scope.Start();
            try
            {
                var response = _currentQuotaLimitBaseQuotaRestClient.Update(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new QuotaArmOperation<CurrentQuotaLimitBaseResource>(new CurrentQuotaLimitBaseOperationSource(Client), _currentQuotaLimitBaseQuotaClientDiagnostics, Pipeline, _currentQuotaLimitBaseQuotaRestClient.CreateUpdateRequest(Id.Parent, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
