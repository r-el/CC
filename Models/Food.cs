using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.Models
{
    public class Food
    {
        public Food() { }
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }        // שם מאכל
        public string Unit { get; set; }        // יחידה

        public int Calories { get; set; }       // קלוריות
        public int Carbs { get; set; }          // פחמימות
        public int Fat { get; set; }            // שומנים
        public int Protein { get; set; }        // חלבונים
        public int Sodium { get; set; }         // נתרן
        public int Sugar { get; set; }          // סוכרים
    }
}
