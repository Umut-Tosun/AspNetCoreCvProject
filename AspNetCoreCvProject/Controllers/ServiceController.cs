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
    public class ServiceController : Controller
    {
        ServiceManager sm = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.value1 = "Hizmet Listesi";
            ViewBag.value2 = "Hizmet";
            ViewBag.value3 = "Hizmet Listesi";
            var results = sm.TGetList();
            return View(results);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.value1 = "Hizmet Ekleme";
            ViewBag.value2 = "Hizmet";
            ViewBag.value3 = "Hizmet Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service p)
        {
            sm.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var values = sm.GetByID(id);
            sm.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.value1 = "Hizmet Güncelleme";
            ViewBag.value2 = "Hizmet";
            ViewBag.value3 = "Hizmet Güncelleme";
            var results = sm.GetByID(id);
            return View(results);
        }
        [HttpPost]
        public IActionResult EditService(Service p)
        {
            sm.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
