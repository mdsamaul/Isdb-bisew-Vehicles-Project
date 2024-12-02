using Microsoft.AspNetCore.Mvc;
using Ride_Sharing_Project_isdb_bisew.Models;
using Ride_Sharing_Project_isdb_bisew.Models.ViewModel;

namespace Ride_Sharing_Project_isdb_bisew.Controllers
{
    public class CustomerController : Controller
    {
        private readonly VichecleDbContext db;

        public CustomerController(VichecleDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return PartialView("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CustomerVm customerVm)
        {
            if (ModelState.IsValid)
            {
                // ডাটাবেসে ডাটা সংরক্ষণের কোড (e.g., DbContext.SaveChanges())

                // সফলতার পর Dashboard-এ রিডিরেক্ট করা
                return RedirectToAction("Dashboard");
            }

            return View(customerVm); // যদি ModelState সঠিক না হয় তবে পুনরায় ফর্ম দেখাবে।
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            return PartialView("Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CustomerVm customerVm)
        {
            if (ModelState.IsValid)
            {
                // ডাটাবেসে আপডেট করার কোড
                var c = new Customer()
                {
                    CustomerName = customerVm.CustomerName,
                    Email=customerVm.Email,

                };
                db.Customers.Add(c);
                //return RedirectToAction("/");
            }

            return View("Edit", customerVm); // ভুল থাকলে আবার ফর্ম দেখাবে।
        }

        // Dashboard Action
        [HttpGet]
        public IActionResult Dashboard()
        {
            return View(); // Dashboard এর জন্য একটি View তৈরি করতে হবে।
        }
    }
}
