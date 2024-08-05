using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_MVC.Models;

namespace Project_MVC.Controllers
{
    public class DisplayController : Controller
    {
        MVC_Project_LaEntities1 dbobj = new MVC_Project_LaEntities1();
        // GET: Display




        //    public ActionResult Index(DisplayAll clsobj)
        //    {


        //        var getdata = dbobj.sp_displayall().ToList();

        //        var mdl = (from dt in getdata
        //                   select new DisplayAll()
        //                   {

        //                       Company_Name = dt.Name,
        //                       JobTitle = dt.Job_Title,
        //                       vacancies=dt.No_Vacancies,

        //                       salary = dt.Salary,

        //                   }).ToList();

        //        return View("Index",mdl);
        //    }
        //    public ActionResult search(DisplayAll clsobj)
        //    {

        //        return RedirectToAction("Index","ApplyJob");

        //    }
        //}
    }
}