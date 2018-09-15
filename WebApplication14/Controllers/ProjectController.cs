using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class ProjectController : Controller
    {
        private ProjectContext ORM = null;
        public ProjectController(ProjectContext ORM)
        {
            this.ORM = ORM;
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student s)
        {
            ORM.Add(s);
            ORM.SaveChanges();
            ViewBag.Message = "Registration Done Successfully";
            ModelState.Clear();
            return View();
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}