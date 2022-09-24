using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCvProject.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        FeatureManager fm= new FeatureManager(new EfFeatureDal());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            //  var results = fm.TGetList();
            ViewBag.v1 = c.Skills.Count();
            ViewBag.v2 = c.Messages.Where(x=>x.isRead==false).Count();
            ViewBag.v3 = c.Services.Count();
            ViewBag.v4 = c.Testimonials.Count();
            return View();
        }
    }
}
