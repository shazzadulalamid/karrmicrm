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
    
    public partial class proc_TransactionByDateRange_Result
    {
        public string TransanctionId { get; set; }
        public string RelatedInvoiceNo { get; set; }
        public Nullable<int> PaymentAmount { get; set; }
        public Nullable<int> PaymentModeId { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public Nullable<System.DateTime> PaymentConfirmationDate { get; set; }
        public Nullable<int> ChartOfAccountId { get; set; }
        public string Remarks { get; set; }
        public string InsertedBy { get; set; }
        public string ChartOfAccountName { get; set; }
        public Nullable<int> AccountHeadId { get; set; }
        public string AccountHeadName { get; set; }
        public Nullable<int> AccountHeadTypeId { get; set; }
        public string AccountHeadTypeName { get; set; }
        public string PaymentModeName { get; set; }
        public string PaymentModeIShortName { get; set; }
        public Nullable<int> ChartOfAccountStatus { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> OpeningBalance { get; set; }
    }
}