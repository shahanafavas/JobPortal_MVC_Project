using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_MVC.Models
{

    public class checkboxlisthelper
    {
        public string value { get; set; }

        public string text { get; set; }

        public bool ischecked { get; set; }
    }
    public class EmployeeInsert
    {
        public List<checkboxlisthelper> myqual { get; set; }
        public string[] selectedqual { get; set; }



        [Required(ErrorMessage = "Enter the Name")]
        public string name { set; get; }


        [Range(18, 30, ErrorMessage = "Age must be between 18 and 30")]

        public int age { set; get; }

        public string address { set; get; }
        [Required(ErrorMessage = "Enter a valid number")]
        public string phone { set; get; }
        [Required(ErrorMessage = "Enter email address")]
        public string email { set; get; }


        public string skills { set; get; }

        public string experience { set; get; }

        public string qualification { set; get; }

        public string username { set; get; }

        public string password { set; get; }

        public string status { set; get; }
        public string msg { set; get; }



    }
}