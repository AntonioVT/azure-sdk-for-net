// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Suggested utterances where the detector can be applicable. </summary>
    public partial class QueryUtterancesResults
    {
        /// <summary> Initializes a new instance of QueryUtterancesResults. </summary>
        public QueryUtterancesResults()
        {
            Results = new ChangeTrackingList<QueryUtterancesResult>();
        }

        /// <summary> Initializes a new instance of QueryUtterancesResults. </summary>
        /// <param name="query"> Search Query. </param>
        /// <param name="results"> Array of utterance results for search query. </param>
        internal QueryUtterancesResults(string query, IList<QueryUtterancesResult> results)
        {
            Query = query;
            Results = results;
        }

        /// <summary> Search Query. </summary>
        public string Query { get; set; }
        /// <summary> Array of utterance results for search query. </summary>
        public IList<QueryUtterancesResult> Results { get; }
    }
}
