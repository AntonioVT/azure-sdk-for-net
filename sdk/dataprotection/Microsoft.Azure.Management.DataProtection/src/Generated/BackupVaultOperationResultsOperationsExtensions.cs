// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BackupVaultOperationResultsOperations.
    /// </summary>
    public static partial class BackupVaultOperationResultsOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='operationId'>
            /// </param>
            public static BackupVaultResource Get(this IBackupVaultOperationResultsOperations operations, string vaultName, string resourceGroupName, string operationId)
            {
                return operations.GetAsync(vaultName, resourceGroupName, operationId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='operationId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupVaultResource> GetAsync(this IBackupVaultOperationResultsOperations operations, string vaultName, string resourceGroupName, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
