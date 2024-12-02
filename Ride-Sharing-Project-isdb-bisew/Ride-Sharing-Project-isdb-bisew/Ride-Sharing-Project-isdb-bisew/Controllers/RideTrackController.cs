using Microsoft.AspNetCore.Mvc;
using Ride_Sharing_Project_isdb_bisew.Models;
using Ride_Sharing_Project_isdb_bisew.Models.ViewModel;

namespace Ride_Sharing_Project_isdb_bisew.Controllers
{
    public class RideTrackController : Controller
    {
        public IActionResult Index()
        {
            return PartialView("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return PartialView("Create");
        }
        [HttpPost]
        public IActionResult Create(RideTrackVm rideTrackVm)
        {
            return View("Create");
        }
    }
}
