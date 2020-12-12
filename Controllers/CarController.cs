using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trabalho_igor_gladson.Models;

namespace Trabalho_igor_gladson.Controllers
{
    public class CarController : Controller
    {
        private readonly CarContext _context;

        public CarController(CarContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Cars.ToListAsync());
        }

        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new Car());
            else
                return View(_context.Cars.Find(id));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("IDCar,Mark,Model,Year,Price")] Car car)
        {
            if (ModelState.IsValid)
            {
                if (car.IDCar == 0)
                    _context.Add(car);
                else
                    _context.Update(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewRent([Bind("IDRent,Name,Email,Phone")] Rent rent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rent);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var car = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Rent(int id)
        {
            return View(new Rent());
        }
    }
}
