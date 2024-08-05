using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_MVC.Models
{
    public class JobAdd
    {
        public string jobtitle { set; get; }

        public int salary { set; get; }

        public int vacancies { set; get; }

        public string status { set; get; }

        public string msg { set; get; }
    }
}