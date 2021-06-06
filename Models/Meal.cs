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
        public User User { get; set; }                 // משתמש
        public TypeOfMeal TypeOfMeal { get; set; }     // סוג הארוחה
        public List<FoodsInMeal> Foods { get; set; }   // מאכלים בארוחה
    }
}
