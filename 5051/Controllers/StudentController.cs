using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5051.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string id=null)
        {
            var myStudentID = "";
            if (!string.IsNullOrEmpty(id))
            {
                myStudentID = id;
            }
            ViewBag.StudentID = myStudentID;

            ViewBag.Message = "Your application description page.";
            return View();
        }
    }
}