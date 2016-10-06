//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMIEWebPortal.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Application()
        {
            this.ApplicationAppTypeMappings = new HashSet<ApplicationAppTypeMapping>();
            this.ApplicationDetails = new HashSet<ApplicationDetail>();
            this.AppOnboardDetails = new HashSet<AppOnboardDetail>();
            this.AppTechnologyMappings = new HashSet<AppTechnologyMapping>();
            this.AppUrlMappings = new HashSet<AppUrlMapping>();
            this.EMIETickets = new HashSet<EMIETicket>();
            this.TM_TelemetryData = new HashSet<TM_TelemetryData>();
            this.EMIETicketsArches = new HashSet<EMIETicketsArch>();
        }
    
        public int AppId { get; set; }
        public string Application1 { get; set; }
        public string Windows { get; set; }
        public string Web { get; set; }
        public string Office { get; set; }
        public Nullable<int> ETTOwned { get; set; }
        public Nullable<int> ProjectCategoryId { get; set; }
        public Nullable<int> BPUId { get; set; }
        public Nullable<int> CreatedById { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedById { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ApplicationStateId { get; set; }
        public string Comments { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationAppTypeMapping> ApplicationAppTypeMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationDetail> ApplicationDetails { get; set; }
        public virtual BPU BPU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppOnboardDetail> AppOnboardDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppTechnologyMapping> AppTechnologyMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppUrlMapping> AppUrlMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMIETicket> EMIETickets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_TelemetryData> TM_TelemetryData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMIETicketsArch> EMIETicketsArches { get; set; }
        public virtual User User { get; set; }
    }
}