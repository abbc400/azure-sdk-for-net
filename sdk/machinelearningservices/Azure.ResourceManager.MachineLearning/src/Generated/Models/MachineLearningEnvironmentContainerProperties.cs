// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Container for environment specification versions. </summary>
    public partial class MachineLearningEnvironmentContainerProperties : MachineLearningAssetContainer
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningEnvironmentContainerProperties"/>. </summary>
        public MachineLearningEnvironmentContainerProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEnvironmentContainerProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="latestVersion"> The latest version inside this container. </param>
        /// <param name="nextVersion"> The next auto incremental version. </param>
        /// <param name="provisioningState"> Provisioning state for the environment container. </param>
        internal MachineLearningEnvironmentContainerProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isArchived, string latestVersion, string nextVersion, RegistryAssetProvisioningState? provisioningState) : base(description, properties, tags, serializedAdditionalRawData, isArchived, latestVersion, nextVersion)
        {
            ProvisioningState = provisioningState;
        }

        /// <summary> Provisioning state for the environment container. </summary>
        public RegistryAssetProvisioningState? ProvisioningState { get; }
    }
}
