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
    
    public partial class tblConsumable
    {
        public int ConsumableID { get; set; }
        public int TypeID { get; set; }
        public string MaterialID { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
        public Nullable<decimal> PricePerUnit { get; set; }
    
        public virtual tblMaterial tblMaterial { get; set; }
        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
