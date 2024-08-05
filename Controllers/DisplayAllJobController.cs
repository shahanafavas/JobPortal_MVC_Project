using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Web;
using System.IO;
using System.Data.SqlClient;
using System.Web.Mvc;

using Project_MVC.Models;
using System.Data;

namespace Project_MVC.Controllers
{
    public class DisplayAllJobController : Controller
    {
        MVC_Project_LaEntities1 dbobj = new MVC_Project_LaEntities1();
        // GET: DisplayAllJob
        public ActionResult DisplayAllJob_Load()
        {
          
            return View(GetData());
        }
        private DisplayAll GetData()
        {
            var disply = new DisplayAll();
            List<string> lst = new List<string>();
            var job = dbobj.sp_displayall().ToList();
           
            var lstj = (from row in job
                        select new DisplayAll()
                        {
                            Company_Name = row.Name,
                            JobTitle = row.Job_Title,
                            vacancies = row.No_Vacancies,
                            salary = row.Salary,
                            CId=row.Company_Id,
                            jobid=row.Job_Id,
                            
                        }).ToList();

            disply.selectjob.AddRange(lstj);

            return disply;
        }
        public ActionResult SearchJob_Click(DisplayAll clsobj)
        {
            
            string qry = "";
            if (clsobj != null && clsobj.insertse != null)
            {
                

                if (!string.IsNullOrWhiteSpace(clsobj.insertse.Job_Title))
                {
                    qry += "and Job_Title like '%" + clsobj.insertse.Job_Title + "%'";
                }
                if (!string.IsNullOrWhiteSpace(clsobj.insertse.companyname))
                {
                    qry += "and Name like '%" + clsobj.insertse.companyname + "%'";
                }
                if (!string.IsNullOrWhiteSpace(clsobj.insertse.Salary))
                {
                    qry += "and Salary like '%" + clsobj.insertse.Salary + "%'";
                }
            }
            return View("DisplayAllJob_Load", getdata1(clsobj, qry));
        }
        private DisplayAll getdata1(DisplayAll clsobj, string qry)
        {
          

            using (var con = new SqlConnection(dbobj.Database.Connection.ConnectionString))
            {
               

                SqlCommand cmd = new SqlCommand("sp_check1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@qry", qry);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var joblist = new DisplayAll();
                while (dr.Read())
                {
                    var jobcls = new DisplayAll();
                    //jobcls.jobid = Convert.ToInt32(dr["Job_Id"].ToString());
                    jobcls.Company_Name = dr["Company_Name"].ToString();
                    jobcls.JobTitle = dr["Job_Title"].ToString();
                    jobcls.vacancies = Convert.ToInt32(dr["No_Vacancies"].ToString());
                    jobcls.salary = Convert.ToInt32(dr["Salary"].ToString());
                    jobcls.CId = Convert.ToInt32(dr["Company_Id"].ToString());
                    jobcls.jobid = Convert.ToInt32(dr["Job_Id"].ToString());
                    //jobcls.status = dr["Status"].ToString();
                    joblist.selectjob.Add(jobcls);
                    ;
                }
                con.Close();
                return joblist;
            }
        }
    }
}