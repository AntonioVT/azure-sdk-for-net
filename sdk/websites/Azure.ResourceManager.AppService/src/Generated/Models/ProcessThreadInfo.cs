// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Process Thread Information. </summary>
    public partial class ProcessThreadInfo : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of ProcessThreadInfo. </summary>
        public ProcessThreadInfo()
        {
        }

        /// <summary> Initializes a new instance of ProcessThreadInfo. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="identifier"> Site extension ID. </param>
        /// <param name="href"> HRef URI. </param>
        /// <param name="process"> Process URI. </param>
        /// <param name="startAddress"> Start address. </param>
        /// <param name="currentPriority"> Current thread priority. </param>
        /// <param name="priorityLevel"> Thread priority level. </param>
        /// <param name="basePriority"> Base priority. </param>
        /// <param name="startTime"> Start time. </param>
        /// <param name="totalProcessorTime"> Total processor time. </param>
        /// <param name="userProcessorTime"> User processor time. </param>
        /// <param name="state"> Thread state. </param>
        /// <param name="waitReason"> Wait reason. </param>
        internal ProcessThreadInfo(ResourceIdentifier id, string name, ResourceType type, string kind, int? identifier, string href, string process, string startAddress, int? currentPriority, string priorityLevel, int? basePriority, DateTimeOffset? startTime, string totalProcessorTime, string userProcessorTime, string state, string waitReason) : base(id, name, type, kind)
        {
            Identifier = identifier;
            Href = href;
            Process = process;
            StartAddress = startAddress;
            CurrentPriority = currentPriority;
            PriorityLevel = priorityLevel;
            BasePriority = basePriority;
            StartTime = startTime;
            TotalProcessorTime = totalProcessorTime;
            UserProcessorTime = userProcessorTime;
            State = state;
            WaitReason = waitReason;
        }

        /// <summary> Site extension ID. </summary>
        public int? Identifier { get; }
        /// <summary> HRef URI. </summary>
        public string Href { get; set; }
        /// <summary> Process URI. </summary>
        public string Process { get; set; }
        /// <summary> Start address. </summary>
        public string StartAddress { get; set; }
        /// <summary> Current thread priority. </summary>
        public int? CurrentPriority { get; set; }
        /// <summary> Thread priority level. </summary>
        public string PriorityLevel { get; set; }
        /// <summary> Base priority. </summary>
        public int? BasePriority { get; set; }
        /// <summary> Start time. </summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary> Total processor time. </summary>
        public string TotalProcessorTime { get; set; }
        /// <summary> User processor time. </summary>
        public string UserProcessorTime { get; set; }
        /// <summary> Thread state. </summary>
        public string State { get; set; }
        /// <summary> Wait reason. </summary>
        public string WaitReason { get; set; }
    }
}
