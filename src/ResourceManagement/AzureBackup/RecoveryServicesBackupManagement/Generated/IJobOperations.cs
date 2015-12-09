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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    /// <summary>
    /// Definition of Job operations for the Azure Backup extension.
    /// </summary>
    public partial interface IJobOperations
    {
        /// <summary>
        /// Cancel the job.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        Task<JobResponse> CancelJobAsync(string resourceGroupName, string resourceName, string jobName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Export job.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        Task<JobResponse> ExportJobAsync(string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the details of specific job Objects.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        Task<JobResponse> GetAsync(string resourceGroupName, string resourceName, string jobName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the operation result of specific job.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        Task<JobResponse> GetOperationResultAsync(string resourceGroupName, string resourceName, string jobName, string operationId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list  of jobs.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a JobListResponse.
        /// </returns>
        Task<JobListResponse> ListAsync(string resourceGroupName, string resourceName, CommonJobQueryFilters queryFilter, PaginationRequest paginationParams, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
