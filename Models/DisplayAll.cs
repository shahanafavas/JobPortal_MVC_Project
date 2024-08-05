using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_MVC.Models
{
    public class DisplayAll
    {
        public List<DisplayAll> selectjob { get; set; }

        public DisplayAll()
        {
            selectjob = new List<DisplayAll>();
        }
        public JobSearchCriteria insertse { get; set; }

        public string Company_Name { get; set; }
        public string JobTitle { get; set; }
        public int vacancies { get; set; }

        public int salary { set; get; }

        public string status { set; get; }


        public int jobid { set; get; }
        public int CId { set; get; }

        public int EmpId { set; get; }

        public DateTime date { set; get; }

        
    }
    public class JobSearchCriteria
    {
        public string Job_Title { get; set; }
        public string Salary { get; set; }

        public string companyname { get; set; }
        // Other search criteria properties...
    }
}