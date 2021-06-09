using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.Models
{
    // משקלים
    public class Weights
    {
        public Weights() { Date = DateTime.Now; }// תאריך של ההוספה
        [Key]
        public int ID { get; set; }
        public User User { get; set; }          // שיוך ליוזר
        public decimal Weight { get; set; }     // משקל
        [Display(Name = "תאריך משקל")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }      // זמן עדכון המשקל
    }
}
