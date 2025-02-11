// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    public partial class OperationalInsightsClusterData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(IsDoubleEncryptionEnabled))
            {
                writer.WritePropertyName("isDoubleEncryptionEnabled");
                writer.WriteBooleanValue(IsDoubleEncryptionEnabled.Value);
            }
            if (Optional.IsDefined(IsAvailabilityZonesEnabled))
            {
                writer.WritePropertyName("isAvailabilityZonesEnabled");
                writer.WriteBooleanValue(IsAvailabilityZonesEnabled.Value);
            }
            if (Optional.IsDefined(BillingType))
            {
                writer.WritePropertyName("billingType");
                writer.WriteStringValue(BillingType.Value.ToString());
            }
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties");
                writer.WriteObjectValue(KeyVaultProperties);
            }
            if (Optional.IsCollectionDefined(AssociatedWorkspaces))
            {
                writer.WritePropertyName("associatedWorkspaces");
                writer.WriteStartArray();
                foreach (var item in AssociatedWorkspaces)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CapacityReservationProperties))
            {
                writer.WritePropertyName("capacityReservationProperties");
                writer.WriteObjectValue(CapacityReservationProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static OperationalInsightsClusterData DeserializeOperationalInsightsClusterData(JsonElement element)
        {
            Optional<ManagedServiceIdentity> identity = default;
            Optional<OperationalInsightsClusterSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> clusterId = default;
            Optional<OperationalInsightsClusterEntityStatus> provisioningState = default;
            Optional<bool> isDoubleEncryptionEnabled = default;
            Optional<bool> isAvailabilityZonesEnabled = default;
            Optional<OperationalInsightsBillingType> billingType = default;
            Optional<OperationalInsightsKeyVaultProperties> keyVaultProperties = default;
            Optional<DateTimeOffset> lastModifiedDate = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<IList<OperationalInsightsClusterAssociatedWorkspace>> associatedWorkspaces = default;
            Optional<OperationalInsightsCapacityReservationProperties> capacityReservationProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = OperationalInsightsClusterSku.DeserializeOperationalInsightsClusterSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("clusterId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new OperationalInsightsClusterEntityStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isDoubleEncryptionEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isDoubleEncryptionEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isAvailabilityZonesEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isAvailabilityZonesEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("billingType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingType = new OperationalInsightsBillingType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("keyVaultProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            keyVaultProperties = OperationalInsightsKeyVaultProperties.DeserializeOperationalInsightsKeyVaultProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedDate = property0.Value.GetDateTimeOffset("R");
                            continue;
                        }
                        if (property0.NameEquals("createdDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("R");
                            continue;
                        }
                        if (property0.NameEquals("associatedWorkspaces"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<OperationalInsightsClusterAssociatedWorkspace> array = new List<OperationalInsightsClusterAssociatedWorkspace>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(OperationalInsightsClusterAssociatedWorkspace.DeserializeOperationalInsightsClusterAssociatedWorkspace(item));
                            }
                            associatedWorkspaces = array;
                            continue;
                        }
                        if (property0.NameEquals("capacityReservationProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            capacityReservationProperties = OperationalInsightsCapacityReservationProperties.DeserializeOperationalInsightsCapacityReservationProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new OperationalInsightsClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, sku.Value, Optional.ToNullable(clusterId), Optional.ToNullable(provisioningState), Optional.ToNullable(isDoubleEncryptionEnabled), Optional.ToNullable(isAvailabilityZonesEnabled), Optional.ToNullable(billingType), keyVaultProperties.Value, Optional.ToNullable(lastModifiedDate), Optional.ToNullable(createdDate), Optional.ToList(associatedWorkspaces), capacityReservationProperties.Value);
        }
    }
}
