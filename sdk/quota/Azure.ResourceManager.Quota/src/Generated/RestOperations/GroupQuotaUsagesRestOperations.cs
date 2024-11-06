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
    internal partial class GroupQuotaUsagesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of GroupQuotaUsagesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public GroupQuotaUsagesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-10-15-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string managementGroupId, string groupQuotaName, string resourceProviderName, AzureLocation location)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/locationUsages/", false);
            uri.AppendPath(location, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string managementGroupId, string groupQuotaName, string resourceProviderName, AzureLocation location)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/locationUsages/", false);
            uri.AppendPath(location, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the GroupQuotas usages and limits(quota). Location is required paramter. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ResourceUsageList>> ListAsync(string managementGroupId, string groupQuotaName, string resourceProviderName, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));

            using var message = CreateListRequest(managementGroupId, groupQuotaName, resourceProviderName, location);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceUsageList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceUsageList.DeserializeResourceUsageList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the GroupQuotas usages and limits(quota). Location is required paramter. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ResourceUsageList> List(string managementGroupId, string groupQuotaName, string resourceProviderName, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));

            using var message = CreateListRequest(managementGroupId, groupQuotaName, resourceProviderName, location);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceUsageList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceUsageList.DeserializeResourceUsageList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string managementGroupId, string groupQuotaName, string resourceProviderName, AzureLocation location)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string managementGroupId, string groupQuotaName, string resourceProviderName, AzureLocation location)
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

        /// <summary> Gets the GroupQuotas usages and limits(quota). Location is required paramter. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ResourceUsageList>> ListNextPageAsync(string nextLink, string managementGroupId, string groupQuotaName, string resourceProviderName, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));

            using var message = CreateListNextPageRequest(nextLink, managementGroupId, groupQuotaName, resourceProviderName, location);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceUsageList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceUsageList.DeserializeResourceUsageList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the GroupQuotas usages and limits(quota). Location is required paramter. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ResourceUsageList> ListNextPage(string nextLink, string managementGroupId, string groupQuotaName, string resourceProviderName, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));

            using var message = CreateListNextPageRequest(nextLink, managementGroupId, groupQuotaName, resourceProviderName, location);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceUsageList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceUsageList.DeserializeResourceUsageList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
