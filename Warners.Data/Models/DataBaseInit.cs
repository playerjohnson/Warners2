using System;
using System.Collections.Generic;

namespace Warners.Data.Models
{
    public class DataBaseInit : System.Data.Entity.DropCreateDatabaseIfModelChanges<QAF>
    {
        protected override async void Seed(QAF context)
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
}