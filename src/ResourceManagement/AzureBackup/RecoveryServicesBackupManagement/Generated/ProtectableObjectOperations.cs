// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    /// <summary>
    /// Definition of Protectable Object operations for the Azure Backup
    /// extension.
    /// </summary>
    internal partial class ProtectableObjectOperations : IServiceOperations<RecoveryServicesBackupManagementClient>, IProtectableObjectOperations
    {
        /// <summary>
        /// Initializes a new instance of the ProtectableObjectOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal ProtectableObjectOperations(RecoveryServicesBackupManagementClient client)
        {
            this._client = client;
        }
        
        private RecoveryServicesBackupManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.RecoveryServicesBackupManagementClient.
        /// </summary>
        public RecoveryServicesBackupManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Get the list of all Protectable Objects.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='queryFilter'>
        /// Optional.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a ProtectableObjectListResponse.
        /// </returns>
        public async Task<ProtectableObjectListResponse> ListAsync(string resourceGroupName, string resourceName, ProtectableObjectListQueryParameters queryFilter, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("resourceName", resourceName);
                tracingParameters.Add("queryFilter", queryFilter);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId.ToString());
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            url = url + "/";
            url = url + "vaults";
            url = url + "/";
            url = url + Uri.EscapeDataString(resourceName);
            url = url + "/backupProtectableItems";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-03-15");
            List<string> odataFilter = new List<string>();
            if (queryFilter != null && queryFilter.ProviderType != null)
            {
                odataFilter.Add("ProviderType eq '" + Uri.EscapeDataString(queryFilter.ProviderType) + "'");
            }
            if (queryFilter != null && queryFilter.Status != null)
            {
                odataFilter.Add("Status eq '" + Uri.EscapeDataString(queryFilter.Status) + "'");
            }
            if (queryFilter != null && queryFilter.WorkloadType != null)
            {
                odataFilter.Add("Type eq '" + Uri.EscapeDataString(queryFilter.WorkloadType) + "'");
            }
            if (odataFilter.Count > 0)
            {
                queryParameters.Add("$filter=" + string.Join(" and ", odataFilter));
            }
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", "en-us");
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ProtectableObjectListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ProtectableObjectListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken itemListValue = responseDoc["itemList"];
                            if (itemListValue != null && itemListValue.Type != JTokenType.Null)
                            {
                                ProtectableObjectResourceList itemListInstance = new ProtectableObjectResourceList();
                                result.ItemList = itemListInstance;
                                
                                JToken valueArray = itemListValue["value"];
                                if (valueArray != null && valueArray.Type != JTokenType.Null)
                                {
                                    foreach (JToken valueValue in ((JArray)valueArray))
                                    {
                                        ProtectableObjectResource protectableObjectResourceInstance = new ProtectableObjectResource();
                                        itemListInstance.ProtectableObjects.Add(protectableObjectResourceInstance);
                                        
                                        JToken propertiesValue = valueValue["properties"];
                                        if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                                        {
                                            string typeName = ((string)propertiesValue["objectType"]);
                                            if (typeName == "IaaSVMProtectableObject")
                                            {
                                                ProtectableObject protectableObjectInstance = new ProtectableObject();
                                                
                                                JToken friendlyNameValue = propertiesValue["friendlyName"];
                                                if (friendlyNameValue != null && friendlyNameValue.Type != JTokenType.Null)
                                                {
                                                    string friendlyNameInstance = ((string)friendlyNameValue);
                                                    protectableObjectInstance.FriendlyName = friendlyNameInstance;
                                                }
                                                
                                                JToken protectionStatusValue = propertiesValue["protectionStatus"];
                                                if (protectionStatusValue != null && protectionStatusValue.Type != JTokenType.Null)
                                                {
                                                    string protectionStatusInstance = ((string)protectionStatusValue);
                                                    protectableObjectInstance.ProtectionStatus = protectionStatusInstance;
                                                }
                                                
                                                JToken resourceGroupValue = propertiesValue["resourceGroup"];
                                                if (resourceGroupValue != null && resourceGroupValue.Type != JTokenType.Null)
                                                {
                                                    string resourceGroupInstance = ((string)resourceGroupValue);
                                                    protectableObjectInstance.ResourceGroup = resourceGroupInstance;
                                                }
                                                
                                                JToken providerTypeValue = propertiesValue["providerType"];
                                                if (providerTypeValue != null && providerTypeValue.Type != JTokenType.Null)
                                                {
                                                    string providerTypeInstance = ((string)providerTypeValue);
                                                    protectableObjectInstance.ProviderType = providerTypeInstance;
                                                }
                                                protectableObjectResourceInstance.Properties = protectableObjectInstance;
                                            }
                                            if (typeName == "IaaSVMProtectableObject")
                                            {
                                                IaaSVMProtectableObject iaaSVMProtectableObjectInstance = new IaaSVMProtectableObject();
                                                
                                                JToken virtualMachineVersionValue = propertiesValue["VirtualMachineVersion"];
                                                if (virtualMachineVersionValue != null && virtualMachineVersionValue.Type != JTokenType.Null)
                                                {
                                                    string virtualMachineVersionInstance = ((string)virtualMachineVersionValue);
                                                    iaaSVMProtectableObjectInstance.VirtualMachineVersion = virtualMachineVersionInstance;
                                                }
                                                
                                                JToken containerUriValue = propertiesValue["containerUri"];
                                                if (containerUriValue != null && containerUriValue.Type != JTokenType.Null)
                                                {
                                                    string containerUriInstance = ((string)containerUriValue);
                                                    iaaSVMProtectableObjectInstance.ContainerUri = containerUriInstance;
                                                }
                                                
                                                JToken protectableObjectUriValue = propertiesValue["protectableObjectUri"];
                                                if (protectableObjectUriValue != null && protectableObjectUriValue.Type != JTokenType.Null)
                                                {
                                                    string protectableObjectUriInstance = ((string)protectableObjectUriValue);
                                                    iaaSVMProtectableObjectInstance.ProtectableObjectUri = protectableObjectUriInstance;
                                                }
                                                
                                                JToken friendlyNameValue2 = propertiesValue["friendlyName"];
                                                if (friendlyNameValue2 != null && friendlyNameValue2.Type != JTokenType.Null)
                                                {
                                                    string friendlyNameInstance2 = ((string)friendlyNameValue2);
                                                    iaaSVMProtectableObjectInstance.FriendlyName = friendlyNameInstance2;
                                                }
                                                
                                                JToken protectionStatusValue2 = propertiesValue["protectionStatus"];
                                                if (protectionStatusValue2 != null && protectionStatusValue2.Type != JTokenType.Null)
                                                {
                                                    string protectionStatusInstance2 = ((string)protectionStatusValue2);
                                                    iaaSVMProtectableObjectInstance.ProtectionStatus = protectionStatusInstance2;
                                                }
                                                
                                                JToken resourceGroupValue2 = propertiesValue["resourceGroup"];
                                                if (resourceGroupValue2 != null && resourceGroupValue2.Type != JTokenType.Null)
                                                {
                                                    string resourceGroupInstance2 = ((string)resourceGroupValue2);
                                                    iaaSVMProtectableObjectInstance.ResourceGroup = resourceGroupInstance2;
                                                }
                                                
                                                JToken providerTypeValue2 = propertiesValue["providerType"];
                                                if (providerTypeValue2 != null && providerTypeValue2.Type != JTokenType.Null)
                                                {
                                                    string providerTypeInstance2 = ((string)providerTypeValue2);
                                                    iaaSVMProtectableObjectInstance.ProviderType = providerTypeInstance2;
                                                }
                                                protectableObjectResourceInstance.Properties = iaaSVMProtectableObjectInstance;
                                            }
                                        }
                                        
                                        JToken idValue = valueValue["id"];
                                        if (idValue != null && idValue.Type != JTokenType.Null)
                                        {
                                            string idInstance = ((string)idValue);
                                            protectableObjectResourceInstance.Id = idInstance;
                                        }
                                        
                                        JToken nameValue = valueValue["name"];
                                        if (nameValue != null && nameValue.Type != JTokenType.Null)
                                        {
                                            string nameInstance = ((string)nameValue);
                                            protectableObjectResourceInstance.Name = nameInstance;
                                        }
                                        
                                        JToken typeValue = valueValue["type"];
                                        if (typeValue != null && typeValue.Type != JTokenType.Null)
                                        {
                                            string typeInstance = ((string)typeValue);
                                            protectableObjectResourceInstance.Type = typeInstance;
                                        }
                                        
                                        JToken locationValue = valueValue["location"];
                                        if (locationValue != null && locationValue.Type != JTokenType.Null)
                                        {
                                            string locationInstance = ((string)locationValue);
                                            protectableObjectResourceInstance.Location = locationInstance;
                                        }
                                        
                                        JToken tagsSequenceElement = ((JToken)valueValue["tags"]);
                                        if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                                        {
                                            foreach (JProperty property in tagsSequenceElement)
                                            {
                                                string tagsKey = ((string)property.Name);
                                                string tagsValue = ((string)property.Value);
                                                protectableObjectResourceInstance.Tags.Add(tagsKey, tagsValue);
                                            }
                                        }
                                        
                                        JToken eTagValue = valueValue["eTag"];
                                        if (eTagValue != null && eTagValue.Type != JTokenType.Null)
                                        {
                                            string eTagInstance = ((string)eTagValue);
                                            protectableObjectResourceInstance.ETag = eTagInstance;
                                        }
                                    }
                                }
                                
                                JToken nextLinkValue = itemListValue["nextLink"];
                                if (nextLinkValue != null && nextLinkValue.Type != JTokenType.Null)
                                {
                                    string nextLinkInstance = ((string)nextLinkValue);
                                    itemListInstance.NextLink = nextLinkInstance;
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
