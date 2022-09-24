using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCvProject.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListManager tdlm = new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = tdlm.TGetList();
            return View(values);
        }
    }
}
