using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_MVC.Models;
namespace Project_MVC.Controllers
{
    public class CompanyController : Controller
    {
        MVC_Project_LaEntities1 obj = new MVC_Project_LaEntities1();
        // GET: Company
        public ActionResult Index()
        {
           

            return View();
        }
        public ActionResult JobInsert_click(JobAdd clsobj)
        {
            if (ModelState.IsValid)
            {

                int companyId = Convert.ToInt32(Session["cmpid"]);
                obj.sp_addjob(companyId, clsobj.jobtitle, clsobj.vacancies, clsobj.salary, clsobj.status);
                clsobj.msg = "Successfully inserted";

                return View("Index", clsobj);
            }
            return View("Index", clsobj);


            
        }
    }
}