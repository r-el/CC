using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CaloriesCounter.Models;

namespace c_c.Models
{
    public class Plans
    {
        public Plans() { Targets = new List<Targets>(); }
        [Key]
        public int ID { get; set; }
        public User User { get; set; }              // שיוך ליוזר
        public DateTime Date { get; set; }          // תאריך
        public List<Targets> Targets { get; set; }  // יעדים

        // הוספת כמה תוכניות
        public void AddTargets(DateTime Date, List<Targets> targets)
        {


        }
        public void AddTargets(List<Targets> targets)
        {

        }
        // הוספת תוכנית אחת
        public void AddTarget(Targets Target)
        {

        }
    }
}