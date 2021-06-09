using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.Models
{
    public class DailyFoods
    {
        public DailyFoods() { }

        [Key]
        public int ID { get; set; }

        // שיוך לארוחה
        public DailyEating DailyEating { get; set; }

        // שיוך למאכל
        public Food Food { get; set; }

        // כמות בגרם
        public double Quantity { get; set; }
    }
}
