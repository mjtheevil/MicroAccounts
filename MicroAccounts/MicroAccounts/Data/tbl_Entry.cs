//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MicroAccounts.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Entry
    {
        public long voucherRefNo { get; set; }
        public Nullable<int> entryType { get; set; }
        public Nullable<long> crId { get; set; }
        public Nullable<long> drId { get; set; }
        public Nullable<decimal> amt { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string stringDate { get; set; }
        public string remarks { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
    }
}