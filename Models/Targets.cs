using c_c.Models;
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
        public Targets() { Meals = new List<Meal>(); }
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

        public List<Meal> Meals { get; set; }   // ארוחות
        public Plans Plan { get; set; }         // שיוך לתכנית


        // חישוב סך כל הקלוריות של כל הארוחות ביום
        public int SumCaloriesByDate(DateTime date)
        {
            int sum = 0;
            foreach (Meal meal in Meals)
            {
                if (meal.Date.ToShortDateString() == date.ToShortDateString())
                    sum += meal.SumCalories;
            }
            return sum;
        }

        // חישוב סך כל הקלוריות של כל הארוחות בתכנית
        public int SumCalories
        {
            get
            {
                int sum = 0;
                foreach (Meal meal in Meals)
                {
                    sum += meal.SumCalories;
                }
                return sum;
            }
        }

        // הוספת ארוחה ליעדים
        public void AddMeal(Meal meal)
        {
            Meals.Add(meal);
            meal.Target = this;
        }
        // יצירת ארוחה והכנסתה ליעדים
        public void AddMeal(List<Food> foods, DateTime date, TypeOfMeal typeOfMeal)
        {
            Meal meal = new Meal {Date=date, TypeOfMeal=typeOfMeal};
            meal.AddFoods(foods);
            AddMeal(meal);
        }
    }
}
