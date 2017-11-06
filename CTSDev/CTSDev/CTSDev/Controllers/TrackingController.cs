using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CTSDev.ViewModels;
using CTSDev.Facade;
using CTSDev.Models;

namespace CTSDev.Controllers
{
    public class TrackingController : Controller
    {
        #region "Unitofwork Reference"

        ITrackingBO _tackingBO = null;

        public TrackingController(ITrackingBO tackingBO)
        {
            this._tackingBO = tackingBO;
        }
        public TrackingController()
        {
            _tackingBO = new TrackingBO();
        }

        #endregion
        //
        // GET: /Tracking/
        [HttpGet]
        public ActionResult TrackingInfo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TrackingInfo(CorrCompInfo tackingviewmodel)
        {
            _tackingBO.InsertData(tackingviewmodel);
            return null;
        }

    }
}
