using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Material.Model;
using Material.Model.Datalayer;

namespace Material.ViewModel
{
    public class MaterialViewModel : BaseViewModel
    {
        dbNewEntities entity = new dbNewEntities();
        private List<MaterialModel> viewMaterialModel;
        private MaterialModel selectedMaterial;

        public List<MaterialModel> ViewMaterialModel
        {
            get
            {
                return viewMaterialModel;
            }

            set
            {
                viewMaterialModel = value;
                NotifyPropertyChanged("ViewMaterialModel");
            }
        }

        public MaterialModel SelectedMaterial
        {
            get
            {
                return selectedMaterial;
            }

            set
            {
                selectedMaterial = value;
                NotifyPropertyChanged("SelectedMaterial");
            }
        }

        public MaterialViewModel()
        {
            GetMaterial();
        }

        private void GetMaterial()
        {
            var Query = (from m in entity.tblMaterials
                         join t in entity.tblMaterialTypes
                         on m.TypeID equals t.TypeID
                         select new MaterialModel
                         {
                             MaterialID = m.MaterialID,
                             Name = m.Name,
                             Description = m.Description,
                             MeasureType = t.MeasureType,
                             TypeID = m.TypeID
                         }).ToList();
            this.viewMaterialModel = Query;
        }
    }
}
