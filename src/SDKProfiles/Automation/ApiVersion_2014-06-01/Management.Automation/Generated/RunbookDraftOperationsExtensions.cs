// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class RunbookDraftOperationsExtensions
    {
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the publish runbook operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResultResponse BeginPublish(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, RunbookDraftPublishParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).BeginPublishAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the publish runbook operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResultResponse> BeginPublishAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, RunbookDraftPublishParameters parameters)
        {
            return operations.BeginPublishAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates the runbook draft with runbookStream as its content.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The runbook draft update parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResultResponse BeginUpdate(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, RunbookDraftUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).BeginUpdateAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates the runbook draft with runbookStream as its content.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The runbook draft update parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResultResponse> BeginUpdateAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, RunbookDraftUpdateParameters parameters)
        {
            return operations.BeginUpdateAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates the runbook draft with runbookStream as its content.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The runbook draft update parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResultResponse BeginUpdateGraph(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, RunbookDraftUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).BeginUpdateGraphAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates the runbook draft with runbookStream as its content.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The runbook draft update parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResultResponse> BeginUpdateGraphAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, RunbookDraftUpdateParameters parameters)
        {
            return operations.BeginUpdateGraphAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the content of runbook draft identified by runbook name.
        /// (see http://aka.ms/azureautomationsdk/runbookdraftoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the runbook content operation.
        /// </returns>
        public static RunbookContentResponse Content(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).ContentAsync(resourceGroupName, automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the content of runbook draft identified by runbook name.
        /// (see http://aka.ms/azureautomationsdk/runbookdraftoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the runbook content operation.
        /// </returns>
        public static Task<RunbookContentResponse> ContentAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return operations.ContentAsync(resourceGroupName, automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the runbook draft identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the get runbook draft operation.
        /// </returns>
        public static RunbookDraftGetResponse Get(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).GetAsync(resourceGroupName, automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the runbook draft identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the get runbook draft operation.
        /// </returns>
        public static Task<RunbookDraftGetResponse> GetAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return operations.GetAsync(resourceGroupName, automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the publish runbook operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResultResponse Publish(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, RunbookDraftPublishParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).PublishAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the publish runbook operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResultResponse> PublishAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, RunbookDraftPublishParameters parameters)
        {
            return operations.PublishAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the undoedit runbook operation.
        /// </returns>
        public static RunbookDraftUndoEditResponse UndoEdit(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).UndoEditAsync(resourceGroupName, automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the undoedit runbook operation.
        /// </returns>
        public static Task<RunbookDraftUndoEditResponse> UndoEditAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return operations.UndoEditAsync(resourceGroupName, automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates the runbook draft with runbookStream as its content.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The runbook draft update parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResultResponse Update(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, RunbookDraftUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).UpdateAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates the runbook draft with runbookStream as its content.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The runbook draft update parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResultResponse> UpdateAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, RunbookDraftUpdateParameters parameters)
        {
            return operations.UpdateAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates the runbook draft with runbookStream as its content.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The runbook draft update parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResultResponse UpdateGraph(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, RunbookDraftUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookDraftOperations)s).UpdateGraphAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates the runbook draft with runbookStream as its content.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookDraftOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The runbook draft update parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResultResponse> UpdateGraphAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccount, RunbookDraftUpdateParameters parameters)
        {
            return operations.UpdateGraphAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
    }
}