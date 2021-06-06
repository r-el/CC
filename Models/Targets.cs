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

        public decimal Weight { get; set; }     // משקל
        public DateTime Date { get; set; }      // תאריך

        public int Calories { get; set; }       // קלוריות
        public int Carbs { get; set; }          // פחמימות
        public int Fat { get; set; }            // שומנים
        public int Protein { get; set; }        // חלבונים
        public int Sodium { get; set; }         // נתרן
        public int Sugar { get; set; }          // סוכרים
    }
}
