using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeCosting.Model;
using LifeCosting.Model.DataLayer;


namespace LifeCosting.ViewModel
{
    public class LengthViewModel : BaseViewModel
    {

        public dbNewEntities entity = new dbNewEntities();

        #region Properties
        private List<LengthModel> viewLengthModel;
        private LengthModel selectedLength;

        public List<LengthModel> ViewLengthModel
        {
            get
            {
                return viewLengthModel;
            }

            set
            {
                viewLengthModel = value;
                NotifyPropertyChanged("LenghtModel");
            }
        }

        public LengthModel SelectedLength
        {
            get
            {
                return selectedLength;
            }

            set
            {
                if (selectedLength != null)
                {
                    selectedLength = value;
                    NotifyPropertyChanged("SelectedLength");
                }
            }
        }
        #endregion

        #region Constructor

        public LengthViewModel()
        {
            GetLengthCost();
        }

        #endregion

        #region Methods

        private void GetLengthCost()
        {
            var Query = (from l in entity.tblLengthCosts
                         join m in entity.tblMaterials
                         on l.MaterialID equals m.MaterialID
                         select new LengthModel
                         {
                             MaterialID = l.MaterialID,
                             Name = m.Name,
                             Description = m.Description,
                             NoPieces = l.NoPieces,
                             LengthPerPiece = l.LengthPerPiece,
                             TotalCostPieces = l.TotalCostPieces,
                             TotalLength = l.TotalLength,
                             PricePerMeter = l.PricePerMeter
                         }).ToList();
            this.viewLengthModel = Query;
        }
        #endregion
    }
}
