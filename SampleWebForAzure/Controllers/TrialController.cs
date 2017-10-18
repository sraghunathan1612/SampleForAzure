using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebForAzure.Controllers
{
    public class TrialController : Controller
    {
        // GET: Trial
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TrialAction()
        {
            //JsonResult jsr = new JsonResult();
            //jsr.Data = "Hi From Trial Azure";
            //return jsr;
            return Json("Hi From Trial Azure", JsonRequestBehavior.AllowGet);
        }
    }
}