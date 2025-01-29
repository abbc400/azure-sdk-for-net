// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration
{
    internal class AppConfigurationSnapshotOperationSource : IOperationSource<AppConfigurationSnapshotResource>
    {
        private readonly ArmClient _client;

        internal AppConfigurationSnapshotOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppConfigurationSnapshotResource IOperationSource<AppConfigurationSnapshotResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppConfigurationSnapshotData.DeserializeAppConfigurationSnapshotData(document.RootElement);
            return new AppConfigurationSnapshotResource(_client, data);
        }

        async ValueTask<AppConfigurationSnapshotResource> IOperationSource<AppConfigurationSnapshotResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppConfigurationSnapshotData.DeserializeAppConfigurationSnapshotData(document.RootElement);
            return new AppConfigurationSnapshotResource(_client, data);
        }
    }
}
