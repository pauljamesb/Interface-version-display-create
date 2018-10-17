using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DOA.Services;
using DOA.Models;
using DOA.Data;
using Microsoft.EntityFrameworkCore;

namespace DOA.Controllers
{
    public class DOAController : Controller
    {


       
        private readonly IDayService _dayService;
        public DOAController(IDayService dayService)
        {
            _dayService = dayService;
        }
       


        /*

        private readonly ApplicationDbContext _db;
        public DOAController(ApplicationDbContext db)
        {
            _db = db;
        }

         */


        public async Task<IActionResult> Index()
        {
            var myDays = await _dayService.DisplayAllDays();
            // var myDays = await _db.AllDaysFromDb.ToArrayAsync();
            var model = new DayViewModel()
            {
                AllDays = myDays
            };

            return View(model);
        }



        
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Day day)
        {
            await _dayService.CreateNewDay(day);
            return RedirectToAction("Index");
        }

        




        // GET Delete Action Method
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productType = await _dayService.DeleteDayAsync(id);
            if (productType == null)
            {
                return NotFound();
            }

            return View(productType);
        }

        // POST Delete Action Method
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productTypes = await _dayService.DeleteDay(id);
            return RedirectToAction(nameof(Index));
        }




        // Edit
        // GET Edit Action Method
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var day = await _dayService.EditDayAsync(id);
            if (day == null)
            {
                return NotFound();
            }

            return View(day);
        }

        // POST Edit Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Day day)
        {
            if (id != day.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var myDays = await _dayService.EditDay(id, day);
                return RedirectToAction(nameof(Index));
            }
            return View(day);
        }



    }
}