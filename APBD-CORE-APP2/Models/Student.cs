using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace APBD_CORE_APP2.Models
{
    public class Student
    {
       
        [Display(Name ="Imię")]
        public string FirstName { get; set; }
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Display(Name = "Kierunek")]
        public string StudyName { get; set; }
    }
}
