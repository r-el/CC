using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.Models
{
    // משתמש
    public class User
    {
        public User() { }
        [Key]
        public int ID { get; set; }

        [Display(Name = "שם פרטי")]
        public string FirstName { get; set; }       // שם פרטי

        [Display(Name = "שם משפחה")]
        public string LastName { get; set; }        // משפחה

        [Display(Name = "תאריך לידה")]
        [DataType(DataType.Date)]
        public DateTime BirthOfDate { get; set; }   // תאריך לידה
    }
}
