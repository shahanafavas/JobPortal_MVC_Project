using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_MVC.Models;

namespace Project_MVC.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        MVC_Project_LaEntities1 dbobj = new MVC_Project_LaEntities1();
        // GET: EmployeeDetails
        public ActionResult Index()
        {
            return View();
        }
    }
}