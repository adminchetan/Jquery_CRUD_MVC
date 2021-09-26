using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jquery_CRUD_MVC.Models;

namespace Jquery_CRUD_MVC.Controllers
{


    public class AjaxController : Controller
    {
        GitExamplesEntities db = new GitExamplesEntities();

        public ActionResult GetRecords()
        {

            
            try
            {

                var employees = db.sp_GetAllEmployee().ToList();

                return Json(
                new
                {
                    data = (from obj in employees
                            select new
                            {
                                Uid = obj.ID,
                                mobileNo = obj.MobileNo,
                                Name = obj.UserName,
                                Designation = obj.UserRole,

                            })
                }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Auth");
            }


        }
    }
}