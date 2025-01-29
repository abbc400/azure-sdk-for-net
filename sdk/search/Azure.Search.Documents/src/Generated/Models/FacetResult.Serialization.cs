// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Search.Documents.Models
{
    public partial class FacetResult
    {
        internal static FacetResult DeserializeFacetResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? count = default;
            IReadOnlyDictionary<string, IList<FacetResult>> searchFacets = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("@search.facets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<FacetResult>> dictionary = new Dictionary<string, IList<FacetResult>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<FacetResult> array = new List<FacetResult>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeFacetResult(item));
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    searchFacets = dictionary;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new FacetResult(count, searchFacets ?? new ChangeTrackingDictionary<string, IList<FacetResult>>(), additionalProperties);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static FacetResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFacetResult(document.RootElement);
        }
    }
}
