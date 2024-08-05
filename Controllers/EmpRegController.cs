using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_MVC.Models;
using System.IO;

namespace Project_MVC.Controllers
{
    public class EmpRegController : Controller
    {
        MVC_Project_LaEntities1 dbobj = new MVC_Project_LaEntities1();
        // GET: EmpReg
        public ActionResult EmpInsert_Pageload()
        {
            EmployeeInsert emp = new EmployeeInsert();
            emp.myqual = getQualification();
            return View(emp);
        }
        public List<checkboxlisthelper> getQualification()
        {
            List<checkboxlisthelper> sts = new List<checkboxlisthelper>()
            {
                new checkboxlisthelper {value="SSLC",text="SSLC",ischecked=true},
                new checkboxlisthelper {value="PLUS TWO",text="PLUS TWO",ischecked=false},
                new checkboxlisthelper {value="BCA",text="BCA",ischecked=false},
                new checkboxlisthelper {value="MCA",text="MCA",ischecked=false},
            };
            return sts;
        }
        public ActionResult EmpInsert_click(EmployeeInsert clsobj)
        {
            if(ModelState.IsValid)
            {

                var getmaxid = dbobj.sp_maxIdLogin().FirstOrDefault();
                int mid = Convert.ToInt32(getmaxid);
                int regid = 0;
                if(mid==0)
                {
                    regid = 1;
                }
                else
                {
                    regid = mid + 1;
                }
                var qid = string.Join(",", clsobj.selectedqual);
                clsobj.qualification = qid;
                clsobj.myqual = getQualification();

                dbobj.sp_employeReg(regid, clsobj.name, clsobj.age, clsobj.address, clsobj.phone, clsobj.email, clsobj.qualification, clsobj.skills, clsobj.experience, clsobj.status);
                dbobj.sp_loginIsert(regid, clsobj.username, clsobj.password, "Employee", clsobj.status);
                clsobj.msg = "Successfully Inserted";
                return View("EmpInsert_Pageload", clsobj);
            }
            return View("EmpInsert_Pageload",clsobj);
        }

    }
}