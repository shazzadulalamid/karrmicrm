//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogisticManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_CandidateJobHistory
    {
        public int AutoId { get; set; }
        public int CandidateId { get; set; }
        public string JobTrade { get; set; }
        public Nullable<int> JobDuration { get; set; }
        public string JobCompany { get; set; }
        public int CountryId { get; set; }
    }
}
