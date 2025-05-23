// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Extensions;

    /// <summary>Query Parameters for ItemDetailsReport</summary>
    public partial class ItemDetailsQueryFilter
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IItemDetailsQueryFilter.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IItemDetailsQueryFilter.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IItemDetailsQueryFilter FromJson(Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonObject json ? new ItemDetailsQueryFilter(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonObject into a new instance of <see cref="ItemDetailsQueryFilter" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ItemDetailsQueryFilter(Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __queryFilter = new Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.QueryFilter(json);
            {_categoryType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonString>("categoryType"), out var __jsonCategoryType) ? (string)__jsonCategoryType : (string)_categoryType;}
            {_orderBy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonString>("orderBy"), out var __jsonOrderBy) ? (string)__jsonOrderBy : (string)_orderBy;}
            {_sortDirection = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonString>("sortDirection"), out var __jsonSortDirection) ? (string)__jsonSortDirection : (string)_sortDirection;}
            {_pageSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNumber>("pageSize"), out var __jsonPageSize) ? (int)__jsonPageSize : _pageSize;}
            {_skipToken = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonString>("skipToken"), out var __jsonSkipToken) ? (string)__jsonSkipToken : (string)_skipToken;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ItemDetailsQueryFilter" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ItemDetailsQueryFilter" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __queryFilter?.ToJson(container, serializationMode);
            AddIf( null != (((object)this._categoryType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonString(this._categoryType.ToString()) : null, "categoryType" ,container.Add );
            AddIf( null != (((object)this._orderBy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonString(this._orderBy.ToString()) : null, "orderBy" ,container.Add );
            AddIf( null != (((object)this._sortDirection)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonString(this._sortDirection.ToString()) : null, "sortDirection" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNumber(this._pageSize), "pageSize" ,container.Add );
            AddIf( null != (((object)this._skipToken)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonString(this._skipToken.ToString()) : null, "skipToken" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}