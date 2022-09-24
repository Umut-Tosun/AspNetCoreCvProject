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
    public class ExperienceController : Controller
    {
        ExperienceManager em = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyim";
            ViewBag.v3 = "Deneyim Listesi";
            var results = em.TGetList();
            return View(results);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.value1 = "Deneyim Ekleme";
            ViewBag.value2 = "Deneyim";
            ViewBag.value3 = "Deneyim Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            em.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = em.GetByID(id);
            em.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.value1 = "Deneyim Güncelleme";
            ViewBag.value2 = "Deneyim";
            ViewBag.value3 = "Deneyim Güncelleme";
            var results = em.GetByID(id);
            return View(results);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience p)
        {
            em.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
