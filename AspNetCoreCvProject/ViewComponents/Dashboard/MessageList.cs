using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCvProject.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        UserMessageManager mm = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = mm.GetUserMessageWithUserService();
            return View(values);
        }
    }
}
