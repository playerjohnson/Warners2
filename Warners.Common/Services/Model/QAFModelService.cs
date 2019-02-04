using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Warners.Data;
using Warners.Data.Models;
using Warners.Data.Respository;

namespace Warners.Common.Services.Model
{
    public class QAFModelService : IQAFModelService
    {
        private IRespository _repository;

        public QAFModelService(IRespository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<FoodItem>> GetFoodItems()
        {
            return await _repository.GetFoodItemsAsync();
        }

        public async Task<IEnumerable<Tester>> GetTestersAsync()
        {
            return await _repository.GetTestersAsync();
        }

        public async Task<Tester> GetTesterAsync(string userID)
        {
            return await _repository.GetTesterAsync(userID);
        }

        public async Task<Marks> AddScoreAsync(Marks testerGrade)
        {
            return await _repository.AddScoreAsync(testerGrade);
        }

        public async Task UpdateScoreAsync(Marks testerGrade)
        {
            await _repository.UpdateScoreAsync(testerGrade);
        }

        public async Task<IEnumerable<Marks>> GetTesterGradesAsync(int testerId)
        {
            return await _repository.GetTesterGradesAsync(testerId);
        }

        public async Task SeedDatabase()
        {
            await _repository.SeedDatabase();
        }

        public async Task<Tester> SetTesterAsync(Tester tester)
        {
            return await _repository.SetTesterAysnc(tester);
        }
    }
}
