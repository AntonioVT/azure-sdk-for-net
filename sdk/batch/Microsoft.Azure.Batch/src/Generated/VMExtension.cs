// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration for virtual machine extensions.
    /// </summary>
    public partial class VMExtension : ITransportObjectProvider<Models.VMExtension>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<bool?> AutoUpgradeMinorVersionProperty;
            public readonly PropertyAccessor<string> NameProperty;
            public readonly PropertyAccessor<object> ProtectedSettingsProperty;
            public readonly PropertyAccessor<IList<string>> ProvisionAfterExtensionsProperty;
            public readonly PropertyAccessor<string> PublisherProperty;
            public readonly PropertyAccessor<object> SettingsProperty;
            public readonly PropertyAccessor<string> TypeProperty;
            public readonly PropertyAccessor<string> TypeHandlerVersionProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.AutoUpgradeMinorVersionProperty = this.CreatePropertyAccessor<bool?>(nameof(AutoUpgradeMinorVersion), BindingAccess.Read | BindingAccess.Write);
                this.NameProperty = this.CreatePropertyAccessor<string>(nameof(Name), BindingAccess.Read | BindingAccess.Write);
                this.ProtectedSettingsProperty = this.CreatePropertyAccessor<object>(nameof(ProtectedSettings), BindingAccess.Read | BindingAccess.Write);
                this.ProvisionAfterExtensionsProperty = this.CreatePropertyAccessor<IList<string>>(nameof(ProvisionAfterExtensions), BindingAccess.Read | BindingAccess.Write);
                this.PublisherProperty = this.CreatePropertyAccessor<string>(nameof(Publisher), BindingAccess.Read | BindingAccess.Write);
                this.SettingsProperty = this.CreatePropertyAccessor<object>(nameof(Settings), BindingAccess.Read | BindingAccess.Write);
                this.TypeProperty = this.CreatePropertyAccessor<string>(nameof(Type), BindingAccess.Read | BindingAccess.Write);
                this.TypeHandlerVersionProperty = this.CreatePropertyAccessor<string>(nameof(TypeHandlerVersion), BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.VMExtension protocolObject) : base(BindingState.Bound)
            {
                this.AutoUpgradeMinorVersionProperty = this.CreatePropertyAccessor(
                    protocolObject.AutoUpgradeMinorVersion,
                    nameof(AutoUpgradeMinorVersion),
                    BindingAccess.Read | BindingAccess.Write);
                this.NameProperty = this.CreatePropertyAccessor(
                    protocolObject.Name,
                    nameof(Name),
                    BindingAccess.Read | BindingAccess.Write);
                this.ProtectedSettingsProperty = this.CreatePropertyAccessor(
                    protocolObject.ProtectedSettings,
                    nameof(ProtectedSettings),
                    BindingAccess.Read | BindingAccess.Write);
                this.ProvisionAfterExtensionsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CollectionToThreadSafeCollection(protocolObject.ProvisionAfterExtensions, o => o),
                    nameof(ProvisionAfterExtensions),
                    BindingAccess.Read | BindingAccess.Write);
                this.PublisherProperty = this.CreatePropertyAccessor(
                    protocolObject.Publisher,
                    nameof(Publisher),
                    BindingAccess.Read | BindingAccess.Write);
                this.SettingsProperty = this.CreatePropertyAccessor(
                    protocolObject.Settings,
                    nameof(Settings),
                    BindingAccess.Read | BindingAccess.Write);
                this.TypeProperty = this.CreatePropertyAccessor(
                    protocolObject.Type,
                    nameof(Type),
                    BindingAccess.Read | BindingAccess.Write);
                this.TypeHandlerVersionProperty = this.CreatePropertyAccessor(
                    protocolObject.TypeHandlerVersion,
                    nameof(TypeHandlerVersion),
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VMExtension"/> class.
        /// </summary>
        /// <param name='name'>The name of the virtual machine extension.</param>
        /// <param name='publisher'>The name of the extension handler publisher.</param>
        /// <param name='type'>The type of the extension.</param>
        public VMExtension(
            string name,
            string publisher,
            string type)
        {
            this.propertyContainer = new PropertyContainer();
            this.Name = name;
            this.Publisher = publisher;
            this.Type = type;
        }

        /// <summary>
        /// Default constructor to support mocking the <see cref="VMExtension"/> class.
        /// </summary>
        protected VMExtension()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal VMExtension(Models.VMExtension protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region VMExtension

        /// <summary>
        /// Gets or sets indicates whether the extension should use a newer minor version if one is available at deployment 
        /// time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this 
        /// property set to true.
        /// </summary>
        public bool? AutoUpgradeMinorVersion
        {
            get { return this.propertyContainer.AutoUpgradeMinorVersionProperty.Value; }
            set { this.propertyContainer.AutoUpgradeMinorVersionProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the name of the virtual machine extension.
        /// </summary>
        public string Name
        {
            get { return this.propertyContainer.NameProperty.Value; }
            set { this.propertyContainer.NameProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected 
        /// settings at all.
        /// </summary>
        public object ProtectedSettings
        {
            get { return this.propertyContainer.ProtectedSettingsProperty.Value; }
            set { this.propertyContainer.ProtectedSettingsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the collection of extension names.
        /// </summary>
        /// <remarks>
        /// Collection of extension names after which this extension needs to be provisioned.
        /// </remarks>
        public IList<string> ProvisionAfterExtensions
        {
            get { return this.propertyContainer.ProvisionAfterExtensionsProperty.Value; }
            set
            {
                this.propertyContainer.ProvisionAfterExtensionsProperty.Value = ConcurrentChangeTrackedList<string>.TransformEnumerableToConcurrentList(value);
            }
        }

        /// <summary>
        /// Gets or sets the name of the extension handler publisher.
        /// </summary>
        public string Publisher
        {
            get { return this.propertyContainer.PublisherProperty.Value; }
            set { this.propertyContainer.PublisherProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets jSON formatted public settings for the extension.
        /// </summary>
        public object Settings
        {
            get { return this.propertyContainer.SettingsProperty.Value; }
            set { this.propertyContainer.SettingsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the type of the extension.
        /// </summary>
        public string Type
        {
            get { return this.propertyContainer.TypeProperty.Value; }
            set { this.propertyContainer.TypeProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the version of script handler.
        /// </summary>
        public string TypeHandlerVersion
        {
            get { return this.propertyContainer.TypeHandlerVersionProperty.Value; }
            set { this.propertyContainer.TypeHandlerVersionProperty.Value = value; }
        }

        #endregion // VMExtension

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.VMExtension ITransportObjectProvider<Models.VMExtension>.GetTransportObject()
        {
            Models.VMExtension result = new Models.VMExtension()
            {
                AutoUpgradeMinorVersion = this.AutoUpgradeMinorVersion,
                Name = this.Name,
                ProtectedSettings = this.ProtectedSettings,
                ProvisionAfterExtensions = this.ProvisionAfterExtensions,
                Publisher = this.Publisher,
                Settings = this.Settings,
                Type = this.Type,
                TypeHandlerVersion = this.TypeHandlerVersion,
            };

            return result;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<VMExtension> ConvertFromProtocolCollection(IEnumerable<Models.VMExtension> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<VMExtension> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new VMExtension(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<VMExtension> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.VMExtension> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<VMExtension> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new VMExtension(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<VMExtension> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.VMExtension> protoCollection)
        {
            IReadOnlyList<VMExtension> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new VMExtension(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}