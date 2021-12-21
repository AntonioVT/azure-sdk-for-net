// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description of an operation available for Microsoft.Web resource provider. </summary>
    public partial class CsmOperationDescription
    {
        /// <summary> Initializes a new instance of CsmOperationDescription. </summary>
        internal CsmOperationDescription()
        {
        }

        /// <summary> Initializes a new instance of CsmOperationDescription. </summary>
        /// <param name="name"></param>
        /// <param name="isDataAction"></param>
        /// <param name="display"> Meta data about operation used for display in portal. </param>
        /// <param name="origin"></param>
        /// <param name="properties"> Properties available for a Microsoft.Web resource provider operation. </param>
        internal CsmOperationDescription(string name, bool? isDataAction, CsmOperationDisplay display, string origin, CsmOperationDescriptionProperties properties)
        {
            Name = name;
            IsDataAction = isDataAction;
            Display = display;
            Origin = origin;
            Properties = properties;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the is data action. </summary>
        public bool? IsDataAction { get; }
        /// <summary> Meta data about operation used for display in portal. </summary>
        public CsmOperationDisplay Display { get; }
        /// <summary> Gets the origin. </summary>
        public string Origin { get; }
        /// <summary> Properties available for a Microsoft.Web resource provider operation. </summary>
        public CsmOperationDescriptionProperties Properties { get; }
    }
}
