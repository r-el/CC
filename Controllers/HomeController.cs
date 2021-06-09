using CaloriesCounter.Models;
using CaloriesCounter.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static CaloriesCounter.Models.Dal;

namespace CaloriesCounter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DAL.Get.Foods.ToList();
            return View();
        }

        // משתמש חדש
        public IActionResult NewUser()
        {
            VMUser vmuser = new VMUser();
            return View(vmuser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewUser(VMUser vmuser)
        {
            DAL.Get.Users.Add(vmuser.User);
            vmuser.User.AddWeight(vmuser.Weight);
            DAL.Get.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // דף כניסה
        public IActionResult Connect()
        {
            VMUser user = new VMUser();
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Connect(VMUser vmuser)
        {
            // תמצא את המשתמש ע"י שם משתמש וסיסמא
            List<User> users = (from u in DAL.Get.Users
                                where (u.Email == vmuser.User.Email) && (u.Password == vmuser.User.Password)
                                select u).ToList<User>();
            if (users != null)
            {
                User user = new User();
                foreach (User u in users)
                {
                    user = u;
                }
                return RedirectToAction("NewPlan, user");
            }
            return View(vmuser);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
