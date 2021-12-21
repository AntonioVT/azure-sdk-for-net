// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB Cassandra table column. </summary>
    public partial class CassandraColumn
    {
        /// <summary> Initializes a new instance of CassandraColumn. </summary>
        public CassandraColumn()
        {
        }

        /// <summary> Initializes a new instance of CassandraColumn. </summary>
        /// <param name="name"> Name of the Cosmos DB Cassandra table column. </param>
        /// <param name="type"> Type of the Cosmos DB Cassandra table column. </param>
        internal CassandraColumn(string name, string type)
        {
            Name = name;
            Type = type;
        }

        /// <summary> Name of the Cosmos DB Cassandra table column. </summary>
        public string Name { get; set; }
        /// <summary> Type of the Cosmos DB Cassandra table column. </summary>
        public string Type { get; set; }
    }
}
