using Microsoft.AspNetCore.Mvc;
using Ride_Sharing_Project_isdb_bisew.Models.ViewModel;

namespace Ride_Sharing_Project_isdb_bisew.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return PartialView("Create");
        }
        [HttpPost]
        public IActionResult Create(CustomerVm customerVm)
        {
          
                return View("Create");
          

            // সফলভাবে ডাটা প্রসেস করা হলে রেসপন্স রিটার্ন করুন
           
        }
    }
}
