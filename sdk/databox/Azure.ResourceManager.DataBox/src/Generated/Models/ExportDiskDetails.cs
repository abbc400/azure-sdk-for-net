// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Export disk details. </summary>
    public partial class ExportDiskDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExportDiskDetails"/>. </summary>
        internal ExportDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExportDiskDetails"/>. </summary>
        /// <param name="manifestFile"> The relative path of the manifest file on the disk. </param>
        /// <param name="manifestHash"> The Base16-encoded MD5 hash of the manifest file on the disk. </param>
        /// <param name="backupManifestCloudPath"> Path to backed up manifest, only returned if enableManifestBackup is true. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExportDiskDetails(string manifestFile, string manifestHash, string backupManifestCloudPath, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ManifestFile = manifestFile;
            ManifestHash = manifestHash;
            BackupManifestCloudPath = backupManifestCloudPath;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The relative path of the manifest file on the disk. </summary>
        public string ManifestFile { get; }
        /// <summary> The Base16-encoded MD5 hash of the manifest file on the disk. </summary>
        public string ManifestHash { get; }
        /// <summary> Path to backed up manifest, only returned if enableManifestBackup is true. </summary>
        public string BackupManifestCloudPath { get; }
    }
}
