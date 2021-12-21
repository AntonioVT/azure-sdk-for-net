// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the SourceControl data model. </summary>
    public partial class SourceControlData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of SourceControlData. </summary>
        public SourceControlData()
        {
        }

        /// <summary> Initializes a new instance of SourceControlData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="token"> OAuth access token. </param>
        /// <param name="tokenSecret"> OAuth access token secret. </param>
        /// <param name="refreshToken"> OAuth refresh token. </param>
        /// <param name="expirationTime"> OAuth token expiration. </param>
        internal SourceControlData(ResourceIdentifier id, string name, ResourceType type, string kind, string token, string tokenSecret, string refreshToken, DateTimeOffset? expirationTime) : base(id, name, type, kind)
        {
            Token = token;
            TokenSecret = tokenSecret;
            RefreshToken = refreshToken;
            ExpirationTime = expirationTime;
        }

        /// <summary> OAuth access token. </summary>
        public string Token { get; set; }
        /// <summary> OAuth access token secret. </summary>
        public string TokenSecret { get; set; }
        /// <summary> OAuth refresh token. </summary>
        public string RefreshToken { get; set; }
        /// <summary> OAuth token expiration. </summary>
        public DateTimeOffset? ExpirationTime { get; set; }
    }
}
