//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_MVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application_Tab
    {
        public int Application_Id { get; set; }
        public int Job_Id { get; set; }
        public int Employee_Id { get; set; }
        public int Company_Id { get; set; }
        public System.DateTime Date { get; set; }
        public byte[] Resume { get; set; }
    
        public virtual CompanyReg CompanyReg { get; set; }
        public virtual EmployeeReg EmployeeReg { get; set; }
        public virtual JobTab JobTab { get; set; }
    }
}
