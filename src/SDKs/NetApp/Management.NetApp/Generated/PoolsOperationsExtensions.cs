// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PoolsOperations.
    /// </summary>
    public static partial class PoolsOperationsExtensions
    {
            /// <summary>
            /// Lists all capacity pools in the NetApp Account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            public static IEnumerable<CapacityPool> List(this IPoolsOperations operations, string resourceGroup, string accountName)
            {
                return operations.ListAsync(resourceGroup, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all capacity pools in the NetApp Account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<CapacityPool>> ListAsync(this IPoolsOperations operations, string resourceGroup, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroup, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a capacity pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            public static CapacityPool Get(this IPoolsOperations operations, string resourceGroup, string accountName, string poolName)
            {
                return operations.GetAsync(resourceGroup, accountName, poolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a capacity pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapacityPool> GetAsync(this IPoolsOperations operations, string resourceGroup, string accountName, string poolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroup, accountName, poolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or Update a capacity pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Capacity pool object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            public static CapacityPool CreateOrUpdate(this IPoolsOperations operations, CapacityPool body, string resourceGroup, string accountName, string poolName)
            {
                return operations.CreateOrUpdateAsync(body, resourceGroup, accountName, poolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or Update a capacity pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Capacity pool object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapacityPool> CreateOrUpdateAsync(this IPoolsOperations operations, CapacityPool body, string resourceGroup, string accountName, string poolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(body, resourceGroup, accountName, poolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Patch a capacity pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Capacity pool object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            public static CapacityPool Update(this IPoolsOperations operations, CapacityPoolPatch body, string resourceGroup, string accountName, string poolName)
            {
                return operations.UpdateAsync(body, resourceGroup, accountName, poolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch a capacity pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Capacity pool object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapacityPool> UpdateAsync(this IPoolsOperations operations, CapacityPoolPatch body, string resourceGroup, string accountName, string poolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(body, resourceGroup, accountName, poolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a capacity pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            public static void Delete(this IPoolsOperations operations, string resourceGroup, string accountName, string poolName)
            {
                operations.DeleteAsync(resourceGroup, accountName, poolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a capacity pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPoolsOperations operations, string resourceGroup, string accountName, string poolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroup, accountName, poolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or Update a capacity pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Capacity pool object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            public static CapacityPool BeginCreateOrUpdate(this IPoolsOperations operations, CapacityPool body, string resourceGroup, string accountName, string poolName)
            {
                return operations.BeginCreateOrUpdateAsync(body, resourceGroup, accountName, poolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or Update a capacity pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Capacity pool object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapacityPool> BeginCreateOrUpdateAsync(this IPoolsOperations operations, CapacityPool body, string resourceGroup, string accountName, string poolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(body, resourceGroup, accountName, poolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a capacity pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            public static void BeginDelete(this IPoolsOperations operations, string resourceGroup, string accountName, string poolName)
            {
                operations.BeginDeleteAsync(resourceGroup, accountName, poolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a capacity pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPoolsOperations operations, string resourceGroup, string accountName, string poolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroup, accountName, poolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
