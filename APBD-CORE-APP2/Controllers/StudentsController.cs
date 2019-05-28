using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD_CORE_APP2.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD_CORE_APP2.Controllers
{
    public class StudentsController : Controller
    {
        private readonly s16540Context _context;
        
        public StudentsController(s16540Context context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {


            var students =
                from student in _context.Student
                join studies in _context.Studies on student.IdStudies equals studies.IdStudies
                select new Student{FirstName= student.FirstName,LastName= student.LastName, Studies = new Studies { Name = studies.Name } };
            
            
           
            return View(students.ToList());
        }
        public IActionResult Create()
        {
            if (!ModelState.IsValid)
            {

            }
            return View();
        }
        public IActionResult Delete()
        {

            return View();
        }
    }
}