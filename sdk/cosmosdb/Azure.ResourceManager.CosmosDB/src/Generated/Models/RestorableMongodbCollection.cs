// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> An Azure Cosmos DB MongoDB collection event. </summary>
    public partial class RestorableMongodbCollection : Resource
    {
        /// <summary> Initializes a new instance of RestorableMongodbCollection. </summary>
        internal RestorableMongodbCollection()
        {
        }

        /// <summary> Initializes a new instance of RestorableMongodbCollection. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="resource"> The resource of an Azure Cosmos DB MongoDB collection event. </param>
        internal RestorableMongodbCollection(ResourceIdentifier id, string name, ResourceType type, RestorableMongodbCollectionPropertiesResource resource) : base(id, name, type)
        {
            Resource = resource;
        }

        /// <summary> The resource of an Azure Cosmos DB MongoDB collection event. </summary>
        public RestorableMongodbCollectionPropertiesResource Resource { get; }
    }
}
