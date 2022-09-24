using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCvProject.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
