using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material.Model
{
    public class MaterialModel
    {
        public string MaterialID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeID { get; set; }
        public string MeasureType { get; set; }
    }
}
