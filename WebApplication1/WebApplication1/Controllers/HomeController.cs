using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.Computers;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private ComputerRepository _repository = new ComputerRepository();

        public IActionResult Index()
        {
            this.ViewBag.Computers = this._repository.SelectAll();

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Computer computer = this._repository.SelectById(id);
            
            return View(computer); 
        }

        [HttpPost]
        public IActionResult Edit(int id, Computer computer)
        {
            if (this.ModelState.IsValid)
            {
                this._repository.Update(computer);
                return RedirectToAction("Index");
            }

            return View(computer);
        }

        public IActionResult Delete(int id)
        {
            Computer computer = this._repository.SelectById(id);
            this._repository.Delete(computer);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Computer computer)
        {
            if (this.ModelState.IsValid)
            {
                this._repository.InsertInto(computer);
                return RedirectToAction("Confirm");
            }

            return View(computer);
        }

        public IActionResult Confirm()
        {
            return View();
        }
    }
}
