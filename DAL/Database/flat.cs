//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class flat
    {
        public int id { get; set; }
        public int colonyCode { get; set; }
        public int buildingCode { get; set; }
        public string buildingName { get; set; }
        public int floorDetail { get; set; }
        public string flatNumber { get; set; }
        public string flatSize { get; set; }
        public string flatRenterName { get; set; }
        public string month { get; set; }
        public string flatRent { get; set; }
        public string wasaBill { get; set; }
        public string currentBill { get; set; }
        public string status { get; set; }
        public int colonyId { get; set; }
        public int buildingId { get; set; }
    }
}