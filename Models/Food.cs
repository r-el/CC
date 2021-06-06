using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.Models
{
    // מאכל
    public class Food
    {
        public Food() { }
        [Key]
        public int ID { get; set; }
        [Display(Name = "שם מאכל")]
        public string Name { get; set; }        // שם מאכל
        [Display(Name = "יחידה")]
        public string Unit { get; set; }        // יחידה

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
