using ClassLibrary1.Models;
using Dip.Models;
using Dip.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dip.Controllers
{
    public class WorkController : Controller
    {
        WorkService _workService;

        public WorkController()
        {
            _workService = new WorkService();
        }

        // GET: Work
        public ActionResult Index()
        {
            JobsModel model = new JobsModel();
            model.Jobs = _workService.GetJobsByName(User.Identity.Name);
            return View(model);
        }


        [HttpPost]
        public ActionResult SaveDone(JobsModel model)
        {
            _workService.UpdateJobs(model.Jobs);
            return RedirectToAction("Index", "Work");
        }
        [HttpPost]
        public ActionResult SaveActive(JobsModel model)
        {
            _workService.UpdateJobs(model.Jobs);
            return RedirectToAction("Index", "Work");
        }
        [HttpPost]
        public ActionResult SaveNew(JobsModel model)
        {
            model.NewJob.EmployeeName = User.Identity.Name;
            _workService.AddJob(model.NewJob);
            return RedirectToAction("Index", "Work");
        }
    }
}