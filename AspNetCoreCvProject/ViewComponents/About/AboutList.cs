using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCvProject.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager am = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = am.TGetList();
            return View(values);
        }
    }
}
