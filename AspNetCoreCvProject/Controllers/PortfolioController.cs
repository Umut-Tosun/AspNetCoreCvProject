using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCvProject.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager pm = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.value1 = "Proje Listesi";
            ViewBag.value2 = "Proje";
            ViewBag.value3 = "Proje Listesi";
            var results = pm.TGetList();
            return View(results);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.value1 = "Proje Ekleme";
            ViewBag.value2 = "Proje";
            ViewBag.value3 = "Proje Ekleme";
            
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            ViewBag.value1 = "Proje Ekleme";
            ViewBag.value2 = "Proje";
            ViewBag.value3 = "Proje Ekleme";
            PortfolioValidator pv = new PortfolioValidator();
            ValidationResult results = pv.Validate(p);
            if(results.IsValid)
            {
                pm.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = pm.GetByID(id);
            pm.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.value1 = "Proje Güncelleme";
            ViewBag.value2 = "Proje";
            ViewBag.value3 = "Proje Güncelleme";
            var results = pm.GetByID(id);
            return View(results);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio p)
        {
            PortfolioValidator pv = new PortfolioValidator();
            ValidationResult results = pv.Validate(p);
            if (results.IsValid)
            {
                pm.TUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
