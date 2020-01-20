//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MLReporting.Domain.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HostDim
    {
        public HostDim()
        {
            this.HostClusterContainsVMHostFacts = new HashSet<HostClusterContainsVMHostFact>();
            this.HostContainsVirtualMachineFacts = new HashSet<HostContainsVirtualMachineFact>();
            this.HostGroupContainsVMHostFacts = new HashSet<HostGroupContainsVMHostFact>();
            this.HostHostsHostVolumeFacts = new HashSet<HostHostsHostVolumeFact>();
            this.HostHostsVMHostDiskFacts = new HashSet<HostHostsVMHostDiskFact>();
            this.VirtualMachineBaseUsageMonthlyFacts = new HashSet<VirtualMachineBaseUsageMonthlyFact>();
            this.VMInventoryMonthlyFacts = new HashSet<VMInventoryMonthlyFact>();
            this.VirtualMachineBaseUsageHourlyFacts = new HashSet<VirtualMachineBaseUsageHourlyFact>();
            this.VirtualMachineBaseUsageDailyFacts = new HashSet<VirtualMachineBaseUsageDailyFact>();
            this.VirtualMachineBaseUsageDailyFactStagings = new HashSet<VirtualMachineBaseUsageDailyFactStaging>();
            this.VirtualMachineBaseUsageHourlyFactStagings = new HashSet<VirtualMachineBaseUsageHourlyFactStaging>();
        }
    
        public int HostDimKey { get; set; }
        public System.Guid BaseManagedEntityId { get; set; }
        public string VMMId { get; set; }
        public string VMMServer { get; set; }
        public string Description { get; set; }
        public string HostGroup { get; set; }
        public string HostName { get; set; }
        public string TotalRAM { get; set; }
        public string NoOfVMsDeployed { get; set; }
        public string NoOfVMsRunning { get; set; }
        public string State { get; set; }
        public string VirtualizationStackVersionState { get; set; }
        public string AgentVersionState { get; set; }
        public string VirtualizationPlatform { get; set; }
        public string NumberOfProcessors { get; set; }
        public Nullable<int> NumberOfCores { get; set; }
        public string SMBiosGuid { get; set; }
        public string OperatingSystem { get; set; }
        public string OperatingSystemVersion { get; set; }
        public string DisplayName { get; set; }
        public Nullable<int> DWInsertedId { get; set; }
        public Nullable<int> DWUpdatedId { get; set; }
        public Nullable<bool> DWIsDeleted { get; set; }
        public int OperatingSystemDimKey { get; set; }
    
        public virtual ICollection<HostClusterContainsVMHostFact> HostClusterContainsVMHostFacts { get; set; }
        public virtual ICollection<HostContainsVirtualMachineFact> HostContainsVirtualMachineFacts { get; set; }
        public virtual ICollection<HostGroupContainsVMHostFact> HostGroupContainsVMHostFacts { get; set; }
        public virtual ICollection<HostHostsHostVolumeFact> HostHostsHostVolumeFacts { get; set; }
        public virtual ICollection<HostHostsVMHostDiskFact> HostHostsVMHostDiskFacts { get; set; }
        public virtual ICollection<VirtualMachineBaseUsageMonthlyFact> VirtualMachineBaseUsageMonthlyFacts { get; set; }
        public virtual ICollection<VMInventoryMonthlyFact> VMInventoryMonthlyFacts { get; set; }
        public virtual ICollection<VirtualMachineBaseUsageHourlyFact> VirtualMachineBaseUsageHourlyFacts { get; set; }
        public virtual ICollection<VirtualMachineBaseUsageDailyFact> VirtualMachineBaseUsageDailyFacts { get; set; }
        public virtual ICollection<VirtualMachineBaseUsageDailyFactStaging> VirtualMachineBaseUsageDailyFactStagings { get; set; }
        public virtual ICollection<VirtualMachineBaseUsageHourlyFactStaging> VirtualMachineBaseUsageHourlyFactStagings { get; set; }
    }
}