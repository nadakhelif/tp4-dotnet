using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication4.Models;
using WebApplication4.Data;

namespace WebApplication4.Controllers
{
	public class StudentController : Controller
	{
		

		public IActionResult Index()
		{
			

			StudentRepository studentRepository = new StudentRepository();
			List<Student> l = studentRepository.all();
			ViewData["studentsList"] = l;

			return View();
		}

		public IActionResult Courses()
		{
            StudentRepository studentRepository = new StudentRepository();
			List<string> l = studentRepository.UniqueCourses();
            ViewData["CoursesList"] = l;
			return View();
		}

        public IActionResult ByCourse(string course)
        {
            StudentRepository studentRepository = new StudentRepository();
            List<Student> l = studentRepository.StudentsByCourse(course);
			ViewData["course"] = course;
            ViewData["StudentsList"] = l;
            return View();
        }

        

		
	}
}