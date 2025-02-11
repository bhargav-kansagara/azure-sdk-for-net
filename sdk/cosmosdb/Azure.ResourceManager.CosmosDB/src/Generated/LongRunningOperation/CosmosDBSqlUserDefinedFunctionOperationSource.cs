// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CosmosDB
{
    internal class CosmosDBSqlUserDefinedFunctionOperationSource : IOperationSource<CosmosDBSqlUserDefinedFunctionResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBSqlUserDefinedFunctionOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBSqlUserDefinedFunctionResource IOperationSource<CosmosDBSqlUserDefinedFunctionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CosmosDBSqlUserDefinedFunctionData.DeserializeCosmosDBSqlUserDefinedFunctionData(document.RootElement);
            return new CosmosDBSqlUserDefinedFunctionResource(_client, data);
        }

        async ValueTask<CosmosDBSqlUserDefinedFunctionResource> IOperationSource<CosmosDBSqlUserDefinedFunctionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CosmosDBSqlUserDefinedFunctionData.DeserializeCosmosDBSqlUserDefinedFunctionData(document.RootElement);
            return new CosmosDBSqlUserDefinedFunctionResource(_client, data);
        }
    }
}
