// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmSearchModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.OfferingsByRegion"/>. </summary>
        /// <param name="regionName"> The name of the region. </param>
        /// <param name="features"> The list of features offered in this region. </param>
        /// <param name="skus"> The list of SKUs offered in this region. </param>
        /// <returns> A new <see cref="Models.OfferingsByRegion"/> instance for mocking. </returns>
        public static OfferingsByRegion OfferingsByRegion(string regionName = null, IEnumerable<FeatureOffering> features = null, IEnumerable<SkuOffering> skus = null)
        {
            features ??= new List<FeatureOffering>();
            skus ??= new List<SkuOffering>();

            return new OfferingsByRegion(regionName, features?.ToList(), skus?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.FeatureOffering"/>. </summary>
        /// <param name="name"> The name of the feature offered in this region. </param>
        /// <returns> A new <see cref="Models.FeatureOffering"/> instance for mocking. </returns>
        public static FeatureOffering FeatureOffering(FeatureName? name = null)
        {
            return new FeatureOffering(name, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SkuOffering"/>. </summary>
        /// <param name="skuName"> Defines the SKU of a search service, which determines billing rate and capacity limits. </param>
        /// <param name="limits"> The limits associated with this SKU offered in this region. </param>
        /// <returns> A new <see cref="Models.SkuOffering"/> instance for mocking. </returns>
        public static SkuOffering SkuOffering(SearchServiceSkuName? skuName = null, SkuOfferingLimits limits = null)
        {
            return new SkuOffering(skuName != null ? new SearchSku(skuName, serializedAdditionalRawData: null) : null, limits, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SkuOfferingLimits"/>. </summary>
        /// <param name="indexes"> The maximum number of indexes available for this SKU. </param>
        /// <param name="indexers"> The maximum number of indexers available for this SKU. </param>
        /// <param name="partitionStorageInGigabytes"> The maximum storage size in Gigabytes available for this SKU per partition. </param>
        /// <param name="partitionVectorStorageInGigabytes"> The maximum vector storage size in Gigabytes available for this SKU per partition. </param>
        /// <param name="searchUnits"> The maximum number of search units available for this SKU. </param>
        /// <param name="replicas"> The maximum number of replicas available for this SKU. </param>
        /// <param name="partitions"> The maximum number of partitions available for this SKU. </param>
        /// <returns> A new <see cref="Models.SkuOfferingLimits"/> instance for mocking. </returns>
        public static SkuOfferingLimits SkuOfferingLimits(int? indexes = null, int? indexers = null, int? partitionStorageInGigabytes = null, int? partitionVectorStorageInGigabytes = null, int? searchUnits = null, int? replicas = null, int? partitions = null)
        {
            return new SkuOfferingLimits(
                indexes,
                indexers,
                partitionStorageInGigabytes,
                partitionVectorStorageInGigabytes,
                searchUnits,
                replicas,
                partitions,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SearchServiceAdminKeyResult"/>. </summary>
        /// <param name="primaryKey"> The primary admin API key of the search service. </param>
        /// <param name="secondaryKey"> The secondary admin API key of the search service. </param>
        /// <returns> A new <see cref="Models.SearchServiceAdminKeyResult"/> instance for mocking. </returns>
        public static SearchServiceAdminKeyResult SearchServiceAdminKeyResult(string primaryKey = null, string secondaryKey = null)
        {
            return new SearchServiceAdminKeyResult(primaryKey, secondaryKey, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SearchServiceQueryKey"/>. </summary>
        /// <param name="name"> The name of the query API key. Query names are optional, but assigning a name can help you remember how it's used. </param>
        /// <param name="key"> The value of the query API key. </param>
        /// <returns> A new <see cref="Models.SearchServiceQueryKey"/> instance for mocking. </returns>
        public static SearchServiceQueryKey SearchServiceQueryKey(string name = null, string key = null)
        {
            return new SearchServiceQueryKey(name, key, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Search.SearchServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="searchSkuName"> The SKU of the search service, which determines price tier and capacity limits. This property is required when creating a new search service. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="replicaCount"> The number of replicas in the search service. If specified, it must be a value between 1 and 12 inclusive for standard SKUs or between 1 and 3 inclusive for basic SKU. </param>
        /// <param name="partitionCount"> The number of partitions in the search service; if specified, it can be 1, 2, 3, 4, 6, or 12. Values greater than 1 are only valid for standard SKUs. For 'standard3' services with hostingMode set to 'highDensity', the allowed values are between 1 and 3. </param>
        /// <param name="endpoint"> The endpoint of the Azure AI Search service. </param>
        /// <param name="hostingMode"> Applicable only for the standard3 SKU. You can set this property to enable up to 3 high density partitions that allow up to 1000 indexes, which is much higher than the maximum indexes allowed for any other SKU. For the standard3 SKU, the value is either 'default' or 'highDensity'. For all other SKUs, this value must be 'default'. </param>
        /// <param name="computeType"> Configure this property to support the search service using either the default compute or Azure Confidential Compute. </param>
        /// <param name="publicInternetAccess"> This value can be set to 'enabled' to avoid breaking changes on existing customer resources and templates. If set to 'disabled', traffic over public interface is not allowed, and private endpoint connections would be the exclusive access method. </param>
        /// <param name="status"> The status of the search service. Possible values include: 'running': The search service is running and no provisioning operations are underway. 'provisioning': The search service is being provisioned or scaled up or down. 'deleting': The search service is being deleted. 'degraded': The search service is degraded. This can occur when the underlying search units are not healthy. The search service is most likely operational, but performance might be slow and some requests might be dropped. 'disabled': The search service is disabled. In this state, the service will reject all API requests. 'error': The search service is in an error state. 'stopped': The search service is in a subscription that's disabled. If your service is in the degraded, disabled, or error states, it means the Azure AI Search team is actively investigating the underlying issue. Dedicated services in these states are still chargeable based on the number of search units provisioned. </param>
        /// <param name="statusDetails"> The details of the search service status. </param>
        /// <param name="provisioningState"> The state of the last provisioning operation performed on the search service. Provisioning is an intermediate state that occurs while service capacity is being established. After capacity is set up, provisioningState changes to either 'Succeeded' or 'Failed'. Client applications can poll provisioning status (the recommended polling interval is from 30 seconds to one minute) by using the Get Search Service operation to see when an operation is completed. If you are using the free service, this value tends to come back as 'Succeeded' directly in the call to Create search service. This is because the free service uses capacity that is already set up. </param>
        /// <param name="networkRuleSet"> Network specific rules that determine how the Azure AI Search service may be reached. </param>
        /// <param name="disabledDataExfiltrationOptions"> A list of data exfiltration scenarios that are explicitly disallowed for the search service. Currently, the only supported value is 'All' to disable all possible data export scenarios with more fine grained controls planned for the future. </param>
        /// <param name="encryptionWithCmk"> Specifies any policy regarding encryption of resources (such as indexes) using customer manager keys within a search service. </param>
        /// <param name="isLocalAuthDisabled"> When set to true, calls to the search service will not be permitted to utilize API keys for authentication. This cannot be set to true if 'dataPlaneAuthOptions' are defined. </param>
        /// <param name="authOptions"> Defines the options for how the data plane API of a search service authenticates requests. This cannot be set if 'disableLocalAuth' is set to true. </param>
        /// <param name="semanticSearch"> Sets options that control the availability of semantic search. This configuration is only possible for certain Azure AI Search SKUs in certain locations. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections to the Azure AI Search service. </param>
        /// <param name="sharedPrivateLinkResources"> The list of shared private link resources managed by the Azure AI Search service. </param>
        /// <param name="eTag"> A system generated property representing the service's etag that can be for optimistic concurrency control during updates. </param>
        /// <param name="upgradeAvailable"> Indicates whether or not the search service has an upgrade available. </param>
        /// <param name="serviceUpgradeOn"> The date and time the search service was last upgraded. This field will be null until the service gets upgraded for the first time. </param>
        /// <returns> A new <see cref="Search.SearchServiceData"/> instance for mocking. </returns>
        public static SearchServiceData SearchServiceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, SearchServiceSkuName? searchSkuName = null, ManagedServiceIdentity identity = null, int? replicaCount = null, int? partitionCount = null, Uri endpoint = null, SearchServiceHostingMode? hostingMode = null, ComputeType? computeType = null, SearchServicePublicInternetAccess? publicInternetAccess = null, SearchServiceStatus? status = null, string statusDetails = null, SearchServiceProvisioningState? provisioningState = null, SearchServiceNetworkRuleSet networkRuleSet = null, IEnumerable<SearchDisabledDataExfiltrationOption> disabledDataExfiltrationOptions = null, SearchEncryptionWithCmk encryptionWithCmk = null, bool? isLocalAuthDisabled = null, SearchAadAuthDataPlaneAuthOptions authOptions = null, SearchSemanticSearch? semanticSearch = null, IEnumerable<SearchPrivateEndpointConnectionData> privateEndpointConnections = null, IEnumerable<SharedSearchServicePrivateLinkResourceData> sharedPrivateLinkResources = null, ETag? eTag = null, bool? upgradeAvailable = null, DateTimeOffset? serviceUpgradeOn = null)
        {
            tags ??= new Dictionary<string, string>();
            disabledDataExfiltrationOptions ??= new List<SearchDisabledDataExfiltrationOption>();
            privateEndpointConnections ??= new List<SearchPrivateEndpointConnectionData>();
            sharedPrivateLinkResources ??= new List<SharedSearchServicePrivateLinkResourceData>();

            return new SearchServiceData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                searchSkuName != null ? new SearchSku(searchSkuName, serializedAdditionalRawData: null) : null,
                identity,
                replicaCount,
                partitionCount,
                endpoint,
                hostingMode,
                computeType,
                publicInternetAccess,
                status,
                statusDetails,
                provisioningState,
                networkRuleSet,
                disabledDataExfiltrationOptions?.ToList(),
                encryptionWithCmk,
                isLocalAuthDisabled,
                authOptions,
                semanticSearch,
                privateEndpointConnections?.ToList(),
                sharedPrivateLinkResources?.ToList(),
                eTag,
                upgradeAvailable,
                serviceUpgradeOn,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SearchEncryptionWithCmk"/>. </summary>
        /// <param name="enforcement"> Describes how a search service should enforce compliance if it finds objects that aren't encrypted with the customer-managed key. </param>
        /// <param name="encryptionComplianceStatus"> Returns the status of search service compliance with respect to non-CMK-encrypted objects. If a service has more than one unencrypted object, and enforcement is enabled, the service is marked as noncompliant. </param>
        /// <returns> A new <see cref="Models.SearchEncryptionWithCmk"/> instance for mocking. </returns>
        public static SearchEncryptionWithCmk SearchEncryptionWithCmk(SearchEncryptionWithCmkEnforcement? enforcement = null, SearchEncryptionComplianceStatus? encryptionComplianceStatus = null)
        {
            return new SearchEncryptionWithCmk(enforcement, encryptionComplianceStatus, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Search.SearchPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Describes the properties of an existing private endpoint connection to the Azure AI Search service. </param>
        /// <returns> A new <see cref="Search.SearchPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static SearchPrivateEndpointConnectionData SearchPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, SearchServicePrivateEndpointConnectionProperties properties = null)
        {
            return new SearchPrivateEndpointConnectionData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Search.SharedSearchServicePrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Describes the properties of a shared private link resource managed by the Azure AI Search service. </param>
        /// <returns> A new <see cref="Search.SharedSearchServicePrivateLinkResourceData"/> instance for mocking. </returns>
        public static SharedSearchServicePrivateLinkResourceData SharedSearchServicePrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, SharedSearchServicePrivateLinkResourceProperties properties = null)
        {
            return new SharedSearchServicePrivateLinkResourceData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SearchServicePatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="searchSkuName"> The SKU of the search service, which determines price tier and capacity limits. This property is required when creating a new search service. </param>
        /// <param name="identity"> Details about the search service identity. A null value indicates that the search service has no identity assigned. </param>
        /// <param name="replicaCount"> The number of replicas in the search service. If specified, it must be a value between 1 and 12 inclusive for standard SKUs or between 1 and 3 inclusive for basic SKU. </param>
        /// <param name="partitionCount"> The number of partitions in the search service; if specified, it can be 1, 2, 3, 4, 6, or 12. Values greater than 1 are only valid for standard SKUs. For 'standard3' services with hostingMode set to 'highDensity', the allowed values are between 1 and 3. </param>
        /// <param name="endpoint"> The endpoint of the Azure AI Search service. </param>
        /// <param name="hostingMode"> Applicable only for the standard3 SKU. You can set this property to enable up to 3 high density partitions that allow up to 1000 indexes, which is much higher than the maximum indexes allowed for any other SKU. For the standard3 SKU, the value is either 'default' or 'highDensity'. For all other SKUs, this value must be 'default'. </param>
        /// <param name="computeType"> Configure this property to support the search service using either the default compute or Azure Confidential Compute. </param>
        /// <param name="publicInternetAccess"> This value can be set to 'enabled' to avoid breaking changes on existing customer resources and templates. If set to 'disabled', traffic over public interface is not allowed, and private endpoint connections would be the exclusive access method. </param>
        /// <param name="status"> The status of the search service. Possible values include: 'running': The search service is running and no provisioning operations are underway. 'provisioning': The search service is being provisioned or scaled up or down. 'deleting': The search service is being deleted. 'degraded': The search service is degraded. This can occur when the underlying search units are not healthy. The search service is most likely operational, but performance might be slow and some requests might be dropped. 'disabled': The search service is disabled. In this state, the service will reject all API requests. 'error': The search service is in an error state. 'stopped': The search service is in a subscription that's disabled. If your service is in the degraded, disabled, or error states, it means the Azure AI Search team is actively investigating the underlying issue. Dedicated services in these states are still chargeable based on the number of search units provisioned. </param>
        /// <param name="statusDetails"> The details of the search service status. </param>
        /// <param name="provisioningState"> The state of the last provisioning operation performed on the search service. Provisioning is an intermediate state that occurs while service capacity is being established. After capacity is set up, provisioningState changes to either 'Succeeded' or 'Failed'. Client applications can poll provisioning status (the recommended polling interval is from 30 seconds to one minute) by using the Get Search Service operation to see when an operation is completed. If you are using the free service, this value tends to come back as 'Succeeded' directly in the call to Create search service. This is because the free service uses capacity that is already set up. </param>
        /// <param name="networkRuleSet"> Network specific rules that determine how the Azure AI Search service may be reached. </param>
        /// <param name="disabledDataExfiltrationOptions"> A list of data exfiltration scenarios that are explicitly disallowed for the search service. Currently, the only supported value is 'All' to disable all possible data export scenarios with more fine grained controls planned for the future. </param>
        /// <param name="encryptionWithCmk"> Specifies any policy regarding encryption of resources (such as indexes) using customer manager keys within a search service. </param>
        /// <param name="isLocalAuthDisabled"> When set to true, calls to the search service will not be permitted to utilize API keys for authentication. This cannot be set to true if 'dataPlaneAuthOptions' are defined. </param>
        /// <param name="authOptions"> Defines the options for how the data plane API of a search service authenticates requests. This cannot be set if 'disableLocalAuth' is set to true. </param>
        /// <param name="semanticSearch"> Sets options that control the availability of semantic search. This configuration is only possible for certain Azure AI Search SKUs in certain locations. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections to the Azure AI Search service. </param>
        /// <param name="sharedPrivateLinkResources"> The list of shared private link resources managed by the Azure AI Search service. </param>
        /// <param name="eTag"> A system generated property representing the service's etag that can be for optimistic concurrency control during updates. </param>
        /// <param name="upgradeAvailable"> Indicates whether or not the search service has an upgrade available. </param>
        /// <param name="serviceUpgradeOn"> The date and time the search service was last upgraded. This field will be null until the service gets upgraded for the first time. </param>
        /// <returns> A new <see cref="Models.SearchServicePatch"/> instance for mocking. </returns>
        public static SearchServicePatch SearchServicePatch(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, SearchServiceSkuName? searchSkuName = null, ManagedServiceIdentity identity = null, int? replicaCount = null, int? partitionCount = null, Uri endpoint = null, SearchServiceHostingMode? hostingMode = null, ComputeType? computeType = null, SearchServicePublicInternetAccess? publicInternetAccess = null, SearchServiceStatus? status = null, string statusDetails = null, SearchServiceProvisioningState? provisioningState = null, SearchServiceNetworkRuleSet networkRuleSet = null, IEnumerable<SearchDisabledDataExfiltrationOption> disabledDataExfiltrationOptions = null, SearchEncryptionWithCmk encryptionWithCmk = null, bool? isLocalAuthDisabled = null, SearchAadAuthDataPlaneAuthOptions authOptions = null, SearchSemanticSearch? semanticSearch = null, IEnumerable<SearchPrivateEndpointConnectionData> privateEndpointConnections = null, IEnumerable<SharedSearchServicePrivateLinkResourceData> sharedPrivateLinkResources = null, ETag? eTag = null, bool? upgradeAvailable = null, DateTimeOffset? serviceUpgradeOn = null)
        {
            tags ??= new Dictionary<string, string>();
            disabledDataExfiltrationOptions ??= new List<SearchDisabledDataExfiltrationOption>();
            privateEndpointConnections ??= new List<SearchPrivateEndpointConnectionData>();
            sharedPrivateLinkResources ??= new List<SharedSearchServicePrivateLinkResourceData>();

            return new SearchServicePatch(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                searchSkuName != null ? new SearchSku(searchSkuName, serializedAdditionalRawData: null) : null,
                identity,
                replicaCount,
                partitionCount,
                endpoint,
                hostingMode,
                computeType,
                publicInternetAccess,
                status,
                statusDetails,
                provisioningState,
                networkRuleSet,
                disabledDataExfiltrationOptions?.ToList(),
                encryptionWithCmk,
                isLocalAuthDisabled,
                authOptions,
                semanticSearch,
                privateEndpointConnections?.ToList(),
                sharedPrivateLinkResources?.ToList(),
                eTag,
                upgradeAvailable,
                serviceUpgradeOn,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SearchPrivateLinkResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Describes the properties of a supported private link resource for the Azure AI Search service. </param>
        /// <returns> A new <see cref="Models.SearchPrivateLinkResource"/> instance for mocking. </returns>
        public static SearchPrivateLinkResource SearchPrivateLinkResource(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, SearchPrivateLinkResourceProperties properties = null)
        {
            return new SearchPrivateLinkResource(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SearchPrivateLinkResourceProperties"/>. </summary>
        /// <param name="groupId"> The group ID of the private link resource. </param>
        /// <param name="requiredMembers"> The list of required members of the private link resource. </param>
        /// <param name="requiredZoneNames"> The list of required DNS zone names of the private link resource. </param>
        /// <param name="shareablePrivateLinkResourceTypes"> The list of resources that are onboarded to private link service, that are supported by Azure AI Search. </param>
        /// <returns> A new <see cref="Models.SearchPrivateLinkResourceProperties"/> instance for mocking. </returns>
        public static SearchPrivateLinkResourceProperties SearchPrivateLinkResourceProperties(string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null, IEnumerable<ShareableSearchServicePrivateLinkResourceType> shareablePrivateLinkResourceTypes = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();
            shareablePrivateLinkResourceTypes ??= new List<ShareableSearchServicePrivateLinkResourceType>();

            return new SearchPrivateLinkResourceProperties(groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), shareablePrivateLinkResourceTypes?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ShareableSearchServicePrivateLinkResourceType"/>. </summary>
        /// <param name="name"> The name of the resource type that has been onboarded to private link service, supported by Azure AI Search. </param>
        /// <param name="properties"> Describes the properties of a resource type that has been onboarded to private link service, supported by Azure AI Search. </param>
        /// <returns> A new <see cref="Models.ShareableSearchServicePrivateLinkResourceType"/> instance for mocking. </returns>
        public static ShareableSearchServicePrivateLinkResourceType ShareableSearchServicePrivateLinkResourceType(string name = null, ShareableSearchServicePrivateLinkResourceProperties properties = null)
        {
            return new ShareableSearchServicePrivateLinkResourceType(name, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ShareableSearchServicePrivateLinkResourceProperties"/>. </summary>
        /// <param name="shareablePrivateLinkResourcePropertiesType"> The resource provider type for the resource that has been onboarded to private link service, supported by Azure AI Search. </param>
        /// <param name="groupId"> The resource provider group id for the resource that has been onboarded to private link service, supported by Azure AI Search. </param>
        /// <param name="description"> The description of the resource type that has been onboarded to private link service, supported by Azure AI Search. </param>
        /// <returns> A new <see cref="Models.ShareableSearchServicePrivateLinkResourceProperties"/> instance for mocking. </returns>
        public static ShareableSearchServicePrivateLinkResourceProperties ShareableSearchServicePrivateLinkResourceProperties(string shareablePrivateLinkResourcePropertiesType = null, string groupId = null, string description = null)
        {
            return new ShareableSearchServicePrivateLinkResourceProperties(shareablePrivateLinkResourcePropertiesType, groupId, description, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SearchServiceNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The search service name to validate. Search service names must only contain lowercase letters, digits or dashes, cannot use dash as the first two or last one characters, cannot contain consecutive dashes, and must be between 2 and 60 characters in length. </param>
        /// <param name="resourceType"> The type of the resource whose name is to be validated. This value must always be 'searchServices'. </param>
        /// <returns> A new <see cref="Models.SearchServiceNameAvailabilityContent"/> instance for mocking. </returns>
        public static SearchServiceNameAvailabilityContent SearchServiceNameAvailabilityContent(string name = null, SearchServiceResourceType resourceType = default)
        {
            return new SearchServiceNameAvailabilityContent(name, resourceType, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SearchServiceNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> A value indicating whether the name is available. </param>
        /// <param name="reason"> The reason why the name is not available. 'Invalid' indicates the name provided does not match the naming requirements (incorrect length, unsupported characters, etc.). 'AlreadyExists' indicates that the name is already in use and is therefore unavailable. </param>
        /// <param name="message"> A message that explains why the name is invalid and provides resource naming requirements. Available only if 'Invalid' is returned in the 'reason' property. </param>
        /// <returns> A new <see cref="Models.SearchServiceNameAvailabilityResult"/> instance for mocking. </returns>
        public static SearchServiceNameAvailabilityResult SearchServiceNameAvailabilityResult(bool? isNameAvailable = null, SearchServiceNameUnavailableReason? reason = null, string message = null)
        {
            return new SearchServiceNameAvailabilityResult(isNameAvailable, reason, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QuotaUsageResult"/>. </summary>
        /// <param name="id"> The resource ID of the quota usage SKU endpoint for Microsoft.Search provider. </param>
        /// <param name="unit"> The unit of measurement for the search SKU. </param>
        /// <param name="currentValue"> The currently used up value for the particular search SKU. </param>
        /// <param name="limit"> The quota limit for the particular search SKU. </param>
        /// <param name="name"> The name of the SKU supported by Azure AI Search. </param>
        /// <returns> A new <see cref="Models.QuotaUsageResult"/> instance for mocking. </returns>
        public static QuotaUsageResult QuotaUsageResult(ResourceIdentifier id = null, string unit = null, int? currentValue = null, int? limit = null, QuotaUsageResultName name = null)
        {
            return new QuotaUsageResult(
                id,
                unit,
                currentValue,
                limit,
                name,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QuotaUsageResultName"/>. </summary>
        /// <param name="value"> The SKU name supported by Azure AI Search. </param>
        /// <param name="localizedValue"> The localized string value for the SKU name. </param>
        /// <returns> A new <see cref="Models.QuotaUsageResultName"/> instance for mocking. </returns>
        public static QuotaUsageResultName QuotaUsageResultName(string value = null, string localizedValue = null)
        {
            return new QuotaUsageResultName(value, localizedValue, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Search.NetworkSecurityPerimeterConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"></param>
        /// <param name="networkSecurityPerimeter"> The perimeter for a network security perimeter configuration. </param>
        /// <param name="resourceAssociation"> The resource association for the network security perimeter. </param>
        /// <param name="profile"> The profile for a network security perimeter configuration. </param>
        /// <param name="provisioningIssues"></param>
        /// <returns> A new <see cref="Search.NetworkSecurityPerimeterConfigurationData"/> instance for mocking. </returns>
        public static NetworkSecurityPerimeterConfigurationData NetworkSecurityPerimeterConfigurationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string provisioningState = null, NspConfigPerimeter networkSecurityPerimeter = null, NspConfigAssociation resourceAssociation = null, NspConfigProfile profile = null, IEnumerable<NspProvisioningIssue> provisioningIssues = null)
        {
            provisioningIssues ??= new List<NspProvisioningIssue>();

            return new NetworkSecurityPerimeterConfigurationData(
                id,
                name,
                resourceType,
                systemData,
                provisioningState,
                networkSecurityPerimeter,
                resourceAssociation,
                profile,
                provisioningIssues?.ToList(),
                serializedAdditionalRawData: null);
        }
    }
}
