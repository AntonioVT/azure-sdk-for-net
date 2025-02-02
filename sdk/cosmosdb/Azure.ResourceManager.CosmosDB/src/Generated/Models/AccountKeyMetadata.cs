// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The metadata related to an access key for a given database account. </summary>
    internal partial class AccountKeyMetadata
    {
        /// <summary> Initializes a new instance of AccountKeyMetadata. </summary>
        internal AccountKeyMetadata()
        {
        }

        /// <summary> Initializes a new instance of AccountKeyMetadata. </summary>
        /// <param name="generatedOn"> Generation time in UTC of the key in ISO-8601 format. If the value is missing from the object, it means that the last key regeneration was triggered before 2022-06-18. </param>
        internal AccountKeyMetadata(DateTimeOffset? generatedOn)
        {
            GeneratedOn = generatedOn;
        }

        /// <summary> Generation time in UTC of the key in ISO-8601 format. If the value is missing from the object, it means that the last key regeneration was triggered before 2022-06-18. </summary>
        public DateTimeOffset? GeneratedOn { get; }
    }
}
