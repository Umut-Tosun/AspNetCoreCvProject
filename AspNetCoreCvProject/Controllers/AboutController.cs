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
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.value1 = "Hakkımda Güncelleme";
            ViewBag.value2 = "Hakkımda";
            ViewBag.value3 = "Hakkımda Güncelleme";
            var results = am.GetByID(1);
            return View(results);
        }
        [HttpPost]
        public IActionResult Index(About p)
        {
            am.TUpdate(p);
            return RedirectToAction("Index", "Default");
        }
    }
}
