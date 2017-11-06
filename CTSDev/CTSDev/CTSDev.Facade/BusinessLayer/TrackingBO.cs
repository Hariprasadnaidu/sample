using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTSDev.Facade;
using CTSDev.DataLayer;
using CTSDev.Models;

namespace CTSDev.Facade
{
    public class TrackingBO : ITrackingBO
    {
        #region "Unitofwork Reference"
        IUnitOfWork _unitOfWork = null;

        public TrackingBO(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }
        public TrackingBO()
        {
            _unitOfWork = new UnitOfWork();
        }

        #endregion

        public int InsertData(CorrCompInfo corrcompinfo)
        {
            corrcompinfo.purpose_of_contact = "12345";
            corrcompinfo.date_entered = DateTime.Now;
            corrcompinfo.date_recd = DateTime.Now;
            corrcompinfo.cc_date = DateTime.Now;
            _unitOfWork.Repository<CorrCompInfo>().Insert(corrcompinfo);
            return 1;
        }
    }
}
