// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.IotOperations
{
    internal class IotOperationsBrokerListenerOperationSource : IOperationSource<IotOperationsBrokerListenerResource>
    {
        private readonly ArmClient _client;

        internal IotOperationsBrokerListenerOperationSource(ArmClient client)
        {
            _client = client;
        }

        IotOperationsBrokerListenerResource IOperationSource<IotOperationsBrokerListenerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = IotOperationsBrokerListenerData.DeserializeIotOperationsBrokerListenerData(document.RootElement);
            return new IotOperationsBrokerListenerResource(_client, data);
        }

        async ValueTask<IotOperationsBrokerListenerResource> IOperationSource<IotOperationsBrokerListenerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = IotOperationsBrokerListenerData.DeserializeIotOperationsBrokerListenerData(document.RootElement);
            return new IotOperationsBrokerListenerResource(_client, data);
        }
    }
}
