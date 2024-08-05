using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_MVC.Models
{
    public class applyjob
    {
       public int jobid { set; get; }

        public int empid { set; get; }

        public int cmpid { set; get; }

        public DateTime date { set; get; }

        public byte[] resume { set; get; }

        public string msg { set; get; }
    }
}