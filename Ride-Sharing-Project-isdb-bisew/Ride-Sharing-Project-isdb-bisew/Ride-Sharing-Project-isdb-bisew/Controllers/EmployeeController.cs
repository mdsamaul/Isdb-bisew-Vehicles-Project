using Microsoft.AspNetCore.Mvc;
using Ride_Sharing_Project_isdb_bisew.Models.ViewModel;

namespace Ride_Sharing_Project_isdb_bisew.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return PartialView("Create");
        }
        [HttpPost]
        public IActionResult Create(EmployeeVm employeeVm)
        {
            return View("Create");
        }
    }
}
