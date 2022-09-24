using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCvProject.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.V1 = c.Portfolios.Count();
            ViewBag.V2 = c.SocialMedias.Count();
            ViewBag.V3 = c.Experiences.Count();
            return View();
        }
    }
}
