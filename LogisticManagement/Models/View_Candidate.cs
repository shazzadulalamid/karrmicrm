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
    
    public partial class View_Candidate
    {
        public int AutoId { get; set; }
        public int CandidateId { get; set; }
        public string CandidateCode { get; set; }
        public string CandidateName { get; set; }
        public string CandidateContactNo { get; set; }
        public string CandidateAddress { get; set; }
        public Nullable<System.DateTime> CandidateDOB { get; set; }
        public string CandidateGender { get; set; }
        public string CandidateGuardianName { get; set; }
        public string CandidateGurdianContact { get; set; }
        public string CandidateImageRef { get; set; }
        public string JobTrade { get; set; }
        public Nullable<int> JobDuration { get; set; }
        public string JobCompany { get; set; }
        public Nullable<int> SkillId { get; set; }
        public string SkillName { get; set; }
        public Nullable<int> DocumentId { get; set; }
        public string DocumentKey { get; set; }
        public Nullable<System.DateTime> DocumentExpiryDate { get; set; }
        public string DocumentImageRef { get; set; }
        public string DocumentOrgImageRef { get; set; }
        public string DocumentName { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryShortName { get; set; }
        public string JobCountryName { get; set; }
        public string JobCountryShortName { get; set; }
    }
}
