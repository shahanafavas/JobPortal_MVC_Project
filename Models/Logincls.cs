using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_MVC.Models
{
    public class Logincls
    {
        [Required(ErrorMessage ="Enter the username")]
        public string uname { set; get; }
        [Required(ErrorMessage ="enter the password")]
        public string password { set; get; }

        public string utype { set; get; }

        public string msg { set; get; }
    }
}