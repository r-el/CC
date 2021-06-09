using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.Models
{
    // מאכלים בארוחה
    public class FoodsInMeal
    {
        public FoodsInMeal() { }
        [Key]
        public int ID { get; set; }
        [Display(Name = "כמות")]
        public double Quantity { get; set; }            // כמות בגרם
        public TypeOfMeal TypeOfMeal { get; set; }      // סוג ארוחה
        public Meal Meal { get; set; }                  // שיוך לארוחה
        public Food Food { get; set; }                  // שיוך למאכל
        /* -------להוסיף מצב רוח ופעילות-------- */
    }
}
