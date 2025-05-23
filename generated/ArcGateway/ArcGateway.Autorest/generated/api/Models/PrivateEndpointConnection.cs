// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Extensions;

    /// <summary>A private endpoint connection</summary>
    public partial class PrivateEndpointConnection :
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnection,
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IProxyResourceAutoGenerated"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IProxyResourceAutoGenerated __proxyResourceAutoGenerated = new Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.ProxyResourceAutoGenerated();

        /// <summary>List of group IDs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).GroupId; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).Id; }

        /// <summary>Internal Acessors for GroupId</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionInternal.GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).GroupId = value; }

        /// <summary>Internal Acessors for PrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointProperty Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionInternal.PrivateEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpoint = value; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateLinkServiceConnectionStateProperty Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionInternal.PrivateLinkServiceConnectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionState = value; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionStateActionsRequired</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionInternal.PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateActionsRequired = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionProperties Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.PrivateEndpointConnectionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).Name; }

        /// <summary>Resource id of the private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inlined)]
        public string PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpointId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpointId = value ?? null; }

        /// <summary>The actions required for private link service connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateActionsRequired; }

        /// <summary>The private link service connection description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateDescription = value ?? null; }

        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateStatus = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionProperties _property;

        /// <summary>Resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.PrivateEndpointConnectionProperties()); set => this._property = value; }

        /// <summary>State of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IResourceInternal)__proxyResourceAutoGenerated).Type; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnection" /> instance.</summary>
        public PrivateEndpointConnection()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResourceAutoGenerated), __proxyResourceAutoGenerated);
            await eventListener.AssertObjectIsValid(nameof(__proxyResourceAutoGenerated), __proxyResourceAutoGenerated);
        }
    }
    /// A private endpoint connection
    public partial interface IPrivateEndpointConnection :
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IProxyResourceAutoGenerated
    {
        /// <summary>List of group IDs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of group IDs.",
        SerializedName = @"groupIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> GroupId { get;  }
        /// <summary>Resource id of the private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource id of the private endpoint.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointId { get; set; }
        /// <summary>The actions required for private link service connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The actions required for private link service connection.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateActionsRequired { get;  }
        /// <summary>The private link service connection description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The private link service connection description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The private link service connection status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>State of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"State of the private endpoint connection.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }

    }
    /// A private endpoint connection
    internal partial interface IPrivateEndpointConnectionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IProxyResourceAutoGeneratedInternal
    {
        /// <summary>List of group IDs.</summary>
        System.Collections.Generic.List<string> GroupId { get; set; }
        /// <summary>Private endpoint which the connection belongs to.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointProperty PrivateEndpoint { get; set; }
        /// <summary>Resource id of the private endpoint.</summary>
        string PrivateEndpointId { get; set; }
        /// <summary>Connection state of the private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateLinkServiceConnectionStateProperty PrivateLinkServiceConnectionState { get; set; }
        /// <summary>The actions required for private link service connection.</summary>
        string PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>The private link service connection description.</summary>
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>The private link service connection status.</summary>
        string PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>Resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IPrivateEndpointConnectionProperties Property { get; set; }
        /// <summary>State of the private endpoint connection.</summary>
        string ProvisioningState { get; set; }

    }
}