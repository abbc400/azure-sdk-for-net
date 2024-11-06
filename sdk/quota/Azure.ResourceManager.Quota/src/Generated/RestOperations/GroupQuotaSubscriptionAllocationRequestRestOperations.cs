// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Quota.Models;

namespace Azure.ResourceManager.Quota
{
    internal partial class GroupQuotaSubscriptionAllocationRequestRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of GroupQuotaSubscriptionAllocationRequestRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public GroupQuotaSubscriptionAllocationRequestRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-10-15-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateUpdateRequestUri(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, AzureLocation location, SubscriptionQuotaAllocationsListData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/quotaAllocations/", false);
            uri.AppendPath(location, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateUpdateRequest(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, AzureLocation location, SubscriptionQuotaAllocationsListData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/quotaAllocations/", false);
            uri.AppendPath(location, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Request to assign quota from group quota to a specific Subscription. The assign GroupQuota to subscriptions or reduce the quota allocated to subscription to give back the unused quota ( quota &gt;= usages) to the groupQuota. So, this API can be used to assign Quota to subscriptions and assign back unused quota to group quota, which can be assigned to another subscriptions in the GroupQuota. User can collect unused quotas from multiple subscriptions within the groupQuota and assign the groupQuota to the subscription, where it's needed. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="data"> Quota requests payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, AzureLocation location, SubscriptionQuotaAllocationsListData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(managementGroupId, subscriptionId, groupQuotaName, resourceProviderName, location, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Request to assign quota from group quota to a specific Subscription. The assign GroupQuota to subscriptions or reduce the quota allocated to subscription to give back the unused quota ( quota &gt;= usages) to the groupQuota. So, this API can be used to assign Quota to subscriptions and assign back unused quota to group quota, which can be assigned to another subscriptions in the GroupQuota. User can collect unused quotas from multiple subscriptions within the groupQuota and assign the groupQuota to the subscription, where it's needed. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="data"> Quota requests payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, AzureLocation location, SubscriptionQuotaAllocationsListData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(managementGroupId, subscriptionId, groupQuotaName, resourceProviderName, location, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, string allocationId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/quotaAllocationRequests/", false);
            uri.AppendPath(allocationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, string allocationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/quotaAllocationRequests/", false);
            uri.AppendPath(allocationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the quota allocation request status for the subscriptionId by allocationId. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="allocationId"> Request Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="allocationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="allocationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<QuotaAllocationRequestStatusData>> GetAsync(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, string allocationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNullOrEmpty(allocationId, nameof(allocationId));

            using var message = CreateGetRequest(managementGroupId, subscriptionId, groupQuotaName, resourceProviderName, allocationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaAllocationRequestStatusData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = QuotaAllocationRequestStatusData.DeserializeQuotaAllocationRequestStatusData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((QuotaAllocationRequestStatusData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the quota allocation request status for the subscriptionId by allocationId. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="allocationId"> Request Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="allocationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="allocationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<QuotaAllocationRequestStatusData> Get(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, string allocationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNullOrEmpty(allocationId, nameof(allocationId));

            using var message = CreateGetRequest(managementGroupId, subscriptionId, groupQuotaName, resourceProviderName, allocationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaAllocationRequestStatusData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = QuotaAllocationRequestStatusData.DeserializeQuotaAllocationRequestStatusData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((QuotaAllocationRequestStatusData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListRequestUri(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/quotaAllocationRequests", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("$filter", filter, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/quotaAllocationRequests", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("$filter", filter, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get all the quotaAllocationRequests for a resourceProvider/location. The filter paramter for location is required. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<QuotaAllocationRequestStatusList>> ListAsync(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListRequest(managementGroupId, subscriptionId, groupQuotaName, resourceProviderName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaAllocationRequestStatusList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = QuotaAllocationRequestStatusList.DeserializeQuotaAllocationRequestStatusList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all the quotaAllocationRequests for a resourceProvider/location. The filter paramter for location is required. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<QuotaAllocationRequestStatusList> List(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListRequest(managementGroupId, subscriptionId, groupQuotaName, resourceProviderName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaAllocationRequestStatusList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = QuotaAllocationRequestStatusList.DeserializeQuotaAllocationRequestStatusList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get all the quotaAllocationRequests for a resourceProvider/location. The filter paramter for location is required. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<QuotaAllocationRequestStatusList>> ListNextPageAsync(string nextLink, string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListNextPageRequest(nextLink, managementGroupId, subscriptionId, groupQuotaName, resourceProviderName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaAllocationRequestStatusList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = QuotaAllocationRequestStatusList.DeserializeQuotaAllocationRequestStatusList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all the quotaAllocationRequests for a resourceProvider/location. The filter paramter for location is required. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<QuotaAllocationRequestStatusList> ListNextPage(string nextLink, string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListNextPageRequest(nextLink, managementGroupId, subscriptionId, groupQuotaName, resourceProviderName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaAllocationRequestStatusList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = QuotaAllocationRequestStatusList.DeserializeQuotaAllocationRequestStatusList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
