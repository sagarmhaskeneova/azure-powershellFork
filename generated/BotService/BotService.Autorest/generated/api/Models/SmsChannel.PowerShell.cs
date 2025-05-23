// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.PowerShell;

    /// <summary>Sms channel definition</summary>
    [System.ComponentModel.TypeConverter(typeof(SmsChannelTypeConverter))]
    public partial class SmsChannel
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.SmsChannel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannel DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SmsChannel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.SmsChannel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannel DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SmsChannel(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SmsChannel" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SmsChannel" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannel FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.SmsChannel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SmsChannel(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.SmsChannelPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Phone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).Phone = (string) content.GetValueForProperty("Phone",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).Phone, global::System.Convert.ToString);
            }
            if (content.Contains("AccountSid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).AccountSid = (string) content.GetValueForProperty("AccountSid",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).AccountSid, global::System.Convert.ToString);
            }
            if (content.Contains("AuthToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).AuthToken = (string) content.GetValueForProperty("AuthToken",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).AuthToken, global::System.Convert.ToString);
            }
            if (content.Contains("IsValidated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).IsValidated = (bool?) content.GetValueForProperty("IsValidated",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).IsValidated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).IsEnabled = (bool?) content.GetValueForProperty("IsEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).IsEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.SmsChannel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SmsChannel(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.SmsChannelPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Phone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).Phone = (string) content.GetValueForProperty("Phone",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).Phone, global::System.Convert.ToString);
            }
            if (content.Contains("AccountSid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).AccountSid = (string) content.GetValueForProperty("AccountSid",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).AccountSid, global::System.Convert.ToString);
            }
            if (content.Contains("AuthToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).AuthToken = (string) content.GetValueForProperty("AuthToken",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).AuthToken, global::System.Convert.ToString);
            }
            if (content.Contains("IsValidated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).IsValidated = (bool?) content.GetValueForProperty("IsValidated",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).IsValidated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).IsEnabled = (bool?) content.GetValueForProperty("IsEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISmsChannelInternal)this).IsEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Sms channel definition
    [System.ComponentModel.TypeConverter(typeof(SmsChannelTypeConverter))]
    public partial interface ISmsChannel

    {

    }
}