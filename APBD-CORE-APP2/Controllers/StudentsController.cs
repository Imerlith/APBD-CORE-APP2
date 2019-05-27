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
           
          
            var students = _context.Student.ToList();
            //var students = new List<Student>
            //{
            //    new Student { FirstName = "Jan", LastName="Kowalski",StudyName="Informatyka"},
            //    new Student { FirstName = "Jan", LastName="Pat 2",StudyName="Teologia"},
            //    new Student { FirstName = "Jakub", LastName="Dzieciątko",StudyName="Hentai"},
            //    new Student { FirstName = "Paweł", LastName="Kalbarczyk",StudyName="Informatyka"},
            //    new Student { FirstName = "Przemek", LastName="Gołębski",StudyName="Informatyka"},
            //    new Student { FirstName = "Adam", LastName="Nowak",StudyName="Sztuka nowych mediów"}
            //};
            //students.OrderBy(s => s.LastName);
            return View(students);
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