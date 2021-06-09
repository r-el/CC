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
        public User() { Weights = new List<Weights>(); BirthOfDate = DateTime.Now.AddYears(-20); }

        [Key]
        public int ID { get; set; }
        [Display(Name = "שם פרטי")]
        public string FirstName { get; set; } 
        [Display(Name = "שם משפחה")]
        public string LastName { get; set; }
        [Display(Name = "תאריך לידה")]
        [DataType(DataType.Date)]
        public DateTime BirthOfDate { get; set; }
        public List<Weights> Weights { get; set; }  // משקלים 

        public List<Targets> Targets { get; set; }  // יעדים
        public List<Meal> Meals { get; set; }       // רשימת ארוחות

        // הוספת משקל חדש
        public void AddWeight(decimal weight)
        {
            Weights.Add(new Weights { Weight = weight, User = this });
        }
    }
}
