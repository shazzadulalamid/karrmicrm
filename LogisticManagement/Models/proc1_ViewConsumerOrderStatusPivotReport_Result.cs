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
    
    public partial class proc1_ViewConsumerOrderStatusPivotReport_Result
    {
        public string ConsumerCode { get; set; }
        public string FullName { get; set; }
        public string ContactNo { get; set; }
        public Nullable<int> TotalOrder { get; set; }
        public int WaitingForShipment { get; set; }
        public int ChinaWarehouseReceivePending { get; set; }
        public int ShipmentPendingfromChinaWarehouse { get; set; }
        public int ReceiveInBDWarehouse { get; set; }
        public int ReadyForDelivery { get; set; }
        public int OnTransittoCustomer { get; set; }
        public int DisputedApplied { get; set; }
        public int Delivered { get; set; }
        public int Refunded { get; set; }
    }
}
