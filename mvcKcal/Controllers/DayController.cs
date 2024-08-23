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
