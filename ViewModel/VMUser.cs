using CaloriesCounter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.ViewModel
{
    // כדי לאפשר למשתמש להכניס משקל בפעם הראשונה
    public class VMUser
    {
        public VMUser() { User = new User(); }

        public User User { get; set; }          // משתמש
        [Display(Name = "תאריך משקל")]
        [DataType(DataType.Date)]
        public decimal Weight { get; set; }     // משקל
    }
}
