using Microsoft.AspNetCore.Mvc;
using CRUDApplication.Data;
using CRUDApplication.Models;
using System.Collections.Generic;

namespace CRUDApplication.Controllers
{
    public class FactoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FactoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Factory> factoryList = _context.Factories; // Update to match the table name
            return View(factoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Factory factory)
        {
            if (ModelState.IsValid)
            {
                _context.Factories.Add(factory); // Update to match the table name
                _context.SaveChanges();
                TempData["SuccessMsg"] = $"Factory ({factory.FactoryName}) added successfully.";
                return RedirectToAction("Index");
            }
            return View(factory);
        }

        public IActionResult Edit(int? factoryId)
        {
            var factory = _context.Factories.Find(factoryId); // Update to match the table name

            if (factory == null)
            {
                return NotFound();
            }
            return View(factory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Factory factory)
        {
            if (ModelState.IsValid)
            {
                _context.Factories.Update(factory); // Update to match the table name
                _context.SaveChanges();
                TempData["SuccessMsg"] = $"Factory ({factory.FactoryName}) updated successfully.";
                return RedirectToAction("Index");
            }
            return View(factory);
        }

        public IActionResult Delete(int? factoryId)
        {
            var factory = _context.Factories.Find(factoryId); // Update to match the table name

            if (factory == null)
            {
                return NotFound();
            }
            return View(factory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteFactory(int? factoryId)
        {
            var factory = _context.Factories.Find(factoryId); // Update to match the table name
            if (factory == null)
            {
                return NotFound();
            }
            _context.Factories.Remove(factory); // Update to match the table name
            _context.SaveChanges();
            TempData["SuccessMsg"] = $"Factory ({factory.FactoryName}) deleted successfully.";
            return RedirectToAction("Index");
        }
    }
}
