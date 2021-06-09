using CaloriesCounter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.ViewModel
{
    public class VMNewMeal
    {
        public VMNewMeal() { }
        public Meal Meal { get; set; }
        public int TypeID { get; set; }
    }
}
