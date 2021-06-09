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

        // הוספת מספר תוכניות
        public void AddTargets(DateTime dateOfFirstTargets, List<Targets> targets)
        {
            // הכנסת היעדים כשבוע
            foreach (Targets target in targets)
            {
                target.Date = dateOfFirstTargets;
                dateOfFirstTargets = dateOfFirstTargets.AddDays(7);
            }
            AddTargets(targets);
        }
        public void AddTargets(List<Targets> targets)
        {
            foreach (Targets target in targets)
            {
                AddTarget(target);
            }
        }
        // הוספת תוכנית אחת
        public void AddTarget(Targets target)
        {
            Targets.Add(target);
            target.Plan = this;
        }
    }
}