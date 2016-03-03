//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerMaintenanceSystem.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobDetail
    {
        public string CarNo { get; set; }
        public System.DateTime JobDate { get; set; }
        public int WorkerId { get; set; }
        public Nullable<int> KMs { get; set; }
        public Nullable<int> Tuning { get; set; }
        public Nullable<int> Alignment { get; set; }
        public Nullable<int> Balancing { get; set; }
        public Nullable<int> Tires { get; set; }
        public Nullable<int> Weights { get; set; }
        public Nullable<int> OilChanged { get; set; }
        public Nullable<int> OilQty { get; set; }
        public Nullable<int> OilFilter { get; set; }
        public Nullable<int> GearOil { get; set; }
        public Nullable<int> GearOilQty { get; set; }
        public Nullable<int> Point_ { get; set; }
        public Nullable<int> Condenser { get; set; }
        public Nullable<int> Plug { get; set; }
        public Nullable<int> PlugQty { get; set; }
        public Nullable<int> FuelQty { get; set; }
        public Nullable<int> FuelFilter { get; set; }
        public Nullable<int> AirFilter { get; set; }
        public string Remarks { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Worker Worker { get; set; }
    }
}