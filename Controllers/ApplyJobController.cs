using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_MVC.Models;
using System.IO;

namespace Project_MVC.Controllers
{
    public class ApplyJobController : Controller
    {
        MVC_Project_LaEntities1 dbobj = new MVC_Project_LaEntities1();
        // GET: ApplyJob
        public ActionResult Index(int cid, int jid)
        {
            TempData["CId"] = cid;
            TempData["Job_Id"] = jid;
            return View();
        }
        public ActionResult job_click(applyjob clsobj,HttpPostedFileBase file)
        {
            if(ModelState.IsValid)
            {
                if (file != null && file.ContentLength > 0)
                {
                    

                    clsobj.resume = ConvertToByteArray(file);
                }

                int uid = Convert.ToInt32(Session["uid"]);
                int cid = Convert.ToInt32(TempData["CId"]);
                int jid = Convert.ToInt32(TempData["Job_Id"]);

                dbobj.sp_applyJob(jid, uid, cid, clsobj.date, clsobj.resume);
                clsobj.msg = "Applied Successfully";

                return View("Index", clsobj);
            }
            return View("Index", clsobj);
        }

        private byte[] ConvertToByteArray(HttpPostedFileBase file)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.InputStream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }

    }
}