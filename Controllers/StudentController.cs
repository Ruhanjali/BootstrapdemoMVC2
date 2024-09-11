using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

using Bootstrapdemo.Models;

namespace Bootstrapdemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult WithoutViewModel()
        {
            Student sObj = new Student() { Rollno = 3, Name = "Priya" };
            Assesment aObj = new Assesment() { HindiMarks = 45, Englishmarks = 42, HistoryMarks = 40 };

            ViewBag.Sdetail = aObj; //passed by view bag

            return View(sObj); //strongly typed 
        }

        public ActionResult WithViewModel()
        {
            Student sObj = new Student() { Rollno = 3, Name = "Priya" };
            Assesment aObj = new Assesment() { HindiMarks = 45, Englishmarks = 42, HistoryMarks = 40 };

            Marksheet mobj = new Marksheet();
            mobj.MyStudent = sObj;
            mobj.MyAssesment = aObj;

            return View(mobj); 
        }

        public ActionResult Add()
        {
            return View();
        }

        //explicit validation
        [HttpPost]
        public ViewResult Add(Student obj)
        {
            if (!ModelState.IsValidField("Roll No"))
            {
                ModelState.AddModelError("Roll No", "Invalid Roll No");
            }

            if (string.IsNullOrEmpty(obj.Name))
            {
                ModelState.AddModelError("Name", "Name is Blank");
            }
            else
            {
                if (obj.Name.Length > 30)
                    ModelState.AddModelError("Name", "Name is too long");
            }

            Regex conRegx = new Regex(@"^\d{10}$");

            if (conRegx.IsMatch(obj.Contact))
                ModelState.AddModelError("contact", "invalid contact number");

            Regex emailRegx = new Regex(".+@.+");
            if (!emailRegx.IsMatch(obj.Email))
                ModelState.AddModelError("Email", "email is invalid");

            if (!ModelState.IsValidField("BirthDt"))
            {
                ModelState.AddModelError("BirthDt", "Invalid BirthDt");
            }

            if (ModelState.IsValid)
                return View("Success");
            else
            {
                ModelState.AddModelError("", "Invalid student Data");
                return View();
            }
        }
    }
}