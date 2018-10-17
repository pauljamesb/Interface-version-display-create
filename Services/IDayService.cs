using DOA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOA.Services
{
    public interface IDayService
    {
        Task<Day[]> DisplayAllDays();

        Task<bool> CreateNewDay(Day day);

        Task<bool> DeleteDay(int id);

        Task<Day> DeleteDayAsync(int? id);



        // Edit
        Task<bool> EditDay(int id, Day day);

        Task<Day> EditDayAsync(int? id);
    }
}
