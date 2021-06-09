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
        [Display(Name = "משפחה")]
        public string LastName { get; set; }
        [Display(Name = "תאריך לידה")]
        [DataType(DataType.Date)]
        public DateTime BirthOfDate { get; set; }
        [Display(Name = "מייל")]
        [EmailAddress(ErrorMessage = "נא להכניס כתובת נכונה")]
        [Required(ErrorMessage = "שדה חובה")]
        public string Email { get; set; }
        [Display(Name = "סיסמא")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "שדה חובה")]
        public string Password { get; set; }

        public List<Weights> Weights { get; set; }  // משקלים 
        public List<Plans> Plans { get; set; }      // תוכניות
        public List<Meal> Meals { get; set; }       // רשימת ארוחות

        // שם מלא
        public string FullName { get { if (string.IsNullOrEmpty(FirstName)) return ""; return FirstName + " " + LastName; } }

        // הוספת משקל חדש
        public void AddWeight(decimal weight)
        {
            Weights.Add(new Weights { Weight = weight, User = this });
        }
    }
}
