using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.Models
{
    public class DailyEating
    {
        // אתחול רשימת המאכלים
        public DailyEating() { DailyFoods = new List<DailyFoods>(); }
        [Key]
        public int ID { get; set; }

        // רשימת מאכלים שנאכלו היום
        public List<DailyFoods> DailyFoods { get; set; }

        // תאריך
        [Display(Name = "תאריך")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        // הוספת מאכל
        public void AddDailyFood(Food food)
        {
            DailyFoods.Add(new DailyFoods() { Food = food, Quantity = 1, DailyEating = this });
        }

        // הוספת מאכל
        public void AddDailyFood(Food food, double quantity)
        {
            DailyFoods.Add(new DailyFoods() { Food = food, Quantity = quantity, DailyEating = this });
        }

        // חישוב קלוריות יומית
        public int SumCalories
        {
            get
            {
                int sum = 0;
                foreach (DailyFoods dailyFood in DailyFoods)
                {
                    sum += dailyFood.Food.Calories * (int)dailyFood.Quantity;
                }
                return sum;
            }
        }
    }
}
