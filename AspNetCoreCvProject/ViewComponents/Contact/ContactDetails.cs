using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCvProject.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var results = cm.TGetList();
            return View(results);
        }
    }
}
