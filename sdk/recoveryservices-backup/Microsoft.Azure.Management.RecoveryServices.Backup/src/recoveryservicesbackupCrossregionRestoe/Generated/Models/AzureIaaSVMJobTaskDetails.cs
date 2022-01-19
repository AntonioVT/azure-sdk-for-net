// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure IaaS VM workload-specific job task details.
    /// </summary>
    public partial class AzureIaaSVMJobTaskDetails
    {
        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMJobTaskDetails class.
        /// </summary>
        public AzureIaaSVMJobTaskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMJobTaskDetails class.
        /// </summary>
        /// <param name="taskId">The task display name.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="instanceId">The instanceId.</param>
        /// <param name="duration">Time elapsed for task.</param>
        /// <param name="status">The status.</param>
        /// <param name="progressPercentage">Progress of the task.</param>
        /// <param name="taskExecutionDetails">Details about execution of the
        /// task.
        /// eg: number of bytes transferred etc</param>
        public AzureIaaSVMJobTaskDetails(string taskId = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string instanceId = default(string), System.TimeSpan? duration = default(System.TimeSpan?), string status = default(string), double? progressPercentage = default(double?), string taskExecutionDetails = default(string))
        {
            TaskId = taskId;
            StartTime = startTime;
            EndTime = endTime;
            InstanceId = instanceId;
            Duration = duration;
            Status = status;
            ProgressPercentage = progressPercentage;
            TaskExecutionDetails = taskExecutionDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the task display name.
        /// </summary>
        [JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the instanceId.
        /// </summary>
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or sets time elapsed for task.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public System.TimeSpan? Duration { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets progress of the task.
        /// </summary>
        [JsonProperty(PropertyName = "progressPercentage")]
        public double? ProgressPercentage { get; set; }

        /// <summary>
        /// Gets or sets details about execution of the task.
        /// eg: number of bytes transferred etc
        /// </summary>
        [JsonProperty(PropertyName = "taskExecutionDetails")]
        public string TaskExecutionDetails { get; set; }

    }
}
