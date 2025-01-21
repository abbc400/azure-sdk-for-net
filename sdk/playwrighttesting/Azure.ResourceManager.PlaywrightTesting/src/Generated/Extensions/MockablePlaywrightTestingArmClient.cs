// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.PlaywrightTesting.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockablePlaywrightTestingArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockablePlaywrightTestingArmClient"/> class for mocking. </summary>
        protected MockablePlaywrightTestingArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockablePlaywrightTestingArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockablePlaywrightTestingArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockablePlaywrightTestingArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="PlaywrightTestingAccountResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PlaywrightTestingAccountResource.CreateResourceIdentifier" /> to create a <see cref="PlaywrightTestingAccountResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PlaywrightTestingAccountResource"/> object. </returns>
        public virtual PlaywrightTestingAccountResource GetPlaywrightTestingAccountResource(ResourceIdentifier id)
        {
            PlaywrightTestingAccountResource.ValidateResourceId(id);
            return new PlaywrightTestingAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PlaywrightTestingQuotaResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PlaywrightTestingQuotaResource.CreateResourceIdentifier" /> to create a <see cref="PlaywrightTestingQuotaResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PlaywrightTestingQuotaResource"/> object. </returns>
        public virtual PlaywrightTestingQuotaResource GetPlaywrightTestingQuotaResource(ResourceIdentifier id)
        {
            PlaywrightTestingQuotaResource.ValidateResourceId(id);
            return new PlaywrightTestingQuotaResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PlaywrightTestingAccountQuotaResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PlaywrightTestingAccountQuotaResource.CreateResourceIdentifier" /> to create a <see cref="PlaywrightTestingAccountQuotaResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PlaywrightTestingAccountQuotaResource"/> object. </returns>
        public virtual PlaywrightTestingAccountQuotaResource GetPlaywrightTestingAccountQuotaResource(ResourceIdentifier id)
        {
            PlaywrightTestingAccountQuotaResource.ValidateResourceId(id);
            return new PlaywrightTestingAccountQuotaResource(Client, id);
        }
    }
}
