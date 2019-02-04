using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Warners.Data.Models;

namespace Warners.Data.Respository
{
    public class Respository : IRespository
    {
        public async Task<IEnumerable<FoodItem>> GetFoodItemsAsync()
        {
            using (var context = new QAF())
            {
                return await context.FoodItems.ToArrayAsync();
            }
        }

        public async Task<IEnumerable<Tester>> GetTestersAsync()
        {
            using (var context = new QAF())
            {
                return await context.Testers.ToArrayAsync();
            }
        }

        public async Task<Tester> GetTesterAsync(string userId)
        {
            using (var context = new QAF())
            {
                return await context.Testers.FirstOrDefaultAsync(x => x.UserId == userId);
            }
        }


        public async Task<Marks> AddScoreAsync(Marks testerGrade)
        {
            using (var context = new QAF())
            {
                context.Marks.Add(testerGrade);
                await context.SaveChangesAsync();
                return testerGrade;
            }
        }

        public async Task UpdateScoreAsync(Marks testerGrade)
        {
            using (var context = new QAF())
            {
                context.Marks.Attach(testerGrade);
                context.Entry(testerGrade).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Marks>> GetTesterGradesAsync(int testerId)
        {
            using (var context = new QAF())
            {
                return await context.Marks.Where(x => x.TesterId == testerId).ToListAsync();
            }
        }

        public async Task SeedDatabase()
        {
            using (var context = new QAF())
            {

                var foodItems = new List<FoodItem>
                {
                    new FoodItem{ Name = "Test", Description = "TestDescription", Price = 3, Ingredients = "TestIngredients", Allergy = "TestAllergies"}
                };

                foodItems.ForEach(s => context.FoodItems.Add(s));
                await context.SaveChangesAsync();

                var testers = new List<Tester>
                {
                    new Tester{ UserId = "32bdff18-fc6a-4e4e-b015-aec0cd80dc91" }
                };

                testers.ForEach(s => context.Testers.Add(s));
                await context.SaveChangesAsync();
            }
        }

        public async Task<Tester> SetTesterAysnc(Tester tester)
        {
            using (var context = new QAF())
            {
                context.Testers.Add(tester);
                await context.SaveChangesAsync();
                return tester;
            }
        }
    }
}
