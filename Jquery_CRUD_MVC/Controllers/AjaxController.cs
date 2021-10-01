using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jquery_CRUD_MVC.Models;
using Newtonsoft.Json;

namespace Jquery_CRUD_MVC.Controllers
{


    public class AjaxController : Controller
    {
        GitExamplesEntities db = new GitExamplesEntities();

        public JsonResult addDataToMain(string name, string mobile)
        {
            try
            {
                SqlParameter param = new SqlParameter("@name",name); 
                SqlParameter param1 = new SqlParameter("@mobile",mobile);
               var data= db.Database.ExecuteSqlCommand("sp_AddTomain @name, @mobile",param,param1);         //data means no of affected rows


                return Json(new {success=true }, JsonRequestBehavior.AllowGet);


            }

            catch (Exception ex)
            {
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            }
           
        }

        public JsonResult disable(int id)
        {
            try
            {
                SqlParameter param = new SqlParameter("@id", id);
              
                var data = db.Database.ExecuteSqlCommand("sp_AlterDeactiveEmployee @id", param);         //data means no of affected rows

                 return Json(new { success = true }, JsonRequestBehavior.AllowGet);


            }

            catch (Exception ex)
            {
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            }

        }


        public JsonResult enable(int id)
        {
            try
            {
                SqlParameter param = new SqlParameter("@id", id);
              
                var data = db.Database.ExecuteSqlCommand("sp_AlterEnableEmployee @id", param);         //data means no of affected rows

                 return Json(new { success = true }, JsonRequestBehavior.AllowGet);


            }

            catch (Exception ex)
            {
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            }

        }


        public ActionResult GetRecords()
        {          
            try
            {
                var employees = db.sp_GetAllEmployee().ToList();
                var data = (from obj in employees
                            select new
                            {
                                Uid = obj.ID,
                                mobileNo = obj.MobileNo,
                                Name = obj.UserName,
                                Designation = obj.UserRole,
                                active =obj.IsActive,
                                role=obj.UserRole               
                            });

                var Jsonserialdata = JsonConvert.SerializeObject(data);


                return Json(Jsonserialdata , JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Auth");
            }


        }
    }
}