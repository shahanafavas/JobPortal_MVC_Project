using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Project_MVC.Models;

namespace Project_MVC.Controllers
{
    public class UserLogintController : Controller
    {
        MVC_Project_LaEntities1 obj = new MVC_Project_LaEntities1();
        // GET: UserLogin
        public ActionResult Login_pageload()
        {
            return View();
        }
        public ActionResult EmployeeHome()
        {
            return View();
        }
      
        public ActionResult Login_Click(Logincls objcls)
        {
            if(ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(string));
                obj.sp_login(objcls.uname, objcls.password, op);
                string val = (op.Value).ToString();
                if(val=="1")
                {
                    var uid = obj.sp_loginId(objcls.uname, objcls.password).FirstOrDefault();
                    Session["uid"] = uid;

                    var lt = obj.sp_loginType(objcls.uname, objcls.password).FirstOrDefault();
                    if(lt=="Employee")
                    {
                        return RedirectToAction("DisplayAllJob_Load","DisplayAllJob");
                    }
                    else if(lt=="Company")
                    {
                        var cmpid =obj.sp_cmpId(objcls.uname, objcls.password).FirstOrDefault();
                        Session["cmpid"] = cmpid;
                        return RedirectToAction("Index", "Company");
                    }
                }
                else
                {
                    ModelState.Clear();
                    objcls.msg = "Invalid login";
                    return View("Login_pageload", objcls);
                }
            }
            return View("Index", objcls);
        }
    }
}