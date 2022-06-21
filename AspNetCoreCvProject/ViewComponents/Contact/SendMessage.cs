using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCvProject.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        MessageManager mm = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
