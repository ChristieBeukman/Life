using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apex.MVVM;
using LifeCosting.Model;
using LifeCosting.Model.DataLayer;

namespace LifeCosting.ViewModels
{
   public class LengthCostingViewModel : ViewModel
    {
        dbNewEntities ctx = new dbNewEntities();    // DataModel Entities datacontext

        private List<LengthModel> _LengthModels;
        private LengthModel _SelectedLengthModel;


        public List<LengthModel> LengthModel
        {
            get
            {
                return _LengthModels;
            }

            set
            {
                _LengthModels = value;
                NotifyPropertyChanged("LengthModel");
            }
        }

        public LengthModel SelectedLengthModel
        {
            get
            {
                return _SelectedLengthModel;
            }

            set
            {
                _SelectedLengthModel = value;
                NotifyPropertyChanged("SelectedLengthModel");
            }
        }


        #region COnstructor

        public LengthCostingViewModel()
        {
            GetLenght();
        }

        #endregion

        private void GetLenght()
        {
            var Query = (from l in ctx.tblLengthCosts
                         join m in ctx.tblMaterials
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
            this.LengthModel = Query;
        }
    }
}
