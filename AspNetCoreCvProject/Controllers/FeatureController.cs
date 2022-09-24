using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCvProject.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager fm = new FeatureManager(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.value1 = "Öne Çıkan Alan Güncelleme";
            ViewBag.value2 = "Öne Çıkan Alan";
            ViewBag.value3 = "Öne Çıkan Alan Güncelleme";
            var results = fm.GetByID(1);
            return View(results);
        }
        [HttpPost]
        public IActionResult Index(Feature p)
        {
            fm.TUpdate(p);
            return RedirectToAction("Index","Default");
        }
    }
}
