using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warners.Data.Models;

namespace Warners.Data.Respository
{
    public interface IRespository
    {
        Task<IEnumerable<Tester>> GetTestersAsync();
        Task<Tester> GetTesterAsync(string userId);
        Task<IEnumerable<FoodItem>> GetFoodItemsAsync();
        Task<Marks> AddScoreAsync(Marks testerGrade);
        Task UpdateScoreAsync(Marks testerGrade);
        Task<IEnumerable<Marks>> GetTesterGradesAsync(int testerId);
        Task SeedDatabase();
        Task<Tester> SetTesterAysnc(Tester tester);
    }
}
