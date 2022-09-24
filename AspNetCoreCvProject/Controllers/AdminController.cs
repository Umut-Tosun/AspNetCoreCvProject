using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCvProject.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
        public PartialViewResult Footer()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        public PartialViewResult PartialNagivation()
        {
            return PartialView();
        }
        public PartialViewResult NewSideBar()
        {
            return PartialView();
        }
    }
}
