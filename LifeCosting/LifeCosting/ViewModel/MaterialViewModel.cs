using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeCosting.Model.DataLayer;
using LifeCosting.Model;

namespace LifeCosting.ViewModel
{
    public class MaterialViewModel : BaseViewModel
    {
        public dbNewEntities entity = new dbNewEntities();

#region Properties
        private List<MaterialsModel> material;
        private tblMaterial selectedMaterial;

        public List<MaterialsModel> Material
        {
            get
            {
                return material;
            }

            set
            {
                material = value;
                NotifyPropertyChanged("Material");
            }
        }

        public tblMaterial SelectedMaterial
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
        #endregion

#region COnstriuctor

        public MaterialViewModel()
        {
            GetMaterial();
        }

        #endregion

#region Methods

        private void GetMaterial()
        {
            var Query = (from l in entity.tblMaterials
                         select new MaterialsModel
                         {
                             MaterialID = l.MaterialID,
                             Name = l.Name,
                             Description = l.Description
                         }).ToList();
            this.material = Query;
        }
#endregion
    }
}
