using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warners.Data;
using Warners.Data.Models;

namespace Warners.Common.Services.Model
{
    public interface IQAFModelService
    {
        Task<IEnumerable<Tester>> GetTestersAsync();
        Task<Tester> GetTesterAsync(string userId);
        Task<IEnumerable<FoodItem>> GetFoodItems();
        Task<Marks> AddScoreAsync(Marks testerGrade);
        Task UpdateScoreAsync(Marks testerGrade);
        Task<IEnumerable<Marks>> GetTesterGradesAsync(int testerId);
        Task SeedDatabase();
        Task<Tester> SetTesterAsync(Tester tester);
    }
}
