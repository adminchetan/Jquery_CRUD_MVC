using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jquery_CRUD_MVC.Models
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }
        public int UserRole { get; set; }
        public string UserName { get; set; }
        public string MobileNo { get; set; }
        public bool IsActive { get; set; }
        public virtual UserRole UserRole1 { get; set; }


        /*Local Property*/
         public string userRoleName { get; set; }
    }
}