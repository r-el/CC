using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CaloriesCounter.Models
{
    // שכבת נתונים
    public class Dal
    {
        public class DAL : DbContext
        {
            private static DAL Data;
            // חיבור פרטי. גישה לדטאבייס מוגבלת 
            private DAL() : base("data source=localhost\\SQLEXPRESS;"
                                    + " initial catalog = Health;"
                                    + " user id = sa; password = 1234;")
            {
                // תמחק ותיצור את מסד הנתונים מחדש אם המודלים השתנו
                Database.SetInitializer<DAL>(new DropCreateDatabaseIfModelChanges<DAL>());

                // אם אין נתונים בדטאבייס, תוסיף נתונים
                if (Foods.Count() == 0) Seed();
            }

            // איפשור גישה לדטאבייס
            public static DAL Get
            {
                // תן גישה לדטאבייס
                // אם אין נתונים בדטאבייס תאתחל נתונים (ע"י Seed)
                get { if (Data == null) Data = new DAL(); return Data; }
            }

            // זריעה של נתונים לדטאבייס
            private void Seed()
            {
                Food food = new Food
                {
                    Name = "מים",
                    Calories = 0,
                    Carbs = 0,
                    Fat = 0,
                    Unit = "כוס"
                };
                TypeOfMeal typeOfMeal = new TypeOfMeal { Name = "ארוחת בוקר" };

                // הוספת נתונים למודלים
                Foods.Add(food);
                TypesOfMeals.Add(typeOfMeal);
                // שמירת נתונים בדטאבייס
                SaveChanges();
            }

            // יצירת טבלאות
            public DbSet<User> Users { get; set; }                  // משתמשים
            public DbSet<Plans> Plans { get; set; }                 // תוכניות
            public DbSet<Targets> Targets { get; set; }             // יעדים
            public DbSet<Food> Foods { get; set; }                  // מאכלים
            public DbSet<TypeOfMeal> TypesOfMeals { get; set; }     // סוג ארוחה
            public DbSet<FoodsInMeal> FoodsInMeal { get; set; }     // מאכלים בארוחה
            public DbSet<Meal> Meals { get; set; }                  // ארוחות

        }
    }
}
