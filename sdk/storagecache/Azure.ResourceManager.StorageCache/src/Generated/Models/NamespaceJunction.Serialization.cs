// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class NamespaceJunction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NamespacePath))
            {
                writer.WritePropertyName("namespacePath");
                writer.WriteStringValue(NamespacePath);
            }
            if (Optional.IsDefined(TargetPath))
            {
                writer.WritePropertyName("targetPath");
                writer.WriteStringValue(TargetPath);
            }
            if (Optional.IsDefined(NfsExport))
            {
                writer.WritePropertyName("nfsExport");
                writer.WriteStringValue(NfsExport);
            }
            if (Optional.IsDefined(NfsAccessPolicy))
            {
                writer.WritePropertyName("nfsAccessPolicy");
                writer.WriteStringValue(NfsAccessPolicy);
            }
            writer.WriteEndObject();
        }

        internal static NamespaceJunction DeserializeNamespaceJunction(JsonElement element)
        {
            Optional<string> namespacePath = default;
            Optional<string> targetPath = default;
            Optional<string> nfsExport = default;
            Optional<string> nfsAccessPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("namespacePath"))
                {
                    namespacePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetPath"))
                {
                    targetPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nfsExport"))
                {
                    nfsExport = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nfsAccessPolicy"))
                {
                    nfsAccessPolicy = property.Value.GetString();
                    continue;
                }
            }
            return new NamespaceJunction(namespacePath.Value, targetPath.Value, nfsExport.Value, nfsAccessPolicy.Value);
        }
    }
}
