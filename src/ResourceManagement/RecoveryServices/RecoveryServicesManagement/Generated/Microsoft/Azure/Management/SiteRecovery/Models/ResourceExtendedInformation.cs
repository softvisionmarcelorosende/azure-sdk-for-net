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
using System.Linq;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a Resource Extended Information object.
    /// </summary>
    public partial class ResourceExtendedInformation
    {
        private string _extendedInfo;
        
        /// <summary>
        /// Optional. Serialized blob of extended info for the vault.
        /// </summary>
        public string ExtendedInfo
        {
            get { return this._extendedInfo; }
            set { this._extendedInfo = value; }
        }
        
        private string _extendedInfoETag;
        
        /// <summary>
        /// Optional. ETag for the vault.
        /// </summary>
        public string ExtendedInfoETag
        {
            get { return this._extendedInfoETag; }
            set { this._extendedInfoETag = value; }
        }
        
        private string _resourceGroupName;
        
        /// <summary>
        /// Optional. Resource group name for the vault.
        /// </summary>
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }
        
        private long _resourceId;
        
        /// <summary>
        /// Optional. id of the vault.
        /// </summary>
        public long ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }
        
        private string _resourceName;
        
        /// <summary>
        /// Optional. name of the vault.
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }
        
        private string _resourceType;
        
        /// <summary>
        /// Optional. Type of the vault.
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }
        
        private Guid _subscriptionId;
        
        /// <summary>
        /// Optional. subscription id for the vault.
        /// </summary>
        public Guid SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ResourceExtendedInformation class.
        /// </summary>
        public ResourceExtendedInformation()
        {
        }
    }
}
