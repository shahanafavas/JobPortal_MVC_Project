using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_MVC.Models
{
    public class CompanyInsert
    {

        [Required(ErrorMessage = "Enter the name")]
        public string name { set; get; }
        [Required(ErrorMessage = "Enter the Address")]
        public string address { get; set; }

        [Required(ErrorMessage = "Enter Phone number")]
        [RegularExpression(@"^(\d{10})$",ErrorMessage ="enter valid number")]
        public string phone { get; set; }

        public string email { get; set; }
        public string username { get; set; }

        public string pass { get; set; }
        [Compare("pass", ErrorMessage = "password mismatch")]
        public string cpassword { get; set; }

        public string status { get; set; }

        public string msg { get; set; }
    }
}
