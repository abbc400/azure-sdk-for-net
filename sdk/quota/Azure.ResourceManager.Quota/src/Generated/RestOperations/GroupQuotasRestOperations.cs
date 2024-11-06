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
    internal partial class GroupQuotasRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of GroupQuotasRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public GroupQuotasRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-10-15-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string managementGroupId, string groupQuotaName, GroupQuotaEntityData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string managementGroupId, string groupQuotaName, GroupQuotaEntityData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
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

        /// <summary> Creates a new GroupQuota for the name passed. A RequestId will be returned by the Service. The status can be polled periodically. The status Async polling is using standards defined at - https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/async-api-reference.md#asynchronous-operations. Use the OperationsStatus URI provided in Azure-AsyncOperation header, the duration will be specified in retry-after header. Once the operation gets to terminal state - Succeeded | Failed, then the URI will change to Get URI and full details can be checked. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="data"> The GroupQuota body details for creation or update of a GroupQuota entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> or <paramref name="groupQuotaName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string managementGroupId, string groupQuotaName, GroupQuotaEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(managementGroupId, groupQuotaName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new GroupQuota for the name passed. A RequestId will be returned by the Service. The status can be polled periodically. The status Async polling is using standards defined at - https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/async-api-reference.md#asynchronous-operations. Use the OperationsStatus URI provided in Azure-AsyncOperation header, the duration will be specified in retry-after header. Once the operation gets to terminal state - Succeeded | Failed, then the URI will change to Get URI and full details can be checked. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="data"> The GroupQuota body details for creation or update of a GroupQuota entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> or <paramref name="groupQuotaName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string managementGroupId, string groupQuotaName, GroupQuotaEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(managementGroupId, groupQuotaName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateUpdateRequestUri(string managementGroupId, string groupQuotaName, GroupQuotaEntityPatch patch)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateUpdateRequest(string managementGroupId, string groupQuotaName, GroupQuotaEntityPatch patch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(patch, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// Updates the GroupQuotas for the name passed. A GroupQuotas RequestId will be returned by the Service. The status can be polled periodically. The status Async polling is using standards defined at - https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/async-api-reference.md#asynchronous-operations. Use the OperationsStatus URI provided in Azure-AsyncOperation header, the duration will be specified in retry-after header. Once the operation gets to terminal state - Succeeded | Failed, then the URI will change to Get URI and full details can be checked.
        ///  Any change in the filters will be applicable to the future quota assignments, existing quota allocated to subscriptions from the GroupQuotas remains unchanged.
        /// </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="patch"> The  GroupQuotas Patch Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> or <paramref name="groupQuotaName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string managementGroupId, string groupQuotaName, GroupQuotaEntityPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(managementGroupId, groupQuotaName, patch);
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

        /// <summary>
        /// Updates the GroupQuotas for the name passed. A GroupQuotas RequestId will be returned by the Service. The status can be polled periodically. The status Async polling is using standards defined at - https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/async-api-reference.md#asynchronous-operations. Use the OperationsStatus URI provided in Azure-AsyncOperation header, the duration will be specified in retry-after header. Once the operation gets to terminal state - Succeeded | Failed, then the URI will change to Get URI and full details can be checked.
        ///  Any change in the filters will be applicable to the future quota assignments, existing quota allocated to subscriptions from the GroupQuotas remains unchanged.
        /// </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="patch"> The  GroupQuotas Patch Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> or <paramref name="groupQuotaName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string managementGroupId, string groupQuotaName, GroupQuotaEntityPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(managementGroupId, groupQuotaName, patch);
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

        internal RequestUriBuilder CreateGetRequestUri(string managementGroupId, string groupQuotaName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string managementGroupId, string groupQuotaName)
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
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the GroupQuotas for the name passed. It will return the GroupQuotas properties only. The details on group quota can be access from the group quota APIs. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/> or <paramref name="groupQuotaName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> or <paramref name="groupQuotaName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<GroupQuotaEntityData>> GetAsync(string managementGroupId, string groupQuotaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));

            using var message = CreateGetRequest(managementGroupId, groupQuotaName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GroupQuotaEntityData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GroupQuotaEntityData.DeserializeGroupQuotaEntityData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((GroupQuotaEntityData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the GroupQuotas for the name passed. It will return the GroupQuotas properties only. The details on group quota can be access from the group quota APIs. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/> or <paramref name="groupQuotaName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> or <paramref name="groupQuotaName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<GroupQuotaEntityData> Get(string managementGroupId, string groupQuotaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));

            using var message = CreateGetRequest(managementGroupId, groupQuotaName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GroupQuotaEntityData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GroupQuotaEntityData.DeserializeGroupQuotaEntityData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((GroupQuotaEntityData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string managementGroupId, string groupQuotaName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string managementGroupId, string groupQuotaName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the GroupQuotas for the name passed. All the remaining shareQuota in the GroupQuotas will be lost. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/> or <paramref name="groupQuotaName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> or <paramref name="groupQuotaName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string managementGroupId, string groupQuotaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));

            using var message = CreateDeleteRequest(managementGroupId, groupQuotaName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes the GroupQuotas for the name passed. All the remaining shareQuota in the GroupQuotas will be lost. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/> or <paramref name="groupQuotaName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> or <paramref name="groupQuotaName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string managementGroupId, string groupQuotaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));

            using var message = CreateDeleteRequest(managementGroupId, groupQuotaName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListRequestUri(string managementGroupId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string managementGroupId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists GroupQuotas for the scope passed. It will return the GroupQuotas QuotaEntity properties only.The details on group quota can be access from the group quota APIs. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<GroupQuotaList>> ListAsync(string managementGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));

            using var message = CreateListRequest(managementGroupId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GroupQuotaList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GroupQuotaList.DeserializeGroupQuotaList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists GroupQuotas for the scope passed. It will return the GroupQuotas QuotaEntity properties only.The details on group quota can be access from the group quota APIs. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<GroupQuotaList> List(string managementGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));

            using var message = CreateListRequest(managementGroupId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GroupQuotaList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GroupQuotaList.DeserializeGroupQuotaList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string managementGroupId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string managementGroupId)
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

        /// <summary> Lists GroupQuotas for the scope passed. It will return the GroupQuotas QuotaEntity properties only.The details on group quota can be access from the group quota APIs. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="managementGroupId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<GroupQuotaList>> ListNextPageAsync(string nextLink, string managementGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));

            using var message = CreateListNextPageRequest(nextLink, managementGroupId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GroupQuotaList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GroupQuotaList.DeserializeGroupQuotaList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists GroupQuotas for the scope passed. It will return the GroupQuotas QuotaEntity properties only.The details on group quota can be access from the group quota APIs. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="managementGroupId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<GroupQuotaList> ListNextPage(string nextLink, string managementGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));

            using var message = CreateListNextPageRequest(nextLink, managementGroupId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GroupQuotaList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GroupQuotaList.DeserializeGroupQuotaList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
