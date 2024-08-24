using Microsoft.AspNetCore.Mvc;

namespace mvcKcal.Controllers
{
    public class DayController : Controller
    {
        public IActionResult Index()
        {
            List<Day> days = DayService.GetAll();
            List<DayViewModel> dayVMs = new List<DayViewModel>();
            foreach (Day day in days)
            {
                dayVMs.Add(DayService.DayToVM(day));
            }
            return View(dayVMs);
        }

        public IActionResult Detail(int id)
        {
            return View(DayService.DayToVM(DayService.Get(id)));
        }

        public IActionResult Create()
        {
            DayAndRecipeViewModel dayAndRecipeVM = new DayAndRecipeViewModel
            {
                Day = new Day(),
                Recipes = RecipeService.GetAll(),
            };
            return View(dayAndRecipeVM);
        }

        [HttpPost]
        public IActionResult Create(Day day, List<int> recipeIds)
        {
            Console.WriteLine(day.Id);
            foreach (int recipeId in day.RecipeIds)
            {
                Console.WriteLine(recipeId);
            }
            Console.WriteLine(day.Name);
            DayService.Create(day);
            return RedirectToAction("Index");
        }

        public IActionResult Test()
        {
            DayService.Create(new Day
            {
                Id = 0,
                Name = "d1",
                RecipeIds = new List<int> { 0 }
            });
            return RedirectToAction("Index");
        }
    }
}
