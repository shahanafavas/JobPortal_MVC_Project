using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_MVC.Models;
using System.IO;

namespace Project_MVC.Controllers
{
    public class CompanyRegController : Controller
    {
        MVC_Project_LaEntities1 dbobj = new MVC_Project_LaEntities1();
        // GET: CompanyReg
        public ActionResult CompanyInsert_Pageload()
        {
            return View();
        }
        public ActionResult CompanyInsert_click(CompanyInsert clsobj)
        {
            if (ModelState.IsValid)
            {
                var getmaxid = dbobj.sp_maxIdLogin().FirstOrDefault();
                int mid = Convert.ToInt32(getmaxid);
                int regid = 0;
                if (mid == 0)
                {
                    regid = 1;
                }
                else
                {
                    regid = mid + 1;
                }
                Session["CompID"] = regid;
                dbobj.sp_CompanyRegi(regid, clsobj.name, clsobj.address,clsobj.phone, clsobj.email, clsobj.status);
                dbobj.sp_loginIsert(regid, clsobj.username, clsobj.pass,"Company",clsobj.status);
                clsobj.msg = "Successfully Inserted";
               
                return View("CompanyInsert_Pageload", clsobj);
            }
            return View("CompanyInsert_Pageload", clsobj);
        }
    }
}