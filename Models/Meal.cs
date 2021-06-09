using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.Models
{
    // ארוחה
    public class Meal
    {
        public Meal() { Foods = new List<FoodsInMeal>(); }
        [Key]
        public int ID { get; set; }
        [Display(Name = "תאריך")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }             // תאריך
        public TypeOfMeal TypeOfMeal { get; set; }     // סוג הארוחה
        public List<FoodsInMeal> Foods { get; set; }   // מאכלים בארוחה
        public Targets Target { get; set; }            // שיוך הארוחה ליעדים

        // הוספת כמה מאכלים לארוחה
        public void AddFoods(List<Food> foods)
        {
            foreach (Food food in foods)
            {
                AddFood(food, 1); // הכנס כל מאכל לרשימה עם כמות של 100 גרם לכל מאכל
            }
        }
        // הוספת מאכל יחיד לארוחה
        public void AddFood(Food food, double? quantity )
        {
            double myQuantity = 1;
            if (quantity != null)
                myQuantity = quantity.Value;
            Foods.Add(new FoodsInMeal() { Food=food, Meal=this, Quantity=myQuantity  } );
        }
    }
}
