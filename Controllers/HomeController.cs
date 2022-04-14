using FinalPractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPractice.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext context { get; set; }

        public HomeController(ApplicationContext temp)
        {
            context = temp;
        }

        //private IFinalPracticeRepository repo;

        //public HomeController(IFinalPracticeRepository temp)
        //{
        //    repo = temp;
        //}

        public IActionResult Index()
        {
            var blah = context.MyTable.ToList();

            return View(blah);
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(FormResponse fr)
        {
            context.Add(fr);
            context.SaveChanges();

            return View("AddConfirmation", fr);
        }

        [HttpGet]
        public IActionResult DataTable()
        {
            var MyTable = context.MyTable
                .OrderBy(x => x.Title)
                .ToList();

            return View(MyTable);
        }

        [HttpGet]
        public IActionResult Edit(int formid)
        {
            var response_to_edit = context.MyTable.Single(x => x.FormId == formid);

            return View("Form", response_to_edit);
        }

        [HttpPost]
        public IActionResult Edit(FormResponse edited_record)
        {
            context.Update(edited_record);
            context.SaveChanges();

            return RedirectToAction("DataTable");
        }

        [HttpGet]
        public IActionResult Delete(int formid)
        {
            var response_to_delete = context.MyTable.Single(x => x.FormId == formid);

            return View(response_to_delete);
        }

        [HttpPost]
        public IActionResult Delete(FormResponse del)
        {
            context.MyTable.Remove(del);
            context.SaveChanges();

            return RedirectToAction("DataTable");
        }
    }
}
