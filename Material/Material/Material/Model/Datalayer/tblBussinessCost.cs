//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Material.Model.Datalayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBussinessCost
    {
        public int BussinessCostID { get; set; }
        public int TypeID { get; set; }
        public string MaterialID { get; set; }
        public string CostName { get; set; }
        public Nullable<decimal> RatePerHour { get; set; }
    
        public virtual tblMaterial tblMaterial { get; set; }
        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
