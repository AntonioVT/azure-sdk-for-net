// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the GitHub provider. </summary>
    public partial class GitHub
    {
        /// <summary> Initializes a new instance of GitHub. </summary>
        public GitHub()
        {
        }

        /// <summary> Initializes a new instance of GitHub. </summary>
        /// <param name="enabled"> &lt;code&gt;false&lt;/code&gt; if the GitHub provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the app registration for the GitHub provider. </param>
        /// <param name="login"> The configuration settings of the login flow. </param>
        internal GitHub(bool? enabled, ClientRegistration registration, LoginScopes login)
        {
            Enabled = enabled;
            Registration = registration;
            Login = login;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the GitHub provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The configuration settings of the app registration for the GitHub provider. </summary>
        public ClientRegistration Registration { get; set; }
        /// <summary> The configuration settings of the login flow. </summary>
        public LoginScopes Login { get; set; }
    }
}
