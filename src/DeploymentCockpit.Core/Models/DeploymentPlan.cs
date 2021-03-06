//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeploymentCockpit.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeploymentPlan
    {
        public DeploymentPlan()
        {
            this.Steps = new HashSet<DeploymentPlanStep>();
            this.DeploymentJobs = new HashSet<DeploymentJob>();
            this.Parameters = new HashSet<DeploymentPlanParameter>();
        }
    
        public short DeploymentPlanID { get; set; }
        public short ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ApiCode { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual ICollection<DeploymentPlanStep> Steps { get; set; }
        public virtual ICollection<DeploymentJob> DeploymentJobs { get; set; }
        public virtual ICollection<DeploymentPlanParameter> Parameters { get; set; }
    }
}
