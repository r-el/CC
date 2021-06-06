using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.Models
{
    // סוג הארוחה 
    public class TypeOfMeal
    {
        public TypeOfMeal() { }
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } // שם הארוחה
    }
}
