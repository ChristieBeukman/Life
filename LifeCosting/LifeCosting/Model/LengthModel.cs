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
        
        public int LengthCostID { get; set; }
        public int TypeID { get; set; }
        public string MaterialID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? NoPieces { get; set; }
        public decimal? LengthPerPiece { get; set; }
        public decimal? TotalLength { get; set; }
        public decimal? TotalCostPieces { get; set; }
        public decimal? PricePerMeter { get; set; }

    }
}
