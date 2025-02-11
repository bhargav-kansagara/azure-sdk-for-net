// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationContentHash : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("algorithm");
            writer.WriteStringValue(Algorithm);
            writer.WritePropertyName("value");
            writer.WriteStringValue(Value);
            writer.WriteEndObject();
        }

        internal static AutomationContentHash DeserializeAutomationContentHash(JsonElement element)
        {
            string algorithm = default;
            string value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("algorithm"))
                {
                    algorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new AutomationContentHash(algorithm, value);
        }
    }
}
