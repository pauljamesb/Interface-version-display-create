using DOA.Data;
using DOA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOA.Services
{
    public class DayService : IDayService
    {

        private readonly ApplicationDbContext _db;
        public DayService(ApplicationDbContext db)
        {
            _db = db;
        }


        // Display days
        public async Task<Day[]> DisplayAllDays()
        {
            var myDays = await _db.AllDaysFromDb.ToArrayAsync();
            return myDays;
        }


        //Create new day
        public async Task<bool> CreateNewDay(Day day)
        {
            _db.AllDaysFromDb.Add(day);

            var saveResult = await _db.SaveChangesAsync();
            return saveResult == 1;
        }


        // +++++++++++++++++++++++++++++++++++++++++++
        // Delete a day
        // +++++++++++++++++++++++++++++++++++++++++++
        // This gets Key of item that has been clicked.
        // And forwards to delete view.
        public async Task<Day> DeleteDayAsync(int? id)
        {
            var theDays = await _db.AllDaysFromDb.FindAsync(id);
            return theDays;
        }

        // Once on the delete view with the clicked item referenced.
        // The item can be deleted.
        // The page then redirects back to index.
        public async Task<bool> DeleteDay(int id)
        {
            var theDay = await _db.AllDaysFromDb.FindAsync(id);
            _db.AllDaysFromDb.Remove(theDay);
            var saveRes = await _db.SaveChangesAsync();
            return saveRes == 1;
        }


        // Edit a day
        public async Task<Day> EditDayAsync(int? id)
        {
            var theDays = await _db.AllDaysFromDb.FindAsync(id);
            return theDays;
        }

        public async Task<bool> EditDay(int id, Day day)
        {
            _db.Update(day);
            var saveRes = await _db.SaveChangesAsync();
            return saveRes == 1;
        }










    }
}
