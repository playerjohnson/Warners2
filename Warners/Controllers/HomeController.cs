using AutoMapper;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Warners.Common.Serialization;
using Warners.Common.Services.Cache;
using Warners.Common.Services.Model;
using Warners.Common.Services.Session;
using Warners.Data;
using Warners.Data.Models;
using Warners.Models;

namespace Warners.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ICacheService cacheService, ISessionService sessionService, IQAFModelService modelService, ISerializer serializer) : base(cacheService, sessionService, modelService, serializer)
        {
        }

        public ActionResult Index()
        {
            //await _modelService.SeedDatabase();
            
            ViewBag.Message = "Login Page";

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Grade");
            }

            return View("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Grade()
        {
            var foodItems = await _modelService.GetFoodItems();

            var viewModel = new GradeViewModel
            {
                FoodItems = Mapper.Map<IEnumerable<FoodItem>, IEnumerable<SelectListItem>>(foodItems)
            };

            return View("Grade", viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Score(GradeViewModel gradeViewModel)
        {
            var userId = User.Identity.GetUserId();
            var tester = await _modelService.GetTesterAsync(userId);
            if (tester == null)
            {
                tester = await _modelService.SetTesterAsync(new Tester() { UserId = userId });
            }

            var testerGrade = new Marks
            {
                FoodItemId = gradeViewModel.SelectedFoodId,
                TesterId = tester.ID,
                Grade = await _serializer.SerializeAsync(gradeViewModel.Grade)
            };

            await _modelService.AddScoreAsync(testerGrade);

            return RedirectToAction("Results");
        }

        public async Task<ActionResult> Results()
        {
            var userId = User.Identity.GetUserId();
            var tester = await _modelService.GetTesterAsync(userId);
            if (tester == null)
            {
                tester = await _modelService.SetTesterAsync(new Tester() { UserId = userId });
            }
            var marks = await _modelService.GetTesterGradesAsync(tester.ID);
            var foodItems = await _modelService.GetFoodItems();

            var markedFoodItems = new List<FoodItem>();
            marks.ToList().ForEach(s => markedFoodItems.Add(foodItems.FirstOrDefault(x => x.ID == s.FoodItemId)));

            var gradedItems = new List<GradedItemModel>();
            markedFoodItems.ForEach(x => gradedItems.Add(new GradedItemModel(x, _serializer.DeserializeAsync<Grade>(marks.FirstOrDefault(s => s.FoodItemId == x.ID).Grade).GetAwaiter().GetResult())));

            var viewModel = new ResultsViewModel
            {
                GradedFoodItems = gradedItems
            };

            return View("Results", viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}