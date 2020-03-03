using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AjaxPractice.Models;

namespace AjaxPractice.Concrete
{
    public class EFDBContext
    {
        public DbSet<EmpModel> Emps { get; set; }
    }
}