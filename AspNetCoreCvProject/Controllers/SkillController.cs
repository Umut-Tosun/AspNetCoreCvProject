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
    public class SkillController : Controller
    {
        SkillManager sm = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.value1 = "Yetenek Listesi";
            ViewBag.value2 = "Yetenek";
            ViewBag.value3 = "Yetenek Listesi";
            var results = sm.TGetList();
            return View(results);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.value1 = "Yetenek Ekleme";
            ViewBag.value2 = "Yetenek";
            ViewBag.value3 = "Yetenek Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            sm.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = sm.GetByID(id);
            sm.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.value1 = "Yetenek Güncelleme";
            ViewBag.value2 = "Yetenek";
            ViewBag.value3 = "Yetenek Güncelleme";
            var results = sm.GetByID(id);
            return View(results);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill p)
        {
            sm.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
