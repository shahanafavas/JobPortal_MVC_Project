﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MVC_Project_LaEntities1 : DbContext
    {
        public MVC_Project_LaEntities1()
            : base("name=MVC_Project_LaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Application_Tab> Application_Tab { get; set; }
        public virtual DbSet<CompanyReg> CompanyRegs { get; set; }
        public virtual DbSet<EmployeeReg> EmployeeRegs { get; set; }
        public virtual DbSet<JobTab> JobTabs { get; set; }
        public virtual DbSet<LoginTab> LoginTabs { get; set; }
    
        public virtual int sp_addjob(Nullable<int> compid, string jobtitle, Nullable<int> vacancies, Nullable<int> salary, string status)
        {
            var compidParameter = compid.HasValue ?
                new ObjectParameter("compid", compid) :
                new ObjectParameter("compid", typeof(int));
    
            var jobtitleParameter = jobtitle != null ?
                new ObjectParameter("jobtitle", jobtitle) :
                new ObjectParameter("jobtitle", typeof(string));
    
            var vacanciesParameter = vacancies.HasValue ?
                new ObjectParameter("vacancies", vacancies) :
                new ObjectParameter("vacancies", typeof(int));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(int));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_addjob", compidParameter, jobtitleParameter, vacanciesParameter, salaryParameter, statusParameter);
        }
    
        public virtual int sp_applyJob(Nullable<int> jobid, Nullable<int> empid, Nullable<int> cmpid, Nullable<System.DateTime> date, byte[] resume)
        {
            var jobidParameter = jobid.HasValue ?
                new ObjectParameter("jobid", jobid) :
                new ObjectParameter("jobid", typeof(int));
    
            var empidParameter = empid.HasValue ?
                new ObjectParameter("empid", empid) :
                new ObjectParameter("empid", typeof(int));
    
            var cmpidParameter = cmpid.HasValue ?
                new ObjectParameter("cmpid", cmpid) :
                new ObjectParameter("cmpid", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var resumeParameter = resume != null ?
                new ObjectParameter("resume", resume) :
                new ObjectParameter("resume", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_applyJob", jobidParameter, empidParameter, cmpidParameter, dateParameter, resumeParameter);
        }
    
        public virtual int sp_check1(string qry)
        {
            var qryParameter = qry != null ?
                new ObjectParameter("qry", qry) :
                new ObjectParameter("qry", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_check1", qryParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_cmpId(string una, string pwd)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_cmpId", unaParameter, pwdParameter);
        }
    
        public virtual int sp_CompanyRegi(Nullable<int> cid, string cname, string caddr, string cphone, string cemail, string cstatus)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var cnameParameter = cname != null ?
                new ObjectParameter("cname", cname) :
                new ObjectParameter("cname", typeof(string));
    
            var caddrParameter = caddr != null ?
                new ObjectParameter("caddr", caddr) :
                new ObjectParameter("caddr", typeof(string));
    
            var cphoneParameter = cphone != null ?
                new ObjectParameter("cphone", cphone) :
                new ObjectParameter("cphone", typeof(string));
    
            var cemailParameter = cemail != null ?
                new ObjectParameter("cemail", cemail) :
                new ObjectParameter("cemail", typeof(string));
    
            var cstatusParameter = cstatus != null ?
                new ObjectParameter("cstatus", cstatus) :
                new ObjectParameter("cstatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CompanyRegi", cidParameter, cnameParameter, caddrParameter, cphoneParameter, cemailParameter, cstatusParameter);
        }
    
        public virtual ObjectResult<sp_displayall_Result> sp_displayall()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_displayall_Result>("sp_displayall");
        }
    
        public virtual int sp_employeReg(Nullable<int> eid, string ename, Nullable<int> eage, string eaddr, string ephn, string eemail, string equal, string eskill, string eexper, string estatus)
        {
            var eidParameter = eid.HasValue ?
                new ObjectParameter("eid", eid) :
                new ObjectParameter("eid", typeof(int));
    
            var enameParameter = ename != null ?
                new ObjectParameter("ename", ename) :
                new ObjectParameter("ename", typeof(string));
    
            var eageParameter = eage.HasValue ?
                new ObjectParameter("eage", eage) :
                new ObjectParameter("eage", typeof(int));
    
            var eaddrParameter = eaddr != null ?
                new ObjectParameter("eaddr", eaddr) :
                new ObjectParameter("eaddr", typeof(string));
    
            var ephnParameter = ephn != null ?
                new ObjectParameter("ephn", ephn) :
                new ObjectParameter("ephn", typeof(string));
    
            var eemailParameter = eemail != null ?
                new ObjectParameter("eemail", eemail) :
                new ObjectParameter("eemail", typeof(string));
    
            var equalParameter = equal != null ?
                new ObjectParameter("equal", equal) :
                new ObjectParameter("equal", typeof(string));
    
            var eskillParameter = eskill != null ?
                new ObjectParameter("eskill", eskill) :
                new ObjectParameter("eskill", typeof(string));
    
            var eexperParameter = eexper != null ?
                new ObjectParameter("eexper", eexper) :
                new ObjectParameter("eexper", typeof(string));
    
            var estatusParameter = estatus != null ?
                new ObjectParameter("estatus", estatus) :
                new ObjectParameter("estatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_employeReg", eidParameter, enameParameter, eageParameter, eaddrParameter, ephnParameter, eemailParameter, equalParameter, eskillParameter, eexperParameter, estatusParameter);
        }
    
        public virtual int sp_login(string una, string pwd, ObjectParameter status)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_login", unaParameter, pwdParameter, status);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_loginId(string una, string pwd)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_loginId", unaParameter, pwdParameter);
        }
    
        public virtual int sp_loginIsert(Nullable<int> rid, string una, string pasw, string utype, string status)
        {
            var ridParameter = rid.HasValue ?
                new ObjectParameter("rid", rid) :
                new ObjectParameter("rid", typeof(int));
    
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var paswParameter = pasw != null ?
                new ObjectParameter("pasw", pasw) :
                new ObjectParameter("pasw", typeof(string));
    
            var utypeParameter = utype != null ?
                new ObjectParameter("utype", utype) :
                new ObjectParameter("utype", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_loginIsert", ridParameter, unaParameter, paswParameter, utypeParameter, statusParameter);
        }
    
        public virtual ObjectResult<string> sp_loginType(string una, string pwd)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_loginType", unaParameter, pwdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_maxIdLogin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_maxIdLogin");
        }
    }
}