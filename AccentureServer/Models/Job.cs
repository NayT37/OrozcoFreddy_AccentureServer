//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccentureServer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job
    {
        public int JobID { get; set; }
        public string CompanyName { get; set; }
        public string Salary { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public string CompanyNIT { get; set; }
        public int ClientID { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
