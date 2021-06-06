using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.Models
{
    // יעדים
    public class Targets
    {
        public Targets() { }

        [Key]
        public int ID { get; set; }

        [Display(Name = "משקל")]
        public decimal Weight { get; set; }     // משקל
        [Display(Name = "תאריך")]
        public DateTime Date { get; set; }      // תאריך

        [Display(Name = "קלוריות")]
        public int Calories { get; set; }       // קלוריות
        [Display(Name = "פחמימות")]
        public int Carbs { get; set; }          // פחמימות
        [Display(Name = "שומנים")]
        public int Fat { get; set; }            // שומנים
        [Display(Name = "חלבונים")]
        public int Protein { get; set; }        // חלבונים
        [Display(Name = "נתרן")]
        public int Sodium { get; set; }         // נתרן
        [Display(Name = "סוכרים")]
        public int Sugar { get; set; }          // סוכרים
    }
}
