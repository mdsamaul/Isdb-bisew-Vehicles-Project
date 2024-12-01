using Microsoft.AspNetCore.Mvc;

namespace Ride_Sharing_Project_isdb_bisew.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult WebsiteTraffic()
        {
            return PartialView("_WebsiteTraffic");  // Return the partial view
        }

        public IActionResult Settings()
        {
            return PartialView("_Settings");  // Return the partial view
        }

        public IActionResult Password()
        {
            return PartialView("_Password");  // Return the partial view
        }
    }
}
