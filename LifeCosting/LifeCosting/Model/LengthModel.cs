using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeCosting.Model.DataLayer;

namespace LifeCosting.Model
{
    public class LengthModel
    {
        public int LenghtCostID { get; set; }
        public int TypeID { get; set; }
        public string MaterialID { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        public Nullable<decimal> NoPieces { get; set; }
        public Nullable<decimal> LengthPerPiece { get; set; }
        public Nullable<decimal> TotalLength { get; set; }
        public Nullable<decimal> TotalCostPieces { get; set; }
        public Nullable<decimal> PricePerMeter { get; set; }
    }
}
