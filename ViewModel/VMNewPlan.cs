using CaloriesCounter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.ViewModel
{
    public class VMNewPlan
    {
        // אתחול ארוחות
        public VMNewPlan() { Meals = new List<VMNewMeal>(); }

        public User User { get; set; }                   // נתוני משתמש

        public int UserID { get; set; }                  // שיוך של התוכנית ליוזר כשהוא חוזר מהוויו

        public List<Food> Foods { get; set; }            // מאכלים

        public List<TypeOfMeal> Types { get; set; }      // סוגי ארוחות

        public List<VMNewMeal> Meals { get; set; }       // ליסט ארוחות

        public VMNewMeal Meal { get; set; }              // ארוחה
    }
}
